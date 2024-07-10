namespace Code_Generator
{
    partial class frmCodeGenerator
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
            this.cbDatabaseNAme = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltablerecord = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.ctNormal = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnGenerateDataAccessSetting = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenerateLogHandler = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenerateErrorLogger = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenerateDataAccessHelper = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bntCopy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenerateStoredProcedure = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenerateBussinessLayer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenerateDataAccessLayer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblcolumnRecord = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvCDA = new System.Windows.Forms.ListView();
            this.chColmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAllowNull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctAdvance = new System.Windows.Forms.TabPage();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnGeneratetoAllTable = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGeneratetotheSelectedTable = new Guna.UI2.WinForms.Guna2GradientButton();
            this.s = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAppconfig = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtAppconfig = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnBussinessLayer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtBussinessLayer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDataAccessLayer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnGenerateAccessLayer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPathAccessLayer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvTables = new System.Windows.Forms.ListView();
            this.chTableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2TabControl1.SuspendLayout();
            this.ctNormal.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.ctAdvance.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.s.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.btnDataAccessLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDatabaseNAme
            // 
            this.cbDatabaseNAme.BackColor = System.Drawing.Color.Transparent;
            this.cbDatabaseNAme.BorderColor = System.Drawing.Color.Black;
            this.cbDatabaseNAme.BorderRadius = 10;
            this.cbDatabaseNAme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDatabaseNAme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabaseNAme.FocusedColor = System.Drawing.Color.Black;
            this.cbDatabaseNAme.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cbDatabaseNAme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDatabaseNAme.ForeColor = System.Drawing.Color.Black;
            this.cbDatabaseNAme.HoverState.BorderColor = System.Drawing.Color.Black;
            this.cbDatabaseNAme.ItemHeight = 30;
            this.cbDatabaseNAme.Location = new System.Drawing.Point(3, 43);
            this.cbDatabaseNAme.Name = "cbDatabaseNAme";
            this.cbDatabaseNAme.Size = new System.Drawing.Size(220, 36);
            this.cbDatabaseNAme.TabIndex = 0;
            this.cbDatabaseNAme.SelectedIndexChanged += new System.EventHandler(this.cbDatabaseNAme_SelectedIndexChanged);
            this.cbDatabaseNAme.Validating += new System.ComponentModel.CancelEventHandler(this.cbDatabaseNAme_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "# Of Table record:";
            // 
            // lbltablerecord
            // 
            this.lbltablerecord.AutoSize = true;
            this.lbltablerecord.ForeColor = System.Drawing.Color.Red;
            this.lbltablerecord.Location = new System.Drawing.Point(129, 576);
            this.lbltablerecord.Name = "lbltablerecord";
            this.lbltablerecord.Size = new System.Drawing.Size(14, 16);
            this.lbltablerecord.TabIndex = 4;
            this.lbltablerecord.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(3, 611);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.ctNormal);
            this.guna2TabControl1.Controls.Add(this.ctAdvance);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(244, 43);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1002, 602);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 6;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // ctNormal
            // 
            this.ctNormal.Controls.Add(this.guna2GroupBox1);
            this.ctNormal.Controls.Add(this.bntCopy);
            this.ctNormal.Controls.Add(this.btnGenerateStoredProcedure);
            this.ctNormal.Controls.Add(this.btnGenerateBussinessLayer);
            this.ctNormal.Controls.Add(this.btnGenerateDataAccessLayer);
            this.ctNormal.Controls.Add(this.lblcolumnRecord);
            this.ctNormal.Controls.Add(this.txtCode);
            this.ctNormal.Controls.Add(this.label4);
            this.ctNormal.Controls.Add(this.lvCDA);
            this.ctNormal.Location = new System.Drawing.Point(4, 44);
            this.ctNormal.Name = "ctNormal";
            this.ctNormal.Padding = new System.Windows.Forms.Padding(3);
            this.ctNormal.Size = new System.Drawing.Size(994, 554);
            this.ctNormal.TabIndex = 0;
            this.ctNormal.Text = "Normal";
            this.ctNormal.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnGenerateDataAccessSetting);
            this.guna2GroupBox1.Controls.Add(this.btnGenerateLogHandler);
            this.guna2GroupBox1.Controls.Add(this.btnGenerateErrorLogger);
            this.guna2GroupBox1.Controls.Add(this.btnGenerateDataAccessHelper);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(477, 302);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(511, 157);
            this.guna2GroupBox1.TabIndex = 17;
            this.guna2GroupBox1.Text = "Helper class for Data Access Layer";
            // 
            // btnGenerateDataAccessSetting
            // 
            this.btnGenerateDataAccessSetting.BorderRadius = 20;
            this.btnGenerateDataAccessSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateDataAccessSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateDataAccessSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateDataAccessSetting.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateDataAccessSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateDataAccessSetting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDataAccessSetting.ForeColor = System.Drawing.Color.White;
            this.btnGenerateDataAccessSetting.Location = new System.Drawing.Point(12, 43);
            this.btnGenerateDataAccessSetting.Name = "btnGenerateDataAccessSetting";
            this.btnGenerateDataAccessSetting.Size = new System.Drawing.Size(209, 45);
            this.btnGenerateDataAccessSetting.TabIndex = 16;
            this.btnGenerateDataAccessSetting.Text = "Generate Data Access Setting";
            this.btnGenerateDataAccessSetting.Click += new System.EventHandler(this.btnGenerateDataAccessSetting_Click);
            // 
            // btnGenerateLogHandler
            // 
            this.btnGenerateLogHandler.BorderRadius = 20;
            this.btnGenerateLogHandler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateLogHandler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateLogHandler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateLogHandler.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateLogHandler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateLogHandler.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateLogHandler.ForeColor = System.Drawing.Color.White;
            this.btnGenerateLogHandler.Location = new System.Drawing.Point(275, 106);
            this.btnGenerateLogHandler.Name = "btnGenerateLogHandler";
            this.btnGenerateLogHandler.Size = new System.Drawing.Size(209, 45);
            this.btnGenerateLogHandler.TabIndex = 14;
            this.btnGenerateLogHandler.Text = "Generate Log Handler";
            this.btnGenerateLogHandler.Click += new System.EventHandler(this.btnGenerateLogHandler_Click);
            // 
            // btnGenerateErrorLogger
            // 
            this.btnGenerateErrorLogger.BorderRadius = 20;
            this.btnGenerateErrorLogger.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateErrorLogger.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateErrorLogger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateErrorLogger.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateErrorLogger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateErrorLogger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateErrorLogger.ForeColor = System.Drawing.Color.White;
            this.btnGenerateErrorLogger.Location = new System.Drawing.Point(275, 43);
            this.btnGenerateErrorLogger.Name = "btnGenerateErrorLogger";
            this.btnGenerateErrorLogger.Size = new System.Drawing.Size(209, 45);
            this.btnGenerateErrorLogger.TabIndex = 15;
            this.btnGenerateErrorLogger.Text = "Generate Error Logger";
            this.btnGenerateErrorLogger.Click += new System.EventHandler(this.btnGenerateErrorLogger_Click);
            // 
            // btnGenerateDataAccessHelper
            // 
            this.btnGenerateDataAccessHelper.BorderRadius = 20;
            this.btnGenerateDataAccessHelper.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateDataAccessHelper.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateDataAccessHelper.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateDataAccessHelper.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateDataAccessHelper.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateDataAccessHelper.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDataAccessHelper.ForeColor = System.Drawing.Color.White;
            this.btnGenerateDataAccessHelper.Location = new System.Drawing.Point(12, 106);
            this.btnGenerateDataAccessHelper.Name = "btnGenerateDataAccessHelper";
            this.btnGenerateDataAccessHelper.Size = new System.Drawing.Size(209, 45);
            this.btnGenerateDataAccessHelper.TabIndex = 13;
            this.btnGenerateDataAccessHelper.Text = "Generate Data Access Helper";
            this.btnGenerateDataAccessHelper.Click += new System.EventHandler(this.btnGenerateDataAccessHelper_Click);
            // 
            // bntCopy
            // 
            this.bntCopy.BorderRadius = 20;
            this.bntCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntCopy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCopy.ForeColor = System.Drawing.Color.White;
            this.bntCopy.Location = new System.Drawing.Point(857, 489);
            this.bntCopy.Name = "bntCopy";
            this.bntCopy.Size = new System.Drawing.Size(121, 45);
            this.bntCopy.TabIndex = 12;
            this.bntCopy.Text = "Copy";
            this.bntCopy.Click += new System.EventHandler(this.bntCopy_Click);
            // 
            // btnGenerateStoredProcedure
            // 
            this.btnGenerateStoredProcedure.BorderRadius = 20;
            this.btnGenerateStoredProcedure.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateStoredProcedure.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateStoredProcedure.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateStoredProcedure.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateStoredProcedure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateStoredProcedure.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateStoredProcedure.ForeColor = System.Drawing.Color.White;
            this.btnGenerateStoredProcedure.Location = new System.Drawing.Point(584, 489);
            this.btnGenerateStoredProcedure.Name = "btnGenerateStoredProcedure";
            this.btnGenerateStoredProcedure.Size = new System.Drawing.Size(209, 45);
            this.btnGenerateStoredProcedure.TabIndex = 11;
            this.btnGenerateStoredProcedure.Text = "Generate Stored Procedure";
            this.btnGenerateStoredProcedure.Click += new System.EventHandler(this.btnGenerateStoredProcedure_Click);
            // 
            // btnGenerateBussinessLayer
            // 
            this.btnGenerateBussinessLayer.BorderRadius = 20;
            this.btnGenerateBussinessLayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateBussinessLayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateBussinessLayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateBussinessLayer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateBussinessLayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateBussinessLayer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBussinessLayer.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBussinessLayer.Location = new System.Drawing.Point(296, 489);
            this.btnGenerateBussinessLayer.Name = "btnGenerateBussinessLayer";
            this.btnGenerateBussinessLayer.Size = new System.Drawing.Size(209, 45);
            this.btnGenerateBussinessLayer.TabIndex = 10;
            this.btnGenerateBussinessLayer.Text = "Generate Bussiness Layer";
            this.btnGenerateBussinessLayer.Click += new System.EventHandler(this.btnGenerateBussinessLayer_Click);
            // 
            // btnGenerateDataAccessLayer
            // 
            this.btnGenerateDataAccessLayer.BorderRadius = 20;
            this.btnGenerateDataAccessLayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateDataAccessLayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateDataAccessLayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateDataAccessLayer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateDataAccessLayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateDataAccessLayer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDataAccessLayer.ForeColor = System.Drawing.Color.White;
            this.btnGenerateDataAccessLayer.Location = new System.Drawing.Point(10, 490);
            this.btnGenerateDataAccessLayer.Name = "btnGenerateDataAccessLayer";
            this.btnGenerateDataAccessLayer.Size = new System.Drawing.Size(209, 45);
            this.btnGenerateDataAccessLayer.TabIndex = 9;
            this.btnGenerateDataAccessLayer.Text = "Generate Data Access Layer";
            this.btnGenerateDataAccessLayer.Click += new System.EventHandler(this.btnGenerateDataAccessLayer_Click);
            // 
            // lblcolumnRecord
            // 
            this.lblcolumnRecord.AutoSize = true;
            this.lblcolumnRecord.ForeColor = System.Drawing.Color.Red;
            this.lblcolumnRecord.Location = new System.Drawing.Point(130, 464);
            this.lblcolumnRecord.Name = "lblcolumnRecord";
            this.lblcolumnRecord.Size = new System.Drawing.Size(14, 16);
            this.lblcolumnRecord.TabIndex = 8;
            this.lblcolumnRecord.Text = "0";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCode.Location = new System.Drawing.Point(477, 6);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(511, 290);
            this.txtCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(7, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "# Of Column record:";
            // 
            // lvCDA
            // 
            this.lvCDA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chColmnName,
            this.chDataType,
            this.chAllowNull});
            this.lvCDA.GridLines = true;
            this.lvCDA.HideSelection = false;
            this.lvCDA.Location = new System.Drawing.Point(3, -1);
            this.lvCDA.Name = "lvCDA";
            this.lvCDA.Size = new System.Drawing.Size(468, 460);
            this.lvCDA.TabIndex = 0;
            this.lvCDA.UseCompatibleStateImageBehavior = false;
            this.lvCDA.View = System.Windows.Forms.View.Details;
            // 
            // chColmnName
            // 
            this.chColmnName.Text = "Column Name";
            this.chColmnName.Width = 236;
            // 
            // chDataType
            // 
            this.chDataType.Text = "Data Type";
            this.chDataType.Width = 148;
            // 
            // chAllowNull
            // 
            this.chAllowNull.Text = "Allow Null";
            this.chAllowNull.Width = 77;
            // 
            // ctAdvance
            // 
            this.ctAdvance.Controls.Add(this.guna2GroupBox4);
            this.ctAdvance.Controls.Add(this.s);
            this.ctAdvance.Controls.Add(this.guna2GroupBox2);
            this.ctAdvance.Controls.Add(this.btnDataAccessLayer);
            this.ctAdvance.Location = new System.Drawing.Point(4, 44);
            this.ctAdvance.Name = "ctAdvance";
            this.ctAdvance.Padding = new System.Windows.Forms.Padding(3);
            this.ctAdvance.Size = new System.Drawing.Size(994, 554);
            this.ctAdvance.TabIndex = 1;
            this.ctAdvance.Text = "Advance";
            this.ctAdvance.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Controls.Add(this.btnGeneratetoAllTable);
            this.guna2GroupBox4.Controls.Add(this.btnGeneratetotheSelectedTable);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.Location = new System.Drawing.Point(6, 453);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(985, 98);
            this.guna2GroupBox4.TabIndex = 14;
            this.guna2GroupBox4.Text = "Stored Procedure";
            // 
            // btnGeneratetoAllTable
            // 
            this.btnGeneratetoAllTable.BorderRadius = 20;
            this.btnGeneratetoAllTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratetoAllTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratetoAllTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratetoAllTable.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratetoAllTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneratetoAllTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratetoAllTable.ForeColor = System.Drawing.Color.White;
            this.btnGeneratetoAllTable.Location = new System.Drawing.Point(574, 43);
            this.btnGeneratetoAllTable.Name = "btnGeneratetoAllTable";
            this.btnGeneratetoAllTable.Size = new System.Drawing.Size(182, 45);
            this.btnGeneratetoAllTable.TabIndex = 14;
            this.btnGeneratetoAllTable.Text = "Generate To All Tables";
            this.btnGeneratetoAllTable.Click += new System.EventHandler(this.btnGeneratetoAllTable_Click);
            // 
            // btnGeneratetotheSelectedTable
            // 
            this.btnGeneratetotheSelectedTable.BorderRadius = 20;
            this.btnGeneratetotheSelectedTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratetotheSelectedTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratetotheSelectedTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratetotheSelectedTable.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratetotheSelectedTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneratetotheSelectedTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratetotheSelectedTable.ForeColor = System.Drawing.Color.White;
            this.btnGeneratetotheSelectedTable.Location = new System.Drawing.Point(92, 43);
            this.btnGeneratetotheSelectedTable.Name = "btnGeneratetotheSelectedTable";
            this.btnGeneratetotheSelectedTable.Size = new System.Drawing.Size(262, 45);
            this.btnGeneratetotheSelectedTable.TabIndex = 13;
            this.btnGeneratetotheSelectedTable.Text = "Generate To The Selected Table";
            this.btnGeneratetotheSelectedTable.Click += new System.EventHandler(this.btnGeneratetotheSelectedTable_Click);
            // 
            // s
            // 
            this.s.Controls.Add(this.btnAppconfig);
            this.s.Controls.Add(this.txtAppconfig);
            this.s.Controls.Add(this.label7);
            this.s.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.Black;
            this.s.Location = new System.Drawing.Point(8, 303);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(985, 143);
            this.s.TabIndex = 14;
            this.s.Text = "App.config";
            // 
            // btnAppconfig
            // 
            this.btnAppconfig.BorderRadius = 20;
            this.btnAppconfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppconfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppconfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppconfig.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppconfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppconfig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppconfig.ForeColor = System.Drawing.Color.White;
            this.btnAppconfig.Location = new System.Drawing.Point(781, 91);
            this.btnAppconfig.Name = "btnAppconfig";
            this.btnAppconfig.Size = new System.Drawing.Size(182, 45);
            this.btnAppconfig.TabIndex = 13;
            this.btnAppconfig.Text = "Generate";
            this.btnAppconfig.Click += new System.EventHandler(this.btnAppconfig_Click);
            // 
            // txtAppconfig
            // 
            this.txtAppconfig.Location = new System.Drawing.Point(75, 53);
            this.txtAppconfig.Name = "txtAppconfig";
            this.txtAppconfig.Size = new System.Drawing.Size(888, 25);
            this.txtAppconfig.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Path:";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btnBussinessLayer);
            this.guna2GroupBox2.Controls.Add(this.txtBussinessLayer);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(6, 155);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(985, 143);
            this.guna2GroupBox2.TabIndex = 14;
            this.guna2GroupBox2.Text = "Data Bussiness Layer";
            // 
            // btnBussinessLayer
            // 
            this.btnBussinessLayer.BorderRadius = 20;
            this.btnBussinessLayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBussinessLayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBussinessLayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBussinessLayer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBussinessLayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBussinessLayer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBussinessLayer.ForeColor = System.Drawing.Color.White;
            this.btnBussinessLayer.Location = new System.Drawing.Point(781, 91);
            this.btnBussinessLayer.Name = "btnBussinessLayer";
            this.btnBussinessLayer.Size = new System.Drawing.Size(182, 45);
            this.btnBussinessLayer.TabIndex = 13;
            this.btnBussinessLayer.Text = "Generate";
            this.btnBussinessLayer.Click += new System.EventHandler(this.btnBussinessLayer_Click);
            // 
            // txtBussinessLayer
            // 
            this.txtBussinessLayer.Location = new System.Drawing.Point(75, 53);
            this.txtBussinessLayer.Name = "txtBussinessLayer";
            this.txtBussinessLayer.Size = new System.Drawing.Size(888, 25);
            this.txtBussinessLayer.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Path:";
            // 
            // btnDataAccessLayer
            // 
            this.btnDataAccessLayer.Controls.Add(this.btnGenerateAccessLayer);
            this.btnDataAccessLayer.Controls.Add(this.txtPathAccessLayer);
            this.btnDataAccessLayer.Controls.Add(this.label5);
            this.btnDataAccessLayer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataAccessLayer.ForeColor = System.Drawing.Color.Black;
            this.btnDataAccessLayer.Location = new System.Drawing.Point(3, 6);
            this.btnDataAccessLayer.Name = "btnDataAccessLayer";
            this.btnDataAccessLayer.Size = new System.Drawing.Size(985, 143);
            this.btnDataAccessLayer.TabIndex = 0;
            this.btnDataAccessLayer.Text = "Data Access Layer";
            // 
            // btnGenerateAccessLayer
            // 
            this.btnGenerateAccessLayer.BorderRadius = 20;
            this.btnGenerateAccessLayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateAccessLayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateAccessLayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateAccessLayer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateAccessLayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateAccessLayer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAccessLayer.ForeColor = System.Drawing.Color.White;
            this.btnGenerateAccessLayer.Location = new System.Drawing.Point(781, 91);
            this.btnGenerateAccessLayer.Name = "btnGenerateAccessLayer";
            this.btnGenerateAccessLayer.Size = new System.Drawing.Size(182, 45);
            this.btnGenerateAccessLayer.TabIndex = 13;
            this.btnGenerateAccessLayer.Text = "Generate";
            this.btnGenerateAccessLayer.Click += new System.EventHandler(this.btnGenerateAccessLayer_Click);
            // 
            // txtPathAccessLayer
            // 
            this.txtPathAccessLayer.Location = new System.Drawing.Point(75, 53);
            this.txtPathAccessLayer.Name = "txtPathAccessLayer";
            this.txtPathAccessLayer.Size = new System.Drawing.Size(888, 25);
            this.txtPathAccessLayer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(535, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Code Generator";
            // 
            // lvTables
            // 
            this.lvTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTableName});
            this.lvTables.GridLines = true;
            this.lvTables.HideSelection = false;
            this.lvTables.Location = new System.Drawing.Point(13, 82);
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(211, 460);
            this.lvTables.TabIndex = 18;
            this.lvTables.UseCompatibleStateImageBehavior = false;
            this.lvTables.View = System.Windows.Forms.View.Details;
            this.lvTables.SelectedIndexChanged += new System.EventHandler(this.lvTables_SelectedIndexChanged);
            this.lvTables.Validating += new System.ComponentModel.CancelEventHandler(this.lvTables_Validating);
            // 
            // chTableName
            // 
            this.chTableName.Text = "Table Name";
            this.chTableName.Width = 206;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 648);
            this.Controls.Add(this.lvTables);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbltablerecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDatabaseNAme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Genertaor";
            this.Load += new System.EventHandler(this.frmCodeGenerator_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.ctNormal.ResumeLayout(false);
            this.ctNormal.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ctAdvance.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.btnDataAccessLayer.ResumeLayout(false);
            this.btnDataAccessLayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbDatabaseNAme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltablerecord;
        private System.Windows.Forms.Button btnReset;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage ctNormal;
        private System.Windows.Forms.TabPage ctAdvance;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ListView lvCDA;
        private System.Windows.Forms.ColumnHeader chColmnName;
        private System.Windows.Forms.ColumnHeader chDataType;
        private System.Windows.Forms.ColumnHeader chAllowNull;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateDataAccessLayer;
        private System.Windows.Forms.Label lblcolumnRecord;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateDataAccessSetting;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateErrorLogger;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateLogHandler;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateDataAccessHelper;
        private Guna.UI2.WinForms.Guna2GradientButton bntCopy;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateStoredProcedure;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateBussinessLayer;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GroupBox btnDataAccessLayer;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2GradientButton btnGeneratetoAllTable;
        private Guna.UI2.WinForms.Guna2GradientButton btnGeneratetotheSelectedTable;
        private Guna.UI2.WinForms.Guna2GroupBox s;
        private Guna.UI2.WinForms.Guna2GradientButton btnAppconfig;
        private System.Windows.Forms.TextBox txtAppconfig;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnBussinessLayer;
        private System.Windows.Forms.TextBox txtBussinessLayer;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateAccessLayer;
        private System.Windows.Forms.TextBox txtPathAccessLayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvTables;
        private System.Windows.Forms.ColumnHeader chTableName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

