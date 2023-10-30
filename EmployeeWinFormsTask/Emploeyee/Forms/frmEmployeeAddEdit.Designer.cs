
namespace EmployeeWinFormsTask.Emploeyee.Forms
{
    partial class frmEmployeeAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeAddEdit));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.tlsEmployeeAddEditForm = new System.Windows.Forms.ToolStrip();
            this.btnSaveEmployee = new System.Windows.Forms.ToolStripButton();
            this.btnCencelEmployee = new System.Windows.Forms.ToolStripButton();
            this.txtEmployeeFullName = new System.Windows.Forms.TextBox();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtEmployeePersonalID = new System.Windows.Forms.TextBox();
            this.cbEmployeeGender = new System.Windows.Forms.ComboBox();
            this.lblEmployeeFullName = new System.Windows.Forms.Label();
            this.lblEmployeeDob = new System.Windows.Forms.Label();
            this.lblEmployeeGender = new System.Windows.Forms.Label();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.lblEmployeeAddress = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.lblEmployeePersonalID = new System.Windows.Forms.Label();
            this.dtpickerEmployeeDob = new System.Windows.Forms.DateTimePicker();
            this.databaseAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlsEmployeeAddEditForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAccessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // tlsEmployeeAddEditForm
            // 
            this.tlsEmployeeAddEditForm.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsEmployeeAddEditForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveEmployee,
            this.btnCencelEmployee});
            this.tlsEmployeeAddEditForm.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tlsEmployeeAddEditForm.Location = new System.Drawing.Point(0, 0);
            this.tlsEmployeeAddEditForm.Name = "tlsEmployeeAddEditForm";
            this.tlsEmployeeAddEditForm.Size = new System.Drawing.Size(593, 39);
            this.tlsEmployeeAddEditForm.TabIndex = 0;
            this.tlsEmployeeAddEditForm.Text = "tlsEmployeeAddEditForm";
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveEmployee.Image")));
            this.btnSaveEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(94, 36);
            this.btnSaveEmployee.Text = "შენახვა";
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // btnCencelEmployee
            // 
            this.btnCencelEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCencelEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnCencelEmployee.Image")));
            this.btnCencelEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCencelEmployee.Name = "btnCencelEmployee";
            this.btnCencelEmployee.Size = new System.Drawing.Size(104, 36);
            this.btnCencelEmployee.Text = "გაუქმება";
            this.btnCencelEmployee.Click += new System.EventHandler(this.btnCencelEmployee_Click);
            // 
            // txtEmployeeFullName
            // 
            this.txtEmployeeFullName.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeFullName.Location = new System.Drawing.Point(259, 90);
            this.txtEmployeeFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeFullName.Name = "txtEmployeeFullName";
            this.txtEmployeeFullName.Size = new System.Drawing.Size(233, 25);
            this.txtEmployeeFullName.TabIndex = 1;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(259, 246);
            this.txtEmployeePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(233, 25);
            this.txtEmployeePhone.TabIndex = 4;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(259, 299);
            this.txtEmployeeAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(233, 25);
            this.txtEmployeeAddress.TabIndex = 5;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(259, 352);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(233, 25);
            this.txtEmployeeEmail.TabIndex = 6;
            // 
            // txtEmployeePersonalID
            // 
            this.txtEmployeePersonalID.Location = new System.Drawing.Point(259, 406);
            this.txtEmployeePersonalID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeePersonalID.Name = "txtEmployeePersonalID";
            this.txtEmployeePersonalID.Size = new System.Drawing.Size(233, 25);
            this.txtEmployeePersonalID.TabIndex = 7;
            // 
            // cbEmployeeGender
            // 
            this.cbEmployeeGender.FormattingEnabled = true;
            this.cbEmployeeGender.Location = new System.Drawing.Point(259, 194);
            this.cbEmployeeGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmployeeGender.Name = "cbEmployeeGender";
            this.cbEmployeeGender.Size = new System.Drawing.Size(233, 26);
            this.cbEmployeeGender.TabIndex = 3;
            // 
            // lblEmployeeFullName
            // 
            this.lblEmployeeFullName.AutoSize = true;
            this.lblEmployeeFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFullName.Location = new System.Drawing.Point(79, 90);
            this.lblEmployeeFullName.Name = "lblEmployeeFullName";
            this.lblEmployeeFullName.Size = new System.Drawing.Size(122, 17);
            this.lblEmployeeFullName.TabIndex = 8;
            this.lblEmployeeFullName.Text = "გვარი და სახელი";
            // 
            // lblEmployeeDob
            // 
            this.lblEmployeeDob.AutoSize = true;
            this.lblEmployeeDob.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDob.Location = new System.Drawing.Point(79, 143);
            this.lblEmployeeDob.Name = "lblEmployeeDob";
            this.lblEmployeeDob.Size = new System.Drawing.Size(138, 17);
            this.lblEmployeeDob.TabIndex = 9;
            this.lblEmployeeDob.Text = "დაბადების თარიღი";
            // 
            // lblEmployeeGender
            // 
            this.lblEmployeeGender.AutoSize = true;
            this.lblEmployeeGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeGender.Location = new System.Drawing.Point(79, 201);
            this.lblEmployeeGender.Name = "lblEmployeeGender";
            this.lblEmployeeGender.Size = new System.Drawing.Size(44, 17);
            this.lblEmployeeGender.TabIndex = 10;
            this.lblEmployeeGender.Text = "სქესი";
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePhone.Location = new System.Drawing.Point(79, 252);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(142, 17);
            this.lblEmployeePhone.TabIndex = 11;
            this.lblEmployeePhone.Text = "ტელეფონის ნომერი";
            // 
            // lblEmployeeAddress
            // 
            this.lblEmployeeAddress.AutoSize = true;
            this.lblEmployeeAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAddress.Location = new System.Drawing.Point(79, 299);
            this.lblEmployeeAddress.Name = "lblEmployeeAddress";
            this.lblEmployeeAddress.Size = new System.Drawing.Size(79, 17);
            this.lblEmployeeAddress.TabIndex = 12;
            this.lblEmployeeAddress.Text = "მისამართი";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeEmail.Location = new System.Drawing.Point(79, 352);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(60, 17);
            this.lblEmployeeEmail.TabIndex = 13;
            this.lblEmployeeEmail.Text = "იმეილი";
            // 
            // lblEmployeePersonalID
            // 
            this.lblEmployeePersonalID.AutoSize = true;
            this.lblEmployeePersonalID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePersonalID.Location = new System.Drawing.Point(79, 406);
            this.lblEmployeePersonalID.Name = "lblEmployeePersonalID";
            this.lblEmployeePersonalID.Size = new System.Drawing.Size(111, 17);
            this.lblEmployeePersonalID.TabIndex = 14;
            this.lblEmployeePersonalID.Text = "პირადი ნომერი";
            // 
            // dtpickerEmployeeDob
            // 
            this.dtpickerEmployeeDob.CustomFormat = "dd.MM.yyyy";
            this.dtpickerEmployeeDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerEmployeeDob.Location = new System.Drawing.Point(259, 147);
            this.dtpickerEmployeeDob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpickerEmployeeDob.Name = "dtpickerEmployeeDob";
            this.dtpickerEmployeeDob.Size = new System.Drawing.Size(233, 25);
            this.dtpickerEmployeeDob.TabIndex = 2;
            // 
            // databaseAccessBindingSource
            // 
            this.databaseAccessBindingSource.DataSource = typeof(EmployeeWinFormsTask.Database.DatabaseAccess);
            // 
            // frmMainBindingSource
            // 
            this.frmMainBindingSource.DataSource = typeof(EmployeeWinFormsTask.frmMain);
            // 
            // frmEmployeeAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 536);
            this.Controls.Add(this.dtpickerEmployeeDob);
            this.Controls.Add(this.lblEmployeePersonalID);
            this.Controls.Add(this.lblEmployeeEmail);
            this.Controls.Add(this.lblEmployeeAddress);
            this.Controls.Add(this.lblEmployeePhone);
            this.Controls.Add(this.lblEmployeeGender);
            this.Controls.Add(this.lblEmployeeDob);
            this.Controls.Add(this.lblEmployeeFullName);
            this.Controls.Add(this.cbEmployeeGender);
            this.Controls.Add(this.txtEmployeePersonalID);
            this.Controls.Add(this.txtEmployeeEmail);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.txtEmployeePhone);
            this.Controls.Add(this.txtEmployeeFullName);
            this.Controls.Add(this.tlsEmployeeAddEditForm);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployeeAddEdit";
            this.Text = "frmEmployeeAddEdit";
            this.tlsEmployeeAddEditForm.ResumeLayout(false);
            this.tlsEmployeeAddEditForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAccessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource databaseAccessBindingSource;
        private System.Windows.Forms.BindingSource frmMainBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.ToolStrip tlsEmployeeAddEditForm;
        private System.Windows.Forms.ToolStripButton btnSaveEmployee;
        private System.Windows.Forms.ToolStripButton btnCencelEmployee;
        private System.Windows.Forms.TextBox txtEmployeeFullName;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeePersonalID;
        private System.Windows.Forms.ComboBox cbEmployeeGender;
        private System.Windows.Forms.Label lblEmployeeFullName;
        private System.Windows.Forms.Label lblEmployeeDob;
        private System.Windows.Forms.Label lblEmployeeGender;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Label lblEmployeeAddress;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeePersonalID;
        private System.Windows.Forms.DateTimePicker dtpickerEmployeeDob;
    }
}