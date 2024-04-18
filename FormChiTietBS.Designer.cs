namespace Project_CSharp
{
    partial class FormThemBS
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
            this.btn__bs__reset = new System.Windows.Forms.Button();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.txtnamebs = new System.Windows.Forms.TextBox();
            this.txtmabs = new System.Windows.Forms.TextBox();
            this.btn__bs__add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.têtx = new System.Windows.Forms.Label();
            this.txtngsi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn__bs__reset
            // 
            this.btn__bs__reset.Location = new System.Drawing.Point(432, 444);
            this.btn__bs__reset.Name = "btn__bs__reset";
            this.btn__bs__reset.Size = new System.Drawing.Size(88, 45);
            this.btn__bs__reset.TabIndex = 52;
            this.btn__bs__reset.Text = "Reset";
            this.btn__bs__reset.UseVisualStyleBackColor = true;
            this.btn__bs__reset.Click += new System.EventHandler(this.btn__info__reset_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsdt.Location = new System.Drawing.Point(586, 236);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(161, 27);
            this.txtsdt.TabIndex = 6;
            this.txtsdt.Validating += new System.ComponentModel.CancelEventHandler(this.checksdt);
            // 
            // txtcccd
            // 
            this.txtcccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcccd.Location = new System.Drawing.Point(214, 235);
            this.txtcccd.Multiline = true;
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(161, 27);
            this.txtcccd.TabIndex = 5;
            this.txtcccd.Validating += new System.ComponentModel.CancelEventHandler(this.checkcccd);
            // 
            // txtnamebs
            // 
            this.txtnamebs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnamebs.Location = new System.Drawing.Point(586, 106);
            this.txtnamebs.Multiline = true;
            this.txtnamebs.Name = "txtnamebs";
            this.txtnamebs.Size = new System.Drawing.Size(161, 27);
            this.txtnamebs.TabIndex = 2;
            this.txtnamebs.Validating += new System.ComponentModel.CancelEventHandler(this.checknamebs);
            // 
            // txtmabs
            // 
            this.txtmabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmabs.Location = new System.Drawing.Point(214, 106);
            this.txtmabs.Multiline = true;
            this.txtmabs.Name = "txtmabs";
            this.txtmabs.Size = new System.Drawing.Size(161, 27);
            this.txtmabs.TabIndex = 48;
            // 
            // btn__bs__add
            // 
            this.btn__bs__add.Location = new System.Drawing.Point(287, 444);
            this.btn__bs__add.Name = "btn__bs__add";
            this.btn__bs__add.Size = new System.Drawing.Size(88, 45);
            this.btn__bs__add.TabIndex = 12;
            this.btn__bs__add.Text = "Thêm";
            this.btn__bs__add.UseVisualStyleBackColor = true;
            this.btn__bs__add.Click += new System.EventHandler(this.btn__bs__add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(58, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Lương cơ bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(442, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(443, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 44;
            this.label6.Text = "Chuyên ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(89, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(79, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Số CCCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(469, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tên bác sĩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(80, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã bác sĩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(298, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 39;
            this.label1.Text = "Thêm bác sĩ";
            // 
            // txtdc
            // 
            this.txtdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdc.Location = new System.Drawing.Point(213, 175);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(162, 28);
            this.txtdc.TabIndex = 3;
            this.txtdc.Validating += new System.ComponentModel.CancelEventHandler(this.checkdc);
            // 
            // txtcn
            // 
            this.txtcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcn.Location = new System.Drawing.Point(586, 173);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(161, 28);
            this.txtcn.TabIndex = 4;
            this.txtcn.Validating += new System.ComponentModel.CancelEventHandler(this.checkcn);
            // 
            // txtlcb
            // 
            this.txtlcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtlcb.Location = new System.Drawing.Point(213, 301);
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(162, 28);
            this.txtlcb.TabIndex = 7;
            this.txtlcb.Validating += new System.ComponentModel.CancelEventHandler(this.checkluong);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(484, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 59;
            this.label9.Text = "Phụ cấp";
            // 
            // txtpc
            // 
            this.txtpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtpc.Location = new System.Drawing.Point(586, 301);
            this.txtpc.Name = "txtpc";
            this.txtpc.Size = new System.Drawing.Size(161, 28);
            this.txtpc.TabIndex = 8;
            this.txtpc.Validating += new System.ComponentModel.CancelEventHandler(this.checkpc);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(80, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 22);
            this.label10.TabIndex = 61;
            this.label10.Text = "Giới tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNam.Location = new System.Drawing.Point(214, 363);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(65, 24);
            this.rdNam.TabIndex = 9;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNu.Location = new System.Drawing.Point(316, 365);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(51, 23);
            this.rdNu.TabIndex = 10;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // têtx
            // 
            this.têtx.AutoSize = true;
            this.têtx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.têtx.Location = new System.Drawing.Point(473, 362);
            this.têtx.Name = "têtx";
            this.têtx.Size = new System.Drawing.Size(88, 22);
            this.têtx.TabIndex = 64;
            this.têtx.Text = "Ngày sinh";
            // 
            // txtngsi
            // 
            this.txtngsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtngsi.Location = new System.Drawing.Point(586, 363);
            this.txtngsi.Mask = "00/00/0000";
            this.txtngsi.Name = "txtngsi";
            this.txtngsi.Size = new System.Drawing.Size(161, 27);
            this.txtngsi.TabIndex = 11;
            this.txtngsi.ValidatingType = typeof(System.DateTime);
            this.txtngsi.Validating += new System.ComponentModel.CancelEventHandler(this.checkday);
            // 
            // FormThemBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.txtngsi);
            this.Controls.Add(this.têtx);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtpc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtlcb);
            this.Controls.Add(this.txtcn);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.btn__bs__reset);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtcccd);
            this.Controls.Add(this.txtnamebs);
            this.Controls.Add(this.txtmabs);
            this.Controls.Add(this.btn__bs__add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTietBS";
            this.Load += new System.EventHandler(this.FormChiTietBS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn__bs__reset;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.TextBox txtnamebs;
        private System.Windows.Forms.TextBox txtmabs;
        private System.Windows.Forms.Button btn__bs__add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtcn;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label têtx;
        private System.Windows.Forms.MaskedTextBox txtngsi;
    }
}