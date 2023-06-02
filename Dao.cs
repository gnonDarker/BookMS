using System.Data.SqlClient;

namespace BookMS
{
    internal class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            //连接数据库
            string str = @"Data Source=GNON-DESKTOP;Initial Catalog=BookDB2;Integrated Security=True";
            //创建数据库连接对象
            sc = new SqlConnection(str);
            //打开数据库
            sc.Open();

            //返回数据库连接对象
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());

            return cmd;
        }
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();
        }
    }
}
