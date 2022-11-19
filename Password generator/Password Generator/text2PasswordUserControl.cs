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
    public partial class text2PasswordUserControl : UserControl
    {
        public text2PasswordUserControl()
        {
            InitializeComponent();
            this.labelEntrySaved.Visible = false;
        }

        /// <summary>
        /// Validates that the text given in input fullfills the requirements
        /// </summary>
        private string validateInput()
        {
            try
            {
                var text = this.textBoxTextToTransform.Text;
                if (text.Length >= 8 && text.Length <= 128)
                {
                    return text;
                }
                return null;
            }
            catch { return null; }
        }

        #region Button Events

        private void textBoxTextToTransform_MouseClick(object sender, MouseEventArgs e)
        {
            this.labelEntrySaved.Visible = false;

            if (this.textBoxTextToTransform.Text == "(Enter text here)")
            {
                this.textBoxTextToTransform.Text = "";
            }
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {
            this.labelEntrySaved.Visible = false;
            var text = validateInput();

            if (text != null)
            {
                string password = Cryptographer.CreatePasswordFromText(text);
                this.TransformedPassword.Text = password;
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
            var added = Cryptographer.AddPassword(this.textBoxAccountName.Text, this.TransformedPassword.Text);
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
