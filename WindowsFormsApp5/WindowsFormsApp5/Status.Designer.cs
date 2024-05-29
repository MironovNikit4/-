namespace WindowsFormsApp5
{
    partial class Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            this.dataGridViewStatus = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.Imya = new System.Windows.Forms.TextBox();
            this.Familiya = new System.Windows.Forms.TextBox();
            this.CheckStatus = new System.Windows.Forms.Button();
            this.Clearfields = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatus
            // 
            this.dataGridViewStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatus.Location = new System.Drawing.Point(114, 213);
            this.dataGridViewStatus.Name = "dataGridViewStatus";
            this.dataGridViewStatus.Size = new System.Drawing.Size(554, 102);
            this.dataGridViewStatus.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(232, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 34);
            this.label6.TabIndex = 35;
            this.label6.Text = "Просмотр заявок на оплату";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(755, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 25);
            this.Exit.TabIndex = 36;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(110, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Фамилия";
            // 
            // Otchestvo
            // 
            this.Otchestvo.BackColor = System.Drawing.Color.Silver;
            this.Otchestvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Otchestvo.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Otchestvo.ForeColor = System.Drawing.Color.Black;
            this.Otchestvo.Location = new System.Drawing.Point(238, 171);
            this.Otchestvo.Margin = new System.Windows.Forms.Padding(4);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(269, 35);
            this.Otchestvo.TabIndex = 39;
            // 
            // Imya
            // 
            this.Imya.BackColor = System.Drawing.Color.Silver;
            this.Imya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Imya.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imya.ForeColor = System.Drawing.Color.Black;
            this.Imya.Location = new System.Drawing.Point(238, 125);
            this.Imya.Margin = new System.Windows.Forms.Padding(4);
            this.Imya.Name = "Imya";
            this.Imya.Size = new System.Drawing.Size(269, 35);
            this.Imya.TabIndex = 38;
            // 
            // Familiya
            // 
            this.Familiya.BackColor = System.Drawing.Color.Silver;
            this.Familiya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Familiya.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Familiya.ForeColor = System.Drawing.Color.Black;
            this.Familiya.Location = new System.Drawing.Point(238, 78);
            this.Familiya.Margin = new System.Windows.Forms.Padding(4);
            this.Familiya.Name = "Familiya";
            this.Familiya.Size = new System.Drawing.Size(269, 35);
            this.Familiya.TabIndex = 37;
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
            this.CheckStatus.Location = new System.Drawing.Point(114, 338);
            this.CheckStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CheckStatus.Name = "CheckStatus";
            this.CheckStatus.Size = new System.Drawing.Size(231, 35);
            this.CheckStatus.TabIndex = 43;
            this.CheckStatus.Text = "Проверить статус заявки";
            this.CheckStatus.UseVisualStyleBackColor = false;
            this.CheckStatus.Click += new System.EventHandler(this.CheckStatus_Click);
            // 
            // Clearfields
            // 
            this.Clearfields.BackColor = System.Drawing.Color.BlueViolet;
            this.Clearfields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clearfields.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clearfields.FlatAppearance.BorderSize = 0;
            this.Clearfields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearfields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearfields.ForeColor = System.Drawing.Color.White;
            this.Clearfields.Location = new System.Drawing.Point(437, 338);
            this.Clearfields.Margin = new System.Windows.Forms.Padding(4);
            this.Clearfields.Name = "Clearfields";
            this.Clearfields.Size = new System.Drawing.Size(231, 35);
            this.Clearfields.TabIndex = 52;
            this.Clearfields.Text = "Очистить поля ввода";
            this.Clearfields.UseVisualStyleBackColor = false;
            this.Clearfields.Click += new System.EventHandler(this.Clearfields_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clearfields);
            this.Controls.Add(this.CheckStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.Imya);
            this.Controls.Add(this.Familiya);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.TextBox Imya;
        private System.Windows.Forms.TextBox Familiya;
        private System.Windows.Forms.Button CheckStatus;
        private System.Windows.Forms.Button Clearfields;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}