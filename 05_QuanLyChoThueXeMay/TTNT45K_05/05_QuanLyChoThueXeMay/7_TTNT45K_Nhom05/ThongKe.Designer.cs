﻿namespace _7_TTNT45K_Nhom05
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTinhTrangXe = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXemLai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaXe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(315, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(88, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình trạng xe";
            // 
            // cbTinhTrangXe
            // 
            this.cbTinhTrangXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrangXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbTinhTrangXe.FormattingEnabled = true;
            this.cbTinhTrangXe.Items.AddRange(new object[] {
            "Dang cho thue",
            "San co",
            "Hong"});
            this.cbTinhTrangXe.Location = new System.Drawing.Point(283, 206);
            this.cbTinhTrangXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTinhTrangXe.Name = "cbTinhTrangXe";
            this.cbTinhTrangXe.Size = new System.Drawing.Size(287, 38);
            this.cbTinhTrangXe.TabIndex = 1;
            this.cbTinhTrangXe.Click += new System.EventHandler(this.cbTinhTrangXe_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackgroundImage = global::_7_TTNT45K_Nhom05.Properties.Resources.search;
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThongKe.Location = new System.Drawing.Point(604, 111);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(167, 65);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 281);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnXemLai
            // 
            this.btnXemLai.BackgroundImage = global::_7_TTNT45K_Nhom05.Properties.Resources.undo1;
            this.btnXemLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXemLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLai.Location = new System.Drawing.Point(604, 196);
            this.btnXemLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemLai.Name = "btnXemLai";
            this.btnXemLai.Size = new System.Drawing.Size(167, 62);
            this.btnXemLai.TabIndex = 3;
            this.btnXemLai.UseVisualStyleBackColor = true;
            this.btnXemLai.Click += new System.EventHandler(this.btnXemLai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doanh thu";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDoanhThu.Location = new System.Drawing.Point(283, 295);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(287, 37);
            this.txtDoanhThu.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 378);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(691, 367);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng quan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã Xe";
            // 
            // cbMaXe
            // 
            this.cbMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbMaXe.FormattingEnabled = true;
            this.cbMaXe.Items.AddRange(new object[] {
            "Tất cả xe"});
            this.cbMaXe.Location = new System.Drawing.Point(283, 111);
            this.cbMaXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaXe.Name = "cbMaXe";
            this.cbMaXe.Size = new System.Drawing.Size(287, 38);
            this.cbMaXe.TabIndex = 0;
            this.cbMaXe.Click += new System.EventHandler(this.cbMaXe_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_7_TTNT45K_Nhom05.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(869, 844);
            this.Controls.Add(this.cbMaXe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXemLai);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cbTinhTrangXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTinhTrangXe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXemLai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaXe;
    }
}