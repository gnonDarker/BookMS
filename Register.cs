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
    public partial class Register : Form
    {
        string table = "";
        public Register()
        {
            InitializeComponent();
        }
        public Register(string table)
        {
            InitializeComponent();
            this.table = table;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            //id,psw,name,sex,phone
            string sql = $"insert into {table} values ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}')";

            if (dao.Excute(sql) > 0)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
            dao.DaoClose();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
