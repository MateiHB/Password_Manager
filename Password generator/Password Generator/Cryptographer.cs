using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Windows.Forms;

namespace PasswordManager
{
    public static class Cryptographer
    {
        private static Random random = new Random();
        private static string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#$%()*+-./:;<=>?@[]^_{|}~";
        private static List<string> wordBank = new List<string>();
        //private static string key = "j(D%7RLR=wo5GlGRdgN?;!!dm<jC;j6ZBm72Y+T!jZ9>5nv)nvp;hs-E+oq#da#/*wJkgM/x2baPW8s4G?clPOa:lv;I=0M#.mLtw>qsT05N=@#xho)Z0P*M=flW/dT)";
        private static string key = "xA7*X?XvesMx9|ERS1a5WUp4jR/42uF[m8I|y3=1q~~lEEn!T+7Hf!I%kc8ff^5.;TlaYHt?#JOWVdy(Ejj.X};Lz6;v^.UvFpz:tnllY*76v:sh%[#{/:v=80#]V|_[";
        private static Dictionary<char, string> possibilities = new Dictionary<char, string>()
        {
            {'a',"@#%0oAO+=+"},{'b',"BdD%8964"},{'c',"oO*()C0"},{'d',"DbB8964"},{'e',"3E#@96"},
            {'f',"FLltT1i()IjJ7!"},{'g',"GoOcC#@69"},{'h',"H4#+="},{'i',"FfLlT()t1jJI7-~_!"},{'j',"JiI()~!LlFfTt17-_"},
            {'k',"KwW%7"},{'l',"tTLF~()fiIJj17-_!"},{'m',"MnN3968^#"},{'n',"NmM2^#47"},{'o',"OaA0C*cdD()bBpPqQ"},
            {'p',"PqQoOLljJiI17"},{'q',"QpPoOLljJiI17"},{'r',"RsS$"},{'s',"SrR$"},{'t',"TLlF~()f1!iIJj7"},
            {'u',"UvVwW"},{'v',"VwW^uUL2"},{'w',"VvW^uUL3"},{'x',"X#*+"},{'y',"YxX+^%$"},
            {'z',"ZsS$25"},{' ',"_-=+.*()^~"},{'1',"fFl~L()t.TiI!"},{'2',"Ss$"},{'3',"e$E"},
            {'4',"bBdD"},{'5',"sS$"},{'6',"bBdDEe"},{'7',"iIL~lfFt()TjJ%"},{'8',"bBdD"},
            {'9',"bBdDEe"},{'0',"aA*o()O"}
        };
        //private static string path = "../../../passwords.csv";
        private static string path = "./passwords.csv";

        /// <summary>
        /// Creates passwords.csv if file is missing
        /// </summary>
        public static void CreateCSVFileIfMissing()
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }

                var config = new CsvConfiguration(CultureInfo.InvariantCulture);
                config.HasHeaderRecord = false;

