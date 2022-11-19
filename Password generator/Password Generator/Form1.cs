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
    public partial class Form1 : Form
    {
        private List<UserControl> userControls = new List<UserControl>();
        public Form1()
        {
            InitializeComponent();
            Cryptographer.CreateCSVFileIfMissing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControls.Add(this.welcomeUserControl);
            userControls.Add(this.randomCharsUserControl);
            userControls.Add(this.seedPhraseUserControl);
            userControls.Add(this.text2PasswordUserControl);
            userControls.Add(this.passwordManagerUserControl);
            hideAllUserControls();
            this.welcomeUserControl.Visible = true;
        }

        private void buttonRandomCharacters_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            this.randomCharsUserControl.Visible = true;
        }

        private void buttonRandomWords_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            this.seedPhraseUserControl.Visible = true;
        }

        private void buttonText2Password_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            this.text2PasswordUserControl.Visible = true;
        }

        private void buttonPasswordManager_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            this.passwordManagerUserControl.Visible = true;
            this.passwordManagerUserControl.RefreshPasswords();
        }
        
        private void hideAllUserControls()
        {
            foreach (UserControl uc in this.userControls)
            {
                uc.Visible = false;
            }
        }
    }
}
