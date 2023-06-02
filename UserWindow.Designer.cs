namespace BookMS
{
    partial class UserWindow
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
            this.ShowButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ViewBookedButton = new System.Windows.Forms.Button();
            this.ViewBorrowButton = new System.Windows.Forms.Button();
            this.BorrowDataGrid = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelResButton = new System.Windows.Forms.Button();
            this.FindPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.FindPanel.Location = new System.Drawing.Point(468, 222);
            this.FindPanel.Name = "FindPanel";
            this.FindPanel.Size = new System.Drawing.Size(291, 216);
            this.FindPanel.TabIndex = 14;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(87, 176);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(103, 36);
            this.findBtn.TabIndex = 8;
            this.findBtn.Text = "查询";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "出版日期";
            // 
            // findTextDate
            // 
            this.findTextDate.Location = new System.Drawing.Point(87, 149);
            this.findTextDate.Name = "findTextDate";
            this.findTextDate.Size = new System.Drawing.Size(144, 21);
            this.findTextDate.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "书籍作者";
            // 
            // findTextAuthor
            // 
            this.findTextAuthor.Location = new System.Drawing.Point(87, 104);
            this.findTextAuthor.Name = "findTextAuthor";
            this.findTextAuthor.Size = new System.Drawing.Size(144, 21);
            this.findTextAuthor.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "书籍名称";
            // 
            // findTextName
            // 
            this.findTextName.Location = new System.Drawing.Point(87, 61);
            this.findTextName.Name = "findTextName";
            this.findTextName.Size = new System.Drawing.Size(144, 21);
            this.findTextName.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "书籍ISBN";
            // 
            // findTextISBN
            // 
            this.findTextISBN.Location = new System.Drawing.Point(87, 20);
            this.findTextISBN.Name = "findTextISBN";
            this.findTextISBN.Size = new System.Drawing.Size(144, 21);
            this.findTextISBN.TabIndex = 0;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(635, 12);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(124, 45);
            this.ShowButton.TabIndex = 13;
            this.ShowButton.Text = "显示所有图书";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(464, 12);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(124, 45);
            this.FindButton.TabIndex = 12;
            this.FindButton.Text = "查询图书";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // BorrowButton
            // 
            this.BorrowButton.Location = new System.Drawing.Point(464, 63);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(124, 45);
            this.BorrowButton.TabIndex = 15;
            this.BorrowButton.Text = "借阅图书";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.Location = new System.Drawing.Point(635, 63);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(124, 45);
            this.ReservationButton.TabIndex = 16;
            this.ReservationButton.Text = "预定图书";
            this.ReservationButton.UseVisualStyleBackColor = true;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(464, 171);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(124, 45);
            this.ReturnButton.TabIndex = 17;
            this.ReturnButton.Text = "归还图书";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ViewBookedButton
            // 
            this.ViewBookedButton.Location = new System.Drawing.Point(635, 114);
            this.ViewBookedButton.Name = "ViewBookedButton";
            this.ViewBookedButton.Size = new System.Drawing.Size(124, 45);
            this.ViewBookedButton.TabIndex = 18;
            this.ViewBookedButton.Text = "查看已预定图书";
            this.ViewBookedButton.UseVisualStyleBackColor = true;
            this.ViewBookedButton.Click += new System.EventHandler(this.ViewBookedButton_Click);
            // 
            // ViewBorrowButton
            // 
            this.ViewBorrowButton.Location = new System.Drawing.Point(464, 114);
            this.ViewBorrowButton.Name = "ViewBorrowButton";
            this.ViewBorrowButton.Size = new System.Drawing.Size(124, 45);
            this.ViewBorrowButton.TabIndex = 19;
            this.ViewBorrowButton.Text = "查看已借阅图书";
            this.ViewBorrowButton.UseVisualStyleBackColor = true;
            this.ViewBorrowButton.Click += new System.EventHandler(this.ViewBorrowButton_Click);
            // 
            // BorrowDataGrid
            // 
            this.BorrowDataGrid.AllowUserToAddRows = false;
            this.BorrowDataGrid.AllowUserToDeleteRows = false;
            this.BorrowDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorrowDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.BorrowDataGrid.Location = new System.Drawing.Point(0, 0);
            this.BorrowDataGrid.MultiSelect = false;
            this.BorrowDataGrid.Name = "BorrowDataGrid";
            this.BorrowDataGrid.RowHeadersVisible = false;
            this.BorrowDataGrid.RowTemplate.Height = 23;
            this.BorrowDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorrowDataGrid.Size = new System.Drawing.Size(403, 450);
            this.BorrowDataGrid.TabIndex = 20;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "借阅书籍ISBN";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "借阅书籍名称";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "借阅时间";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "应归还时间";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "逾期时长";
            this.Column10.Name = "Column10";
            // 
            // AppointmentGrid
            // 
            this.ReservationGrid.AllowUserToAddRows = false;
            this.ReservationGrid.AllowUserToDeleteRows = false;
            this.ReservationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReservationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column11});
            this.ReservationGrid.Location = new System.Drawing.Point(0, 0);
            this.ReservationGrid.MultiSelect = false;
            this.ReservationGrid.Name = "AppointmentGrid";
            this.ReservationGrid.RowHeadersVisible = false;
            this.ReservationGrid.RowTemplate.Height = 23;
            this.ReservationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationGrid.Size = new System.Drawing.Size(403, 450);
            this.ReservationGrid.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "预约书籍ISBN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "预约书籍名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "预约时间";
            this.Column11.Name = "Column11";
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
            this.bookDataGrid.MultiSelect = false;
            this.bookDataGrid.Name = "bookDataGrid";
            this.bookDataGrid.RowHeadersVisible = false;
            this.bookDataGrid.RowTemplate.Height = 23;
            this.bookDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDataGrid.Size = new System.Drawing.Size(403, 450);
            this.bookDataGrid.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ISBN";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "书名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "作者";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出版日期";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "库存数量";
            this.Column5.Name = "Column5";
            // 
            // CancelResButton
            // 
            this.CancelResButton.Location = new System.Drawing.Point(635, 171);
            this.CancelResButton.Name = "CancelResButton";
            this.CancelResButton.Size = new System.Drawing.Size(124, 45);
            this.CancelResButton.TabIndex = 23;
            this.CancelResButton.Text = "取消预定";
            this.CancelResButton.UseVisualStyleBackColor = true;
            this.CancelResButton.Click += new System.EventHandler(this.CancelResButton_Click);
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelResButton);
            this.Controls.Add(this.bookDataGrid);
            this.Controls.Add(this.ReservationGrid);
            this.Controls.Add(this.BorrowDataGrid);
            this.Controls.Add(this.ViewBorrowButton);
            this.Controls.Add(this.ViewBookedButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ReservationButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.FindPanel);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.FindButton);
            this.Name = "UserWindow";
            this.Text = "UserWindow";
            this.FindPanel.ResumeLayout(false);
            this.FindPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Button ReservationButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button ViewBookedButton;
        private System.Windows.Forms.Button ViewBorrowButton;
        private System.Windows.Forms.DataGridView BorrowDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridView ReservationGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridView bookDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button CancelResButton;
    }
}