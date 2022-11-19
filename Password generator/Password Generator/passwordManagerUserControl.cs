using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class passwordManagerUserControl : UserControl
    {
        public passwordManagerUserControl()
        {
            InitializeComponent();
        }

        private void passwordManagerUserControl_Load(object sender, EventArgs e)
        {
            RefreshPasswords();

            this.labelEntrySaved.Visible = false;
            this.labelEntryDeleted.Visible = false;
        }

        /// <summary>
        /// Retrieve passwords from CSV file and refresh DataGridView
        /// </summary>
        public void RefreshPasswords()
        {
            Cryptographer.CreateCSVFileIfMissing();
            var passwords = Cryptographer.RetrievePasswords();
            dataGridViewPasswords.Rows.Clear();

            dataGridViewPasswords.ColumnCount = 2;
            dataGridViewPasswords.ColumnHeadersVisible = true;
            dataGridViewPasswords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Black;
            columnHeaderStyle.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            columnHeaderStyle.ForeColor = Color.Black;
            dataGridViewPasswords.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridViewPasswords.Columns[0].Name = "Account";
            dataGridViewPasswords.Columns[1].Name = "Password";

            for (var i = 0; i < passwords.Count; i++)
            {
                var entry = passwords.ElementAt(i);
                var row = new string[] { entry.Item1, entry.Item2 };

                dataGridViewPasswords.Rows.Add(row);
            }
        }

        #region Button Events

        private void textBoxAddAccountName_Click(object sender, EventArgs e)
        {
            this.labelEntrySaved.Visible = false;
            this.labelEntryDeleted.Visible = false;

            if (this.textBoxAddAccountName.Text == "(Account)")
            {
                this.textBoxAddAccountName.Text = "";
            }
        }

        private void textBoxAddPassword_Click(object sender, EventArgs e)
        {
            this.labelEntrySaved.Visible = false;
            this.labelEntryDeleted.Visible = false;

            if (this.textBoxAddPassword.Text == "(Password)")
            {
                this.textBoxAddPassword.Text = "";
            }
        }

        private void buttonAddPassword_Click(object sender, EventArgs e)
        {
            var account = this.textBoxAddAccountName.Text;
            var password = this.textBoxAddPassword.Text;

            var added = Cryptographer.AddPassword(account, password);
            if (added)
            {
                this.RefreshPasswords();
                this.labelEntrySaved.Visible = true;
            }
            else
            {
                this.labelEntrySaved.Visible = false;
            }
        }

        private void buttonDeletePassword_Click(object sender, EventArgs e)
        {
            var account = this.textBoxAddAccountName.Text;
            var password = this.textBoxAddPassword.Text;

            var deleted = Cryptographer.DeletePassword(account, password);
            if (deleted)
            {
                this.RefreshPasswords();
                this.labelEntryDeleted.Visible = true;
            }
            else
            {
                this.labelEntryDeleted.Visible = false;
            }
        }

        private void dataGridViewPasswords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.labelEntrySaved.Visible = false;
            this.labelEntryDeleted.Visible = false;

            if (this.dataGridViewPasswords.CurrentRow != null) {
                this.textBoxAddAccountName.Text = this.dataGridViewPasswords.CurrentRow.Cells[0].Value as string;
                this.textBoxAddPassword.Text = this.dataGridViewPasswords.CurrentRow.Cells[1].Value as string;
            } 
        }
        
        #endregion

    }
}
