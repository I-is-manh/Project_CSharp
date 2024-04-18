namespace Project_CSharp
{
    partial class FormThemThuoc
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
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtnamet = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtnsx = new System.Windows.Forms.TextBox();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn__add = new System.Windows.Forms.Button();
            this.btn__reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdvt
            // 
            this.txtdvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdvt.Location = new System.Drawing.Point(547, 274);
            this.txtdvt.Multiline = true;
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(156, 25);
            this.txtdvt.TabIndex = 23;
            this.txtdvt.Validating += new System.ComponentModel.CancelEventHandler(this.checkdvt);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(411, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Đơn vị tính";
            // 
            // txtgiaban
            // 
            this.txtgiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtgiaban.Location = new System.Drawing.Point(547, 195);
            this.txtgiaban.Multiline = true;
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(156, 25);
            this.txtgiaban.TabIndex = 19;
            this.txtgiaban.TextChanged += new System.EventHandler(this.txtgiaban_TextChanged);
            this.txtgiaban.Validating += new System.ComponentModel.CancelEventHandler(this.checkgb);
            // 
            // txtnamet
            // 
            this.txtnamet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnamet.Location = new System.Drawing.Point(547, 112);
            this.txtnamet.Multiline = true;
            this.txtnamet.Name = "txtnamet";
            this.txtnamet.Size = new System.Drawing.Size(156, 25);
            this.txtnamet.TabIndex = 15;
            this.txtnamet.Validating += new System.ComponentModel.CancelEventHandler(this.checktt);
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsl.Location = new System.Drawing.Point(207, 274);
            this.txtsl.Multiline = true;
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(156, 25);
            this.txtsl.TabIndex = 21;
            this.txtsl.Validating += new System.ComponentModel.CancelEventHandler(this.checksl);
            // 
            // txtnsx
            // 
            this.txtnsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnsx.Location = new System.Drawing.Point(207, 194);
            this.txtnsx.Multiline = true;
            this.txtnsx.Name = "txtnsx";
            this.txtnsx.Size = new System.Drawing.Size(156, 25);
            this.txtnsx.TabIndex = 17;
            this.txtnsx.Validating += new System.ComponentModel.CancelEventHandler(this.check);
            // 
            // txtmath
            // 
            this.txtmath.Location = new System.Drawing.Point(207, 111);
            this.txtmath.Name = "txtmath";
            this.txtmath.ReadOnly = true;
            this.txtmath.Size = new System.Drawing.Size(156, 22);
            this.txtmath.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(98, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(423, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(81, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nhà sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(423, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(97, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(319, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Thêm thuốc";
            // 
            // btn__add
            // 
            this.btn__add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn__add.Location = new System.Drawing.Point(273, 338);
            this.btn__add.Name = "btn__add";
            this.btn__add.Size = new System.Drawing.Size(90, 52);
            this.btn__add.TabIndex = 26;
            this.btn__add.Text = "Thêm";
            this.btn__add.UseVisualStyleBackColor = true;
            this.btn__add.Click += new System.EventHandler(this.btn__add_Click);
            // 
            // btn__reset
            // 
            this.btn__reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn__reset.Location = new System.Drawing.Point(415, 338);
            this.btn__reset.Name = "btn__reset";
            this.btn__reset.Size = new System.Drawing.Size(90, 52);
            this.btn__reset.TabIndex = 27;
            this.btn__reset.Text = "Xóa";
            this.btn__reset.UseVisualStyleBackColor = true;
            this.btn__reset.Click += new System.EventHandler(this.btn__reset_Click);
            // 
            // FormThemThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn__reset);
            this.Controls.Add(this.btn__add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdvt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtgiaban);
            this.Controls.Add(this.txtnamet);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtnsx);
            this.Controls.Add(this.txtmath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormThemThuoc";
            this.Text = "FormThemThuoc";
            this.Load += new System.EventHandler(this.FormThemThuoc_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkvalidate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtnamet;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtnsx;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn__add;
        private System.Windows.Forms.Button btn__reset;
    }
}