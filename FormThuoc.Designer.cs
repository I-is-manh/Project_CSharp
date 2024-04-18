namespace Project_CSharp
{
    partial class FormThuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.txtnsx = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtnamet = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.dgvt = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_rpt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(304, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(124, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(444, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(97, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(437, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(96, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng tồn";
            // 
            // txtmath
            // 
            this.txtmath.Location = new System.Drawing.Point(225, 90);
            this.txtmath.Name = "txtmath";
            this.txtmath.ReadOnly = true;
            this.txtmath.Size = new System.Drawing.Size(156, 22);
            this.txtmath.TabIndex = 1;
            // 
            // txtnsx
            // 
            this.txtnsx.Location = new System.Drawing.Point(225, 169);
            this.txtnsx.Name = "txtnsx";
            this.txtnsx.Size = new System.Drawing.Size(156, 22);
            this.txtnsx.TabIndex = 3;
            this.txtnsx.Validating += new System.ComponentModel.CancelEventHandler(this.check);
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(225, 253);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(156, 22);
            this.txtsl.TabIndex = 5;
            this.txtsl.Validating += new System.ComponentModel.CancelEventHandler(this.checksl);
            // 
            // txtnamet
            // 
            this.txtnamet.Location = new System.Drawing.Point(546, 90);
            this.txtnamet.Name = "txtnamet";
            this.txtnamet.Size = new System.Drawing.Size(156, 22);
            this.txtnamet.TabIndex = 2;
            this.txtnamet.Validating += new System.ComponentModel.CancelEventHandler(this.checktt);
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(546, 169);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(156, 22);
            this.txtgiaban.TabIndex = 4;
            this.txtgiaban.Validating += new System.ComponentModel.CancelEventHandler(this.checkgb);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(12, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Danh sách thuốc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(432, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đơn vị tính";
            // 
            // txtdvt
            // 
            this.txtdvt.Location = new System.Drawing.Point(546, 252);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(156, 22);
            this.txtdvt.TabIndex = 6;
            this.txtdvt.Validating += new System.ComponentModel.CancelEventHandler(this.checkdvt);
            // 
            // dgvt
            // 
            this.dgvt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.nsx,
            this.giaban,
            this.soluong,
            this.dvt});
            this.dgvt.Location = new System.Drawing.Point(12, 383);
            this.dgvt.Name = "dgvt";
            this.dgvt.RowHeadersWidth = 51;
            this.dgvt.RowTemplate.Height = 24;
            this.dgvt.Size = new System.Drawing.Size(830, 247);
            this.dgvt.TabIndex = 13;
            this.dgvt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvt_CellClick);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "iMaThuoc";
            this.ma.HeaderText = "Mã thuốc";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "sTenThuoc";
            this.ten.HeaderText = "Tên thuốc";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            // 
            // nsx
            // 
            this.nsx.DataPropertyName = "sNhaSanXuat";
            this.nsx.HeaderText = "Nhà sản xuất";
            this.nsx.MinimumWidth = 6;
            this.nsx.Name = "nsx";
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "fGiaBan";
            this.giaban.HeaderText = "Giá bán";
            this.giaban.MinimumWidth = 6;
            this.giaban.Name = "giaban";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "iSLThuocCon";
            this.soluong.HeaderText = "Số lượng tồn";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "sDonViTinh";
            this.dvt.HeaderText = "Đơn vị tính";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_add.Location = new System.Drawing.Point(117, 654);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 52);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua.Location = new System.Drawing.Point(250, 654);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(90, 52);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Location = new System.Drawing.Point(375, 654);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 52);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tim.Location = new System.Drawing.Point(505, 654);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(90, 52);
            this.btn_tim.TabIndex = 17;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_rpt
            // 
            this.btn_rpt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_rpt.Location = new System.Drawing.Point(629, 654);
            this.btn_rpt.Name = "btn_rpt";
            this.btn_rpt.Size = new System.Drawing.Size(90, 52);
            this.btn_rpt.TabIndex = 18;
            this.btn_rpt.Text = "In";
            this.btn_rpt.UseVisualStyleBackColor = true;
            this.btn_rpt.Click += new System.EventHandler(this.btn_rpt_Click);
            // 
            // FormThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 752);
            this.Controls.Add(this.btn_rpt);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgvt);
            this.Controls.Add(this.txtdvt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.label1);
            this.Name = "FormThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.FormThuoc_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkvalidate);
            ((System.ComponentModel.ISupportInitialize)(this.dgvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.TextBox txtnsx;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtnamet;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.DataGridView dgvt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.Button btn_rpt;
    }
}