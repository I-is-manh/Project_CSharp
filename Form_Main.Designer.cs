namespace Project_CSharp
{
    partial class Form_Main
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
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Thêm bệnh nhân");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Quản lý bệnh nhân", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Quản lý nhân viên");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Quản lý phòng khám");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Quản lý thuốc");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Quản lý dịch vụ");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Quản lý tài khoản");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Đăng xuất");
            this.tvql = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvql
            // 
            this.tvql.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tvql.FullRowSelect = true;
            this.tvql.ItemHeight = 55;
            this.tvql.Location = new System.Drawing.Point(12, 155);
            this.tvql.Name = "tvql";
            treeNode25.Name = "qlbn_add";
            treeNode25.Text = "Thêm bệnh nhân";
            treeNode26.Name = "n1_qlbn";
            treeNode26.Text = "Quản lý bệnh nhân";
            treeNode27.Name = "n2_qlbs";
            treeNode27.Text = "Quản lý nhân viên";
            treeNode28.Name = "n3_qlpk";
            treeNode28.Text = "Quản lý phòng khám";
            treeNode29.Name = "n4_qlthuoc";
            treeNode29.Text = "Quản lý thuốc";
            treeNode30.Name = "n5_qldv";
            treeNode30.Text = "Quản lý dịch vụ";
            treeNode31.Name = "n7_qltk";
            treeNode31.Text = "Quản lý tài khoản";
            treeNode32.Name = "n6_dx";
            treeNode32.Text = "Đăng xuất";
            this.tvql.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32});
            this.tvql.ShowLines = false;
            this.tvql.ShowRootLines = false;
            this.tvql.Size = new System.Drawing.Size(244, 579);
            this.tvql.TabIndex = 2;
            this.tvql.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_CSharp.Properties.Resources.behjvien1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.BackgroundImage = global::Project_CSharp.Properties.Resources.behjvien1;
            this.panelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panelForm.Location = new System.Drawing.Point(262, 12);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(852, 722);
            this.panelForm.TabIndex = 3;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 745);
            this.Controls.Add(this.tvql);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TreeView tvql;
    }
}