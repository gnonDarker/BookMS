namespace BookMS
{
    partial class UserMsg
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
            this.MessageDataGrid = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.ChageButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MessageDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageDataGrid
            // 
            this.MessageDataGrid.AllowUserToAddRows = false;
            this.MessageDataGrid.AllowUserToDeleteRows = false;
            this.MessageDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MessageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessageDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.MessageDataGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.MessageDataGrid.Location = new System.Drawing.Point(0, 0);
            this.MessageDataGrid.MultiSelect = false;
            this.MessageDataGrid.Name = "MessageDataGrid";
            this.MessageDataGrid.RowHeadersVisible = false;
            this.MessageDataGrid.RowHeadersWidth = 51;
            this.MessageDataGrid.RowTemplate.Height = 23;
            this.MessageDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MessageDataGrid.Size = new System.Drawing.Size(290, 450);
            this.MessageDataGrid.TabIndex = 2;
            this.MessageDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MessageDataGrid_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "留言ID";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "留言时间";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "留言内容";
            this.Column2.Name = "Column2";
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(306, 12);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(482, 318);
            this.MessageText.TabIndex = 3;
            // 
            // ChageButton
            // 
            this.ChageButton.Location = new System.Drawing.Point(479, 360);
            this.ChageButton.Name = "ChageButton";
            this.ChageButton.Size = new System.Drawing.Size(137, 47);
            this.ChageButton.TabIndex = 4;
            this.ChageButton.Text = "修改留言";
            this.ChageButton.UseVisualStyleBackColor = true;
            this.ChageButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(306, 360);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(137, 47);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "删除留言";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(651, 360);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(137, 47);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "新增留言";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // UserMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChageButton);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.MessageDataGrid);
            this.Name = "UserMsg";
            this.Text = "用户留言板";
            ((System.ComponentModel.ISupportInitialize)(this.MessageDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MessageDataGrid;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button ChageButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button SendButton;
    }
}