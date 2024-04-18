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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Quản lý bệnh nhân");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Quản lý bác sĩ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý phòng khám");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quản lý thuốc");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Quản lý dịch vụ");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quản lý hóa đơn");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Quản lý tài khoản");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Đăng xuất");
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
            treeNode1.Name = "n1_qlbn";
            treeNode1.Text = "Quản lý bệnh nhân";
            treeNode2.Name = "n2_qlbs";
            treeNode2.Text = "Quản lý bác sĩ";
            treeNode3.Name = "n3_qlpk";
            treeNode3.Text = "Quản lý phòng khám";
            treeNode4.Name = "n4_qlthuoc";
            treeNode4.Text = "Quản lý thuốc";
            treeNode5.Name = "n5_qldv";
            treeNode5.Text = "Quản lý dịch vụ";
            treeNode6.Name = "n6_qlhd";
            treeNode6.Text = "Quản lý hóa đơn";
            treeNode7.Name = "n7_qltk";
            treeNode7.Text = "Quản lý tài khoản";
            treeNode8.Name = "n6_dx";
            treeNode8.Text = "Đăng xuất";
            this.tvql.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
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
            this.ClientSize = new System.Drawing.Size(1120, 738);
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