
namespace LibraryManagementSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pn_top = new System.Windows.Forms.Panel();
            this.btn_Max = new DevExpress.XtraEditors.SimpleButton();
            this.btn_min = new DevExpress.XtraEditors.SimpleButton();
            this.bn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.lblChange = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_account = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.returnBooks_btn = new System.Windows.Forms.Button();
            this.Borrowed_Btn = new System.Windows.Forms.Button();
            this.addBooks_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pn_top.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pn_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_top.Controls.Add(this.btn_Max);
            this.pn_top.Controls.Add(this.btn_min);
            this.pn_top.Controls.Add(this.bn_Close);
            this.pn_top.Controls.Add(this.lblChange);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(225, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(919, 41);
            this.pn_top.TabIndex = 0;
            // 
            // btn_Max
            // 
            this.btn_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Max.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Max.Appearance.Options.UseFont = true;
            this.btn_Max.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Max.ImageOptions.SvgImage")));
            this.btn_Max.Location = new System.Drawing.Point(814, 0);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Max.Size = new System.Drawing.Size(43, 31);
            this.btn_Max.TabIndex = 4;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.ImageOptions.Image")));
            this.btn_min.Location = new System.Drawing.Point(765, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_min.Size = new System.Drawing.Size(43, 31);
            this.btn_min.TabIndex = 3;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // bn_Close
            // 
            this.bn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bn_Close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bn_Close.ImageOptions.Image")));
            this.bn_Close.Location = new System.Drawing.Point(863, 0);
            this.bn_Close.Name = "bn_Close";
            this.bn_Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bn_Close.Size = new System.Drawing.Size(43, 31);
            this.bn_Close.TabIndex = 2;
            this.bn_Close.Click += new System.EventHandler(this.bn_Close_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.White;
            this.lblChange.Location = new System.Drawing.Point(13, 9);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(281, 18);
            this.lblChange.TabIndex = 1;
            this.lblChange.Text = "Library Management System | Main Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Add_account);
            this.panel2.Controls.Add(this.btnAddPerson);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.returnBooks_btn);
            this.panel2.Controls.Add(this.Borrowed_Btn);
            this.panel2.Controls.Add(this.addBooks_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 619);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Add_account
            // 
            this.Add_account.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Add_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_account.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Add_account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Add_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_account.ForeColor = System.Drawing.Color.White;
            this.Add_account.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_32px_3;
            this.Add_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_account.Location = new System.Drawing.Point(8, 450);
            this.Add_account.Name = "Add_account";
            this.Add_account.Size = new System.Drawing.Size(200, 45);
            this.Add_account.TabIndex = 10;
            this.Add_account.Text = "AddAccount";
            this.Add_account.UseVisualStyleBackColor = true;
            this.Add_account.Visible = false;
            this.Add_account.Click += new System.EventHandler(this.Add_account_Click_1);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px;
            this.btnAddPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPerson.Location = new System.Drawing.Point(8, 297);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(200, 45);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.Text = "AddPerson";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Log out";
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_20px;
            this.logout_btn.Location = new System.Drawing.Point(8, 554);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(35, 35);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // returnBooks_btn
            // 
            this.returnBooks_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.returnBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.returnBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.returnBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_btn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_32px_3;
            this.returnBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBooks_btn.Location = new System.Drawing.Point(8, 399);
            this.returnBooks_btn.Name = "returnBooks_btn";
            this.returnBooks_btn.Size = new System.Drawing.Size(200, 45);
            this.returnBooks_btn.TabIndex = 5;
            this.returnBooks_btn.Text = "ReturnBooks";
            this.returnBooks_btn.UseVisualStyleBackColor = true;
            this.returnBooks_btn.Click += new System.EventHandler(this.returnBooks_btn_Click);
            // 
            // Borrowed_Btn
            // 
            this.Borrowed_Btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Borrowed_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Borrowed_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Borrowed_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Borrowed_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrowed_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowed_Btn.ForeColor = System.Drawing.Color.White;
            this.Borrowed_Btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px_1;
            this.Borrowed_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrowed_Btn.Location = new System.Drawing.Point(8, 348);
            this.Borrowed_Btn.Name = "Borrowed_Btn";
            this.Borrowed_Btn.Size = new System.Drawing.Size(200, 45);
            this.Borrowed_Btn.TabIndex = 4;
            this.Borrowed_Btn.Text = "BorrowedBooks";
            this.Borrowed_Btn.UseVisualStyleBackColor = true;
            this.Borrowed_Btn.Click += new System.EventHandler(this.Borrowed_Btn_Click);
            // 
            // addBooks_btn
            // 
            this.addBooks_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_btn.ForeColor = System.Drawing.Color.White;
            this.addBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px;
            this.addBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBooks_btn.Location = new System.Drawing.Point(8, 246);
            this.addBooks_btn.Name = "addBooks_btn";
            this.addBooks_btn.Size = new System.Drawing.Size(200, 45);
            this.addBooks_btn.TabIndex = 3;
            this.addBooks_btn.Text = "AddBooks";
            this.addBooks_btn.UseVisualStyleBackColor = true;
            this.addBooks_btn.Click += new System.EventHandler(this.addBooks_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dashboard_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_dashboard_32px;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(8, 195);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(200, 45);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(41, 131);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(130, 19);
            this.greet_label.TabIndex = 1;
            this.greet_label.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_Container
            // 
            this.pn_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Container.BackColor = System.Drawing.Color.White;
            this.pn_Container.Location = new System.Drawing.Point(231, 47);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(901, 560);
            this.pn_Container.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 619);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pn_top.ResumeLayout(false);
            this.pn_top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBooks_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button returnBooks_btn;
        private System.Windows.Forms.Button Borrowed_Btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn_Container;
        private DevExpress.XtraEditors.SimpleButton bn_Close;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button Add_account;
        private DevExpress.XtraEditors.SimpleButton btn_Max;
        private DevExpress.XtraEditors.SimpleButton btn_min;
    }
}