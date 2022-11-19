
namespace PasswordManager
{
    partial class passwordManagerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxAddAccountName = new System.Windows.Forms.TextBox();
            this.textBoxAddPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewPasswords = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeletePassword = new System.Windows.Forms.Button();
            this.buttonAddPassword = new System.Windows.Forms.Button();
            this.labelEntrySaved = new System.Windows.Forms.Label();
            this.labelEntryDeleted = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasswords)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.565892F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.81395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.325581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 645);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(217, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewPasswords, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(217, 144);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 367);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxAddAccountName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAddPassword, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 324);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(624, 39);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBoxAddAccountName
            // 
            this.textBoxAddAccountName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxAddAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddAccountName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddAccountName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxAddAccountName.Location = new System.Drawing.Point(3, 3);
            this.textBoxAddAccountName.Name = "textBoxAddAccountName";
            this.textBoxAddAccountName.Size = new System.Drawing.Size(306, 34);
            this.textBoxAddAccountName.TabIndex = 0;
            this.textBoxAddAccountName.Text = "(Account)";
            this.textBoxAddAccountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBoxAddAccountName, "Enter an account name to save the password");
            this.textBoxAddAccountName.Click += new System.EventHandler(this.textBoxAddAccountName_Click);
            // 
            // textBoxAddPassword
            // 
            this.textBoxAddPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxAddPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddPassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxAddPassword.Location = new System.Drawing.Point(315, 3);
            this.textBoxAddPassword.Name = "textBoxAddPassword";
            this.textBoxAddPassword.Size = new System.Drawing.Size(306, 34);
            this.textBoxAddPassword.TabIndex = 1;
            this.textBoxAddPassword.Text = "(Password)";
            this.textBoxAddPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBoxAddPassword, "Enter the password");
            this.textBoxAddPassword.Click += new System.EventHandler(this.textBoxAddPassword_Click);
            // 
            // dataGridViewPasswords
            // 
            this.dataGridViewPasswords.AllowUserToAddRows = false;
            this.dataGridViewPasswords.AllowUserToDeleteRows = false;
            this.dataGridViewPasswords.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPasswords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPasswords.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewPasswords.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPasswords.Name = "dataGridViewPasswords";
            this.dataGridViewPasswords.RowHeadersWidth = 51;
            this.dataGridViewPasswords.RowTemplate.Height = 24;
            this.dataGridViewPasswords.Size = new System.Drawing.Size(626, 274);
            this.dataGridViewPasswords.TabIndex = 1;
            this.dataGridViewPasswords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPasswords_CellClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonDeletePassword, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonAddPassword, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelEntrySaved, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelEntryDeleted, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(216, 518);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(634, 124);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // buttonDeletePassword
            // 
            this.buttonDeletePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeletePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDeletePassword.Location = new System.Drawing.Point(320, 15);
            this.buttonDeletePassword.Name = "buttonDeletePassword";
            this.buttonDeletePassword.Size = new System.Drawing.Size(311, 49);
            this.buttonDeletePassword.TabIndex = 3;
            this.buttonDeletePassword.Text = "Delete";
            this.buttonDeletePassword.UseVisualStyleBackColor = true;
            this.buttonDeletePassword.Click += new System.EventHandler(this.buttonDeletePassword_Click);
            // 
            // buttonAddPassword
            // 
            this.buttonAddPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddPassword.Location = new System.Drawing.Point(3, 15);
            this.buttonAddPassword.Name = "buttonAddPassword";
            this.buttonAddPassword.Size = new System.Drawing.Size(311, 49);
            this.buttonAddPassword.TabIndex = 2;
            this.buttonAddPassword.Text = "Add";
            this.buttonAddPassword.UseVisualStyleBackColor = true;
            this.buttonAddPassword.Click += new System.EventHandler(this.buttonAddPassword_Click);
            // 
            // labelEntrySaved
            // 
            this.labelEntrySaved.AutoSize = true;
            this.labelEntrySaved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEntrySaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEntrySaved.Location = new System.Drawing.Point(3, 67);
            this.labelEntrySaved.Name = "labelEntrySaved";
            this.labelEntrySaved.Size = new System.Drawing.Size(311, 57);
            this.labelEntrySaved.TabIndex = 4;
            this.labelEntrySaved.Text = "(Entry saved!)";
            this.labelEntrySaved.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEntryDeleted
            // 
            this.labelEntryDeleted.AutoSize = true;
            this.labelEntryDeleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEntryDeleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEntryDeleted.Location = new System.Drawing.Point(320, 67);
            this.labelEntryDeleted.Name = "labelEntryDeleted";
            this.labelEntryDeleted.Size = new System.Drawing.Size(311, 57);
            this.labelEntryDeleted.TabIndex = 5;
            this.labelEntryDeleted.Text = "(Entry deleted!)";
            this.labelEntryDeleted.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Password Manager";
            // 
            // passwordManagerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "passwordManagerUserControl";
            this.Size = new System.Drawing.Size(1067, 645);
            this.Load += new System.EventHandler(this.passwordManagerUserControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasswords)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridViewPasswords;
        private System.Windows.Forms.TextBox textBoxAddAccountName;
        private System.Windows.Forms.TextBox textBoxAddPassword;
        private System.Windows.Forms.Button buttonDeletePassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonAddPassword;
        private System.Windows.Forms.Label labelEntrySaved;
        private System.Windows.Forms.Label labelEntryDeleted;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
