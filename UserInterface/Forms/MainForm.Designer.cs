namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpoyees = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnOrganizationalStructure = new System.Windows.Forms.Button();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnPositions = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Controls.Add(this.tpConfiguration);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(915, 100);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnPositions);
            this.tpGeneral.Controls.Add(this.btnDepartments);
            this.tpGeneral.Controls.Add(this.btnSalaries);
            this.tpGeneral.Controls.Add(this.btnOrganizationalStructure);
            this.tpGeneral.Controls.Add(this.btnContracts);
            this.tpGeneral.Controls.Add(this.btnEmpoyees);
            this.tpGeneral.Location = new System.Drawing.Point(4, 25);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(907, 71);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 25);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(1008, 71);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            this.tpConfiguration.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 350);
            this.panel1.TabIndex = 1;
            // 
            // btnEmpoyees
            // 
            this.btnEmpoyees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmpoyees.Location = new System.Drawing.Point(3, 3);
            this.btnEmpoyees.Name = "btnEmpoyees";
            this.btnEmpoyees.Size = new System.Drawing.Size(150, 65);
            this.btnEmpoyees.TabIndex = 0;
            this.btnEmpoyees.Text = "Pracownicy";
            this.btnEmpoyees.UseVisualStyleBackColor = true;
            // 
            // btnContracts
            // 
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContracts.Location = new System.Drawing.Point(153, 3);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(150, 65);
            this.btnContracts.TabIndex = 1;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.UseVisualStyleBackColor = true;
            // 
            // btnOrganizationalStructure
            // 
            this.btnOrganizationalStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationalStructure.Location = new System.Drawing.Point(303, 3);
            this.btnOrganizationalStructure.Name = "btnOrganizationalStructure";
            this.btnOrganizationalStructure.Size = new System.Drawing.Size(150, 65);
            this.btnOrganizationalStructure.TabIndex = 2;
            this.btnOrganizationalStructure.Text = "Struktura Organizacyjna";
            this.btnOrganizationalStructure.UseVisualStyleBackColor = true;
            // 
            // btnSalaries
            // 
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalaries.Location = new System.Drawing.Point(453, 3);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(150, 65);
            this.btnSalaries.TabIndex = 3;
            this.btnSalaries.Text = "Wynagrodzenia";
            this.btnSalaries.UseVisualStyleBackColor = true;
            // 
            // btnDepartments
            // 
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartments.Location = new System.Drawing.Point(603, 3);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(150, 65);
            this.btnDepartments.TabIndex = 4;
            this.btnDepartments.Text = "Działy";
            this.btnDepartments.UseVisualStyleBackColor = true;
            // 
            // btnPositions
            // 
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPositions.Location = new System.Drawing.Point(753, 3);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(150, 65);
            this.btnPositions.TabIndex = 5;
            this.btnPositions.Text = "Stanowiska";
            this.btnPositions.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssVersion,
            this.tssDatabase,
            this.tsslUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(915, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssVersion
            // 
            this.tssVersion.Name = "tssVersion";
            this.tssVersion.Size = new System.Drawing.Size(87, 20);
            this.tssVersion.Text = "Wersja 1.0.0";
            // 
            // tssDatabase
            // 
            this.tssDatabase.Name = "tssDatabase";
            this.tssDatabase.Size = new System.Drawing.Size(156, 20);
            this.tssDatabase.Text = "Baza: HumanResource";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(105, 20);
            this.tsslUser.Text = "Użytkownik: JK";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.Text = "SystemHR";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnEmpoyees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Button btnOrganizationalStructure;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssVersion;
        private System.Windows.Forms.ToolStripStatusLabel tssDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
    }
}