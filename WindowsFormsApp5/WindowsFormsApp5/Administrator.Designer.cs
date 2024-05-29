namespace WindowsFormsApp5
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.label6 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridViewStatus = new System.Windows.Forms.DataGridView();
            this.Accept = new System.Windows.Forms.Button();
            this.Decline = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IDPoshlina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(192, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 34);
            this.label6.TabIndex = 34;
            this.label6.Text = "Просмотр заявок на оплату";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(638, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 25);
            this.Exit.TabIndex = 36;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridViewStatus
            // 
            this.dataGridViewStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatus.Location = new System.Drawing.Point(88, 62);
            this.dataGridViewStatus.Name = "dataGridViewStatus";
            this.dataGridViewStatus.Size = new System.Drawing.Size(554, 219);
            this.dataGridViewStatus.TabIndex = 44;
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.Color.BlueViolet;
            this.Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accept.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Accept.FlatAppearance.BorderSize = 0;
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accept.ForeColor = System.Drawing.Color.White;
            this.Accept.Location = new System.Drawing.Point(88, 385);
            this.Accept.Margin = new System.Windows.Forms.Padding(4);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(244, 35);
            this.Accept.TabIndex = 52;
            this.Accept.Text = "Принять";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Decline
            // 
            this.Decline.BackColor = System.Drawing.Color.BlueViolet;
            this.Decline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decline.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Decline.FlatAppearance.BorderSize = 0;
            this.Decline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Decline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decline.ForeColor = System.Drawing.Color.White;
            this.Decline.Location = new System.Drawing.Point(372, 385);
            this.Decline.Margin = new System.Windows.Forms.Padding(4);
            this.Decline.Name = "Decline";
            this.Decline.Size = new System.Drawing.Size(270, 35);
            this.Decline.TabIndex = 53;
            this.Decline.Text = "Отклонить";
            this.Decline.UseVisualStyleBackColor = false;
            this.Decline.Click += new System.EventHandler(this.Decline_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // IDPoshlina
            // 
            this.IDPoshlina.BackColor = System.Drawing.Color.Silver;
            this.IDPoshlina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDPoshlina.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPoshlina.ForeColor = System.Drawing.Color.Black;
            this.IDPoshlina.Location = new System.Drawing.Point(216, 342);
            this.IDPoshlina.Margin = new System.Windows.Forms.Padding(4);
            this.IDPoshlina.Name = "IDPoshlina";
            this.IDPoshlina.Size = new System.Drawing.Size(426, 35);
            this.IDPoshlina.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID Пошлины";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.BlueViolet;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(240, 288);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(244, 35);
            this.Search.TabIndex = 57;
            this.Search.Text = "Просмотр заявок";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDPoshlina);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Decline);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.dataGridViewStatus);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridViewStatus;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Decline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox IDPoshlina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
    }
}