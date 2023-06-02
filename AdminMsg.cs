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
    public partial class AdminMsg : Form
    {
        public AdminMsg()
        {
            InitializeComponent();
            ShowMessage();
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
                string userID = dc[1].ToString();
                string userName = dc[2].ToString();
                string phone = dc[3].ToString();
                string date = dc[5].ToString();
                string content = dc[4].ToString();
                         

                MessageDataGrid.Rows.Add(id,userID,userName,phone,date,content);
            }

            dc.Close();
            dao.DaoClose();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id =(int)MessageDataGrid.SelectedRows[0].Cells[0].Value;
            }
            catch
            {
                MessageBox.Show("请先从留言列表中选中想要删除的留言！");
                return;
            }
            DialogResult dr = MessageBox.Show("确认删除？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                Dao dao = new Dao();
                string sql = $"Delete from t_board where MessageID={id}";

                if (dao.Excute(sql) > 0)
                {
                    MessageBox.Show("删除留言成功！");
                    ShowMessage();
                    MessageText.Text = "";
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                dao.DaoClose();
            }
        }

        private void MessageDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageText.Text = MessageDataGrid.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
