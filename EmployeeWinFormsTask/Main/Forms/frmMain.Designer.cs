
namespace EmployeeWinFormsTask
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlsEmployeeMainForm = new System.Windows.Forms.ToolStrip();
            this.btnAddEmployee = new System.Windows.Forms.ToolStripButton();
            this.btnEditEmployee = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteEmployee = new System.Windows.Forms.ToolStripButton();
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.frmMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tlsEmployeeMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsEmployeeMainForm
            // 
            this.tlsEmployeeMainForm.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsEmployeeMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddEmployee,
            this.btnEditEmployee,
            this.btnDeleteEmployee});
            this.tlsEmployeeMainForm.Location = new System.Drawing.Point(0, 0);
            this.tlsEmployeeMainForm.Name = "tlsEmployeeMainForm";
            this.tlsEmployeeMainForm.Size = new System.Drawing.Size(755, 39);
            this.tlsEmployeeMainForm.TabIndex = 0;
            this.tlsEmployeeMainForm.Text = "tlsEmployeeMainForm";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(105, 36);
            this.btnAddEmployee.Text = "დამატება";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEmployee.Image")));
            this.btnEditEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(134, 36);
            this.btnEditEmployee.Text = "რედაქტირება";
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(87, 36);
            this.btnDeleteEmployee.Text = "წაშლა";
            // 
            // gcEmployee
            // 
            this.gcEmployee.DataSource = this.frmMainBindingSource;
            this.gcEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmployee.Location = new System.Drawing.Point(0, 39);
            this.gcEmployee.MainView = this.gvEmployee;
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.Size = new System.Drawing.Size(755, 389);
            this.gcEmployee.TabIndex = 1;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            this.gcEmployee.Click += new System.EventHandler(this.gcEmployee_Click);
            // 
            // frmMainBindingSource
            // 
            this.frmMainBindingSource.DataSource = typeof(EmployeeWinFormsTask.frmMain);
            // 
            // gvEmployee
            // 
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFullName,
            this.colDob,
            this.colGenderID,
            this.colPhone,
            this.colAddress,
            this.colPersonalID,
            this.colEmail});
            this.gvEmployee.GridControl = this.gcEmployee;
            this.gvEmployee.Name = "gvEmployee";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 42;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "დასაქმებულის სახელი და გვარი";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 201;
            // 
            // colDob
            // 
            this.colDob.Caption = "დაბადების თარიღი";
            this.colDob.FieldName = "Dob";
            this.colDob.Name = "colDob";
            this.colDob.Visible = true;
            this.colDob.VisibleIndex = 2;
            this.colDob.Width = 136;
            // 
            // colGenderID
            // 
            this.colGenderID.Caption = "სქესი";
            this.colGenderID.FieldName = "GenderName";
            this.colGenderID.Name = "colGenderID";
            this.colGenderID.Visible = true;
            this.colGenderID.VisibleIndex = 3;
            this.colGenderID.Width = 67;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "ტელეფონი";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            this.colPhone.Width = 83;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "მისამართი";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 5;
            this.colAddress.Width = 51;
            // 
            // colPersonalID
            // 
            this.colPersonalID.Caption = "პირადი ნომერი";
            this.colPersonalID.FieldName = "PersonalID";
            this.colPersonalID.Name = "colPersonalID";
            this.colPersonalID.Visible = true;
            this.colPersonalID.VisibleIndex = 6;
            this.colPersonalID.Width = 68;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "იმეილი";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            this.colEmail.Width = 82;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 428);
            this.Controls.Add(this.gcEmployee);
            this.Controls.Add(this.tlsEmployeeMainForm);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlsEmployeeMainForm.ResumeLayout(false);
            this.tlsEmployeeMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsEmployeeMainForm;
        private System.Windows.Forms.ToolStripButton btnAddEmployee;
        private DevExpress.XtraGrid.GridControl gcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDob;
        private DevExpress.XtraGrid.Columns.GridColumn colGenderID;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private System.Windows.Forms.ToolStripButton btnEditEmployee;
        private System.Windows.Forms.ToolStripButton btnDeleteEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonalID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private System.Windows.Forms.BindingSource frmMainBindingSource;
    }
}