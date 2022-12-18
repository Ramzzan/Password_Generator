namespace Password_Generator
{
    partial class PasswordGeneratorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGeneratorUI));
            this.generateGroup = new System.Windows.Forms.GroupBox();
            this.copyBox = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.strengthBar = new System.Windows.Forms.PictureBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.characterGroup = new System.Windows.Forms.GroupBox();
            this.chSymbols = new System.Windows.Forms.CheckBox();
            this.chNumbers = new System.Windows.Forms.CheckBox();
            this.chLowercase = new System.Windows.Forms.CheckBox();
            this.chUppercase = new System.Windows.Forms.CheckBox();
            this.lengthGroup = new System.Windows.Forms.GroupBox();
            this.lengthSlider = new System.Windows.Forms.TrackBar();
            this.sliderValue = new System.Windows.Forms.Label();
            this.txtBorder = new System.Windows.Forms.TextBox();
            this.backgroundIllustration = new System.Windows.Forms.PictureBox();
            this.generateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthBar)).BeginInit();
            this.characterGroup.SuspendLayout();
            this.lengthGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundIllustration)).BeginInit();
            this.SuspendLayout();
            // 
            // generateGroup
            // 
            this.generateGroup.Controls.Add(this.copyBox);
            this.generateGroup.Controls.Add(this.txtPassword);
            this.generateGroup.Controls.Add(this.strengthBar);
            this.generateGroup.Controls.Add(this.btGenerate);
            this.generateGroup.Controls.Add(this.characterGroup);
            this.generateGroup.Controls.Add(this.lengthGroup);
            this.generateGroup.Controls.Add(this.txtBorder);
            this.generateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateGroup.Location = new System.Drawing.Point(34, 34);
            this.generateGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateGroup.Name = "generateGroup";
            this.generateGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateGroup.Size = new System.Drawing.Size(504, 526);
            this.generateGroup.TabIndex = 0;
            this.generateGroup.TabStop = false;
            this.generateGroup.Text = "Password Generator";
            // 
            // copyBox
            // 
            this.copyBox.BackColor = System.Drawing.SystemColors.Window;
            this.copyBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyBox.Image = global::Password_Generator.Properties.Resources.Copy;
            this.copyBox.Location = new System.Drawing.Point(462, 82);
            this.copyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyBox.Name = "copyBox";
            this.copyBox.Size = new System.Drawing.Size(26, 27);
            this.copyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.copyBox.TabIndex = 2;
            this.copyBox.TabStop = false;
            this.copyBox.Visible = false;
            this.copyBox.Click += new System.EventHandler(this.copyBox_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(44, 82);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(410, 27);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseDown);
            // 
            // strengthBar
            // 
            this.strengthBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.strengthBar.Location = new System.Drawing.Point(34, 121);
            this.strengthBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.strengthBar.Name = "strengthBar";
            this.strengthBar.Size = new System.Drawing.Size(462, 2);
            this.strengthBar.TabIndex = 2;
            this.strengthBar.TabStop = false;
            this.strengthBar.Visible = false;
            // 
            // btGenerate
            // 
            this.btGenerate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGenerate.FlatAppearance.BorderSize = 0;
            this.btGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerate.ForeColor = System.Drawing.SystemColors.Control;
            this.btGenerate.Location = new System.Drawing.Point(34, 438);
            this.btGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(462, 54);
            this.btGenerate.TabIndex = 0;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = false;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // characterGroup
            // 
            this.characterGroup.Controls.Add(this.chSymbols);
            this.characterGroup.Controls.Add(this.chNumbers);
            this.characterGroup.Controls.Add(this.chLowercase);
            this.characterGroup.Controls.Add(this.chUppercase);
            this.characterGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterGroup.Location = new System.Drawing.Point(34, 271);
            this.characterGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.characterGroup.Name = "characterGroup";
            this.characterGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.characterGroup.Size = new System.Drawing.Size(462, 148);
            this.characterGroup.TabIndex = 2;
            this.characterGroup.TabStop = false;
            this.characterGroup.Text = "Character type";
            // 
            // chSymbols
            // 
            this.chSymbols.AutoSize = true;
            this.chSymbols.Location = new System.Drawing.Point(217, 90);
            this.chSymbols.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chSymbols.Name = "chSymbols";
            this.chSymbols.Size = new System.Drawing.Size(117, 29);
            this.chSymbols.TabIndex = 3;
            this.chSymbols.Text = "Symbols";
            this.chSymbols.UseVisualStyleBackColor = true;
            // 
            // chNumbers
            // 
            this.chNumbers.AutoSize = true;
            this.chNumbers.Checked = true;
            this.chNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chNumbers.Location = new System.Drawing.Point(37, 90);
            this.chNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chNumbers.Name = "chNumbers";
            this.chNumbers.Size = new System.Drawing.Size(120, 29);
            this.chNumbers.TabIndex = 2;
            this.chNumbers.Text = "Numbers";
            this.chNumbers.UseVisualStyleBackColor = true;
            // 
            // chLowercase
            // 
            this.chLowercase.AutoSize = true;
            this.chLowercase.Checked = true;
            this.chLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLowercase.Location = new System.Drawing.Point(217, 54);
            this.chLowercase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chLowercase.Name = "chLowercase";
            this.chLowercase.Size = new System.Drawing.Size(138, 29);
            this.chLowercase.TabIndex = 1;
            this.chLowercase.Text = "Lowercase";
            this.chLowercase.UseVisualStyleBackColor = true;
            // 
            // chUppercase
            // 
            this.chUppercase.AutoSize = true;
            this.chUppercase.Location = new System.Drawing.Point(37, 54);
            this.chUppercase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chUppercase.Name = "chUppercase";
            this.chUppercase.Size = new System.Drawing.Size(138, 29);
            this.chUppercase.TabIndex = 0;
            this.chUppercase.Text = "Uppercase";
            this.chUppercase.UseVisualStyleBackColor = true;
            // 
            // lengthGroup
            // 
            this.lengthGroup.Controls.Add(this.lengthSlider);
            this.lengthGroup.Controls.Add(this.sliderValue);
            this.lengthGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthGroup.Location = new System.Drawing.Point(34, 145);
            this.lengthGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lengthGroup.Name = "lengthGroup";
            this.lengthGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lengthGroup.Size = new System.Drawing.Size(462, 118);
            this.lengthGroup.TabIndex = 1;
            this.lengthGroup.TabStop = false;
            this.lengthGroup.Text = "Length";
            // 
            // lengthSlider
            // 
            this.lengthSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lengthSlider.LargeChange = 1;
            this.lengthSlider.Location = new System.Drawing.Point(57, 50);
            this.lengthSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lengthSlider.Maximum = 24;
            this.lengthSlider.Minimum = 4;
            this.lengthSlider.Name = "lengthSlider";
            this.lengthSlider.Size = new System.Drawing.Size(397, 56);
            this.lengthSlider.TabIndex = 0;
            this.lengthSlider.Value = 24;
            this.lengthSlider.Scroll += new System.EventHandler(this.lengthSlider_Scroll);
            // 
            // sliderValue
            // 
            this.sliderValue.AutoSize = true;
            this.sliderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderValue.Location = new System.Drawing.Point(8, 50);
            this.sliderValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sliderValue.Name = "sliderValue";
            this.sliderValue.Size = new System.Drawing.Size(44, 31);
            this.sliderValue.TabIndex = 0;
            this.sliderValue.Text = "25";
            // 
            // txtBorder
            // 
            this.txtBorder.BackColor = System.Drawing.SystemColors.Window;
            this.txtBorder.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorder.Location = new System.Drawing.Point(34, 71);
            this.txtBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBorder.Name = "txtBorder";
            this.txtBorder.ReadOnly = true;
            this.txtBorder.Size = new System.Drawing.Size(462, 46);
            this.txtBorder.TabIndex = 0;
            this.txtBorder.TabStop = false;
            this.txtBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBorder_MouseDown);
            // 
            // backgroundIllustration
            // 
            this.backgroundIllustration.BackColor = System.Drawing.Color.Transparent;
            this.backgroundIllustration.Image = global::Password_Generator.Properties.Resources.Vector;
            this.backgroundIllustration.Location = new System.Drawing.Point(557, 89);
            this.backgroundIllustration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backgroundIllustration.Name = "backgroundIllustration";
            this.backgroundIllustration.Size = new System.Drawing.Size(343, 417);
            this.backgroundIllustration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgroundIllustration.TabIndex = 1;
            this.backgroundIllustration.TabStop = false;
            // 
            // PasswordGeneratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 594);
            this.Controls.Add(this.generateGroup);
            this.Controls.Add(this.backgroundIllustration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PasswordGeneratorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.generateGroup.ResumeLayout(false);
            this.generateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthBar)).EndInit();
            this.characterGroup.ResumeLayout(false);
            this.characterGroup.PerformLayout();
            this.lengthGroup.ResumeLayout(false);
            this.lengthGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundIllustration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generateGroup;
        private System.Windows.Forms.GroupBox characterGroup;
        private System.Windows.Forms.CheckBox chSymbols;
        private System.Windows.Forms.CheckBox chNumbers;
        private System.Windows.Forms.CheckBox chLowercase;
        private System.Windows.Forms.CheckBox chUppercase;
        private System.Windows.Forms.GroupBox lengthGroup;
        private System.Windows.Forms.TrackBar lengthSlider;
        private System.Windows.Forms.Label sliderValue;
        private System.Windows.Forms.TextBox txtBorder;
        private System.Windows.Forms.PictureBox backgroundIllustration;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.PictureBox strengthBar;
        private System.Windows.Forms.PictureBox copyBox;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

