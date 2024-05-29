namespace WindowsFormsApp5
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.CreateTicket = new System.Windows.Forms.Button();
            this.Familiya = new System.Windows.Forms.TextBox();
            this.Imya = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.CreditCart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Target = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SummaryPay = new System.Windows.Forms.TextBox();
            this.CheckStatus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateTicket
            // 
            this.CreateTicket.BackColor = System.Drawing.Color.BlueViolet;
            this.CreateTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTicket.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateTicket.FlatAppearance.BorderSize = 0;
            this.CreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTicket.ForeColor = System.Drawing.Color.White;
            this.CreateTicket.Location = new System.Drawing.Point(194, 363);
            this.CreateTicket.Margin = new System.Windows.Forms.Padding(4);
            this.CreateTicket.Name = "CreateTicket";
            this.CreateTicket.Size = new System.Drawing.Size(231, 35);
            this.CreateTicket.TabIndex = 19;
            this.CreateTicket.Text = "Оставить заявку на оплату";
            this.CreateTicket.UseVisualStyleBackColor = false;
            this.CreateTicket.Click += new System.EventHandler(this.CreateTicket_Click);
            // 
            // Familiya
            // 
            this.Familiya.BackColor = System.Drawing.Color.Silver;
            this.Familiya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Familiya.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Familiya.ForeColor = System.Drawing.Color.Black;
            this.Familiya.Location = new System.Drawing.Point(194, 72);
            this.Familiya.Margin = new System.Windows.Forms.Padding(4);
            this.Familiya.Name = "Familiya";
            this.Familiya.Size = new System.Drawing.Size(231, 35);
            this.Familiya.TabIndex = 20;
            // 
            // Imya
            // 
            this.Imya.BackColor = System.Drawing.Color.Silver;
            this.Imya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Imya.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imya.ForeColor = System.Drawing.Color.Black;
            this.Imya.Location = new System.Drawing.Point(194, 123);
            this.Imya.Margin = new System.Windows.Forms.Padding(4);
            this.Imya.Name = "Imya";
            this.Imya.Size = new System.Drawing.Size(231, 35);
            this.Imya.TabIndex = 21;
            // 
            // Otchestvo
            // 
            this.Otchestvo.BackColor = System.Drawing.Color.Silver;
            this.Otchestvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Otchestvo.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Otchestvo.ForeColor = System.Drawing.Color.Black;
            this.Otchestvo.Location = new System.Drawing.Point(194, 166);
            this.Otchestvo.Margin = new System.Windows.Forms.Padding(4);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(231, 35);
            this.Otchestvo.TabIndex = 22;
            // 
            // CreditCart
            // 
            this.CreditCart.BackColor = System.Drawing.Color.Silver;
            this.CreditCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreditCart.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCart.ForeColor = System.Drawing.Color.Black;
            this.CreditCart.Location = new System.Drawing.Point(194, 314);
            this.CreditCart.Margin = new System.Windows.Forms.Padding(4);
            this.CreditCart.Name = "CreditCart";
            this.CreditCart.Size = new System.Drawing.Size(231, 35);
            this.CreditCart.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Назначение";
            // 
            // Target
            // 
            this.Target.FormattingEnabled = true;
            this.Target.Items.AddRange(new object[] {
            "Вступление в наследство",
            "Покупка жилья или участка земли",
            "Подача в суд на страховую компанию",
            "Выступление ответчиком от лица компании",
            "Выдача паспорта РФ, загранпаспорта",
            "Регистрация браков и разводов",
            "Пошлина на товары, разрешение на ввоз товаров из-за рубежа",
            "Регистрация автомобилей и другого транспорта, выдача и замена водительского удост" +
                "оверения"});
            this.Target.Location = new System.Drawing.Point(194, 207);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(231, 21);
            this.Target.TabIndex = 30;
            this.Target.SelectedIndexChanged += new System.EventHandler(this.Target_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(257, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Реквизиты";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(541, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 25);
            this.Exit.TabIndex = 32;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(188, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 34);
            this.label6.TabIndex = 33;
            this.label6.Text = "Заявка на оплату";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(28, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Номер карты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(28, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Сумма к оплате";
            // 
            // SummaryPay
            // 
            this.SummaryPay.BackColor = System.Drawing.Color.Silver;
            this.SummaryPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryPay.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryPay.ForeColor = System.Drawing.Color.Black;
            this.SummaryPay.Location = new System.Drawing.Point(194, 238);
            this.SummaryPay.Margin = new System.Windows.Forms.Padding(4);
            this.SummaryPay.Name = "SummaryPay";
            this.SummaryPay.Size = new System.Drawing.Size(231, 35);
            this.SummaryPay.TabIndex = 36;
            // 
            // CheckStatus
            // 
            this.CheckStatus.BackColor = System.Drawing.Color.BlueViolet;
            this.CheckStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckStatus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckStatus.FlatAppearance.BorderSize = 0;
            this.CheckStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckStatus.ForeColor = System.Drawing.Color.White;
            this.CheckStatus.Location = new System.Drawing.Point(194, 406);
            this.CheckStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CheckStatus.Name = "CheckStatus";
            this.CheckStatus.Size = new System.Drawing.Size(231, 35);
            this.CheckStatus.TabIndex = 37;
            this.CheckStatus.Text = "Проверить статус заявки";
            this.CheckStatus.UseVisualStyleBackColor = false;
            this.CheckStatus.Click += new System.EventHandler(this.CheckStatus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(491, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 443);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckStatus);
            this.Controls.Add(this.SummaryPay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreditCart);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.Imya);
            this.Controls.Add(this.Familiya);
            this.Controls.Add(this.CreateTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTicket;
        private System.Windows.Forms.TextBox Familiya;
        private System.Windows.Forms.TextBox Imya;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.TextBox CreditCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Target;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SummaryPay;
        private System.Windows.Forms.Button CheckStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}