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
    public partial class UserWindow : Form
    {
        Panel nowPanel;
        DataGridView nowGrid;

        public UserWindow()
        {
            InitializeComponent();
            ShowInfo();
            InitPanle();
            InitGrid();
        }

        private void UpdatePanel(Panel panel)
        {
            if (nowPanel != null && nowPanel != panel) nowPanel.Visible = false;
            nowPanel = panel;
        }
        private void UpdateGrid(DataGridView grid)
        {
            if (nowGrid != null & nowGrid != grid) nowGrid.Visible = false;
            nowGrid = grid;
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

                bookDataGrid.Rows.Add(ISBN, name, author, date, bookNum);
            }

            dc.Close();
            dao.DaoClose();
        }

        private void InitPanle()
        {           
            FindPanel.Hide();
        }
        private void InitGrid()
        {
            nowGrid = bookDataGrid;
            bookDataGrid.Show();
            BorrowDataGrid.Hide();
            ReservationGrid.Hide();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FindPanel.Visible = !FindPanel.Visible;
            if (FindPanel.Visible)
            {
                UpdatePanel(FindPanel);
                bookDataGrid.Visible = true;
                UpdateGrid(bookDataGrid);
            }
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
                    conditionNum++;
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

                    bookDataGrid.Rows.Add(ISBN, name, author, date);
                }

                dc.Close();
                dao.DaoClose();
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            bookDataGrid.Visible = !bookDataGrid.Visible;
            if (bookDataGrid.Visible)
            {
                UpdateGrid(bookDataGrid);
                ShowInfo();               
            }
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            string ISBN;
            try
            {
                ISBN = bookDataGrid.SelectedRows[0].Cells[0].Value.ToString();          
            }
            catch
            {
                MessageBox.Show("请先选中想要借阅的书籍！");
                return;
            }
            DialogResult dr = MessageBox.Show("确认借阅书籍？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                Dao dao = new Dao();
                string sql = $"select BookNum from t_book where ISBN='{ISBN}'";

                IDataReader dc = dao.read(sql);
                dc.Read();
                if ((int)dc[0] <= 0)
                {
                    MessageBox.Show("该书籍目前没有更多可借阅的库存！");
                    return;
                }

                try
                {
                    sql = $"insert into t_borrow values('{Data.UID}','{ISBN}',SYSDATETIME(),DATEADD(day,30,SYSDATETIME()),0)";
                    if (dao.Excute(sql) > 0)
                    {
                        MessageBox.Show("借阅成功！");

                        sql = $"update t_book set BookNum=BookNum-1 where ISBN='{ISBN}'";
                        if (dao.Excute(sql) <= 0) MessageBox.Show("错误！更新库存失败，请联系管理员");
                    }
                    else
                    {
                        MessageBox.Show("借阅失败！");
                    }

                    dc.Close();
                    dao.DaoClose();
                }
                catch
                {
                    MessageBox.Show("不可重复借阅书籍！");
                }
            }
        }

        private void ViewBorrowButton_Click(object sender, EventArgs e)
        {
            BorrowDataGrid.Visible = !BorrowDataGrid.Visible;
            if (BorrowDataGrid.Visible)
            {
                UpdateGrid(BorrowDataGrid);
                ShowBorrowInfo();
            }
        }
        private void ShowBorrowInfo()
        {
            BorrowDataGrid.Rows.Clear();

            Dao dao = new Dao();
            string sql = $"Select BookISBN,Name,BorrowTime,ReturnTime,OverDue from t_borrow,t_book where t_borrow.BookISBN=t_book.ISBN and BorrowerID={Data.UID}";
            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                string ISBN = dc[0].ToString();
                string name = dc[1].ToString();
                string borrowTime = dc[2].ToString();
                string returnTime = dc[3].ToString();
                int overdue = (int)dc[4];

                BorrowDataGrid.Rows.Add(ISBN, name, borrowTime, returnTime, overdue);
            }

            dc.Close();
            dao.DaoClose();
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            string ISBN;
            try
            {
                ISBN = bookDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("请先从图书列表中选中想要预定的书籍！");
                return;
            }

            DialogResult dr = MessageBox.Show("确认预定书籍？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                Dao dao = new Dao();
                try
                {
                    string sql = $"insert into t_reservation values('{Data.UID}','{ISBN}',SYSDATETIME())";
                    if (dao.Excute(sql) > 0)
                    {
                        MessageBox.Show("预定成功！");
                    }
                    else
                    {
                        MessageBox.Show("预定失败！");
                    }
                }
                catch
                {
                    MessageBox.Show("不可重复预约书籍！");
                }
            }
        }

        private void ViewBookedButton_Click(object sender, EventArgs e)
        {
            ReservationGrid.Visible = !ReservationGrid.Visible;
            if (ReservationGrid.Visible)
            {
                UpdateGrid(ReservationGrid);
                ShowReservationInfo();
            }
        }
        private void ShowReservationInfo()
        {
            ReservationGrid.Rows.Clear();

            Dao dao = new Dao();
            string sql = $"Select BookISBN,Name,ReservationTime from t_reservation,t_book where t_reservation.BookISBN=t_book.ISBN and BorrowerID={Data.UID}";
            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                string ISBN = dc[0].ToString();
                string name = dc[1].ToString();
                string reservationTime = dc[2].ToString();

                ReservationGrid.Rows.Add(ISBN, name, reservationTime);
            }

            dc.Close();
            dao.DaoClose();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            string ISBN;
            try
            {
                ISBN = BorrowDataGrid.SelectedRows[0].Cells[0].Value.ToString();               
            }
            catch
            {
                MessageBox.Show("请先从借书列表中选中想要借阅的书籍！");
                return;
            }
            DialogResult dr = MessageBox.Show("确认归还书籍？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                Dao dao = new Dao();
                string sql = $"Delete from t_borrow where BorrowerID={Data.UID} and BookISBN='{ISBN}'";

                if (dao.Excute(sql) > 0)
                {
                    MessageBox.Show("还书成功！");
                    sql = $"update t_book set BookNum=BookNum+1 where ISBN='{ISBN}'";
                    if (dao.Excute(sql) <= 0) MessageBox.Show("更新库存失败，请联系管理员！");
                    dao.DaoClose();
                    ShowBorrowInfo();
                }
                else
                {
                    MessageBox.Show("还书失败！");
                }
                dao.DaoClose();
            }
        }

        private void CancelResButton_Click(object sender, EventArgs e)
        {
            string ISBN;
            try
            {
                ISBN =ReservationGrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("请先从预约列表中选中想要取消预约的书籍！");
                return;
            }
            DialogResult dr = MessageBox.Show("确认取消预约？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                Dao dao = new Dao();
                string sql = $"Delete from t_reservation where BorrowerID={Data.UID} and BookISBN='{ISBN}'";

                if (dao.Excute(sql) > 0)
                {
                    MessageBox.Show("取消预约成功！");
                    ShowReservationInfo();
                }
                else
                {
                    MessageBox.Show("取消预约失败！");
                }
                dao.DaoClose();
            }
        }
    }
}
