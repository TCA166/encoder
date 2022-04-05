using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Word_Encoder_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly Random rnd = new Random();
        string identifier;
        private void Form1_Load(object sender, EventArgs e)
        {
            int rawidentifier = 0x200B;
            identifier = Char.ConvertFromUtf32(rawidentifier);
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);


        }
        static string GetBase64StringForImage(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }
        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if(current.Name == "OneTimePadTab")
            {
                code_raw_1.Visible = false;
                code_raw_2.Visible = false;
                code_raw_3.Visible = false;
                code_raw_4.Visible = false;
                code_raw_5.Visible = false;
                code_raw_6.Visible = false;
                Randomize_code.Visible = false;
                Security_Code_Title.Visible = false;
            }
            else
            {
                code_raw_1.Visible = true;
                code_raw_2.Visible = true;
                code_raw_3.Visible = true;
                code_raw_4.Visible = true;
                code_raw_5.Visible = true;
                code_raw_6.Visible = true;
                Randomize_code.Visible = true;
                Security_Code_Title.Visible = true;
            }
        }
        private void Unicode_Encode_Click(object sender, EventArgs e)
        {
            //encoding in unicode tab
            string textraw = UnicodeInput.Text;
            if (textraw.Length > 0)
            {
                decimal security1 = code_raw_1.Value;
                decimal security2 = code_raw_2.Value;
                decimal security3 = code_raw_3.Value;
                decimal security4 = code_raw_4.Value;
                decimal security5 = code_raw_5.Value;
                decimal security6 = code_raw_6.Value;
                string textshuffled = textraw.Shuffle(Convert.ToInt32(security6));
                string textencoded = "";
                decimal startvalue = security1 + security2 + security3 + security4 + security5 + security6 + code_raw_unicode.Value;
                int i = 0;
                foreach (char c in textshuffled)
                {
                    decimal b = 0;
                    b = startvalue + Char.ConvertToUtf32(c.ToString(), 0);

                    if (b > 0)
                    {
                        b = b * (security1);
                        b = b / (security2 + i);
                        b = b - (security3 + i);
                        b = b + (security4 - i);
                        b = b * (security5 + i);

                        textencoded = textencoded + b.ToString() + identifier;
                        //rolling code
                        i = i + 1;

                    }
                }
                UnicodeOutput.Text = textencoded;
            }

        }

        private void UnicodeDecode_Click(object sender, EventArgs e)
        {

            string textraw = UnicodeOutput.Text;
            if (textraw.Length > 0)
            {
                decimal security1 = code_raw_1.Value;
                decimal security2 = code_raw_2.Value;
                decimal security3 = code_raw_3.Value;
                decimal security4 = code_raw_4.Value;
                decimal security5 = code_raw_5.Value;
                decimal security6 = code_raw_6.Value;
                decimal startvalue = security1 + security2 + security3 + security4 + security5 + security6 + code_raw_unicode.Value;
                int i = 0;
                string[] rawinput = textraw.Split(Convert.ToChar(identifier));
                string messagedecoded = "";
                string messagedeshuffled = "";
                foreach (string s in rawinput)
                {
                    if (s != "")
                    {
                        try
                        {
                            decimal d = Convert.ToDecimal(s);
                            d = d / (security5 + i);
                            d = d - (security4 - i);
                            d = d + (security3 + i);
                            d = d * (security2 + i);
                            d = d / (security1);

                            d = d - startvalue;

                            i = i + 1;

                            try
                            {

                                messagedecoded = messagedecoded + Char.ConvertFromUtf32(Convert.ToInt32(d));
                                int shufflevalue = Convert.ToInt32(security6);
                                messagedeshuffled = messagedecoded.DeShuffle(shufflevalue);
                                UnicodeInput.Text = messagedeshuffled;
                            }
                            catch
                            {
                                MessageBox.Show("An error has occured while converting the message to text. Make sure the security code that the message has been encoded in matches the one you have input.", "Unicode decoding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("An error has occured while decoding the message. Make sure you have Input the right text", "Unicode decoding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }

        }

        private void UnicodeCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(UnicodeOutput.Text);
        }

        private void Randomize_code_Click(object sender, EventArgs e)
        {
            code_raw_1.Value = rnd.Next(1,9999);
            code_raw_2.Value = rnd.Next(1, 9999);
            code_raw_3.Value = rnd.Next(1, 9999);
            code_raw_4.Value = rnd.Next(1, 9999);
            code_raw_5.Value = rnd.Next(1, 9999);
            code_raw_6.Value = rnd.Next(1, 9999);

        }

        private void Base64Encode_Click(object sender, EventArgs e)
        {
            string textraw = Base64Input.Text;
            if (textraw.Length > 0)
            {
                decimal security1 = code_raw_1.Value;
                decimal security2 = code_raw_2.Value;
                decimal security3 = code_raw_3.Value;
                decimal security4 = code_raw_4.Value;
                decimal security5 = code_raw_5.Value;
                decimal security6 = code_raw_6.Value;
                string textshuffled = textraw.Shuffle(Convert.ToInt32(security6));
                string textencodedin64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(textshuffled));
                string textshuffled1 = textencodedin64.Shuffle(Convert.ToInt32(security1));
                string textshuffled2 = textshuffled1.Shuffle(Convert.ToInt32(security2));
                string textshuffled3 = textshuffled2.Shuffle(Convert.ToInt32(security3));
                string textshuffled4 = textshuffled3.Shuffle(Convert.ToInt32(security4));
                string textshuffled5 = textshuffled4.Shuffle(Convert.ToInt32(security5));
                Base64Output.Text = textshuffled5;
            }
        }

        private void Base64Decode_Click(object sender, EventArgs e)
        {
            try
            {
                decimal security1 = code_raw_1.Value;
                decimal security2 = code_raw_2.Value;
                decimal security3 = code_raw_3.Value;
                decimal security4 = code_raw_4.Value;
                decimal security5 = code_raw_5.Value;
                decimal security6 = code_raw_6.Value;
                //deshuffling process: shuffled 6 times (raw) -> shuffled5 ->shuffled 4 -> shuffled 3 -> shuffled 2 -> base 64 shuffled once -> non base 64 shuffled -> normal text
                string shuffled5 = Base64Output.Text.DeShuffle(Convert.ToInt32(security5));
                string shuffled4 = shuffled5.DeShuffle(Convert.ToInt32(security4));
                string shuffled3 = shuffled4.DeShuffle(Convert.ToInt32(security3));
                string shuffled2 = shuffled3.DeShuffle(Convert.ToInt32(security2));
                string shuffled1 = shuffled2.DeShuffle(Convert.ToInt32(security1));
                var base64EncodedBytes = System.Convert.FromBase64String(shuffled1);
                string textdecoded = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                Base64Input.Text = textdecoded.DeShuffle(Convert.ToInt32(security6));
            }
            catch
            {
                MessageBox.Show("Current security code doesn't match the security code that the message was encoded in.", "Decoding",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Base64Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Base64Output.Text);
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            if(AdvancedMode.Checked == false)
            {
                openFileDialog1.Filter = "Images (*.jpg *.png)|*.jpg;*.png|Text files (*.txt)|*.txt";
            }
            else
            {
                openFileDialog1.Filter = "Images (*.jpg *.png)|*.jpg;*.png|Text files (*.txt)|*.txt| All files|*";
            }

            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog1.FileName;
                string fileContent = "";
                if (filePath.Contains(".jpg") == true || filePath.Contains(".png") == true)
                {
                    fileContent = GetBase64StringForImage(filePath);
                }
                else if(filePath.Contains(".txt") == true)
                {
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            fileContent = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
                        }
                    }
                }
                else
                {
                    fileContent = Convert.ToBase64String(File.ReadAllBytes(filePath));
                }
                string textraw = fileContent;
                if (textraw.Length > 0)
                {
                    decimal security1 = code_raw_1.Value;
                    decimal security2 = code_raw_2.Value;
                    decimal security3 = code_raw_3.Value;
                    decimal security4 = code_raw_4.Value;
                    decimal security5 = code_raw_5.Value;
                    decimal security6 = code_raw_6.Value;
                    string textshuffled = textraw.Shuffle(Convert.ToInt32(security6));
                    string textencodedin64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(textshuffled));
                    string textshuffled1 = textencodedin64.Shuffle(Convert.ToInt32(security1));
                    string textshuffled2 = textshuffled1.Shuffle(Convert.ToInt32(security2));
                    string textshuffled3 = textshuffled2.Shuffle(Convert.ToInt32(security3));
                    string textshuffled4 = textshuffled3.Shuffle(Convert.ToInt32(security4));
                    string textshuffled5 = textshuffled4.Shuffle(Convert.ToInt32(security5));
                    FileOutput.Text = textshuffled5;
                }
            }
        }

        private void DecodeFile_Click(object sender, EventArgs e)
        {
            decimal security1 = code_raw_1.Value;
            decimal security2 = code_raw_2.Value;
            decimal security3 = code_raw_3.Value;
            decimal security4 = code_raw_4.Value;
            decimal security5 = code_raw_5.Value;
            decimal security6 = code_raw_6.Value;
            //deshuffling process: shuffled 6 times (raw) -> shuffled5 ->shuffled 4 -> shuffled 3 -> shuffled 2 -> base 64 shuffled once -> non base 64 shuffled -> normal text
            string shuffled5 = FileOutput.Text.DeShuffle(Convert.ToInt32(security5));
            string shuffled4 = shuffled5.DeShuffle(Convert.ToInt32(security4));
            string shuffled3 = shuffled4.DeShuffle(Convert.ToInt32(security3));
            string shuffled2 = shuffled3.DeShuffle(Convert.ToInt32(security2));
            string shuffled1 = shuffled2.DeShuffle(Convert.ToInt32(security1));
            string filedecoded = "";
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(shuffled1);
                string textdecoded = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                filedecoded = textdecoded.DeShuffle(Convert.ToInt32(security6));
            }
            catch
            {
                MessageBox.Show("Something went wrong while decoding the file.", "File Decoding",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            saveFileDialog1.InitialDirectory = "c:\\";
            if (AdvancedMode.Checked == false)
            {
                saveFileDialog1.Filter = "Images (*.jpg *.png)|*.jpg;*.png|Text files (*.txt)|*.txt";
            }
            else
            {
                saveFileDialog1.Filter = "Images (*.jpg *.png)|*.jpg;*.png|Text files (*.txt)|*.txt|All files|*";
            }
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var bytes = Convert.FromBase64String(filedecoded);
                string filepath = saveFileDialog1.FileName;
                //Get the path of specified file
                string filePath = saveFileDialog1.FileName;
                using (var imageFile = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.Write(bytes, 0, bytes.Length);
                    imageFile.Flush();
                }
            }
        }

        private void OneTimeEncrypt_Click(object sender, EventArgs e)
        {
            if (OneTimeEncryptInput.Text.Length > 0)
            {
                byte[] originalBytes = Encoding.Unicode.GetBytes(OneTimeEncryptInput.Text);
                byte[] keyBytes = new byte[originalBytes.Length];
                Random random = new Random();
                random.NextBytes(keyBytes);
                byte[] encryptedbytes = new byte[originalBytes.Length];
                DoVernam(originalBytes, keyBytes,ref encryptedbytes);
                OneTimeEncryptOutput.Text = Convert.ToBase64String(encryptedbytes);
                OneTimeEncryptCode.Text = Convert.ToBase64String(keyBytes);
            }
        }
        private void DoVernam(byte[] inBytes, byte[] keyBytes, ref byte[] outBytes)
        {
            // Check arguments:
            if ((inBytes.Length != keyBytes.Length) ||
                (keyBytes.Length != outBytes.Length))
                MessageBox.Show("Wrong One-time pad or message", "One-time pad encryption",MessageBoxButtons.OK,MessageBoxIcon.Error);

            // Encrypt/decrypt by XOR:
            for (int i = 0; i < inBytes.Length; i++)
                outBytes[i] = (byte)(inBytes[i] ^ keyBytes[i]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(OneTimeDecryptInput.Text);
                byte[] keyBytes = Convert.FromBase64String(OneTimeDecryptCode.Text);
                byte[] decryptedBytes = new byte[encryptedBytes.Length];
                DoVernam(encryptedBytes, keyBytes, ref decryptedBytes);
                OneTimeDecryptOutput.Text = Encoding.Unicode.GetString(decryptedBytes);
            }
            catch
            {
                MessageBox.Show("Wrong key or message","One time pad decryption",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }


    //shuffle extensions necessary for shuffling
    public static class ShuffleExtensions
    {
        public static int[] GetShuffleExchanges(int size, int key)
        {
            int[] exchanges = new int[size - 1];
            var rand = new Random(key);
            for (int i = size - 1; i > 0; i--)
            {
                int n = rand.Next(i + 1);
                exchanges[size - 1 - i] = n;
            }
            return exchanges;
        }

        public static string Shuffle(this string toShuffle, int key)
        {
            int size = toShuffle.Length;
            char[] chars = toShuffle.ToArray();
            var exchanges = GetShuffleExchanges(size, key);
            for (int i = size - 1; i > 0; i--)
            {
                int n = exchanges[size - 1 - i];
                char tmp = chars[i];
                chars[i] = chars[n];
                chars[n] = tmp;
            }
            return new string(chars);
        }

        public static string DeShuffle(this string shuffled, int key)
        {
            int size = shuffled.Length;
            char[] chars = shuffled.ToArray();
            var exchanges = GetShuffleExchanges(size, key);
            for (int i = 1; i < size; i++)
            {
                int n = exchanges[size - i - 1];
                char tmp = chars[i];
                chars[i] = chars[n];
                chars[n] = tmp;
            }
            return new string(chars);
        }
    }
}
