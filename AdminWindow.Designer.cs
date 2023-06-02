namespace BookMS
{
    partial class AdminWindow
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
            this.bookDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddBookPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.bookNumTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ModifyPanel = new System.Windows.Forms.Panel();
            this.bookNum = new System.Windows.Forms.Label();
            this.modifyBookNumText = new System.Windows.Forms.TextBox();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.modifyTextDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modifyTextAuthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.modifyTextName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modifyTextISBN = new System.Windows.Forms.TextBox();
            this.FindPanel = new System.Windows.Forms.Panel();
            this.findBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.findTextDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.findTextAuthor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.findTextName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.findTextISBN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).BeginInit();
            this.AddBookPanel.SuspendLayout();
            this.ModifyPanel.SuspendLayout();
            this.FindPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookDataGrid
            // 
            this.bookDataGrid.AllowUserToAddRows = false;
            this.bookDataGrid.AllowUserToDeleteRows = false;
            this.bookDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.bookDataGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookDataGrid.Location = new System.Drawing.Point(0, 0);
            this.bookDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.bookDataGrid.MultiSelect = false;
            this.bookDataGrid.Name = "bookDataGrid";
            this.bookDataGrid.RowHeadersVisible = false;
            this.bookDataGrid.RowHeadersWidth = 51;
            this.bookDataGrid.RowTemplate.Height = 23;
            this.bookDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDataGrid.Size = new System.Drawing.Size(537, 562);
            this.bookDataGrid.TabIndex = 1;
            this.bookDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataPanel_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ISBN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "书名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "作者";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出版日期";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "库存数量";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(599, 15);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(165, 56);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "添加图书";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(821, 15);
            this.ModifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(165, 56);
            this.ModifyButton.TabIndex = 3;
            this.ModifyButton.Text = "修改图书";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(599, 79);
            this.FindButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(165, 56);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "查询图书";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(821, 79);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(165, 56);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "删除图书";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddBookPanel
            // 
            this.AddBookPanel.Controls.Add(this.label13);
            this.AddBookPanel.Controls.Add(this.bookNumTextBox);
            this.AddBookPanel.Controls.Add(this.addBtn);
            this.AddBookPanel.Controls.Add(this.label4);
            this.AddBookPanel.Controls.Add(this.dateTextBox);
            this.AddBookPanel.Controls.Add(this.label3);
            this.AddBookPanel.Controls.Add(this.authorTextBox);
            this.AddBookPanel.Controls.Add(this.label2);
            this.AddBookPanel.Controls.Add(this.nameTextBox);
            this.AddBookPanel.Controls.Add(this.label1);
            this.AddBookPanel.Controls.Add(this.ISBNtextBox);
            this.AddBookPanel.Location = new System.Drawing.Point(599, 229);
            this.AddBookPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddBookPanel.Name = "AddBookPanel";
            this.AddBookPanel.Size = new System.Drawing.Size(388, 319);
            this.AddBookPanel.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 236);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "库存数量";
            // 
            // bookNumTextBox
            // 
            this.bookNumTextBox.Location = new System.Drawing.Point(116, 232);
            this.bookNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookNumTextBox.Name = "bookNumTextBox";
            this.bookNumTextBox.Size = new System.Drawing.Size(191, 25);
            this.bookNumTextBox.TabIndex = 11;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(116, 266);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(137, 45);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "出版日期";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(116, 186);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(191, 25);
            this.dateTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "书籍作者";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(116, 130);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(191, 25);
            this.authorTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "书籍名称";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(116, 76);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(191, 25);
            this.nameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "书籍ISBN";
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(116, 25);
            this.ISBNtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(191, 25);
            this.ISBNtextBox.TabIndex = 0;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(821, 142);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(165, 56);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.Text = "显示所有图书";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ModifyPanel
            // 
            this.ModifyPanel.Controls.Add(this.bookNum);
            this.ModifyPanel.Controls.Add(this.modifyBookNumText);
            this.ModifyPanel.Controls.Add(this.modifyBtn);
            this.ModifyPanel.Controls.Add(this.label5);
            this.ModifyPanel.Controls.Add(this.modifyTextDate);
            this.ModifyPanel.Controls.Add(this.label6);
            this.ModifyPanel.Controls.Add(this.modifyTextAuthor);
            this.ModifyPanel.Controls.Add(this.label7);
            this.ModifyPanel.Controls.Add(this.modifyTextName);
            this.ModifyPanel.Controls.Add(this.label8);
            this.ModifyPanel.Controls.Add(this.modifyTextISBN);
            this.ModifyPanel.Location = new System.Drawing.Point(595, 221);
            this.ModifyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyPanel.Name = "ModifyPanel";
            this.ModifyPanel.Size = new System.Drawing.Size(388, 319);
            this.ModifyPanel.TabIndex = 9;
            this.ModifyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ModifyPanel_Paint);
            // 
            // bookNum
            // 
            this.bookNum.AutoSize = true;
            this.bookNum.Location = new System.Drawing.Point(24, 244);
            this.bookNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookNum.Name = "bookNum";
            this.bookNum.Size = new System.Drawing.Size(67, 15);
            this.bookNum.TabIndex = 10;
            this.bookNum.Text = "库存数量";
            // 
            // modifyBookNumText
            // 
            this.modifyBookNumText.Location = new System.Drawing.Point(116, 236);
            this.modifyBookNumText.Margin = new System.Windows.Forms.Padding(4);
            this.modifyBookNumText.Name = "modifyBookNumText";
            this.modifyBookNumText.Size = new System.Drawing.Size(191, 25);
            this.modifyBookNumText.TabIndex = 9;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(116, 270);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(137, 45);
            this.modifyBtn.TabIndex = 8;
            this.modifyBtn.Text = "修改";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "出版日期";
            // 
            // modifyTextDate
            // 
            this.modifyTextDate.Location = new System.Drawing.Point(116, 186);
            this.modifyTextDate.Margin = new System.Windows.Forms.Padding(4);
            this.modifyTextDate.Name = "modifyTextDate";
            this.modifyTextDate.Size = new System.Drawing.Size(191, 25);
            this.modifyTextDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "书籍作者";
            // 
            // modifyTextAuthor
            // 
            this.modifyTextAuthor.Location = new System.Drawing.Point(116, 130);
            this.modifyTextAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.modifyTextAuthor.Name = "modifyTextAuthor";
            this.modifyTextAuthor.Size = new System.Drawing.Size(191, 25);
            this.modifyTextAuthor.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "书籍名称";
            // 
            // modifyTextName
            // 
            this.modifyTextName.Location = new System.Drawing.Point(116, 76);
            this.modifyTextName.Margin = new System.Windows.Forms.Padding(4);
            this.modifyTextName.Name = "modifyTextName";
            this.modifyTextName.Size = new System.Drawing.Size(191, 25);
            this.modifyTextName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "书籍ISBN";
            // 
            // modifyTextISBN
            // 
            this.modifyTextISBN.Location = new System.Drawing.Point(116, 25);
            this.modifyTextISBN.Margin = new System.Windows.Forms.Padding(4);
            this.modifyTextISBN.Name = "modifyTextISBN";
            this.modifyTextISBN.Size = new System.Drawing.Size(191, 25);
            this.modifyTextISBN.TabIndex = 0;
            // 
            // FindPanel
            // 
            this.FindPanel.Controls.Add(this.findBtn);
            this.FindPanel.Controls.Add(this.label9);
            this.FindPanel.Controls.Add(this.findTextDate);
            this.FindPanel.Controls.Add(this.label10);
            this.FindPanel.Controls.Add(this.findTextAuthor);
            this.FindPanel.Controls.Add(this.label11);
            this.FindPanel.Controls.Add(this.findTextName);
            this.FindPanel.Controls.Add(this.label12);
            this.FindPanel.Controls.Add(this.findTextISBN);
            this.FindPanel.Location = new System.Drawing.Point(591, 218);
            this.FindPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FindPanel.Name = "FindPanel";
            this.FindPanel.Size = new System.Drawing.Size(388, 319);
            this.FindPanel.TabIndex = 10;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(116, 246);
            this.findBtn.Margin = new System.Windows.Forms.Padding(4);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(137, 45);
            this.findBtn.TabIndex = 8;
            this.findBtn.Text = "查询";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "出版日期";
            // 
            // findTextDate
            // 
            this.findTextDate.Location = new System.Drawing.Point(116, 186);
            this.findTextDate.Margin = new System.Windows.Forms.Padding(4);
            this.findTextDate.Name = "findTextDate";
            this.findTextDate.Size = new System.Drawing.Size(191, 25);
            this.findTextDate.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 134);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "书籍作者";
            // 
            // findTextAuthor
            // 
            this.findTextAuthor.Location = new System.Drawing.Point(116, 130);
            this.findTextAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.findTextAuthor.Name = "findTextAuthor";
            this.findTextAuthor.Size = new System.Drawing.Size(191, 25);
            this.findTextAuthor.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "书籍名称";
            // 
            // findTextName
            // 
            this.findTextName.Location = new System.Drawing.Point(116, 76);
            this.findTextName.Margin = new System.Windows.Forms.Padding(4);
            this.findTextName.Name = "findTextName";
            this.findTextName.Size = new System.Drawing.Size(191, 25);
            this.findTextName.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "书籍ISBN";
            // 
            // findTextISBN
            // 
            this.findTextISBN.Location = new System.Drawing.Point(116, 25);
            this.findTextISBN.Margin = new System.Windows.Forms.Padding(4);
            this.findTextISBN.Name = "findTextISBN";
            this.findTextISBN.Size = new System.Drawing.Size(191, 25);
            this.findTextISBN.TabIndex = 0;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.ModifyPanel);
            this.Controls.Add(this.FindPanel);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.AddBookPanel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.bookDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminWindow";
            this.Text = "管理员页面";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).EndInit();
            this.AddBookPanel.ResumeLayout(false);
            this.AddBookPanel.PerformLayout();
            this.ModifyPanel.ResumeLayout(false);
            this.ModifyPanel.PerformLayout();
            this.FindPanel.ResumeLayout(false);
            this.FindPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView bookDataGrid;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel AddBookPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Panel ModifyPanel;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modifyTextDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modifyTextAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modifyTextName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox modifyTextISBN;
        private System.Windows.Forms.Panel FindPanel;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox findTextDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox findTextAuthor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox findTextName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox findTextISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label bookNum;
        private System.Windows.Forms.TextBox bookNumTextBox;
        private System.Windows.Forms.TextBox modifyBookNumText;
        private System.Windows.Forms.Label label13;
    }
}