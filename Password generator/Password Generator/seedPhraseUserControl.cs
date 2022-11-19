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
    public partial class seedPhraseUserControl : UserControl
    {
        List<Tuple<int, string>> seedPhrase = new List<Tuple<int, string>>();

        public seedPhraseUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates that the number given in input fullfills the requirements
        /// </summary>
        private Nullable<int> validateInput()
        {
            try
            {
                var result = Int32.Parse(this.textBoxNumberWords.Text);
                if (result <= 24 && result >= 1)
                {
                    return result;
                }
                return null;
            }
            catch { return null; }
        }

        #region Button Events
        
        private void buttonGenerateRLP_Click(object sender, EventArgs e)
        {
            var number = validateInput();
            if (number != null)
            {
                this.seedPhrase.Clear();
                this.dataGridViewSeedPhrase.Rows.Clear();

                //create Seed Phrase
                this.seedPhrase = Cryptographer.CreateSeedPhrasePassword(number.Value);

                //display password
                dataGridViewSeedPhrase.ColumnCount = 2;
                dataGridViewSeedPhrase.ColumnHeadersVisible = true;
                dataGridViewSeedPhrase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Black;
                columnHeaderStyle.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                columnHeaderStyle.ForeColor = Color.Black;
                dataGridViewSeedPhrase.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                dataGridViewSeedPhrase.Columns[0].Name = "Index";
                dataGridViewSeedPhrase.Columns[1].Name = "Word";

                for (var i=0; i<this.seedPhrase.Count; i++)
                {
                    var entry = this.seedPhrase.ElementAt(i);
                    var row = new string[] { entry.Item1.ToString(), entry.Item2 };

                    dataGridViewSeedPhrase.Rows.Add(row);
                }
            }
            else
            {
                DialogResult message = MessageBox.Show("Error Detected in Input", "Wrong entry", MessageBoxButtons.OK);
            }
        }
        
        #endregion

    }
}
