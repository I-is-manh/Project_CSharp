namespace Project_CSharp
{
    partial class FormHoaDon
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
            this.tmahd = new System.Windows.Forms.TextBox();
            this.tmabn = new System.Windows.Forms.TextBox();
            this.ttenbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tngaylap = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stenbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(314, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(466, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(120, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bệnh nhân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(436, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày lập hóa đơn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh sách hóa đơn";
            // 
            // tmahd
            // 
            this.tmahd.Enabled = false;
            this.tmahd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tmahd.Location = new System.Drawing.Point(249, 116);
            this.tmahd.Name = "tmahd";
            this.tmahd.Size = new System.Drawing.Size(156, 27);
            this.tmahd.TabIndex = 5;
            // 
            // tmabn
            // 
            this.tmabn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tmabn.Location = new System.Drawing.Point(591, 117);
            this.tmabn.Name = "tmabn";
            this.tmabn.Size = new System.Drawing.Size(162, 27);
            this.tmabn.TabIndex = 6;
            // 
            // ttenbn
            // 
            this.ttenbn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttenbn.Location = new System.Drawing.Point(249, 204);
            this.ttenbn.Name = "ttenbn";
            this.ttenbn.Size = new System.Drawing.Size(156, 27);
            this.ttenbn.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(139, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã hóa đơn";
            // 
            // tngaylap
            // 
            this.tngaylap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tngaylap.Location = new System.Drawing.Point(591, 204);
            this.tngaylap.Name = "tngaylap";
            this.tngaylap.Size = new System.Drawing.Size(162, 27);
            this.tngaylap.TabIndex = 9;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.mabn,
            this.stenbn,
            this.dngaylap,
            this.chitiet,
            this.remove});
            this.dgv.Location = new System.Drawing.Point(12, 364);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(830, 217);
            this.dgv.TabIndex = 10;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_content);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "iMaHD";
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            this.mahd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mabn
            // 
            this.mabn.DataPropertyName = "iMaBN";
            this.mabn.HeaderText = "Mã bệnh nhân";
            this.mabn.MinimumWidth = 6;
            this.mabn.Name = "mabn";
            this.mabn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stenbn
            // 
            this.stenbn.DataPropertyName = "sHoTenBN";
            this.stenbn.HeaderText = "Tên bệnh nhân";
            this.stenbn.MinimumWidth = 6;
            this.stenbn.Name = "stenbn";
            this.stenbn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dngaylap
            // 
            this.dngaylap.DataPropertyName = "dNgayLap";
            this.dngaylap.HeaderText = "Ngày lập";
            this.dngaylap.MinimumWidth = 6;
            this.dngaylap.Name = "dngaylap";
            this.dngaylap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chitiet
            // 
            this.chitiet.HeaderText = "Xem chi tiết hóa đơn";
            this.chitiet.MinimumWidth = 6;
            this.chitiet.Name = "chitiet";
            this.chitiet.Text = "Chi tiết";
            this.chitiet.UseColumnTextForButtonValue = true;
            // 
            // remove
            // 
            this.remove.HeaderText = "Xóa";
            this.remove.MinimumWidth = 6;
            this.remove.Name = "remove";
            this.remove.Text = "Xóa";
            this.remove.UseColumnTextForButtonValue = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 752);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tngaylap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ttenbn);
            this.Controls.Add(this.tmabn);
            this.Controls.Add(this.tmahd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tmahd;
        private System.Windows.Forms.TextBox tmabn;
        private System.Windows.Forms.TextBox ttenbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tngaylap;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stenbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dngaylap;
        private System.Windows.Forms.DataGridViewButtonColumn chitiet;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
    }
}