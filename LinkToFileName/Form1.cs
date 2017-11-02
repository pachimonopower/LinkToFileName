using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkToFileName
{
    public partial class Form1 : Form
    {

        private const int COL_INDEX_NO = 0;
        private const int COL_INDEX_LINK = 1;
        private const int COL_INDEX_FILENAME = 2;
        private const int COL_INDEX_NEWFILENAME = 3;
        private const int COL_INDEX_FILEPATH = 4;
        private const int COL_INDEX_NEWFILEPATH = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvwList.Items.Clear();
        }

        private void txtTargetFolder_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void txtTargetFolder_DragDrop(object sender, DragEventArgs e)
        {
            var strFileName = (string[])(e.Data.GetData(DataFormats.FileDrop, false));
            if (System.IO.Directory.Exists(strFileName[0].ToString()))
            {
                txtTargetFolder.Text = strFileName[0].ToString();
            }
        }

        private void lvwList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lvwList_DragDrop(object sender, DragEventArgs e)
        {
            var strFileName = (string[])(e.Data.GetData(DataFormats.FileDrop, false));
            if (System.IO.File.Exists(strFileName[0].ToString()))
            {
                var path = strFileName[0].ToString();
                using (var sr = new System.IO.StreamReader(path))
                {
                    try
                    {
                        lvwList.BeginUpdate();
                        lvwList.Items.Clear();
                        var number = 1;
                        while (sr.Peek() > 0)
                        {

                            var link = sr.ReadLine();
                            if (string.IsNullOrEmpty(link)) continue;

                            var newItem = lvwList.Items.Add(number++.ToString());
                            newItem.SubItems.Add(System.IO.Path.GetFileName(link));
                            newItem.SubItems.Add("");
                            newItem.SubItems.Add("");
                            newItem.SubItems.Add("");
                            newItem.SubItems.Add("");

                        }
                    }
                    finally
                    {
                        lvwList.EndUpdate();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            if (lvwList.Items.Count == 0)
            {
                MessageBox.Show("リストにアイテムが1件もありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (System.IO.Directory.Exists(txtTargetFolder.Text) == false)
            {
                MessageBox.Show("フォルダーが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var files = System.IO.Directory.GetFiles(txtTargetFolder.Text, "*", System.IO.SearchOption.TopDirectoryOnly);
            if (files.Length == 0)
            {
                MessageBox.Show("ファイルが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                var numberCount = (int)nudStartNumber.Value;
                var zeroPaddingCount = (int)Math.Log10(lvwList.Items.Count) + 1;

                foreach (ListViewItem v in lvwList.Items)
                {

                    var foundFiles = files.Where(a => a.IndexOf(v.SubItems[COL_INDEX_LINK].Text) > -1);
                    if (foundFiles.Count() == 0) continue;

                    var foundFile = foundFiles.First();

                    v.SubItems[COL_INDEX_FILENAME].Text = System.IO.Path.GetFileName(foundFile);
                    v.SubItems[COL_INDEX_FILEPATH].Text = foundFile;

                    var newFileName = string.Format(txtNewFileName.Text,
                                                    chkZeroPadding.Checked ? numberCount.ToString().PadLeft(zeroPaddingCount, '0') : numberCount.ToString());

                    v.SubItems[COL_INDEX_NEWFILENAME].Text = newFileName;
                    v.SubItems[COL_INDEX_NEWFILEPATH].Text = System.IO.Path.GetDirectoryName(foundFile) + "\\" + newFileName;

                    numberCount++;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {

            btnRefresh_Click(btnRefresh, EventArgs.Empty);

            var result = MessageBox.Show("ファイル名を変更します。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result != DialogResult.Yes) return;

            txtNewFileName.Enabled = false;
            txtTargetFolder.Enabled = false;
            lvwList.Enabled = false;
            chkZeroPadding.Enabled = false;
            btnRefresh.Enabled = false;
            btnStart.Enabled = false;

            var isSuccess = true;
            var processCount = 0;

            await Task.Factory.StartNew(() => {

                var items = new List<string[]>();

                Invoke((MethodInvoker)(() => {
                    foreach (ListViewItem v in lvwList.Items)
                    {
                        items.Add(new string[] { v.SubItems[COL_INDEX_FILEPATH].Text, v.SubItems[COL_INDEX_NEWFILEPATH].Text });
                    }
                }));

                try
                {
                    foreach (var v in items)
                    {
                        try
                        {
                            System.IO.File.Move(v[0], v[1]);
                            processCount++;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                catch(Exception ex)
                {
                    isSuccess = false;
                    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            });

            txtNewFileName.Enabled = true;
            txtTargetFolder.Enabled = true;
            lvwList.Enabled = true;
            chkZeroPadding.Enabled = true;
            btnRefresh.Enabled = true;
            btnStart.Enabled = true;

            if (isSuccess)
            {
                MessageBox.Show(string.Format("{0}件中、{1}個のファイル名を変更しました。",
                                              lvwList.Items.Count, processCount),
                                "終了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
