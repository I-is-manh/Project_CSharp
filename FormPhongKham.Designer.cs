namespace Project_CSharp
{
    partial class FormPhongKham
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
            this.sophong = new System.Windows.Forms.TextBox();
            this.tenphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.namebs = new System.Windows.Forms.TextBox();
            this.iphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namephong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namebasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.mabs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(282, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phòng bệnh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(159, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(456, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(154, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã bác sĩ";
            // 
            // sophong
            // 
            this.sophong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sophong.Location = new System.Drawing.Point(248, 108);
            this.sophong.Name = "sophong";
            this.sophong.Size = new System.Drawing.Size(142, 27);
            this.sophong.TabIndex = 4;
            // 
            // tenphong
            // 
            this.tenphong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenphong.Location = new System.Drawing.Point(544, 109);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(156, 27);
            this.tenphong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Danh sách phòng bệnh";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iphong,
            this.namephong,
            this.mabasi,
            this.namebasi});
            this.dgv.Location = new System.Drawing.Point(12, 373);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(830, 246);
            this.dgv.TabIndex = 8;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickrow);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(446, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên bác sĩ";
            // 
            // namebs
            // 
            this.namebs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.namebs.Location = new System.Drawing.Point(544, 174);
            this.namebs.Name = "namebs";
            this.namebs.Size = new System.Drawing.Size(156, 27);
            this.namebs.TabIndex = 10;
            // 
            // iphong
            // 
            this.iphong.DataPropertyName = "iSoPhong";
            this.iphong.HeaderText = "Số phòng";
            this.iphong.MinimumWidth = 6;
            this.iphong.Name = "iphong";
            this.iphong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // namephong
            // 
            this.namephong.DataPropertyName = "sTenPhong";
            this.namephong.HeaderText = "Tên phòng";
            this.namephong.MinimumWidth = 6;
            this.namephong.Name = "namephong";
            this.namephong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mabasi
            // 
            this.mabasi.DataPropertyName = "iMaBS";
            this.mabasi.HeaderText = "Mã bác sĩ";
            this.mabasi.MinimumWidth = 6;
            this.mabasi.Name = "mabasi";
            this.mabasi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // namebasi
            // 
            this.namebasi.DataPropertyName = "sHoTenBS";
            this.namebasi.HeaderText = "Tên bác sĩ";
            this.namebasi.MinimumWidth = 6;
            this.namebasi.Name = "namebasi";
            this.namebasi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_add.Location = new System.Drawing.Point(230, 645);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 46);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua.Location = new System.Drawing.Point(366, 645);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(86, 46);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_remove.Location = new System.Drawing.Point(503, 645);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(86, 46);
            this.btn_remove.TabIndex = 13;
            this.btn_remove.Text = "Xóa";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // mabs
            // 
            this.mabs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mabs.FormattingEnabled = true;
            this.mabs.Location = new System.Drawing.Point(248, 179);
            this.mabs.Name = "mabs";
            this.mabs.Size = new System.Drawing.Size(142, 27);
            this.mabs.TabIndex = 14;
            this.mabs.SelectedIndexChanged += new System.EventHandler(this.mabs_SelectedIndexChanged);
            // 
            // FormPhongKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 752);
            this.Controls.Add(this.mabs);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.namebs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tenphong);
            this.Controls.Add(this.sophong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPhongKham";
            this.Text = "FormPhongKham";
            this.Load += new System.EventHandler(this.FormPhongKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sophong;
        private System.Windows.Forms.TextBox tenphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox namebs;
        private System.Windows.Forms.DataGridViewTextBoxColumn iphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn namephong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namebasi;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ComboBox mabs;
    }
}