
namespace LibraryManagementSystem
{
    partial class ReturnBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Resert_Page = new System.Windows.Forms.Button();
            this.btn_GetAllReturned = new System.Windows.Forms.Button();
            this.textBook = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.borrowed_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Borrowed_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnBooks_clearBtn = new System.Windows.Forms.Button();
            this.returnBooks_returnBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.lblChangeTxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Resert_Page);
            this.panel1.Controls.Add(this.btn_GetAllReturned);
            this.panel1.Controls.Add(this.textBook);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.borrowed_Address);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Borrowed_phone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.returnBooks_clearBtn);
            this.panel1.Controls.Add(this.returnBooks_returnBtn);
            this.panel1.Location = new System.Drawing.Point(13, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 526);
            this.panel1.TabIndex = 0;
            // 
            // Resert_Page
            // 
            this.Resert_Page.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Resert_Page.FlatAppearance.BorderSize = 0;
            this.Resert_Page.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Resert_Page.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Resert_Page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resert_Page.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resert_Page.ForeColor = System.Drawing.Color.White;
            this.Resert_Page.Location = new System.Drawing.Point(21, 375);
            this.Resert_Page.Name = "Resert_Page";
            this.Resert_Page.Size = new System.Drawing.Size(240, 34);
            this.Resert_Page.TabIndex = 40;
            this.Resert_Page.Text = "Reset";
            this.Resert_Page.UseVisualStyleBackColor = false;
            this.Resert_Page.Click += new System.EventHandler(this.Resert_Page_Click);
            // 
            // btn_GetAllReturned
            // 
            this.btn_GetAllReturned.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_GetAllReturned.FlatAppearance.BorderSize = 0;
            this.btn_GetAllReturned.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_GetAllReturned.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_GetAllReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetAllReturned.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetAllReturned.ForeColor = System.Drawing.Color.White;
            this.btn_GetAllReturned.Location = new System.Drawing.Point(21, 323);
            this.btn_GetAllReturned.Name = "btn_GetAllReturned";
            this.btn_GetAllReturned.Size = new System.Drawing.Size(240, 34);
            this.btn_GetAllReturned.TabIndex = 39;
            this.btn_GetAllReturned.Text = "GetAllReturned";
            this.btn_GetAllReturned.UseVisualStyleBackColor = false;
            this.btn_GetAllReturned.Click += new System.EventHandler(this.btn_GetAllReturned_Click);
            // 
            // textBook
            // 
            this.textBook.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBook.Location = new System.Drawing.Point(111, 139);
            this.textBook.Name = "textBook";
            this.textBook.ReadOnly = true;
            this.textBook.Size = new System.Drawing.Size(150, 23);
            this.textBook.TabIndex = 38;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(111, 13);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(150, 23);
            this.textName.TabIndex = 37;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(111, 180);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(150, 23);
            this.txtAuthor.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Author:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Book Title:";
            // 
            // borrowed_Address
            // 
            this.borrowed_Address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowed_Address.Location = new System.Drawing.Point(111, 100);
            this.borrowed_Address.Name = "borrowed_Address";
            this.borrowed_Address.ReadOnly = true;
            this.borrowed_Address.Size = new System.Drawing.Size(150, 23);
            this.borrowed_Address.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address:";
            // 
            // Borrowed_phone
            // 
            this.Borrowed_phone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowed_phone.Location = new System.Drawing.Point(111, 58);
            this.Borrowed_phone.Name = "Borrowed_phone";
            this.Borrowed_phone.ReadOnly = true;
            this.Borrowed_phone.Size = new System.Drawing.Size(150, 23);
            this.Borrowed_phone.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name:";
            // 
            // returnBooks_clearBtn
            // 
            this.returnBooks_clearBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.returnBooks_clearBtn.FlatAppearance.BorderSize = 0;
            this.returnBooks_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.returnBooks_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.returnBooks_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_clearBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_clearBtn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_clearBtn.Location = new System.Drawing.Point(20, 430);
            this.returnBooks_clearBtn.Name = "returnBooks_clearBtn";
            this.returnBooks_clearBtn.Size = new System.Drawing.Size(240, 34);
            this.returnBooks_clearBtn.TabIndex = 16;
            this.returnBooks_clearBtn.Text = "Clear";
            this.returnBooks_clearBtn.UseVisualStyleBackColor = false;
            this.returnBooks_clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // returnBooks_returnBtn
            // 
            this.returnBooks_returnBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.returnBooks_returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBooks_returnBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.returnBooks_returnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.returnBooks_returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_returnBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_returnBtn.Location = new System.Drawing.Point(21, 268);
            this.returnBooks_returnBtn.Name = "returnBooks_returnBtn";
            this.returnBooks_returnBtn.Size = new System.Drawing.Size(240, 34);
            this.returnBooks_returnBtn.TabIndex = 15;
            this.returnBooks_returnBtn.Text = "Return";
            this.returnBooks_returnBtn.UseVisualStyleBackColor = false;
            this.returnBooks_returnBtn.Click += new System.EventHandler(this.returnBooks_returnBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView11);
            this.panel2.Controls.Add(this.lblChangeTxt);
            this.panel2.Location = new System.Drawing.Point(312, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 526);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView11
            // 
            this.dataGridView11.AllowUserToAddRows = false;
            this.dataGridView11.AllowUserToDeleteRows = false;
            this.dataGridView11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView11.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView11.ColumnHeadersHeight = 29;
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView11.EnableHeadersVisualStyles = false;
            this.dataGridView11.Location = new System.Drawing.Point(19, 60);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView11.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView11.RowHeadersVisible = false;
            this.dataGridView11.RowHeadersWidth = 51;
            this.dataGridView11.Size = new System.Drawing.Size(515, 445);
            this.dataGridView11.TabIndex = 3;
            this.dataGridView11.Click += new System.EventHandler(this.dataGridView11_Click);
            // 
            // lblChangeTxt
            // 
            this.lblChangeTxt.AutoSize = true;
            this.lblChangeTxt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTxt.Location = new System.Drawing.Point(15, 18);
            this.lblChangeTxt.Name = "lblChangeTxt";
            this.lblChangeTxt.Size = new System.Drawing.Size(169, 23);
            this.lblChangeTxt.TabIndex = 0;
            this.lblChangeTxt.Text = "All Borrowed Books";
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReturnBooks";
            this.Size = new System.Drawing.Size(880, 565);
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblChangeTxt;
        private System.Windows.Forms.Button returnBooks_clearBtn;
        private System.Windows.Forms.Button returnBooks_returnBtn;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.TextBox borrowed_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Borrowed_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBook;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btn_GetAllReturned;
        private System.Windows.Forms.Button Resert_Page;
    }
}
