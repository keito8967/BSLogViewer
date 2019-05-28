namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new WindowsFormsApp1.DataSet1();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnXUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastConnection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataColumn1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataColumn2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataColumn3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataColumn4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.MaxLength = 10000000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(284, 470);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "在此处粘贴日志文本";
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnXUID,
            this.ColumnCounts,
            this.ColumnLastConnection});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(566, 154);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CurrentCellChanged += new System.EventHandler(this.dataGridView2_CurrentCellChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataColumn1DataGridViewTextBoxColumn,
            this.dataColumn2DataGridViewTextBoxColumn,
            this.dataColumn3DataGridViewTextBoxColumn,
            this.dataColumn4DataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "DataTable1";
            this.dataGridView1.DataSource = this.dataSet11;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(566, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(566, 470);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 4;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "玩家名";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnXUID
            // 
            this.ColumnXUID.HeaderText = "XUID";
            this.ColumnXUID.Name = "ColumnXUID";
            this.ColumnXUID.ReadOnly = true;
            // 
            // ColumnCounts
            // 
            this.ColumnCounts.HeaderText = "登录次数";
            this.ColumnCounts.Name = "ColumnCounts";
            this.ColumnCounts.ReadOnly = true;
            // 
            // ColumnLastConnection
            // 
            this.ColumnLastConnection.HeaderText = "最后登录";
            this.ColumnLastConnection.Name = "ColumnLastConnection";
            this.ColumnLastConnection.ReadOnly = true;
            this.ColumnLastConnection.Width = 150;
            // 
            // dataColumn1DataGridViewTextBoxColumn
            // 
            this.dataColumn1DataGridViewTextBoxColumn.DataPropertyName = "DataColumn1";
            this.dataColumn1DataGridViewTextBoxColumn.HeaderText = "玩家名";
            this.dataColumn1DataGridViewTextBoxColumn.Name = "dataColumn1DataGridViewTextBoxColumn";
            this.dataColumn1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataColumn2DataGridViewTextBoxColumn
            // 
            this.dataColumn2DataGridViewTextBoxColumn.DataPropertyName = "DataColumn2";
            this.dataColumn2DataGridViewTextBoxColumn.HeaderText = "XUID";
            this.dataColumn2DataGridViewTextBoxColumn.Name = "dataColumn2DataGridViewTextBoxColumn";
            this.dataColumn2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataColumn3DataGridViewTextBoxColumn
            // 
            this.dataColumn3DataGridViewTextBoxColumn.DataPropertyName = "DataColumn3";
            this.dataColumn3DataGridViewTextBoxColumn.HeaderText = "事件";
            this.dataColumn3DataGridViewTextBoxColumn.Name = "dataColumn3DataGridViewTextBoxColumn";
            this.dataColumn3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataColumn4DataGridViewTextBoxColumn
            // 
            this.dataColumn4DataGridViewTextBoxColumn.DataPropertyName = "DataColumn4";
            this.dataColumn4DataGridViewTextBoxColumn.HeaderText = "时间";
            this.dataColumn4DataGridViewTextBoxColumn.Name = "dataColumn4DataGridViewTextBoxColumn";
            this.dataColumn4DataGridViewTextBoxColumn.ReadOnly = true;
            this.dataColumn4DataGridViewTextBoxColumn.Width = 150;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(854, 470);
            this.splitContainer2.SplitterDistance = 284;
            this.splitContainer2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 470);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Form1";
            this.Text = "BSLog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnXUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataColumn1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataColumn2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataColumn3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataColumn4DataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

