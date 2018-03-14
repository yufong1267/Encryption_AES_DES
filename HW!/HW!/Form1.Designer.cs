namespace HW_
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.store_btn = new System.Windows.Forms.Button();
            this.encryption_btn = new System.Windows.Forms.Button();
            this.decryption_DES = new System.Windows.Forms.Button();
            this.encode_AES = new System.Windows.Forms.Button();
            this.decode_AES = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "開啟";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(12, 12);
            this.txtvalue.Multiline = true;
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(505, 267);
            this.txtvalue.TabIndex = 1;
            // 
            // store_btn
            // 
            this.store_btn.Enabled = false;
            this.store_btn.Location = new System.Drawing.Point(113, 285);
            this.store_btn.Name = "store_btn";
            this.store_btn.Size = new System.Drawing.Size(75, 23);
            this.store_btn.TabIndex = 2;
            this.store_btn.Text = "存檔";
            this.store_btn.UseVisualStyleBackColor = true;
            this.store_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // encryption_btn
            // 
            this.encryption_btn.Enabled = false;
            this.encryption_btn.Location = new System.Drawing.Point(230, 285);
            this.encryption_btn.Name = "encryption_btn";
            this.encryption_btn.Size = new System.Drawing.Size(75, 23);
            this.encryption_btn.TabIndex = 3;
            this.encryption_btn.Text = "加密DES";
            this.encryption_btn.UseVisualStyleBackColor = true;
            this.encryption_btn.Click += new System.EventHandler(this.enrcyption_btn_Click);
            // 
            // decryption_DES
            // 
            this.decryption_DES.Enabled = false;
            this.decryption_DES.Location = new System.Drawing.Point(230, 320);
            this.decryption_DES.Name = "decryption_DES";
            this.decryption_DES.Size = new System.Drawing.Size(75, 23);
            this.decryption_DES.TabIndex = 4;
            this.decryption_DES.Text = "解密DES";
            this.decryption_DES.UseVisualStyleBackColor = true;
            this.decryption_DES.Click += new System.EventHandler(this.deode_DES_Click);
            // 
            // encode_AES
            // 
            this.encode_AES.Enabled = false;
            this.encode_AES.Location = new System.Drawing.Point(332, 285);
            this.encode_AES.Name = "encode_AES";
            this.encode_AES.Size = new System.Drawing.Size(75, 23);
            this.encode_AES.TabIndex = 5;
            this.encode_AES.Text = "加密AES";
            this.encode_AES.UseVisualStyleBackColor = true;
            this.encode_AES.Click += new System.EventHandler(this.encode_AES_Click);
            // 
            // decode_AES
            // 
            this.decode_AES.Enabled = false;
            this.decode_AES.Location = new System.Drawing.Point(332, 320);
            this.decode_AES.Name = "decode_AES";
            this.decode_AES.Size = new System.Drawing.Size(75, 23);
            this.decode_AES.TabIndex = 6;
            this.decode_AES.Text = "解密AES";
            this.decode_AES.UseVisualStyleBackColor = true;
            this.decode_AES.Click += new System.EventHandler(this.decode_AES_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(442, 329);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(113, 320);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 8;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 355);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.decode_AES);
            this.Controls.Add(this.encode_AES);
            this.Controls.Add(this.decryption_DES);
            this.Controls.Add(this.encryption_btn);
            this.Controls.Add(this.store_btn);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "homework1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.Button store_btn;
        private System.Windows.Forms.Button encryption_btn;
        private System.Windows.Forms.Button decryption_DES;
        private System.Windows.Forms.Button encode_AES;
        private System.Windows.Forms.Button decode_AES;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button clear;
    }
}

