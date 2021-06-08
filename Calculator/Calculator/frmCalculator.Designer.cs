namespace frmCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSo1
            // 
            this.txtSo1.BackColor = System.Drawing.Color.Khaki;
            this.txtSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo1.Location = new System.Drawing.Point(45, 66);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(119, 34);
            this.txtSo1.TabIndex = 0;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // txtSo2
            // 
            this.txtSo2.BackColor = System.Drawing.Color.Khaki;
            this.txtSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo2.Location = new System.Drawing.Point(294, 65);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(115, 34);
            this.txtSo2.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.Khaki;
            this.txtKQ.Enabled = false;
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.ForeColor = System.Drawing.Color.DarkRed;
            this.txtKQ.Location = new System.Drawing.Point(158, 349);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(202, 45);
            this.txtKQ.TabIndex = 2;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // btnCong
            // 
            this.btnCong.AutoSize = true;
            this.btnCong.BackgroundImage = global::frmCalculator.Properties.Resources.Screenshot_2021_06_08_1603371;
            this.btnCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCong.Image = global::frmCalculator.Properties.Resources.Screenshot_2021_06_08_1603371;
            this.btnCong.Location = new System.Drawing.Point(142, 152);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(58, 56);
            this.btnCong.TabIndex = 3;
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.AutoSize = true;
            this.btnTru.BackgroundImage = global::frmCalculator.Properties.Resources.Screenshot_2021_06_08_1603511;
            this.btnTru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTru.Location = new System.Drawing.Point(234, 152);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(58, 58);
            this.btnTru.TabIndex = 3;
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.AutoSize = true;
            this.btnNhan.BackgroundImage = global::frmCalculator.Properties.Resources.Screenshot_2021_06_08_161903;
            this.btnNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhan.Location = new System.Drawing.Point(142, 233);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(59, 51);
            this.btnNhan.TabIndex = 3;
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.AutoSize = true;
            this.btnChia.BackgroundImage = global::frmCalculator.Properties.Resources.Screenshot_2021_06_08_161913;
            this.btnChia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChia.Location = new System.Drawing.Point(234, 233);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(58, 51);
            this.btnChia.TabIndex = 3;
            this.btnChia.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnChia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmCalculator.Properties.Resources.Screenshot_2021_06_08_1628522;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(84, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 48);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmCalculator.Properties.Resources.e3b88a893ae3656ac1423331ecc422b2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

