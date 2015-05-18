namespace ST_Roster_Generator
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numRosterSize = new System.Windows.Forms.NumericUpDown();
            this.lblRosterSize = new System.Windows.Forms.Label();
            this.cmbCustomNameListFile = new System.Windows.Forms.ComboBox();
            this.cmbRosterFile = new System.Windows.Forms.ComboBox();
            this.lblRosterFile = new System.Windows.Forms.Label();
            this.btnOpenCustomNameListFile = new System.Windows.Forms.Button();
            this.btnSaveRosterFile = new System.Windows.Forms.Button();
            this.lblRosterSizeLimit = new System.Windows.Forms.Label();
            this.cmbXcomListFile = new System.Windows.Forms.ComboBox();
            this.btnOpenXcomListFile = new System.Windows.Forms.Button();
            this.rdbXcomListRadio = new System.Windows.Forms.RadioButton();
            this.rdbCustomNameListRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numRosterSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(41, 219);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Roster";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // numRosterSize
            // 
            this.numRosterSize.Location = new System.Drawing.Point(156, 163);
            this.numRosterSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRosterSize.Name = "numRosterSize";
            this.numRosterSize.Size = new System.Drawing.Size(61, 20);
            this.numRosterSize.TabIndex = 2;
            this.numRosterSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRosterSize.ValueChanged += new System.EventHandler(this.numRosterSize_ValueChanged);
            // 
            // lblRosterSize
            // 
            this.lblRosterSize.AutoSize = true;
            this.lblRosterSize.Location = new System.Drawing.Point(74, 165);
            this.lblRosterSize.Name = "lblRosterSize";
            this.lblRosterSize.Size = new System.Drawing.Size(76, 13);
            this.lblRosterSize.TabIndex = 3;
            this.lblRosterSize.Text = "Size of Roster:";
            // 
            // cmbCustomNameListFile
            // 
            this.cmbCustomNameListFile.Enabled = false;
            this.cmbCustomNameListFile.FormattingEnabled = true;
            this.cmbCustomNameListFile.Location = new System.Drawing.Point(156, 78);
            this.cmbCustomNameListFile.Name = "cmbCustomNameListFile";
            this.cmbCustomNameListFile.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomNameListFile.TabIndex = 4;
            // 
            // cmbRosterFile
            // 
            this.cmbRosterFile.FormattingEnabled = true;
            this.cmbRosterFile.Location = new System.Drawing.Point(156, 120);
            this.cmbRosterFile.Name = "cmbRosterFile";
            this.cmbRosterFile.Size = new System.Drawing.Size(121, 21);
            this.cmbRosterFile.TabIndex = 5;
            // 
            // lblRosterFile
            // 
            this.lblRosterFile.AutoSize = true;
            this.lblRosterFile.Location = new System.Drawing.Point(90, 123);
            this.lblRosterFile.Name = "lblRosterFile";
            this.lblRosterFile.Size = new System.Drawing.Size(60, 13);
            this.lblRosterFile.TabIndex = 7;
            this.lblRosterFile.Text = "Roster File:";
            // 
            // btnOpenCustomNameListFile
            // 
            this.btnOpenCustomNameListFile.Enabled = false;
            this.btnOpenCustomNameListFile.Location = new System.Drawing.Point(283, 76);
            this.btnOpenCustomNameListFile.Name = "btnOpenCustomNameListFile";
            this.btnOpenCustomNameListFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCustomNameListFile.TabIndex = 8;
            this.btnOpenCustomNameListFile.Text = "Browse";
            this.btnOpenCustomNameListFile.UseVisualStyleBackColor = true;
            this.btnOpenCustomNameListFile.Click += new System.EventHandler(this.btnOpenCustomNameListFile_Click);
            // 
            // btnSaveRosterFile
            // 
            this.btnSaveRosterFile.Location = new System.Drawing.Point(283, 120);
            this.btnSaveRosterFile.Name = "btnSaveRosterFile";
            this.btnSaveRosterFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRosterFile.TabIndex = 9;
            this.btnSaveRosterFile.Text = "Browse";
            this.btnSaveRosterFile.UseVisualStyleBackColor = true;
            // 
            // lblRosterSizeLimit
            // 
            this.lblRosterSizeLimit.AutoSize = true;
            this.lblRosterSizeLimit.Location = new System.Drawing.Point(223, 165);
            this.lblRosterSizeLimit.Name = "lblRosterSizeLimit";
            this.lblRosterSizeLimit.Size = new System.Drawing.Size(48, 13);
            this.lblRosterSizeLimit.TabIndex = 10;
            this.lblRosterSizeLimit.Text = "(Max 10)";
            // 
            // cmbXcomListFile
            // 
            this.cmbXcomListFile.Enabled = false;
            this.cmbXcomListFile.FormattingEnabled = true;
            this.cmbXcomListFile.Location = new System.Drawing.Point(156, 33);
            this.cmbXcomListFile.Name = "cmbXcomListFile";
            this.cmbXcomListFile.Size = new System.Drawing.Size(121, 21);
            this.cmbXcomListFile.TabIndex = 11;
            // 
            // btnOpenXcomListFile
            // 
            this.btnOpenXcomListFile.Enabled = false;
            this.btnOpenXcomListFile.Location = new System.Drawing.Point(283, 31);
            this.btnOpenXcomListFile.Name = "btnOpenXcomListFile";
            this.btnOpenXcomListFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenXcomListFile.TabIndex = 13;
            this.btnOpenXcomListFile.Text = "Browse";
            this.btnOpenXcomListFile.UseVisualStyleBackColor = true;
            this.btnOpenXcomListFile.Click += new System.EventHandler(this.btnOpenXcomListFile_Click);
            // 
            // rdbXcomListRadio
            // 
            this.rdbXcomListRadio.AutoSize = true;
            this.rdbXcomListRadio.Location = new System.Drawing.Point(22, 34);
            this.rdbXcomListRadio.Name = "rdbXcomListRadio";
            this.rdbXcomListRadio.Size = new System.Drawing.Size(128, 17);
            this.rdbXcomListRadio.TabIndex = 14;
            this.rdbXcomListRadio.Text = "XCOM Name List File:";
            this.rdbXcomListRadio.UseVisualStyleBackColor = true;
            this.rdbXcomListRadio.CheckedChanged += new System.EventHandler(this.rdbXcomListRadio_CheckedChanged);
            // 
            // rdbCustomNameListRadio
            // 
            this.rdbCustomNameListRadio.AutoSize = true;
            this.rdbCustomNameListRadio.Location = new System.Drawing.Point(18, 79);
            this.rdbCustomNameListRadio.Name = "rdbCustomNameListRadio";
            this.rdbCustomNameListRadio.Size = new System.Drawing.Size(132, 17);
            this.rdbCustomNameListRadio.TabIndex = 15;
            this.rdbCustomNameListRadio.Text = "Custom Name List File:";
            this.rdbCustomNameListRadio.UseVisualStyleBackColor = true;
            this.rdbCustomNameListRadio.CheckedChanged += new System.EventHandler(this.rdbCustomNameListRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 283);
            this.ControlBox = false;
            this.Controls.Add(this.rdbCustomNameListRadio);
            this.Controls.Add(this.rdbXcomListRadio);
            this.Controls.Add(this.btnOpenXcomListFile);
            this.Controls.Add(this.cmbXcomListFile);
            this.Controls.Add(this.lblRosterSizeLimit);
            this.Controls.Add(this.btnSaveRosterFile);
            this.Controls.Add(this.btnOpenCustomNameListFile);
            this.Controls.Add(this.lblRosterFile);
            this.Controls.Add(this.cmbRosterFile);
            this.Controls.Add(this.cmbCustomNameListFile);
            this.Controls.Add(this.lblRosterSize);
            this.Controls.Add(this.numRosterSize);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "ST Roster Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRosterSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numRosterSize;
        private System.Windows.Forms.Label lblRosterSize;
        private System.Windows.Forms.ComboBox cmbCustomNameListFile;
        private System.Windows.Forms.ComboBox cmbRosterFile;
        private System.Windows.Forms.Label lblRosterFile;
        private System.Windows.Forms.Button btnOpenCustomNameListFile;
        private System.Windows.Forms.Button btnSaveRosterFile;
        private System.Windows.Forms.Label lblRosterSizeLimit;
        private System.Windows.Forms.ComboBox cmbXcomListFile;
        private System.Windows.Forms.Button btnOpenXcomListFile;
        private System.Windows.Forms.RadioButton rdbXcomListRadio;
        private System.Windows.Forms.RadioButton rdbCustomNameListRadio;
    }
}

