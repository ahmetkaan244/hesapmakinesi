namespace hesapmakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.islemTxt = new System.Windows.Forms.TextBox();
            this.sayi1Btn = new System.Windows.Forms.Button();
            this.sayi2Btn = new System.Windows.Forms.Button();
            this.sayi3Btn = new System.Windows.Forms.Button();
            this.sayi4Btn = new System.Windows.Forms.Button();
            this.sayi5Btn = new System.Windows.Forms.Button();
            this.sayi6Btn = new System.Windows.Forms.Button();
            this.sayi7Btn = new System.Windows.Forms.Button();
            this.sayi8Btn = new System.Windows.Forms.Button();
            this.sayi9Btn = new System.Windows.Forms.Button();
            this.sayi0Btn = new System.Windows.Forms.Button();
            this.toplaBtn = new System.Windows.Forms.Button();
            this.cikarBtn = new System.Windows.Forms.Button();
            this.bolBtn = new System.Windows.Forms.Button();
            this.carpBtn = new System.Windows.Forms.Button();
            this.sonucBtn = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // islemTxt
            // 
            this.islemTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.islemTxt.Location = new System.Drawing.Point(14, 23);
            this.islemTxt.Name = "islemTxt";
            this.islemTxt.ReadOnly = true;
            this.islemTxt.Size = new System.Drawing.Size(256, 38);
            this.islemTxt.TabIndex = 0;
            this.islemTxt.TextChanged += new System.EventHandler(this.islemTxt_TextChanged);
            // 
            // sayi1Btn
            // 
            this.sayi1Btn.Location = new System.Drawing.Point(14, 75);
            this.sayi1Btn.Name = "sayi1Btn";
            this.sayi1Btn.Size = new System.Drawing.Size(42, 33);
            this.sayi1Btn.TabIndex = 1;
            this.sayi1Btn.Text = "1";
            this.sayi1Btn.UseVisualStyleBackColor = true;
            this.sayi1Btn.Click += new System.EventHandler(this.sayi1Btn_Click);
            // 
            // sayi2Btn
            // 
            this.sayi2Btn.Location = new System.Drawing.Point(81, 75);
            this.sayi2Btn.Name = "sayi2Btn";
            this.sayi2Btn.Size = new System.Drawing.Size(42, 33);
            this.sayi2Btn.TabIndex = 2;
            this.sayi2Btn.Text = "2";
            this.sayi2Btn.UseVisualStyleBackColor = true;
            this.sayi2Btn.Click += new System.EventHandler(this.sayi2Btn_Click);
            // 
            // sayi3Btn
            // 
            this.sayi3Btn.Location = new System.Drawing.Point(145, 75);
            this.sayi3Btn.Name = "sayi3Btn";
            this.sayi3Btn.Size = new System.Drawing.Size(42, 33);
            this.sayi3Btn.TabIndex = 3;
            this.sayi3Btn.Text = "3";
            this.sayi3Btn.UseVisualStyleBackColor = true;
            this.sayi3Btn.Click += new System.EventHandler(this.sayi3Btn_Click);
            // 
            // sayi4Btn
            // 
            this.sayi4Btn.Location = new System.Drawing.Point(14, 114);
            this.sayi4Btn.Name = "sayi4Btn";
            this.sayi4Btn.Size = new System.Drawing.Size(42, 33);
            this.sayi4Btn.TabIndex = 4;
            this.sayi4Btn.Text = "4";
            this.sayi4Btn.UseVisualStyleBackColor = true;
            this.sayi4Btn.Click += new System.EventHandler(this.sayi4Btn_Click);
            // 
            // sayi5Btn
            // 
            this.sayi5Btn.Location = new System.Drawing.Point(81, 114);
            this.sayi5Btn.Name = "sayi5Btn";
            this.sayi5Btn.Size = new System.Drawing.Size(42, 33);
            this.sayi5Btn.TabIndex = 5;
            this.sayi5Btn.Text = "5";
            this.sayi5Btn.UseVisualStyleBackColor = true;
            this.sayi5Btn.Click += new System.EventHandler(this.sayi5Btn_Click);
            // 
            // sayi6Btn
            // 
            this.sayi6Btn.Location = new System.Drawing.Point(145, 114);
            this.sayi6Btn.Name = "sayi6Btn";
            this.sayi6Btn.Size = new System.Drawing.Size(42, 33);
            this.sayi6Btn.TabIndex = 6;
            this.sayi6Btn.Text = "6";
            this.sayi6Btn.UseVisualStyleBackColor = true;
            this.sayi6Btn.Click += new System.EventHandler(this.sayi6Btn_Click);
            // 
            // sayi7Btn
            // 
            this.sayi7Btn.Location = new System.Drawing.Point(14, 153);
            this.sayi7Btn.Name = "sayi7Btn";
            this.sayi7Btn.Size = new System.Drawing.Size(42, 33);
            this.sayi7Btn.TabIndex = 7;
            this.sayi7Btn.Text = "7";
            this.sayi7Btn.UseVisualStyleBackColor = true;
            this.sayi7Btn.Click += new System.EventHandler(this.sayi7Btn_Click);
            // 
            // sayi8Btn
            // 
            this.sayi8Btn.Location = new System.Drawing.Point(81, 153);
            this.sayi8Btn.Name = "sayi8Btn";
            this.sayi8Btn.Size = new System.Drawing.Size(42, 33);
            this.sayi8Btn.TabIndex = 8;
            this.sayi8Btn.Text = "8";
            this.sayi8Btn.UseVisualStyleBackColor = true;
            this.sayi8Btn.Click += new System.EventHandler(this.sayi8Btn_Click);
            // 
            // sayi9Btn
            // 
            this.sayi9Btn.Location = new System.Drawing.Point(145, 153);
            this.sayi9Btn.Name = "sayi9Btn";
            this.sayi9Btn.Size = new System.Drawing.Size(42, 33);
            this.sayi9Btn.TabIndex = 9;
            this.sayi9Btn.Text = "9";
            this.sayi9Btn.UseVisualStyleBackColor = true;
            this.sayi9Btn.Click += new System.EventHandler(this.sayi9Btn_Click);
            // 
            // sayi0Btn
            // 
            this.sayi0Btn.Location = new System.Drawing.Point(14, 192);
            this.sayi0Btn.Name = "sayi0Btn";
            this.sayi0Btn.Size = new System.Drawing.Size(109, 33);
            this.sayi0Btn.TabIndex = 10;
            this.sayi0Btn.Text = "0";
            this.sayi0Btn.UseVisualStyleBackColor = true;
            this.sayi0Btn.Click += new System.EventHandler(this.sayi0Btn_Click);
            // 
            // toplaBtn
            // 
            this.toplaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.toplaBtn.Location = new System.Drawing.Point(202, 192);
            this.toplaBtn.Name = "toplaBtn";
            this.toplaBtn.Size = new System.Drawing.Size(32, 33);
            this.toplaBtn.TabIndex = 11;
            this.toplaBtn.Text = "+";
            this.toplaBtn.UseVisualStyleBackColor = true;
            this.toplaBtn.Click += new System.EventHandler(this.toplaBtn_Click);
            // 
            // cikarBtn
            // 
            this.cikarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cikarBtn.Location = new System.Drawing.Point(202, 153);
            this.cikarBtn.Name = "cikarBtn";
            this.cikarBtn.Size = new System.Drawing.Size(32, 33);
            this.cikarBtn.TabIndex = 12;
            this.cikarBtn.Text = "-";
            this.cikarBtn.UseVisualStyleBackColor = true;
            this.cikarBtn.Click += new System.EventHandler(this.cikarBtn_Click);
            // 
            // bolBtn
            // 
            this.bolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.bolBtn.Location = new System.Drawing.Point(202, 75);
            this.bolBtn.Name = "bolBtn";
            this.bolBtn.Size = new System.Drawing.Size(32, 33);
            this.bolBtn.TabIndex = 13;
            this.bolBtn.Text = "/";
            this.bolBtn.UseVisualStyleBackColor = true;
            this.bolBtn.Click += new System.EventHandler(this.bolBtn_Click);
            // 
            // carpBtn
            // 
            this.carpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.carpBtn.Location = new System.Drawing.Point(202, 114);
            this.carpBtn.Name = "carpBtn";
            this.carpBtn.Size = new System.Drawing.Size(32, 33);
            this.carpBtn.TabIndex = 14;
            this.carpBtn.Text = "*";
            this.carpBtn.UseVisualStyleBackColor = true;
            this.carpBtn.Click += new System.EventHandler(this.carpBtn_Click);
            // 
            // sonucBtn
            // 
            this.sonucBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.sonucBtn.Location = new System.Drawing.Point(240, 75);
            this.sonucBtn.Name = "sonucBtn";
            this.sonucBtn.Size = new System.Drawing.Size(32, 152);
            this.sonucBtn.TabIndex = 15;
            this.sonucBtn.Text = "=";
            this.sonucBtn.UseVisualStyleBackColor = true;
            this.sonucBtn.Click += new System.EventHandler(this.sonucBtn_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(145, 192);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(42, 33);
            this.delete.TabIndex = 16;
            this.delete.Text = "Sil";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 241);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.sonucBtn);
            this.Controls.Add(this.carpBtn);
            this.Controls.Add(this.bolBtn);
            this.Controls.Add(this.cikarBtn);
            this.Controls.Add(this.toplaBtn);
            this.Controls.Add(this.sayi0Btn);
            this.Controls.Add(this.sayi9Btn);
            this.Controls.Add(this.sayi8Btn);
            this.Controls.Add(this.sayi7Btn);
            this.Controls.Add(this.sayi6Btn);
            this.Controls.Add(this.sayi5Btn);
            this.Controls.Add(this.sayi4Btn);
            this.Controls.Add(this.sayi3Btn);
            this.Controls.Add(this.sayi2Btn);
            this.Controls.Add(this.sayi1Btn);
            this.Controls.Add(this.islemTxt);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox islemTxt;
        private System.Windows.Forms.Button sayi1Btn;
        private System.Windows.Forms.Button sayi2Btn;
        private System.Windows.Forms.Button sayi3Btn;
        private System.Windows.Forms.Button sayi4Btn;
        private System.Windows.Forms.Button sayi5Btn;
        private System.Windows.Forms.Button sayi6Btn;
        private System.Windows.Forms.Button sayi7Btn;
        private System.Windows.Forms.Button sayi8Btn;
        private System.Windows.Forms.Button sayi9Btn;
        private System.Windows.Forms.Button sayi0Btn;
        private System.Windows.Forms.Button toplaBtn;
        private System.Windows.Forms.Button cikarBtn;
        private System.Windows.Forms.Button bolBtn;
        private System.Windows.Forms.Button carpBtn;
        private System.Windows.Forms.Button sonucBtn;
        private System.Windows.Forms.Button delete;
    }
}

