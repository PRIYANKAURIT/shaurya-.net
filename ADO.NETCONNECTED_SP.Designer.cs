namespace shaurya.net
{
    partial class Form6
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
            this.btnSearchByIdusingSP = new System.Windows.Forms.Button();
            this.btnDeleteusingSP = new System.Windows.Forms.Button();
            this.btnUpdateusingSP = new System.Windows.Forms.Button();
            this.btnSaveusingSP = new System.Windows.Forms.Button();
            this.EmpGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAllusingSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchByIdusingSP
            // 
            this.btnSearchByIdusingSP.Location = new System.Drawing.Point(366, 134);
            this.btnSearchByIdusingSP.Name = "btnSearchByIdusingSP";
            this.btnSearchByIdusingSP.Size = new System.Drawing.Size(131, 23);
            this.btnSearchByIdusingSP.TabIndex = 31;
            this.btnSearchByIdusingSP.Text = "Search By Id using SP";
            this.btnSearchByIdusingSP.UseVisualStyleBackColor = true;
            this.btnSearchByIdusingSP.Click += new System.EventHandler(this.btnSearchByIdusingSP_Click);
            // 
            // btnDeleteusingSP
            // 
            this.btnDeleteusingSP.Location = new System.Drawing.Point(284, 343);
            this.btnDeleteusingSP.Name = "btnDeleteusingSP";
            this.btnDeleteusingSP.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteusingSP.TabIndex = 30;
            this.btnDeleteusingSP.Text = "Delete using SP";
            this.btnDeleteusingSP.UseVisualStyleBackColor = true;
            this.btnDeleteusingSP.Click += new System.EventHandler(this.btnDeleteusingSP_Click);
            // 
            // btnUpdateusingSP
            // 
            this.btnUpdateusingSP.Location = new System.Drawing.Point(164, 343);
            this.btnUpdateusingSP.Name = "btnUpdateusingSP";
            this.btnUpdateusingSP.Size = new System.Drawing.Size(99, 23);
            this.btnUpdateusingSP.TabIndex = 29;
            this.btnUpdateusingSP.Text = "Update using SP";
            this.btnUpdateusingSP.UseVisualStyleBackColor = true;
            this.btnUpdateusingSP.Click += new System.EventHandler(this.btnUpdateusingSP_Click);
            // 
            // btnSaveusingSP
            // 
            this.btnSaveusingSP.Location = new System.Drawing.Point(33, 343);
            this.btnSaveusingSP.Name = "btnSaveusingSP";
            this.btnSaveusingSP.Size = new System.Drawing.Size(100, 23);
            this.btnSaveusingSP.TabIndex = 28;
            this.btnSaveusingSP.Text = "Save using SP";
            this.btnSaveusingSP.UseVisualStyleBackColor = true;
            this.btnSaveusingSP.Click += new System.EventHandler(this.btnSaveusingSP_Click);
            // 
            // EmpGridView
            // 
            this.EmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGridView.Location = new System.Drawing.Point(527, 85);
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.Size = new System.Drawing.Size(240, 150);
            this.EmpGridView.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(381, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search By Id";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(574, 262);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(163, 23);
            this.btnShowAll.TabIndex = 25;
            this.btnShowAll.Text = "Show All Employee";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(284, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(176, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(164, 88);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(142, 20);
            this.txtEmpId.TabIndex = 21;
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Location = new System.Drawing.Point(164, 191);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(142, 20);
            this.txtEmpSalary.TabIndex = 20;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(164, 137);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(142, 20);
            this.txtEmpName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Emp Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Emp Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Emp Id";
            // 
            // btnShowAllusingSP
            // 
            this.btnShowAllusingSP.Location = new System.Drawing.Point(574, 307);
            this.btnShowAllusingSP.Name = "btnShowAllusingSP";
            this.btnShowAllusingSP.Size = new System.Drawing.Size(193, 23);
            this.btnShowAllusingSP.TabIndex = 32;
            this.btnShowAllusingSP.Text = "Show All Employee using SP";
            this.btnShowAllusingSP.UseVisualStyleBackColor = true;
            this.btnShowAllusingSP.Click += new System.EventHandler(this.btnShowAllusingSP_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAllusingSP);
            this.Controls.Add(this.btnSearchByIdusingSP);
            this.Controls.Add(this.btnDeleteusingSP);
            this.Controls.Add(this.btnUpdateusingSP);
            this.Controls.Add(this.btnSaveusingSP);
            this.Controls.Add(this.EmpGridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtEmpSalary);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "ADO.NET CONNECTED_SP";
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchByIdusingSP;
        private System.Windows.Forms.Button btnDeleteusingSP;
        private System.Windows.Forms.Button btnUpdateusingSP;
        private System.Windows.Forms.Button btnSaveusingSP;
        private System.Windows.Forms.DataGridView EmpGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAllusingSP;
    }
}