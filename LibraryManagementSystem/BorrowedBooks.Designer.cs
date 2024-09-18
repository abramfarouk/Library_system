
namespace LibraryManagementSystem
{
    partial class BorrowedBooks
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Borrowed_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookIssue_bookTitle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bookIssue_returnDate = new System.Windows.Forms.DateTimePicker();
            this.bookBorrowed_addBtn = new System.Windows.Forms.Button();
            this.Borrowed_clearBtn = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.borrowed_Address = new System.Windows.Forms.TextBox();
            this.ListName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone :";
            // 
            // Borrowed_phone
            // 
            this.Borrowed_phone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowed_phone.Location = new System.Drawing.Point(100, 60);
            this.Borrowed_phone.Name = "Borrowed_phone";
            this.Borrowed_phone.ReadOnly = true;
            this.Borrowed_phone.Size = new System.Drawing.Size(144, 23);
            this.Borrowed_phone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Book Title:";
            // 
            // bookIssue_bookTitle
            // 
            this.bookIssue_bookTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_bookTitle.FormattingEnabled = true;
            this.bookIssue_bookTitle.Location = new System.Drawing.Point(358, 22);
            this.bookIssue_bookTitle.Name = "bookIssue_bookTitle";
            this.bookIssue_bookTitle.Size = new System.Drawing.Size(137, 24);
            this.bookIssue_bookTitle.TabIndex = 9;
            this.bookIssue_bookTitle.SelectedIndexChanged += new System.EventHandler(this.bookIssue_bookTitle_SelectedIndexChanged);
            this.bookIssue_bookTitle.Click += new System.EventHandler(this.bookIssue_bookTitle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Author:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Return:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookIssue_returnDate
            // 
            this.bookIssue_returnDate.Location = new System.Drawing.Point(630, 18);
            this.bookIssue_returnDate.Name = "bookIssue_returnDate";
            this.bookIssue_returnDate.Size = new System.Drawing.Size(194, 20);
            this.bookIssue_returnDate.TabIndex = 16;
            // 
            // bookBorrowed_addBtn
            // 
            this.bookBorrowed_addBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.bookBorrowed_addBtn.FlatAppearance.BorderSize = 0;
            this.bookBorrowed_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.bookBorrowed_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.bookBorrowed_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.bookBorrowed_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBorrowed_addBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBorrowed_addBtn.ForeColor = System.Drawing.Color.White;
            this.bookBorrowed_addBtn.Location = new System.Drawing.Point(39, 146);
            this.bookBorrowed_addBtn.Name = "bookBorrowed_addBtn";
            this.bookBorrowed_addBtn.Size = new System.Drawing.Size(225, 45);
            this.bookBorrowed_addBtn.TabIndex = 17;
            this.bookBorrowed_addBtn.Text = "ADD";
            this.bookBorrowed_addBtn.UseVisualStyleBackColor = false;
            this.bookBorrowed_addBtn.Click += new System.EventHandler(this.bookBorrowed_addBtn_Click);
            // 
            // Borrowed_clearBtn
            // 
            this.Borrowed_clearBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Borrowed_clearBtn.FlatAppearance.BorderSize = 0;
            this.Borrowed_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Borrowed_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Borrowed_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Borrowed_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrowed_clearBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowed_clearBtn.ForeColor = System.Drawing.Color.White;
            this.Borrowed_clearBtn.Location = new System.Drawing.Point(544, 146);
            this.Borrowed_clearBtn.Name = "Borrowed_clearBtn";
            this.Borrowed_clearBtn.Size = new System.Drawing.Size(247, 45);
            this.Borrowed_clearBtn.TabIndex = 20;
            this.Borrowed_clearBtn.Text = "CLEAR";
            this.Borrowed_clearBtn.UseVisualStyleBackColor = false;
            this.Borrowed_clearBtn.Click += new System.EventHandler(this.Borrowed_clearBtn_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(358, 63);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(145, 23);
            this.txtAuthor.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address:";
            // 
            // borrowed_Address
            // 
            this.borrowed_Address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowed_Address.Location = new System.Drawing.Point(100, 102);
            this.borrowed_Address.Name = "borrowed_Address";
            this.borrowed_Address.ReadOnly = true;
            this.borrowed_Address.Size = new System.Drawing.Size(145, 23);
            this.borrowed_Address.TabIndex = 23;
            // 
            // ListName
            // 
            this.ListName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListName.FormattingEnabled = true;
            this.ListName.Location = new System.Drawing.Point(100, 22);
            this.ListName.Name = "ListName";
            this.ListName.Size = new System.Drawing.Size(137, 24);
            this.ListName.TabIndex = 24;
            this.ListName.SelectedIndexChanged += new System.EventHandler(this.ListName_SelectedIndexChanged);
            this.ListName.Click += new System.EventHandler(this.ListName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ListName);
            this.panel1.Controls.Add(this.borrowed_Address);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.Borrowed_clearBtn);
            this.panel1.Controls.Add(this.bookBorrowed_addBtn);
            this.panel1.Controls.Add(this.bookIssue_returnDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bookIssue_bookTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Borrowed_phone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(18, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 206);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Issued Books";
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
            this.dataGridView11.Location = new System.Drawing.Point(21, 55);
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
            this.dataGridView11.Size = new System.Drawing.Size(803, 237);
            this.dataGridView11.TabIndex = 2;
            this.dataGridView11.Click += new System.EventHandler(this.dataGridView11_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView11);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(18, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 314);
            this.panel2.TabIndex = 1;
            // 
            // BorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BorrowedBooks";
            this.Size = new System.Drawing.Size(880, 565);
            this.Load += new System.EventHandler(this.BorrowedBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Borrowed_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox bookIssue_bookTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker bookIssue_returnDate;
        private System.Windows.Forms.Button bookBorrowed_addBtn;
        private System.Windows.Forms.Button Borrowed_clearBtn;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox borrowed_Address;
        private System.Windows.Forms.ComboBox ListName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.Panel panel2;
    }
}
