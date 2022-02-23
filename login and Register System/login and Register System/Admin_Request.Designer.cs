namespace login_and_Register_System
{
    partial class Admin_Request
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lrnMethd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stdNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.answers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSetSTD = new login_and_Register_System.DataSetSTD();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RequestsTableAdapter = new login_and_Register_System.DataSetSTDTableAdapters.tbl_RequestsTableAdapter();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learningMathodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRequestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lrnMethd
            // 
            this.lrnMethd.AutoSize = true;
            this.lrnMethd.Location = new System.Drawing.Point(66, 44);
            this.lrnMethd.Name = "lrnMethd";
            this.lrnMethd.Size = new System.Drawing.Size(0, 13);
            this.lrnMethd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "St George College";
            // 
            // stdNo
            // 
            this.stdNo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNo.Location = new System.Drawing.Point(48, 254);
            this.stdNo.Name = "stdNo";
            this.stdNo.Size = new System.Drawing.Size(124, 25);
            this.stdNo.TabIndex = 36;
            this.stdNo.TextChanged += new System.EventHandler(this.stdNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Student Number";
            // 
            // answers
            // 
            this.answers.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answers.FormattingEnabled = true;
            this.answers.Items.AddRange(new object[] {
            "Deny",
            "Accept"});
            this.answers.Location = new System.Drawing.Point(48, 330);
            this.answers.Name = "answers";
            this.answers.Size = new System.Drawing.Size(124, 25);
            this.answers.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Deny or Accept";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 37;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 28);
            this.button2.TabIndex = 38;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataSetSTD
            // 
            this.dataSetSTD.DataSetName = "DataSetSTD";
            this.dataSetSTD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNoDataGridViewTextBoxColumn,
            this.learningMathodDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblRequestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 77);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tblRequestsBindingSource
            // 
            this.tblRequestsBindingSource.DataMember = "tbl_Requests";
            this.tblRequestsBindingSource.DataSource = this.dataSetSTD;
            // 
            // tbl_RequestsTableAdapter
            // 
            this.tbl_RequestsTableAdapter.ClearBeforeFill = true;
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "Student_No";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "Student_No";
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
            // 
            // learningMathodDataGridViewTextBoxColumn
            // 
            this.learningMathodDataGridViewTextBoxColumn.DataPropertyName = "Learning Mathod";
            this.learningMathodDataGridViewTextBoxColumn.HeaderText = "Learning Mathod";
            this.learningMathodDataGridViewTextBoxColumn.Name = "learningMathodDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // Admin_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stdNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lrnMethd);
            this.Name = "Admin_Request";
            this.Text = "Requests";
            this.Load += new System.EventHandler(this.Admin_Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRequestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lrnMethd;
        private System.Windows.Forms.Label label1;
        private DataSetSTD dataSetSTD;
        private System.Windows.Forms.TextBox stdNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox answers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblRequestsBindingSource;
        private DataSetSTDTableAdapters.tbl_RequestsTableAdapter tbl_RequestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learningMathodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
    }
}