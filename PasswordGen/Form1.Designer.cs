namespace PasswordGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LowercaseCheckbox = new System.Windows.Forms.CheckBox();
            this.UppercaseCheckbox = new System.Windows.Forms.CheckBox();
            this.NumbersCheckbox = new System.Windows.Forms.CheckBox();
            this.CharactersCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.PasswordsList = new System.Windows.Forms.ListBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LengthTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LowercaseCheckbox
            // 
            this.LowercaseCheckbox.AutoSize = true;
            this.LowercaseCheckbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowercaseCheckbox.Location = new System.Drawing.Point(37, 71);
            this.LowercaseCheckbox.Name = "LowercaseCheckbox";
            this.LowercaseCheckbox.Size = new System.Drawing.Size(160, 34);
            this.LowercaseCheckbox.TabIndex = 0;
            this.LowercaseCheckbox.Text = "Lowercase";
            this.LowercaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // UppercaseCheckbox
            // 
            this.UppercaseCheckbox.AutoSize = true;
            this.UppercaseCheckbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UppercaseCheckbox.Location = new System.Drawing.Point(37, 111);
            this.UppercaseCheckbox.Name = "UppercaseCheckbox";
            this.UppercaseCheckbox.Size = new System.Drawing.Size(161, 34);
            this.UppercaseCheckbox.TabIndex = 1;
            this.UppercaseCheckbox.Text = "Uppercase";
            this.UppercaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // NumbersCheckbox
            // 
            this.NumbersCheckbox.AutoSize = true;
            this.NumbersCheckbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbersCheckbox.Location = new System.Drawing.Point(37, 151);
            this.NumbersCheckbox.Name = "NumbersCheckbox";
            this.NumbersCheckbox.Size = new System.Drawing.Size(138, 34);
            this.NumbersCheckbox.TabIndex = 2;
            this.NumbersCheckbox.Text = "Numbers";
            this.NumbersCheckbox.UseVisualStyleBackColor = true;
            // 
            // CharactersCheckbox
            // 
            this.CharactersCheckbox.AutoSize = true;
            this.CharactersCheckbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharactersCheckbox.Location = new System.Drawing.Point(37, 191);
            this.CharactersCheckbox.Name = "CharactersCheckbox";
            this.CharactersCheckbox.Size = new System.Drawing.Size(163, 34);
            this.CharactersCheckbox.TabIndex = 3;
            this.CharactersCheckbox.Text = "Characters";
            this.CharactersCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password Generator ( by Pintea )";
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateBtn.Location = new System.Drawing.Point(37, 278);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(161, 45);
            this.GenerateBtn.TabIndex = 5;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // PasswordsList
            // 
            this.PasswordsList.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordsList.FormattingEnabled = true;
            this.PasswordsList.ItemHeight = 25;
            this.PasswordsList.Location = new System.Drawing.Point(233, 78);
            this.PasswordsList.Name = "PasswordsList";
            this.PasswordsList.Size = new System.Drawing.Size(317, 179);
            this.PasswordsList.TabIndex = 6;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(233, 278);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(317, 45);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save List";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LengthTextbox
            // 
            this.LengthTextbox.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthTextbox.Location = new System.Drawing.Point(130, 231);
            this.LengthTextbox.Name = "LengthTextbox";
            this.LengthTextbox.Size = new System.Drawing.Size(55, 30);
            this.LengthTextbox.TabIndex = 8;
            this.LengthTextbox.Text = "12";
            this.LengthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(584, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LengthTextbox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PasswordsList);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharactersCheckbox);
            this.Controls.Add(this.NumbersCheckbox);
            this.Controls.Add(this.UppercaseCheckbox);
            this.Controls.Add(this.LowercaseCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox LowercaseCheckbox;
        private System.Windows.Forms.CheckBox UppercaseCheckbox;
        private System.Windows.Forms.CheckBox NumbersCheckbox;
        private System.Windows.Forms.CheckBox CharactersCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.ListBox PasswordsList;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox LengthTextbox;
        private System.Windows.Forms.Label label2;
    }
}

