using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HW_
{
    public partial class Form1 : Form
    {
        //create a variable to store
        private String encryption_txt = null;
        private String n_encode = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {//用streamreader方法
                         using (StreamReader sr = new StreamReader(ofd.FileName , Encoding.GetEncoding(950) , true)) {
                            txtvalue.Text = await sr.ReadToEndAsync();
                                }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail can't find thie FILE");
            }
            //有出現就可以store
            store_btn.Enabled = true;
            //有選取檔案就可以用encode 跟 decode
            encryption_btn.Enabled = true;
            encode_AES.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n_encode = txtvalue.Text;
            // MessageBox.Show(n_encode);
            //抓這個project 
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MessageBox.Show("檔案存在這邊ㄛ"+path + "/out.txt");
            using (StreamWriter outputFile = new StreamWriter(path + @"\out.txt", true)) {
              outputFile.WriteLine(n_encode);
            }
            
        }

        private void enrcyption_btn_Click(object sender, EventArgs e)
        {
            //加密後 decode true 
            //加密
            decryption_DES.Enabled = true;
            encryption_btn.Enabled = false;
            //把另外一邊的加密button disable
            encode_AES.Enabled = false;

            String mesage = txtvalue.Text;

            String result = EncryptByDES(mesage);
            txtvalue.Text = result;

        }

        private void deode_DES_Click(object sender, EventArgs e)
        {
            encryption_btn.Enabled = true;
            decryption_DES.Enabled = false;
            //把另一邊的加密方法在開起來
            encode_AES.Enabled = true;
            String decode = txtvalue.Text;
            txtvalue.Text = DecryptByDES(decode);
        }

        private String EncryptByDES(string source)
        {
            String return_code = null;
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key1 = Encoding.UTF8.GetBytes("11111111");
            byte[] iv1 = Encoding.UTF8.GetBytes("22222222");
            byte[] data = Encoding.UTF8.GetBytes(source);
            des.Key = key1;
            des.IV = iv1;
            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(data, 0, data.Length);
                cs.FlushFinalBlock();
                return_code = Convert.ToBase64String(ms.ToArray());

            }
                return return_code;
        }

        private String DecryptByDES(String source)
        {
            String return_code = null;
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key1 = Encoding.UTF8.GetBytes("11111111");
            byte[] iv1 = Encoding.UTF8.GetBytes("22222222");
            byte[] data = Convert.FromBase64String(source);
            des.Key = key1;
            des.IV = iv1;
            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cs.Write(data, 0, data.Length);
                cs.FlushFinalBlock();
                return Encoding.UTF8.GetString(ms.ToArray());
            }
            
        }
        private String aesDecrypt(String source) {
            String result = "";
            try
            {
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
                byte[] key = sha256.ComputeHash(Encoding.UTF8.GetBytes("11111111"));
                byte[] iv = md5.ComputeHash(Encoding.UTF8.GetBytes("11111111"));
                aes.Key = key;
                aes.IV = iv;

                byte[] data_AES = Encoding.UTF8.GetBytes(source);
                using (MemoryStream ms = new MemoryStream())

                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(data_AES, 0, data_AES.Length);
                    cs.FlushFinalBlock();
                    result = Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to encrypt");
            }

            return result;
        }
        private string aesDecryptBase64(string SourceStr)
        {
            string decrypt = "";
            try
            {
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
                byte[] key = sha256.ComputeHash(Encoding.UTF8.GetBytes("11111111"));
                byte[] iv = md5.ComputeHash(Encoding.UTF8.GetBytes("11111111"));
                aes.Key = key;
                aes.IV = iv;

                byte[] dataByteArray = Convert.FromBase64String(SourceStr);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(dataByteArray, 0, dataByteArray.Length);
                        cs.FlushFinalBlock();
                        decrypt = Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return decrypt;
        }


        private void encode_AES_Click(object sender, EventArgs e)
        {
            txtvalue.Text = aesDecrypt(txtvalue.Text);
            decode_AES.Enabled = true;
            encode_AES.Enabled = false;
            //把另一邊的加密 disable
            encryption_btn.Enabled = false;
        }

        private void decode_AES_Click(object sender, EventArgs e)
        {
            txtvalue.Text = aesDecryptBase64(txtvalue.Text);
            decode_AES.Enabled = false;
            encode_AES.Enabled = true;
            //把另一邊的加密enable
            encryption_btn.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            txtvalue.Text = "";
        }
    }
}