                using (var writer = new StreamWriter(path, false))
                {
                    using (var csv = new CsvWriter(writer, config))
                    {
                        var entry = new List<CSVEntry>();
                        entry.Add(new CSVEntry() { Account = "Account", Password = "Password" });
                        csv.WriteRecords(entry);
                    }
                }
            }
        }


        /// <summary>
        /// Generates a new password containing random characters
        /// </summary>
        /// <param name="number"> 
        /// Number of characters of password
        /// </param>
        public static string CreateRandomCharsPassword(int number)
        {
            string password;

            while (true)
            {
                password = "";

                for (int i = 0; i < number; i++)
                {
                    password += characters[random.Next(0, characters.Length)];
                }

                //Checks if at least 1 upper/lowercase, 1 special char & 1 digit
                if (password.Any(c => !char.IsLetterOrDigit(c)) &&
                    password.Any(c => char.IsDigit(c)) &&
                    password.Any(c => char.IsUpper(c)) &&
                    password.Any(c => char.IsLower(c)))
                {
                    break;
                }
            }

            return password;
        }

        /// <summary>
        /// Generates a new seed phrase containing random words
        /// </summary>
        /// <param name="number">
        /// Number of words of seed phrase
        /// </param>
        public static List<Tuple<int, string>> CreateSeedPhrasePassword(int number)
        {
            //Initiating the Word Bank
            if (wordBank.Count == 0)
            {
                //"C:\Users\Matei\Desktop\C# projects\Password generator\Password Generator\bip39.txt";
                using (StreamReader file = new StreamReader("../../bip39.txt"))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        wordBank.Add(line);
                    }
                    file.Close();
                }
            }

            var seedPhrase = new List<Tuple<int, string>>();
            //Create Seed Phrases
            for (int i = 0; i < number; i++)
            {
                string word = wordBank.ElementAt(random.Next(0, wordBank.Count()));
                Tuple<int, string> entry = new Tuple<int, string>(i + 1, word);
                seedPhrase.Add(entry);
            }

            return seedPhrase;
        }

        /// <summary>
        /// Transforms text into password
        /// </summary>
        /// <param name="str">
        /// Text to transform
        /// </param>
        public static string CreatePasswordFromText(string str)
        {
            string password;
            while (true)
            {
                double prob = 0.15;
                password = "";

                foreach (char c in str)
                {
                    if ((char.IsLetterOrDigit(c) || c == ' ') && random.NextDouble() < prob)
                    {
                        char ch = char.ToLower(c);
                        var s = possibilities[ch];
                        password += s[random.Next(0, s.Length)];
                    }
                    else { password += c; }
                }
                //Checks if at least 1 upper/lowercase, 1 special char & 1 digit
                if (password.Any(c => !char.IsLetterOrDigit(c) && c != ' ') &&
                    password.Any(c => char.IsDigit(c)) &&
                    password.Any(c => char.IsUpper(c)) &&
                    password.Any(c => char.IsLower(c)))
                {
                    break;
                }
            }
            return password;
        }

        /// <summary>
        /// Retrieves all passwords from passwords.csv
        /// </summary>
        public static List<Tuple<string, string>> RetrievePasswords()
        {
            var list = new List<Tuple<string, string>>();

            using (var streamReader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {

                    var records = csvReader.GetRecords<CSVEntry>().ToList();

                    foreach (var r in records)
                    {
                        list.Add(new Tuple<string, string>(decrypt(r.Account), decrypt(r.Password)));
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Adds password to CSV file
        /// </summary>
        /// <param name="account"> 
        /// Account name to save password under
        /// </param>
        /// <param name="password"> 
        /// Password to save
        /// </param>
        public static bool AddPassword(string account, string password)
        {
            if (validateInput(account, password, false))
            {
                var entry = new List<CSVEntry>();
                entry.Add(new CSVEntry() { Account = encrypt(account), Password = encrypt(password) });
                AddPasswordsToFile(entry, true);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds list of entries to CSV file
        /// </summary>
        /// <param name="entries"> 
        /// List of CSVEntry containing the passwords
        /// </param>
        /// <param name="append"> 
        /// True if appending data to file, false if overwritting the file
        /// </param>
        public static void AddPasswordsToFile(List<CSVEntry> entries, bool append)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HasHeaderRecord = false;

            using (var writer = new StreamWriter(path, append))
            {
                using (var csv = new CsvWriter(writer, config))
                {
                    if (append == false)
                    {
                        var entry = new List<CSVEntry>();
                        entry.Add(new CSVEntry() { Account = "Account", Password = "Password" });
                        csv.WriteRecords(entry);
                    }

                    csv.WriteRecords(entries);
                }
            }
        }

        /// <summary>
        /// Deletes entry from CSV file
        /// </summary>
        /// <param name="name"> 
        /// Name of account to delete
        /// </param>
        /// <param name="password"> 
        /// Password to delete
        /// </param>
        public static bool DeletePassword(string name, string password)
        {
            if (validateInput(name, password, true))
            {
                var records = RetrievePasswords();

                records.RemoveAll(item => item.Item1 == name && item.Item2 == password);

                var csvRecords = new List<CSVEntry>();

                foreach (var item in records)
                {
                    csvRecords.Add(new CSVEntry() { Account = encrypt(item.Item1), Password = encrypt(item.Item2) });
                }
                AddPasswordsToFile(csvRecords, false);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Encrypts string
        /// </summary>
        /// <param name="str"> 
        /// String to encrypt
        /// </param>
        private static string encrypt(string str)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(str);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        /// <summary>
        /// Decrypts string
        /// </summary>
        /// <param name="str"> 
        /// String to decrypt
        /// </param>
        private static string decrypt(string str)
        {
            byte[] data = Convert.FromBase64String(str);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        /// <summary>
        /// Validates if account and password are correct inputs 
        /// </summary>
        /// <param name="account"> 
        /// Account name to verify
        /// </param>
        /// <param name="password"> 
        /// Password to verify
        /// </param>
        /// <param name="existent"> 
        /// Should it be present in the csv file?
        /// </param>
        private static bool validateInput(string account, string password, bool existent)
        {
            if (account == "(Account)" ||
                password == "(Password)" ||
                account == "" ||
                password == "")
            {
                DialogResult message = MessageBox.Show("Invalid Account name or Password", "Error Detected in Input", MessageBoxButtons.OK);
                return false;
            }

            var records = RetrievePasswords();
            var entry = new Tuple<string, string>(account, password);
            var contains = records.Contains(entry);

            if (!existent && contains)
            {
                DialogResult message = MessageBox.Show("Entry already exists", "Error Detected in Input", MessageBoxButtons.OK);
                return false;
            }

            if (existent && !contains)
            {
                DialogResult message = MessageBox.Show("Entry doesn't exist", "Error Detected in Input", MessageBoxButtons.OK);
                return false;
            }

            if (account.Contains(',') || password.Contains(','))
            {

                DialogResult message = MessageBox.Show("Invalid Account name or Password. \",\" is not a legal character", "Error Detected in Input", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        public class CSVEntry
        {
            [Name("Account")]
            public string Account { get; set; }

            [Name("Password")]
            public string Password { get; set; }
        }
    }
}
