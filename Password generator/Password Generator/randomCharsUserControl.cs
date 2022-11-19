using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class randomCharsUserControl : UserControl
    {
        public randomCharsUserControl()
        {
            InitializeComponent();
            this.labelEntrySaved.Visible = false;
        }

        /// <summary>
        /// Validates that the number given in input fullfills the requirements
        /// </summary>
        private Nullable<int> validateInput()
        {
            try
            {
                var result = Int32.Parse(this.textBoxNumberLetters.Text);
                if (result <= 128 && result >= 8)
                {
                    return result;
                }
                return null;
            }
            catch { return null; }
        }

        #region Button Events

        private void buttonGenerateRandomPassword_Click(object sender, EventArgs e)
        {
            this.labelEntrySaved.Visible = false;

            var number = validateInput();
            if (number != null)
            {
                string password = Cryptographer.CreateRandomCharsPassword(number.Value);
                this.labelPassword.Text = password;
            }
            else
            {
                DialogResult message = MessageBox.Show("Error Detected in Input", "Wrong entry", MessageBoxButtons.OK);
            }
        }

        private void textBoxAccountName_Click(object sender, EventArgs e)
        {
            this.labelEntrySaved.Visible = false;

            if (this.textBoxAccountName.Text == "(Account)")
            {
                this.textBoxAccountName.Text = "";
            }
        }

        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            var added = Cryptographer.AddPassword(this.textBoxAccountName.Text, this.labelPassword.Text);
            if (added)
            {
                this.labelEntrySaved.Visible = true;
            }
            else
            {
                this.labelEntrySaved.Visible = false;
            }

        }

        #endregion

    }
}
