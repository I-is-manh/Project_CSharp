namespace Project_CSharp
{
    partial class FormBn
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
            this.dgvbn = new System.Windows.Forms.DataGridView();
            this.mabn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namebn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dngaynv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benhly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmabn = new System.Windows.Forms.TextBox();
            this.tdaynv = new System.Windows.Forms.TextBox();
            this.tnamebn = new System.Windows.Forms.TextBox();
            this.tbenhly = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tsophong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(289, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin bệnh nhân";
            // 
            // dgvbn
            // 
            this.dgvbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabn,
            this.namebn,
            this.dngaynv,
            this.benhly,
            this.sophong,
            this.btn});
            this.dgvbn.Location = new System.Drawing.Point(12, 331);
            this.dgvbn.Name = "dgvbn";
            this.dgvbn.RowHeadersWidth = 51;
            this.dgvbn.RowTemplate.Height = 24;
            this.dgvbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbn.Size = new System.Drawing.Size(830, 267);
            this.dgvbn.TabIndex = 1;
            this.dgvbn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbn_CellClick_1);
            // 
            // mabn
            // 
            this.mabn.DataPropertyName = "iMaBN";
            this.mabn.HeaderText = "Mã bệnh nhân";
            this.mabn.MinimumWidth = 6;
            this.mabn.Name = "mabn";
            this.mabn.Width = 125;
            // 
            // namebn
            // 
            this.namebn.DataPropertyName = "sHoTenBN";
            this.namebn.HeaderText = "Họ và tên";
            this.namebn.MinimumWidth = 6;
            this.namebn.Name = "namebn";
            this.namebn.Width = 125;
            // 
            // dngaynv
            // 
            this.dngaynv.DataPropertyName = "dNgayNhapVien";
            this.dngaynv.HeaderText = "Ngày nhập viện";
            this.dngaynv.MinimumWidth = 6;
            this.dngaynv.Name = "dngaynv";
            this.dngaynv.Width = 125;
            // 
            // benhly
            // 
            this.benhly.DataPropertyName = "sBenh";
            this.benhly.HeaderText = "Bệnh lí";
            this.benhly.MinimumWidth = 6;
            this.benhly.Name = "benhly";
            this.benhly.Width = 125;
            // 
            // sophong
            // 
            this.sophong.DataPropertyName = "iSoPhong";
            this.sophong.HeaderText = "Số phòng";
            this.sophong.MinimumWidth = 6;
            this.sophong.Name = "sophong";
            this.sophong.Width = 125;
            // 
            // btn
            // 
            this.btn.HeaderText = "Xem chi tiết";
            this.btn.MinimumWidth = 6;
            this.btn.Name = "btn";
            this.btn.Text = "Xem chi tiết";
            this.btn.UseColumnTextForButtonValue = true;
            this.btn.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(55, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(55, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày nhập viện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên bệnh nhân";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(500, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bệnh lý";
            // 
            // tmabn
            // 
            this.tmabn.Location = new System.Drawing.Point(216, 88);
            this.tmabn.Name = "tmabn";
            this.tmabn.Size = new System.Drawing.Size(201, 22);
            this.tmabn.TabIndex = 6;
            // 
            // tdaynv
            // 
            this.tdaynv.Location = new System.Drawing.Point(216, 151);
            this.tdaynv.Name = "tdaynv";
            this.tdaynv.Size = new System.Drawing.Size(201, 22);
            this.tdaynv.TabIndex = 7;
            // 
            // tnamebn
            // 
            this.tnamebn.Location = new System.Drawing.Point(594, 88);
            this.tnamebn.Name = "tnamebn";
            this.tnamebn.Size = new System.Drawing.Size(178, 22);
            this.tnamebn.TabIndex = 8;
            // 
            // tbenhly
            // 
            this.tbenhly.Location = new System.Drawing.Point(594, 152);
            this.tbenhly.Name = "tbenhly";
            this.tbenhly.Size = new System.Drawing.Size(178, 22);
            this.tbenhly.TabIndex = 9;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.Location = new System.Drawing.Point(189, 632);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(90, 52);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Location = new System.Drawing.Point(327, 632);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 52);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(452, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 52);
            this.button3.TabIndex = 12;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách bệnh nhân";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.Location = new System.Drawing.Point(580, 632);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(87, 54);
            this.btntimkiem.TabIndex = 15;
            this.btntimkiem.Text = "Tìm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(104, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số phòng";
            // 
            // tsophong
            // 
            this.tsophong.Location = new System.Drawing.Point(216, 215);
            this.tsophong.Name = "tsophong";
            this.tsophong.Size = new System.Drawing.Size(201, 22);
            this.tsophong.TabIndex = 17;
            // 
            // FormBn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 752);
            this.Controls.Add(this.tsophong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tbenhly);
            this.Controls.Add(this.tnamebn);
            this.Controls.Add(this.tdaynv);
            this.Controls.Add(this.tmabn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvbn);
            this.Controls.Add(this.label1);
            this.Name = "FormBn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin bệnh nhân";
            this.Load += new System.EventHandler(this.FormBn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tmabn;
        private System.Windows.Forms.TextBox tdaynv;
        private System.Windows.Forms.TextBox tnamebn;
        private System.Windows.Forms.TextBox tbenhly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tsophong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namebn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dngaynv;
        private System.Windows.Forms.DataGridViewTextBoxColumn benhly;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophong;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
    }
}