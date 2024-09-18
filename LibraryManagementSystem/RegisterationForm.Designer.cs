namespace LibraryManagementSystem
{
    partial class RegisterationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.signINBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.Register_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Register_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterPassTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Register_showPass = new System.Windows.Forms.CheckBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 38);
            this.panel1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Appearance.BackColor = System.Drawing.Color.Purple;
            this.btn_Close.Appearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_Close.Appearance.Options.UseBackColor = true;
            this.btn_Close.Appearance.Options.UseBorderColor = true;
            this.btn_Close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.ImageOptions.Image")));
            this.btn_Close.Location = new System.Drawing.Point(317, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Close.Size = new System.Drawing.Size(39, 35);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // signINBtn
            // 
            this.signINBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.signINBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signINBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.signINBtn.FlatAppearance.BorderSize = 0;
            this.signINBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.signINBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signINBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signINBtn.ForeColor = System.Drawing.Color.White;
            this.signINBtn.Location = new System.Drawing.Point(12, 482);
            this.signINBtn.Name = "signINBtn";
            this.signINBtn.Size = new System.Drawing.Size(335, 31);
            this.signINBtn.TabIndex = 19;
            this.signINBtn.Text = "SIGNIN";
            this.signINBtn.UseVisualStyleBackColor = false;
            this.signINBtn.Click += new System.EventHandler(this.signINBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Register Account";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(12, 419);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(335, 33);
            this.RegisterBtn.TabIndex = 17;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // Register_Name
            // 
            this.Register_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Name.Location = new System.Drawing.Point(12, 306);
            this.Register_Name.Multiline = true;
            this.Register_Name.Name = "Register_Name";
            this.Register_Name.Size = new System.Drawing.Size(335, 30);
            this.Register_Name.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // Register_Email
            // 
            this.Register_Email.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Email.Location = new System.Drawing.Point(12, 252);
            this.Register_Email.Multiline = true;
            this.Register_Email.Name = "Register_Email";
            this.Register_Email.Size = new System.Drawing.Size(335, 30);
            this.Register_Email.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registration From";
            // 
            // RegisterPassTxt
            // 
            this.RegisterPassTxt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPassTxt.Location = new System.Drawing.Point(12, 357);
            this.RegisterPassTxt.Multiline = true;
            this.RegisterPassTxt.Name = "RegisterPassTxt";
            this.RegisterPassTxt.PasswordChar = '*';
            this.RegisterPassTxt.Size = new System.Drawing.Size(335, 30);
            this.RegisterPassTxt.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email:";
            // 
            // Register_showPass
            // 
            this.Register_showPass.AutoSize = true;
            this.Register_showPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_showPass.Location = new System.Drawing.Point(230, 393);
            this.Register_showPass.Name = "Register_showPass";
            this.Register_showPass.Size = new System.Drawing.Size(117, 20);
            this.Register_showPass.TabIndex = 24;
            this.Register_showPass.Text = "Show Password";
            this.Register_showPass.UseVisualStyleBackColor = true;
            this.Register_showPass.CheckedChanged += new System.EventHandler(this.Register_showPass_CheckedChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // RegisterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 525);
            this.Controls.Add(this.Register_showPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterPassTxt);
            this.Controls.Add(this.signINBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.Register_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Register_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterationForm";
            this.Load += new System.EventHandler(this.RegisterationForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signINBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox Register_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Register_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Register_showPass;
        private System.Windows.Forms.TextBox RegisterPassTxt;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}