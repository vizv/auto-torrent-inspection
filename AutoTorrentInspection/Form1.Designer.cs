﻿namespace AutoTorrentInspection
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAnnounceList = new System.Windows.Forms.Button();
            this.cbShowAll = new System.Windows.Forms.CheckBox();
            this.cbState = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "载入";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AllowDrop = true;
            this.btnRefresh.Location = new System.Drawing.Point(12, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(12, 99);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(75, 20);
            this.cbCategory.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.path,
            this.FileName,
            this.Size});
            this.dataGridView1.Location = new System.Drawing.Point(93, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(533, 423);
            this.dataGridView1.TabIndex = 4;
            // 
            // path
            // 
            this.path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.path.HeaderText = "路径";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Width = 54;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileName.HeaderText = "文件名";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 66;
            // 
            // Size
            // 
            this.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Size.HeaderText = "大小";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 54;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "torrent File|*.torrent";
            // 
            // btnAnnounceList
            // 
            this.btnAnnounceList.Location = new System.Drawing.Point(12, 70);
            this.btnAnnounceList.Name = "btnAnnounceList";
            this.btnAnnounceList.Size = new System.Drawing.Size(75, 23);
            this.btnAnnounceList.TabIndex = 6;
            this.btnAnnounceList.Text = "Tracker";
            this.btnAnnounceList.UseVisualStyleBackColor = true;
            this.btnAnnounceList.Click += new System.EventHandler(this.btnAnnounceList_Click);
            // 
            // cbShowAll
            // 
            this.cbShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowAll.AutoSize = true;
            this.cbShowAll.Location = new System.Drawing.Point(12, 419);
            this.cbShowAll.Name = "cbShowAll";
            this.cbShowAll.Size = new System.Drawing.Size(72, 16);
            this.cbShowAll.TabIndex = 7;
            this.cbShowAll.Text = "显示全部";
            this.cbShowAll.UseVisualStyleBackColor = true;
            // 
            // cbState
            // 
            this.cbState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbState.AutoCheck = false;
            this.cbState.AutoSize = true;
            this.cbState.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbState.Checked = true;
            this.cbState.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbState.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbState.Location = new System.Drawing.Point(12, 397);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(72, 16);
            this.cbState.TabIndex = 8;
            this.cbState.Text = "状态正常";
            this.cbState.ThreeState = true;
            this.cbState.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 447);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.cbShowAll);
            this.Controls.Add(this.btnAnnounceList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLoadFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Torrent Inspection";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.Button btnAnnounceList;
        private System.Windows.Forms.CheckBox cbShowAll;
        private System.Windows.Forms.CheckBox cbState;
    }
}

