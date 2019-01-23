namespace MegaDesk_3_DrazenLucic
{
    partial class AddQuote
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.nupDeskWidth = new System.Windows.Forms.NumericUpDown();
            this.nupDeskDepth = new System.Windows.Forms.NumericUpDown();
            this.cboNumberOfDrawers = new System.Windows.Forms.ComboBox();
            this.cboSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.rboProductionTime3 = new System.Windows.Forms.RadioButton();
            this.rboProductionTime14 = new System.Windows.Forms.RadioButton();
            this.rboProductionTime7 = new System.Windows.Forms.RadioButton();
            this.rboProductionTime5 = new System.Windows.Forms.RadioButton();
            this.gboProductionTime = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupDeskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDeskDepth)).BeginInit();
            this.gboProductionTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(354, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 73);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(159, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 73);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desk Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desk Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Production Time";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(260, 38);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(336, 28);
            this.txtCustomerName.TabIndex = 8;
            this.txtCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerName_Validating);
            this.txtCustomerName.Validated += new System.EventHandler(this.txtCustomerName_Validated);
            // 
            // nupDeskWidth
            // 
            this.nupDeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupDeskWidth.Location = new System.Drawing.Point(260, 88);
            this.nupDeskWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupDeskWidth.Name = "nupDeskWidth";
            this.nupDeskWidth.Size = new System.Drawing.Size(120, 28);
            this.nupDeskWidth.TabIndex = 9;
            this.nupDeskWidth.Enter += new System.EventHandler(this.nupField_Enter);
            this.nupDeskWidth.Validating += new System.ComponentModel.CancelEventHandler(this.nupDeskWidth_Validating);
            this.nupDeskWidth.Validated += new System.EventHandler(this.nupDeskWidth_Validated);
            // 
            // nupDeskDepth
            // 
            this.nupDeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupDeskDepth.Location = new System.Drawing.Point(260, 138);
            this.nupDeskDepth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupDeskDepth.Name = "nupDeskDepth";
            this.nupDeskDepth.Size = new System.Drawing.Size(120, 28);
            this.nupDeskDepth.TabIndex = 10;
            this.nupDeskDepth.Enter += new System.EventHandler(this.nupField_Enter);
            this.nupDeskDepth.Validating += new System.ComponentModel.CancelEventHandler(this.nupDeskDepth_Validating);
            this.nupDeskDepth.Validated += new System.EventHandler(this.nupDeskDepth_Validated);
            // 
            // cboNumberOfDrawers
            // 
            this.cboNumberOfDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumberOfDrawers.FormattingEnabled = true;
            this.cboNumberOfDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboNumberOfDrawers.Location = new System.Drawing.Point(259, 189);
            this.cboNumberOfDrawers.Name = "cboNumberOfDrawers";
            this.cboNumberOfDrawers.Size = new System.Drawing.Size(121, 30);
            this.cboNumberOfDrawers.Sorted = true;
            this.cboNumberOfDrawers.TabIndex = 11;
            this.cboNumberOfDrawers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboNumberOfDrawers_KeyDown);
            this.cboNumberOfDrawers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNumberOfDrawers_KeyPress);
            // 
            // cboSurfaceMaterial
            // 
            this.cboSurfaceMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSurfaceMaterial.FormattingEnabled = true;
            this.cboSurfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.cboSurfaceMaterial.Location = new System.Drawing.Point(260, 239);
            this.cboSurfaceMaterial.Name = "cboSurfaceMaterial";
            this.cboSurfaceMaterial.Size = new System.Drawing.Size(121, 30);
            this.cboSurfaceMaterial.Sorted = true;
            this.cboSurfaceMaterial.TabIndex = 12;
            // 
            // rboProductionTime3
            // 
            this.rboProductionTime3.AutoSize = true;
            this.rboProductionTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboProductionTime3.Location = new System.Drawing.Point(6, 108);
            this.rboProductionTime3.Name = "rboProductionTime3";
            this.rboProductionTime3.Size = new System.Drawing.Size(85, 28);
            this.rboProductionTime3.TabIndex = 16;
            this.rboProductionTime3.TabStop = true;
            this.rboProductionTime3.Text = "3 days";
            this.rboProductionTime3.UseVisualStyleBackColor = true;
            // 
            // rboProductionTime14
            // 
            this.rboProductionTime14.AutoSize = true;
            this.rboProductionTime14.Checked = true;
            this.rboProductionTime14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboProductionTime14.Location = new System.Drawing.Point(6, 6);
            this.rboProductionTime14.Name = "rboProductionTime14";
            this.rboProductionTime14.Size = new System.Drawing.Size(95, 28);
            this.rboProductionTime14.TabIndex = 13;
            this.rboProductionTime14.TabStop = true;
            this.rboProductionTime14.Text = "14 days";
            this.rboProductionTime14.UseVisualStyleBackColor = true;
            // 
            // rboProductionTime7
            // 
            this.rboProductionTime7.AutoSize = true;
            this.rboProductionTime7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboProductionTime7.Location = new System.Drawing.Point(6, 40);
            this.rboProductionTime7.Name = "rboProductionTime7";
            this.rboProductionTime7.Size = new System.Drawing.Size(85, 28);
            this.rboProductionTime7.TabIndex = 14;
            this.rboProductionTime7.TabStop = true;
            this.rboProductionTime7.Text = "7 days";
            this.rboProductionTime7.UseVisualStyleBackColor = true;
            // 
            // rboProductionTime5
            // 
            this.rboProductionTime5.AutoSize = true;
            this.rboProductionTime5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboProductionTime5.Location = new System.Drawing.Point(6, 74);
            this.rboProductionTime5.Name = "rboProductionTime5";
            this.rboProductionTime5.Size = new System.Drawing.Size(85, 28);
            this.rboProductionTime5.TabIndex = 15;
            this.rboProductionTime5.TabStop = true;
            this.rboProductionTime5.Text = "5 days";
            this.rboProductionTime5.UseVisualStyleBackColor = true;
            // 
            // gboProductionTime
            // 
            this.gboProductionTime.Controls.Add(this.rboProductionTime14);
            this.gboProductionTime.Controls.Add(this.rboProductionTime3);
            this.gboProductionTime.Controls.Add(this.rboProductionTime5);
            this.gboProductionTime.Controls.Add(this.rboProductionTime7);
            this.gboProductionTime.Location = new System.Drawing.Point(260, 283);
            this.gboProductionTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gboProductionTime.Name = "gboProductionTime";
            this.gboProductionTime.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gboProductionTime.Size = new System.Drawing.Size(166, 133);
            this.gboProductionTime.TabIndex = 17;
            this.gboProductionTime.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 569);
            this.Controls.Add(this.gboProductionTime);
            this.Controls.Add(this.cboSurfaceMaterial);
            this.Controls.Add(this.cboNumberOfDrawers);
            this.Controls.Add(this.nupDeskDepth);
            this.Controls.Add(this.nupDeskWidth);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupDeskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDeskDepth)).EndInit();
            this.gboProductionTime.ResumeLayout(false);
            this.gboProductionTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.NumericUpDown nupDeskWidth;
        private System.Windows.Forms.NumericUpDown nupDeskDepth;
        private System.Windows.Forms.ComboBox cboNumberOfDrawers;
        private System.Windows.Forms.ComboBox cboSurfaceMaterial;
        private System.Windows.Forms.RadioButton rboProductionTime3;
        private System.Windows.Forms.RadioButton rboProductionTime14;
        private System.Windows.Forms.RadioButton rboProductionTime7;
        private System.Windows.Forms.RadioButton rboProductionTime5;
        private System.Windows.Forms.GroupBox gboProductionTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}