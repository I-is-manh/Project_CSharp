namespace Project_CSharp
{
    partial class FormSuaBS
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
            this.txtngsi = new System.Windows.Forms.MaskedTextBox();
            this.têtx = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.txtnamebs = new System.Windows.Forms.TextBox();
            this.txtmabs = new System.Windows.Forms.TextBox();
            this.btn__bs__sua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlcb = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtngsi
            // 
            this.txtngsi.Location = new System.Drawing.Point(517, 369);
            this.txtngsi.Mask = "00/00/0000";
            this.txtngsi.Name = "txtngsi";
            this.txtngsi.Size = new System.Drawing.Size(186, 22);
            this.txtngsi.TabIndex = 89;
            this.txtngsi.ValidatingType = typeof(System.DateTime);
            this.txtngsi.Validating += new System.ComponentModel.CancelEventHandler(this.checkday);
            // 
            // têtx
            // 
            this.têtx.AutoSize = true;
            this.têtx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.têtx.Location = new System.Drawing.Point(413, 369);
            this.têtx.Name = "têtx";
            this.têtx.Size = new System.Drawing.Size(88, 22);
            this.têtx.TabIndex = 88;
            this.têtx.Text = "Ngày sinh";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNu.Location = new System.Drawing.Point(285, 370);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(51, 23);
            this.rdNu.TabIndex = 87;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNam.Location = new System.Drawing.Point(174, 369);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(65, 24);
            this.rdNam.TabIndex = 86;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(78, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 22);
            this.label10.TabIndex = 85;
            this.label10.Text = "Giới tính";
            // 
            // txtpc
            // 
            this.txtpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtpc.Location = new System.Drawing.Point(517, 298);
            this.txtpc.Name = "txtpc";
            this.txtpc.Size = new System.Drawing.Size(186, 28);
            this.txtpc.TabIndex = 84;
            this.txtpc.Validating += new System.ComponentModel.CancelEventHandler(this.checkpc);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(429, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 83;
            this.label9.Text = "Phụ cấp";
            // 
            // txtcn
            // 
            this.txtcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcn.Location = new System.Drawing.Point(517, 180);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(186, 28);
            this.txtcn.TabIndex = 81;
            this.txtcn.Validating += new System.ComponentModel.CancelEventHandler(this.checkcn);
            // 
            // txtdc
            // 
            this.txtdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdc.Location = new System.Drawing.Point(174, 180);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(191, 28);
            this.txtdc.TabIndex = 80;
            this.txtdc.Validating += new System.ComponentModel.CancelEventHandler(this.checkdc);
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsdt.Location = new System.Drawing.Point(517, 242);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(186, 27);
            this.txtsdt.TabIndex = 78;
            this.txtsdt.Validating += new System.ComponentModel.CancelEventHandler(this.checksdt);
            // 
            // txtcccd
            // 
            this.txtcccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcccd.Location = new System.Drawing.Point(174, 241);
            this.txtcccd.Multiline = true;
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(191, 27);
            this.txtcccd.TabIndex = 77;
            this.txtcccd.Validating += new System.ComponentModel.CancelEventHandler(this.checkcccd);
            // 
            // txtnamebs
            // 
            this.txtnamebs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnamebs.Location = new System.Drawing.Point(513, 112);
            this.txtnamebs.Multiline = true;
            this.txtnamebs.Name = "txtnamebs";
            this.txtnamebs.Size = new System.Drawing.Size(190, 27);
            this.txtnamebs.TabIndex = 76;
            this.txtnamebs.Validating += new System.ComponentModel.CancelEventHandler(this.checknamebs);
            // 
            // txtmabs
            // 
            this.txtmabs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmabs.Location = new System.Drawing.Point(174, 113);
            this.txtmabs.Multiline = true;
            this.txtmabs.Name = "txtmabs";
            this.txtmabs.ReadOnly = true;
            this.txtmabs.Size = new System.Drawing.Size(191, 27);
            this.txtmabs.TabIndex = 75;
            this.txtmabs.TextChanged += new System.EventHandler(this.txtmabs_TextChanged);
            // 
            // btn__bs__sua
            // 
            this.btn__bs__sua.Location = new System.Drawing.Point(346, 438);
            this.btn__bs__sua.Name = "btn__bs__sua";
            this.btn__bs__sua.Size = new System.Drawing.Size(88, 45);
            this.btn__bs__sua.TabIndex = 74;
            this.btn__bs__sua.Text = "Sửa";
            this.btn__bs__sua.UseVisualStyleBackColor = true;
            this.btn__bs__sua.Click += new System.EventHandler(this.btn__bs__sua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(40, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 22);
            this.label8.TabIndex = 73;
            this.label8.Text = "Lương cơ bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(397, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 72;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(393, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 71;
            this.label6.Text = "Chuyên ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(76, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 70;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(55, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 69;
            this.label4.Text = "Số CCCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(409, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tên bác sĩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(56, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã bác sĩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(279, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 66;
            this.label1.Text = "Thông tin bác sĩ";
            // 
            // txtlcb
            // 
            this.txtlcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtlcb.Location = new System.Drawing.Point(174, 311);
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(191, 27);
            this.txtlcb.TabIndex = 90;
            this.txtlcb.Validating += new System.ComponentModel.CancelEventHandler(this.checkluong);
            // 
            // FormSuaBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.txtlcb);
            this.Controls.Add(this.txtngsi);
            this.Controls.Add(this.têtx);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtpc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcn);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtcccd);
            this.Controls.Add(this.txtnamebs);
            this.Controls.Add(this.txtmabs);
            this.Controls.Add(this.btn__bs__sua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaBS";
            this.Text = "FormSuaBS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtngsi;
        private System.Windows.Forms.Label têtx;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtpc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcn;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.TextBox txtnamebs;
        private System.Windows.Forms.TextBox txtmabs;
        private System.Windows.Forms.Button btn__bs__sua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtlcb;
    }
}