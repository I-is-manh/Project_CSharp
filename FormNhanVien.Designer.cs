namespace Project_CSharp
{
    partial class FormNhanVien
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
            this.tmabs = new System.Windows.Forms.TextBox();
            this.tdiachi = new System.Windows.Forms.TextBox();
            this.tnamebs = new System.Windows.Forms.TextBox();
            this.tcnganh = new System.Windows.Forms.TextBox();
            this.dgvbs = new System.Windows.Forms.DataGridView();
            this.mabs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chitiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tgioitinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(306, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin bác sĩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(87, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bác sĩ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(425, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bác sĩ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(412, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuyên ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(98, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // tmabs
            // 
            this.tmabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tmabs.Location = new System.Drawing.Point(187, 92);
            this.tmabs.Name = "tmabs";
            this.tmabs.Size = new System.Drawing.Size(180, 27);
            this.tmabs.TabIndex = 5;
            // 
            // tdiachi
            // 
            this.tdiachi.Location = new System.Drawing.Point(187, 163);
            this.tdiachi.Name = "tdiachi";
            this.tdiachi.Size = new System.Drawing.Size(180, 22);
            this.tdiachi.TabIndex = 6;
            // 
            // tnamebs
            // 
            this.tnamebs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tnamebs.Location = new System.Drawing.Point(550, 92);
            this.tnamebs.Name = "tnamebs";
            this.tnamebs.Size = new System.Drawing.Size(182, 27);
            this.tnamebs.TabIndex = 7;
            // 
            // tcnganh
            // 
            this.tcnganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcnganh.Location = new System.Drawing.Point(550, 162);
            this.tcnganh.Name = "tcnganh";
            this.tcnganh.Size = new System.Drawing.Size(182, 27);
            this.tcnganh.TabIndex = 8;
            // 
            // dgvbs
            // 
            this.dgvbs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabs,
            this.tenbs,
            this.dc,
            this.cnganh,
            this.gioitinh,
            this.chitiet});
            this.dgvbs.Location = new System.Drawing.Point(12, 342);
            this.dgvbs.Name = "dgvbs";
            this.dgvbs.RowHeadersWidth = 51;
            this.dgvbs.RowTemplate.Height = 24;
            this.dgvbs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbs.Size = new System.Drawing.Size(830, 258);
            this.dgvbs.TabIndex = 9;
            this.dgvbs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ininfo);
            // 
            // mabs
            // 
            this.mabs.DataPropertyName = "iMaBS";
            this.mabs.HeaderText = "Mã bác sĩ";
            this.mabs.MinimumWidth = 6;
            this.mabs.Name = "mabs";
            this.mabs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tenbs
            // 
            this.tenbs.DataPropertyName = "sHoTenBS";
            this.tenbs.HeaderText = "Tên bác sĩ";
            this.tenbs.MinimumWidth = 6;
            this.tenbs.Name = "tenbs";
            // 
            // dc
            // 
            this.dc.DataPropertyName = "sDiaChi";
            this.dc.HeaderText = "Địa chỉ";
            this.dc.MinimumWidth = 6;
            this.dc.Name = "dc";
            // 
            // cnganh
            // 
            this.cnganh.DataPropertyName = "sChuyenNganh";
            this.cnganh.HeaderText = "Chuyên ngành";
            this.cnganh.MinimumWidth = 6;
            this.cnganh.Name = "cnganh";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "bGioiTinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // chitiet
            // 
            this.chitiet.HeaderText = "Xem chi tiết";
            this.chitiet.MinimumWidth = 6;
            this.chitiet.Name = "chitiet";
            this.chitiet.ReadOnly = true;
            this.chitiet.Text = "Chi tiết";
            this.chitiet.UseColumnTextForButtonValue = true;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.Location = new System.Drawing.Point(179, 637);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(90, 52);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Location = new System.Drawing.Point(303, 637);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 52);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(427, 637);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(90, 52);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(550, 637);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 52);
            this.button4.TabIndex = 14;
            this.button4.Text = "Tìm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(87, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giới tính";
            // 
            // tgioitinh
            // 
            this.tgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tgioitinh.Location = new System.Drawing.Point(185, 235);
            this.tgioitinh.Name = "tgioitinh";
            this.tgioitinh.Size = new System.Drawing.Size(182, 27);
            this.tgioitinh.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(12, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Danh sách thông tin bác sĩ";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 752);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tgioitinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvbs);
            this.Controls.Add(this.tcnganh);
            this.Controls.Add(this.tnamebs);
            this.Controls.Add(this.tdiachi);
            this.Controls.Add(this.tmabs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tmabs;
        private System.Windows.Forms.TextBox tdiachi;
        private System.Windows.Forms.TextBox tnamebs;
        private System.Windows.Forms.TextBox tcnganh;
        private System.Windows.Forms.DataGridView dgvbs;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tgioitinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabs;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnganh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewButtonColumn chitiet;
    }
}