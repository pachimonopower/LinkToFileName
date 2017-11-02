namespace LinkToFileName
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvwList = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNewFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNewFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStart = new System.Windows.Forms.Button();
            this.chkZeroPadding = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.nudStartNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "対象フォルダをドラッグアンドドロップ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "変換元ファイル(*.txt)をドラッグアンドドロップ";
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewFileName.Location = new System.Drawing.Point(14, 32);
            this.txtNewFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(444, 19);
            this.txtNewFileName.TabIndex = 1;
            this.txtNewFileName.Text = "[Title] 第{0}話.mp4";
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.AllowDrop = true;
            this.txtTargetFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetFolder.Location = new System.Drawing.Point(14, 99);
            this.txtTargetFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new System.Drawing.Size(444, 19);
            this.txtTargetFolder.TabIndex = 3;
            this.txtTargetFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtTargetFolder_DragDrop);
            this.txtTargetFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtTargetFolder_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "変換後のファイル名";
            // 
            // lvwList
            // 
            this.lvwList.AllowDrop = true;
            this.lvwList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colLink,
            this.colFileName,
            this.colNewFileName,
            this.colFilePath,
            this.colNewFilePath});
            this.lvwList.FullRowSelect = true;
            this.lvwList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvwList.Location = new System.Drawing.Point(14, 167);
            this.lvwList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(554, 361);
            this.lvwList.TabIndex = 5;
            this.lvwList.UseCompatibleStateImageBehavior = false;
            this.lvwList.View = System.Windows.Forms.View.Details;
            this.lvwList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvwList_DragDrop);
            this.lvwList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvwList_DragEnter);
            // 
            // colNo
            // 
            this.colNo.Text = "No";
            this.colNo.Width = 36;
            // 
            // colLink
            // 
            this.colLink.Text = "リンク元のファイル名";
            this.colLink.Width = 131;
            // 
            // colFileName
            // 
            this.colFileName.Text = "元のファイル名";
            this.colFileName.Width = 163;
            // 
            // colNewFileName
            // 
            this.colNewFileName.Text = "変換後のファイル名";
            this.colNewFileName.Width = 162;
            // 
            // colFilePath
            // 
            this.colFilePath.Text = "colFilePath";
            this.colFilePath.Width = 31;
            // 
            // colNewFilePath
            // 
            this.colNewFilePath.Text = "colNewFilePath";
            this.colNewFilePath.Width = 31;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(447, 542);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 34);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "ファイル名変更";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkZeroPadding
            // 
            this.chkZeroPadding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkZeroPadding.AutoSize = true;
            this.chkZeroPadding.Checked = true;
            this.chkZeroPadding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZeroPadding.Location = new System.Drawing.Point(19, 552);
            this.chkZeroPadding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkZeroPadding.Name = "chkZeroPadding";
            this.chkZeroPadding.Size = new System.Drawing.Size(80, 16);
            this.chkZeroPadding.TabIndex = 6;
            this.chkZeroPadding.Text = "0埋めを行う";
            this.chkZeroPadding.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(313, 542);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 34);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "表示更新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // nudStartNumber
            // 
            this.nudStartNumber.Location = new System.Drawing.Point(194, 549);
            this.nudStartNumber.Name = "nudStartNumber";
            this.nudStartNumber.Size = new System.Drawing.Size(57, 19);
            this.nudStartNumber.TabIndex = 8;
            this.nudStartNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 552);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "連番開始";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 586);
            this.Controls.Add(this.nudStartNumber);
            this.Controls.Add(this.chkZeroPadding);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lvwList);
            this.Controls.Add(this.txtTargetFolder);
            this.Controls.Add(this.txtNewFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "リンクをファイル名に変更する";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStartNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvwList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkZeroPadding;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colLink;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colNewFileName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader colFilePath;
        private System.Windows.Forms.ColumnHeader colNewFilePath;
        private System.Windows.Forms.NumericUpDown nudStartNumber;
        private System.Windows.Forms.Label label4;
    }
}

