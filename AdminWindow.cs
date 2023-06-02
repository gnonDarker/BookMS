using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMS
{
    public partial class AdminWindow : Form
    {
        string NowISBN = "";
        Panel nowPanel;

        public AdminWindow()
        {
            InitializeComponent();
            ShowInfo();
            InitPanle();
        }

        private void InitPanle()
        {
            AddBookPanel.Hide();
            ModifyPanel.Hide();
            FindPanel.Hide();
        }
        private void UpdatePanel(Panel panel)
        {
            if (nowPanel != null&&nowPanel!=panel) nowPanel.Visible=false;
            nowPanel = panel;
        }

        public void ShowInfo()
        {
            bookDataGrid.Rows.Clear();

            Dao dao = new Dao();
            string sql = "Select * from t_book";
            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                string ISBN = dc[0].ToString();
                string name = dc[1].ToString();
                string author = dc[2].ToString();
                string date = dc[3].ToString();
                int bookNum = (int)dc[4];

                bookDataGrid.Rows.Add(ISBN, name, author, date,bookNum);
            }

            dc.Close();
            dao.DaoClose();
        }

        private void bookDataPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
                AddBookPanel.Visible = !AddBookPanel.Visible;
                if(AddBookPanel.Visible) UpdatePanel(AddBookPanel);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ISBNtextBox.Text == "" || nameTextBox.Text == "" || authorTextBox.Text == "" || dateTextBox.Text == ""||bookNumTextBox.Text=="")
            {
                MessageBox.Show("书籍信息项不可为空！");
                return;
            }

            Dao dao = new Dao();
            string sql = $"insert into t_book values('{ISBNtextBox.Text}','{nameTextBox.Text}','{authorTextBox.Text}','{dateTextBox.Text}',{bookNumTextBox.Text})";
            int n = dao.Excute(sql);

            if (n > 0)
            {
                MessageBox.Show("添加成功！");
                ISBNtextBox.Text = "";
                nameTextBox.Text = "";
                authorTextBox.Text = "";
                dateTextBox.Text = "";
                bookNumTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("添加失败！");
            }

            ShowInfo();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ModifyPanel.Visible = !ModifyPanel.Visible;

            if (ModifyPanel.Visible)
            {
                UpdatePanel(ModifyPanel);

                try
                {
                    var book = bookDataGrid.SelectedRows[0];

                    modifyTextISBN.Text = book.Cells[0].Value.ToString();
                    NowISBN = book.Cells[0].Value.ToString();
                    modifyTextName.Text = book.Cells[1].Value.ToString();
                    modifyTextAuthor.Text = book.Cells[2].Value.ToString();
                    modifyTextDate.Text = book.Cells[3].Value.ToString();
                    modifyBookNumText.Text = book.Cells[4].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("请先选中要修改的图书！");
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ISBN = bookDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除书籍？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_book where ISBN='{ISBN}'";
                    Dao dao = new Dao();
                    if (dao.Excute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        ShowInfo();
                    }
                    else MessageBox.Show("删除失败！");

                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中想要删除的书籍！");
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {        
            if (modifyTextISBN.Text == "" || modifyTextName.Text == "" || modifyTextAuthor.Text == "" || modifyTextDate.Text == "")
            {
                MessageBox.Show("修改信息项不能为空！");
                return;
            }
            string sql = $"update t_book set ISBN='{modifyTextISBN.Text}',Name='{modifyTextName.Text}',Author='{modifyTextAuthor.Text}',PublicationDate='{modifyTextDate.Text}',BookNum={modifyBookNumText.Text} where ISBN='{NowISBN}'";
            Dao dao = new Dao();
            if (dao.Excute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                ModifyPanel.Hide();

                ShowInfo();
            }
            else MessageBox.Show("修改失败！");
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FindPanel.Visible = !FindPanel.Visible;
            if(FindPanel.Visible) UpdatePanel(FindPanel);
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            int conditionNum = 0;
            if (findTextAuthor.Text == "" && findTextDate.Text == "" && findTextISBN.Text == "" && findTextName.Text == "")
            {
                MessageBox.Show("不可以所有查询项都为空！");
            }
            else
            {
                string sql = "select * from t_book where";
                if (findTextAuthor.Text != "")
                {
                    if (conditionNum != 0) sql += " and";
                    sql += $" Author='{findTextAuthor.Text}'";
                    conditionNum++;
                }
                if (findTextDate.Text != "")
                {
                    if (conditionNum != 0) sql += " and";
                    sql += $" PublicationDate='{findTextDate.Text}'";
                    conditionNum++;
                }
                if (findTextISBN.Text != "")
                {
                    if (conditionNum != 0) sql += " and";
                    sql += $" ISBN='{findTextISBN.Text}'";
                    conditionNum ++;
                }
                if (findTextName.Text != "")
                {
                    if (conditionNum != 0) sql += " and";
                    sql += $" Name='{findTextName.Text}'";
                    conditionNum++;
                }

                Dao dao = new Dao();
                IDataReader dc = dao.read(sql);
                bookDataGrid.Rows.Clear();
                while (dc.Read())
                {
                    string ISBN = dc[0].ToString();
                    string name = dc[1].ToString();
                    string author = dc[2].ToString();
                    string date = dc[3].ToString();
                    int bookNum = (int)dc[4];

                    bookDataGrid.Rows.Add(ISBN, name, author, date,bookNum);
                }

                dc.Close();
                dao.DaoClose();
            }
        }

        private void ModifyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            AdminMsg t = new AdminMsg();
            t.ShowDialog();
        }
    }
}