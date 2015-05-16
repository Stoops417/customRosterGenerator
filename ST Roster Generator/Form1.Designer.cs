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
            this.cmbNameListFile = new System.Windows.Forms.ComboBox();
            this.cmbRosterFile = new System.Windows.Forms.ComboBox();
            this.lblNameListFile = new System.Windows.Forms.Label();
            this.lblRosterFile = new System.Windows.Forms.Label();
            this.btnOpenNameListFile = new System.Windows.Forms.Button();
            this.btnSaveRosterFile = new System.Windows.Forms.Button();
            this.lblRosterSizeLimit = new System.Windows.Forms.Label();
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
            this.numRosterSize.Location = new System.Drawing.Point(151, 149);
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
            this.lblRosterSize.Location = new System.Drawing.Point(69, 151);
            this.lblRosterSize.Name = "lblRosterSize";
            this.lblRosterSize.Size = new System.Drawing.Size(76, 13);
            this.lblRosterSize.TabIndex = 3;
            this.lblRosterSize.Text = "Size of Roster:";
            // 
            // cmbNameListFile
            // 
            this.cmbNameListFile.FormattingEnabled = true;
            this.cmbNameListFile.Location = new System.Drawing.Point(151, 31);
            this.cmbNameListFile.Name = "cmbNameListFile";
            this.cmbNameListFile.Size = new System.Drawing.Size(121, 21);
            this.cmbNameListFile.TabIndex = 4;
            // 
            // cmbRosterFile
            // 
            this.cmbRosterFile.FormattingEnabled = true;
            this.cmbRosterFile.Location = new System.Drawing.Point(151, 92);
            this.cmbRosterFile.Name = "cmbRosterFile";
            this.cmbRosterFile.Size = new System.Drawing.Size(121, 21);
            this.cmbRosterFile.TabIndex = 5;
            // 
            // lblNameListFile
            // 
            this.lblNameListFile.AutoSize = true;
            this.lblNameListFile.Location = new System.Drawing.Point(69, 34);
            this.lblNameListFile.Name = "lblNameListFile";
            this.lblNameListFile.Size = new System.Drawing.Size(76, 13);
            this.lblNameListFile.TabIndex = 6;
            this.lblNameListFile.Text = "Name List File:";
            // 
            // lblRosterFile
            // 
            this.lblRosterFile.AutoSize = true;
            this.lblRosterFile.Location = new System.Drawing.Point(85, 95);
            this.lblRosterFile.Name = "lblRosterFile";
            this.lblRosterFile.Size = new System.Drawing.Size(60, 13);
            this.lblRosterFile.TabIndex = 7;
            this.lblRosterFile.Text = "Roster File:";
            // 
            // btnOpenNameListFile
            // 
            this.btnOpenNameListFile.Location = new System.Drawing.Point(278, 29);
            this.btnOpenNameListFile.Name = "btnOpenNameListFile";
            this.btnOpenNameListFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenNameListFile.TabIndex = 8;
            this.btnOpenNameListFile.Text = "Browse";
            this.btnOpenNameListFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveRosterFile
            // 
            this.btnSaveRosterFile.Location = new System.Drawing.Point(278, 92);
            this.btnSaveRosterFile.Name = "btnSaveRosterFile";
            this.btnSaveRosterFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRosterFile.TabIndex = 9;
            this.btnSaveRosterFile.Text = "Browse";
            this.btnSaveRosterFile.UseVisualStyleBackColor = true;
            // 
            // lblRosterSizeLimit
            // 
            this.lblRosterSizeLimit.AutoSize = true;
            this.lblRosterSizeLimit.Location = new System.Drawing.Point(218, 151);
            this.lblRosterSizeLimit.Name = "lblRosterSizeLimit";
            this.lblRosterSizeLimit.Size = new System.Drawing.Size(48, 13);
            this.lblRosterSizeLimit.TabIndex = 10;
            this.lblRosterSizeLimit.Text = "(Max 10)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 283);
            this.ControlBox = false;
            this.Controls.Add(this.lblRosterSizeLimit);
            this.Controls.Add(this.btnSaveRosterFile);
            this.Controls.Add(this.btnOpenNameListFile);
            this.Controls.Add(this.lblRosterFile);
            this.Controls.Add(this.lblNameListFile);
            this.Controls.Add(this.cmbRosterFile);
            this.Controls.Add(this.cmbNameListFile);
            this.Controls.Add(this.lblRosterSize);
            this.Controls.Add(this.numRosterSize);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "ST Roster Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numRosterSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numRosterSize;
        private System.Windows.Forms.Label lblRosterSize;
        private System.Windows.Forms.ComboBox cmbNameListFile;
        private System.Windows.Forms.ComboBox cmbRosterFile;
        private System.Windows.Forms.Label lblNameListFile;
        private System.Windows.Forms.Label lblRosterFile;
        private System.Windows.Forms.Button btnOpenNameListFile;
        private System.Windows.Forms.Button btnSaveRosterFile;
        private System.Windows.Forms.Label lblRosterSizeLimit;
    }
}

