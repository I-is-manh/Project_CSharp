namespace Project_CSharp
{
    partial class FormInfoBN
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
            this.btn__info__update = new System.Windows.Forms.Button();
            this.txtbenhly = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtnamebn = new System.Windows.Forms.TextBox();
            this.txtmabn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtngsi = new System.Windows.Forms.MaskedTextBox();
            this.txtngnv = new System.Windows.Forms.MaskedTextBox();
            this.txtsophong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn__info__update
            // 
            this.btn__info__update.Location = new System.Drawing.Point(400, 347);
            this.btn__info__update.Name = "btn__info__update";
            this.btn__info__update.Size = new System.Drawing.Size(88, 45);
            this.btn__info__update.TabIndex = 16;
            this.btn__info__update.Text = "Sửa";
            this.btn__info__update.UseVisualStyleBackColor = true;
            this.btn__info__update.Click += new System.EventHandler(this.btn__info__update_Click);
            // 
            // txtbenhly
            // 
            this.txtbenhly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbenhly.Location = new System.Drawing.Point(627, 213);
            this.txtbenhly.Multiline = true;
            this.txtbenhly.Name = "txtbenhly";
            this.txtbenhly.Size = new System.Drawing.Size(161, 27);
            this.txtbenhly.TabIndex = 14;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsdt.Location = new System.Drawing.Point(255, 212);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(161, 27);
            this.txtsdt.TabIndex = 13;
            // 
            // txtnamebn
            // 
            this.txtnamebn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnamebn.Location = new System.Drawing.Point(627, 90);
            this.txtnamebn.Multiline = true;
            this.txtnamebn.Name = "txtnamebn";
            this.txtnamebn.Size = new System.Drawing.Size(161, 27);
            this.txtnamebn.TabIndex = 10;
            // 
            // txtmabn
            // 
            this.txtmabn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmabn.Location = new System.Drawing.Point(255, 83);
            this.txtmabn.Multiline = true;
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.ReadOnly = true;
            this.txtmabn.Size = new System.Drawing.Size(161, 27);
            this.txtmabn.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin bệnh nhân";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(130, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(535, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bệnh lí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(470, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày nhập viện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(121, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(99, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(470, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(94, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // txtngsi
            // 
            this.txtngsi.Location = new System.Drawing.Point(255, 154);
            this.txtngsi.Mask = "00/00/0000";
            this.txtngsi.Name = "txtngsi";
            this.txtngsi.Size = new System.Drawing.Size(161, 22);
            this.txtngsi.TabIndex = 17;
            this.txtngsi.ValidatingType = typeof(System.DateTime);
            // 
            // txtngnv
            // 
            this.txtngnv.Location = new System.Drawing.Point(627, 153);
            this.txtngnv.Mask = "00/00/0000";
            this.txtngnv.Name = "txtngnv";
            this.txtngnv.Size = new System.Drawing.Size(161, 22);
            this.txtngnv.TabIndex = 18;
            this.txtngnv.ValidatingType = typeof(System.DateTime);
            // 
            // txtsophong
            // 
            this.txtsophong.FormattingEnabled = true;
            this.txtsophong.Location = new System.Drawing.Point(255, 279);
            this.txtsophong.Name = "txtsophong";
            this.txtsophong.Size = new System.Drawing.Size(161, 24);
            this.txtsophong.TabIndex = 19;
            // 
            // FormInfoBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 494);
            this.Controls.Add(this.txtsophong);
            this.Controls.Add(this.txtngnv);
            this.Controls.Add(this.txtngsi);
            this.Controls.Add(this.btn__info__update);
            this.Controls.Add(this.txtbenhly);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtnamebn);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInfoBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfoBN";
            this.Load += new System.EventHandler(this.FormInfoBN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn__info__update;
        private System.Windows.Forms.TextBox txtbenhly;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtnamebn;
        private System.Windows.Forms.TextBox txtmabn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtngsi;
        private System.Windows.Forms.MaskedTextBox txtngnv;
        private System.Windows.Forms.ComboBox txtsophong;
    }
}