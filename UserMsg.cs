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
    public partial class UserMsg : Form
    {
        int messageID;
        public UserMsg()
        {
            InitializeComponent();
            ShowMessage();
            messageID = 0;
        }

        private void ShowMessage()
        {
            MessageDataGrid.Rows.Clear();

            Dao dao = new Dao();
            string sql = "Select * from t_board";
            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                int id = (int)dc[0];
                string date = dc[5].ToString();
                string content = dc[4].ToString();

                MessageDataGrid.Rows.Add(id, date,content);
            }

            dc.Close();
            dao.DaoClose();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (MessageText.Text == "")
            {
                MessageBox.Show("留言内容不可为空！");
            }
            else
            {
                if (messageID != 0)
                {
                    Dao dao = new Dao();

                    string sql = $"update t_board set [Content]='{MessageText.Text}',MessageTime=SYSDATETIME() where MessageID={messageID}";
                    if (dao.Excute(sql) > 0)
                    {
                        MessageBox.Show("修改留言成功！");
                        ShowMessage();
                    }
                    else MessageBox.Show("修改留言失败！");

                    dao.DaoClose();
                }
                else
                {
                    MessageBox.Show("请先选中想要修改的留言！");
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MessageText.Text == "")
            {
                MessageBox.Show("留言内容不可为空！");
            }
            else
            {
                Dao dao = new Dao();
                string sql= $"insert into t_board(UserID,UserName,UserPhone,[Content],MessageTime) values('{Data.UID}','{Data.UName}','{Data.UPhone}','{MessageText.Text}',SYSDATETIME())";

                if (dao.Excute(sql) > 0)
                {
                    MessageBox.Show("新增留言成功！");
                    ShowMessage();
                    MessageText.Text = "";
                }
                else
                {
                    MessageBox.Show("新增留言失败！");
                }
                dao.DaoClose();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (messageID == 0)
            {
                MessageBox.Show("请先选中想要删除的留言！");
                return;
            }
            DialogResult dr = MessageBox.Show("确认删除留言？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                string sql = $"delete from t_board where MessageID={messageID}";
                Dao dao = new Dao();
                if (dao.Excute(sql) > 0)
                {
                    MessageBox.Show("删除成功！");
                    MessageText.Text = "";
                    ShowMessage();
                }
                else MessageBox.Show("删除失败！");

                dao.DaoClose();
            }
        }

        private void MessageDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            messageID=(int)MessageDataGrid.SelectedRows[0].Cells[0].Value;
            MessageText.Text = MessageDataGrid.SelectedRows[0].Cells[2].Value.ToString();
        }
        
    }
}
