namespace ConnectCsharpToMysql
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.ciD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRestore = new System.Windows.Forms.Button();
            this.bBackup = new System.Windows.Forms.Button();
            this.bCount = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSelect = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDisplay
            // 
            this.dgDisplay.AllowUserToAddRows = false;
            this.dgDisplay.AllowUserToDeleteRows = false;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciD,
            this.cName,
            this.cAge});
            this.dgDisplay.Location = new System.Drawing.Point(3, 93);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.ReadOnly = true;
            this.dgDisplay.RowHeadersVisible = false;
            this.dgDisplay.RowTemplate.Height = 23;
            this.dgDisplay.Size = new System.Drawing.Size(303, 103);
            this.dgDisplay.TabIndex = 8;
            // 
            // ciD
            // 
            this.ciD.HeaderText = "id";
            this.ciD.Name = "ciD";
            this.ciD.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cAge
            // 
            this.cAge.HeaderText = "Age";
            this.cAge.Name = "cAge";
            this.cAge.ReadOnly = true;
            // 
            // bRestore
            // 
            this.bRestore.Location = new System.Drawing.Point(151, 66);
            this.bRestore.Name = "bRestore";
            this.bRestore.Size = new System.Drawing.Size(75, 21);
            this.bRestore.TabIndex = 15;
            this.bRestore.Text = "Restore";
            this.bRestore.UseVisualStyleBackColor = true;
            this.bRestore.Click += new System.EventHandler(this.bRestore_Click);
            // 
            // bBackup
            // 
            this.bBackup.Location = new System.Drawing.Point(70, 66);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(75, 21);
            this.bBackup.TabIndex = 14;
            this.bBackup.Text = "Backup";
            this.bBackup.UseVisualStyleBackColor = true;
            this.bBackup.Click += new System.EventHandler(this.bBackup_Click);
            // 
            // bCount
            // 
            this.bCount.Location = new System.Drawing.Point(151, 39);
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(75, 21);
            this.bCount.TabIndex = 13;
            this.bCount.Text = "Count";
            this.bCount.UseVisualStyleBackColor = true;
            this.bCount.Click += new System.EventHandler(this.bCount_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(194, 12);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 21);
            this.bDelete.TabIndex = 12;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(70, 39);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(75, 21);
            this.bSelect.TabIndex = 11;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(113, 12);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 21);
            this.bUpdate.TabIndex = 10;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(32, 12);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 21);
            this.bInsert.TabIndex = 9;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 202);
            this.Controls.Add(this.bRestore);
            this.Controls.Add(this.bBackup);
            this.Controls.Add(this.bCount);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.dgDisplay);
            this.Name = "Form1";
            this.Text = "Connect Csharp To Mysql";
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAge;
        private System.Windows.Forms.Button bRestore;
        private System.Windows.Forms.Button bBackup;
        private System.Windows.Forms.Button bCount;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
    }
}

