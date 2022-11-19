namespace PasswordManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRandomCharacters = new System.Windows.Forms.Button();
            this.buttonSeedPhrase = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.seedPhraseUserControl = new PasswordManager.seedPhraseUserControl();
            this.text2PasswordUserControl = new PasswordManager.text2PasswordUserControl();
            this.randomCharsUserControl = new PasswordManager.randomCharsUserControl();
            this.welcomeUserControl = new PasswordManager.welcomeUserControl();
            this.passwordManagerUserControl = new PasswordManager.passwordManagerUserControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonRandomCharacters, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSeedPhrase, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1068, 57);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonRandomCharacters
            // 
            this.buttonRandomCharacters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonRandomCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRandomCharacters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.buttonRandomCharacters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandomCharacters.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomCharacters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonRandomCharacters.Location = new System.Drawing.Point(4, 4);
            this.buttonRandomCharacters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRandomCharacters.Name = "buttonRandomCharacters";
            this.buttonRandomCharacters.Size = new System.Drawing.Size(526, 49);
            this.buttonRandomCharacters.TabIndex = 0;
            this.buttonRandomCharacters.Text = "Random Characters";
            this.buttonRandomCharacters.UseVisualStyleBackColor = false;
            this.buttonRandomCharacters.Click += new System.EventHandler(this.buttonRandomCharacters_Click);
            // 
            // buttonSeedPhrase
            // 
            this.buttonSeedPhrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonSeedPhrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSeedPhrase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.buttonSeedPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeedPhrase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeedPhrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSeedPhrase.Location = new System.Drawing.Point(538, 4);
            this.buttonSeedPhrase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSeedPhrase.Name = "buttonSeedPhrase";
            this.buttonSeedPhrase.Size = new System.Drawing.Size(526, 49);
            this.buttonSeedPhrase.TabIndex = 1;
            this.buttonSeedPhrase.Text = "Seed Phrase";
            this.buttonSeedPhrase.UseVisualStyleBackColor = false;
            this.buttonSeedPhrase.Click += new System.EventHandler(this.buttonRandomWords_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.25359F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1076, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.randomCharsUserControl);
            this.panel1.Controls.Add(this.welcomeUserControl);
            this.panel1.Controls.Add(this.seedPhraseUserControl);
            this.panel1.Controls.Add(this.text2PasswordUserControl);
            this.panel1.Controls.Add(this.passwordManagerUserControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 634);
            this.panel1.TabIndex = 2;
            // 
            // seedPhraseUserControl
            // 
            this.seedPhraseUserControl.BackColor = System.Drawing.Color.Black;
            this.seedPhraseUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seedPhraseUserControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.seedPhraseUserControl.Location = new System.Drawing.Point(0, 0);
            this.seedPhraseUserControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.seedPhraseUserControl.Name = "seedPhraseUserControl";
            this.seedPhraseUserControl.Size = new System.Drawing.Size(1068, 634);
            this.seedPhraseUserControl.TabIndex = 1;
            this.seedPhraseUserControl.Visible = false;
            //
            // text2PasswordUserControl
            //
            this.text2PasswordUserControl.BackColor = System.Drawing.Color.Black;
            this.text2PasswordUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text2PasswordUserControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text2PasswordUserControl.Location = new System.Drawing.Point(0, 0);
            this.text2PasswordUserControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.text2PasswordUserControl.Name = "text2PasswordUserControl";
            this.text2PasswordUserControl.Size = new System.Drawing.Size(1068, 634);
            this.text2PasswordUserControl.TabIndex = 1;
            this.text2PasswordUserControl.Visible = false;
            // 
            // randomCharsUserControl
            // 
            this.randomCharsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randomCharsUserControl.Location = new System.Drawing.Point(0, 0);
            this.randomCharsUserControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.randomCharsUserControl.Name = "randomCharsUserControl";
            this.randomCharsUserControl.Size = new System.Drawing.Size(1068, 634);
            this.randomCharsUserControl.TabIndex = 0;
            this.randomCharsUserControl.Visible = false;
            // 
            // welcomeUserControl
            // 
            this.welcomeUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeUserControl.Location = new System.Drawing.Point(0, 0);
            this.welcomeUserControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.welcomeUserControl.Name = "welcomeUserControl";
            this.welcomeUserControl.Size = new System.Drawing.Size(1068, 634);
            this.welcomeUserControl.TabIndex = 0;
            this.welcomeUserControl.Visible = false;
            // 
            // passwordManagerUserControl
            // 
            this.passwordManagerUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordManagerUserControl.Location = new System.Drawing.Point(0, 0);
            this.passwordManagerUserControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passwordManagerUserControl.Name = "passwordManagerUserControl";
            this.passwordManagerUserControl.Size = new System.Drawing.Size(1068, 634);
            this.passwordManagerUserControl.TabIndex = 0;
            this.passwordManagerUserControl.Visible = false;

            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonWord, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 69);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1068, 57);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(538, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(526, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Password Manager";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonPasswordManager_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.buttonWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonWord.Location = new System.Drawing.Point(4, 4);
            this.buttonWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(526, 49);
            this.buttonWord.TabIndex = 1;
            this.buttonWord.Text = "Words to Password";
            this.buttonWord.UseVisualStyleBackColor = false;
            this.buttonWord.Click += new System.EventHandler(this.buttonText2Password_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1076, 772);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonRandomCharacters;
        private System.Windows.Forms.Button buttonSeedPhrase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private randomCharsUserControl randomCharsUserControl;
        private welcomeUserControl welcomeUserControl;
        private passwordManagerUserControl passwordManagerUserControl;
        private seedPhraseUserControl seedPhraseUserControl;
        private text2PasswordUserControl text2PasswordUserControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonWord;
    }
}

