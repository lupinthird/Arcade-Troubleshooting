namespace ROMStuckBitSimulator
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpenROM = new System.Windows.Forms.TextBox();
            this.txtSaveROM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkD0 = new System.Windows.Forms.CheckBox();
            this.chkD1 = new System.Windows.Forms.CheckBox();
            this.chkD2 = new System.Windows.Forms.CheckBox();
            this.chkD3 = new System.Windows.Forms.CheckBox();
            this.chkD4 = new System.Windows.Forms.CheckBox();
            this.chkD5 = new System.Windows.Forms.CheckBox();
            this.chkD6 = new System.Windows.Forms.CheckBox();
            this.chkD7 = new System.Windows.Forms.CheckBox();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.cmbChipFamily = new System.Windows.Forms.ComboBox();
            this.pnlAddress = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROM Stuck Bit Simulator by Christopher D. Griffin";
            // 
            // txtOpenROM
            // 
            this.txtOpenROM.Location = new System.Drawing.Point(12, 40);
            this.txtOpenROM.Name = "txtOpenROM";
            this.txtOpenROM.Size = new System.Drawing.Size(439, 20);
            this.txtOpenROM.TabIndex = 1;
            // 
            // txtSaveROM
            // 
            this.txtSaveROM.Location = new System.Drawing.Point(12, 66);
            this.txtSaveROM.Name = "txtSaveROM";
            this.txtSaveROM.Size = new System.Drawing.Size(439, 20);
            this.txtSaveROM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address Bits (A0-A10)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data Bits (D0-D7)";
            // 
            // chkD0
            // 
            this.chkD0.AutoSize = true;
            this.chkD0.Location = new System.Drawing.Point(227, 120);
            this.chkD0.Name = "chkD0";
            this.chkD0.Size = new System.Drawing.Size(40, 17);
            this.chkD0.TabIndex = 16;
            this.chkD0.Text = "D0";
            this.chkD0.UseVisualStyleBackColor = true;
            // 
            // chkD1
            // 
            this.chkD1.AutoSize = true;
            this.chkD1.Location = new System.Drawing.Point(227, 143);
            this.chkD1.Name = "chkD1";
            this.chkD1.Size = new System.Drawing.Size(40, 17);
            this.chkD1.TabIndex = 17;
            this.chkD1.Text = "D1";
            this.chkD1.UseVisualStyleBackColor = true;
            // 
            // chkD2
            // 
            this.chkD2.AutoSize = true;
            this.chkD2.Location = new System.Drawing.Point(227, 166);
            this.chkD2.Name = "chkD2";
            this.chkD2.Size = new System.Drawing.Size(40, 17);
            this.chkD2.TabIndex = 18;
            this.chkD2.Text = "D2";
            this.chkD2.UseVisualStyleBackColor = true;
            // 
            // chkD3
            // 
            this.chkD3.AutoSize = true;
            this.chkD3.Location = new System.Drawing.Point(227, 189);
            this.chkD3.Name = "chkD3";
            this.chkD3.Size = new System.Drawing.Size(40, 17);
            this.chkD3.TabIndex = 19;
            this.chkD3.Text = "D3";
            this.chkD3.UseVisualStyleBackColor = true;
            // 
            // chkD4
            // 
            this.chkD4.AutoSize = true;
            this.chkD4.Location = new System.Drawing.Point(227, 212);
            this.chkD4.Name = "chkD4";
            this.chkD4.Size = new System.Drawing.Size(40, 17);
            this.chkD4.TabIndex = 20;
            this.chkD4.Text = "D4";
            this.chkD4.UseVisualStyleBackColor = true;
            // 
            // chkD5
            // 
            this.chkD5.AutoSize = true;
            this.chkD5.Location = new System.Drawing.Point(227, 235);
            this.chkD5.Name = "chkD5";
            this.chkD5.Size = new System.Drawing.Size(40, 17);
            this.chkD5.TabIndex = 21;
            this.chkD5.Text = "D5";
            this.chkD5.UseVisualStyleBackColor = true;
            // 
            // chkD6
            // 
            this.chkD6.AutoSize = true;
            this.chkD6.Location = new System.Drawing.Point(227, 258);
            this.chkD6.Name = "chkD6";
            this.chkD6.Size = new System.Drawing.Size(40, 17);
            this.chkD6.TabIndex = 22;
            this.chkD6.Text = "D6";
            this.chkD6.UseVisualStyleBackColor = true;
            // 
            // chkD7
            // 
            this.chkD7.AutoSize = true;
            this.chkD7.Location = new System.Drawing.Point(227, 281);
            this.chkD7.Name = "chkD7";
            this.chkD7.Size = new System.Drawing.Size(40, 17);
            this.chkD7.TabIndex = 23;
            this.chkD7.Text = "D7";
            this.chkD7.UseVisualStyleBackColor = true;
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(468, 38);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFileOpen.TabIndex = 24;
            this.btnFileOpen.Text = "Open";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(468, 64);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 25;
            this.btnSaveFile.Text = "Save As";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(382, 316);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(161, 51);
            this.btnGo.TabIndex = 26;
            this.btnGo.Text = "Generate ROM";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cmbChipFamily
            // 
            this.cmbChipFamily.FormattingEnabled = true;
            this.cmbChipFamily.Location = new System.Drawing.Point(382, 104);
            this.cmbChipFamily.Name = "cmbChipFamily";
            this.cmbChipFamily.Size = new System.Drawing.Size(121, 21);
            this.cmbChipFamily.TabIndex = 30;
            this.cmbChipFamily.SelectedIndexChanged += new System.EventHandler(this.cmbChipFamily_SelectedIndexChanged);
            // 
            // pnlAddress
            // 
            this.pnlAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAddress.Location = new System.Drawing.Point(12, 121);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(200, 422);
            this.pnlAddress.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 557);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.cmbChipFamily);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.chkD7);
            this.Controls.Add(this.chkD6);
            this.Controls.Add(this.chkD5);
            this.Controls.Add(this.chkD4);
            this.Controls.Add(this.chkD3);
            this.Controls.Add(this.chkD2);
            this.Controls.Add(this.chkD1);
            this.Controls.Add(this.chkD0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaveROM);
            this.Controls.Add(this.txtOpenROM);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpenROM;
        private System.Windows.Forms.TextBox txtSaveROM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkD0;
        private System.Windows.Forms.CheckBox chkD1;
        private System.Windows.Forms.CheckBox chkD2;
        private System.Windows.Forms.CheckBox chkD3;
        private System.Windows.Forms.CheckBox chkD4;
        private System.Windows.Forms.CheckBox chkD5;
        private System.Windows.Forms.CheckBox chkD6;
        private System.Windows.Forms.CheckBox chkD7;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox cmbChipFamily;
        private System.Windows.Forms.FlowLayoutPanel pnlAddress;
    }
}

