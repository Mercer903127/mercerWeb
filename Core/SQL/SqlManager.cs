using MySql.Data.MySqlClient;
using System.Data;

namespace mercer_web.Core.SQL
{
    public static class SqlManager
    {
        static MySqlConnection _conn = new MySqlConnection();

        public static void OpenConn()
        {
            string DatabaseName = "pipidb";
            string IP = "192.168.1.13";
            string Username = "pipi";
            string Password = "902023";
            string Port = "3306";
            _conn = new MySqlConnection("Database=" + DatabaseName + ";Data Source=" + IP + ";User Id=" + Username + ";Password=" + Password + ";pooling=false;CharSet=utf8;port=" + Port + "");
            _conn.Open();
        }

        public static void CloseConn()
        {
            _conn.Close();
        }

        public static DataSet ExcuQuery(string strSql, params MySqlParameter[] paras)
        {
            using (MySqlCommand command = new MySqlCommand(strSql, _conn))

                try
                {
                    DataSet ds = new DataSet();
                    foreach (MySqlParameter p in paras)
                    {
                        command.Parameters.AddWithValue(p.ParameterName, p.Value);
                    }
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    da.Fill(ds);
                    return ds;

                }
                catch (Exception)
                {

                    throw;
                }
        }

        public static DataSet ExcuQuery(string sql)
        {
            throw new NotImplementedException();
        }

        public static int ExcuInsert(string sql)
        {
            throw new NotImplementedException();
        }

        public static int ExcuUpdate(string sql)
        {
            throw new NotImplementedException();
        }

        public static int ExcuDelete(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
