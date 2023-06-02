namespace BookMS
{
    partial class AdminMsg
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MessageDataGrid = new System.Windows.Forms.DataGridView();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MessageDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(482, 374);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(278, 47);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "删除留言";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MessageDataGrid
            // 
            this.MessageDataGrid.AllowUserToAddRows = false;
            this.MessageDataGrid.AllowUserToDeleteRows = false;
            this.MessageDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MessageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessageDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
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
            this.MessageDataGrid.Size = new System.Drawing.Size(431, 450);
            this.MessageDataGrid.TabIndex = 6;
            this.MessageDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MessageDataGrid_CellContentClick);
            // 
            // MessageText
            // 
            this.MessageText.Enabled = false;
            this.MessageText.Location = new System.Drawing.Point(454, 12);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageText.Size = new System.Drawing.Size(334, 338);
            this.MessageText.TabIndex = 8;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "留言ID";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 70F;
            this.Column5.HeaderText = "留言人账号";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "留言人姓名";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 70F;
            this.Column6.HeaderText = "留言人联系方式";
            this.Column6.Name = "Column6";
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
            // AdminMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MessageDataGrid);
            this.Name = "AdminMsg";
            this.Text = "AdminMsg";
            ((System.ComponentModel.ISupportInitialize)(this.MessageDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView MessageDataGrid;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}