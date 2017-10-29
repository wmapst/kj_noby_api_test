using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace wmap_noby_api
{
    class cls_mysql_connect
    {
        //クエリ実施、結果返答
        public string DataBaseAccess_ExecuteScaler(string strSql, string constr)
        {
            string str_result = "";
            MySqlConnection myConnection = new MySqlConnection(constr);
            MySqlCommand myCommand = new MySqlCommand(strSql.ToString());

            try
            {
                myCommand.Connection = myConnection;
                myCommand.CommandTimeout = 1000;
                myConnection.Open();
                str_result = myCommand.ExecuteScalar().ToString();
                myCommand.Connection.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                myCommand.Connection.Dispose();
                myCommand.Connection.Close();
                myConnection = null;
            }

            return str_result;
        }

        //クエリ実施、結果無返答
        public void DataBaseAccess_ExecuteNonQuery(string strSql, string constr)
        {
            MySqlConnection myConnection = new MySqlConnection(constr);
            MySqlCommand myCommand = new MySqlCommand(strSql.ToString());

            try
            {
                myCommand.Connection = myConnection;
                myCommand.CommandTimeout = 1000;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                myCommand.Connection.Dispose();
                myCommand.Connection.Close();
                myConnection = null;
            }
        }

        //クエリ実施、結果無返答
        public void DataBaseAccess_ExecuteNonQuery_log(string strSql, string constr, DateTime dt, string ip)
        {
            MySqlConnection myConnection = new MySqlConnection(constr);
            MySqlCommand myCommand = new MySqlCommand(strSql, myConnection);
            try
            {
                myCommand.Parameters.Add(new MySqlParameter("date_time_log", dt));
                myCommand.Parameters.Add(new MySqlParameter("ip_address", ip));
                myCommand.CommandTimeout = 1000;
                myCommand.Connection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                myCommand.Connection.Dispose();
                myCommand.Connection.Close();
                myConnection = null;
            }
        }

        //DBアクセス1
        public DataTable DataBaseAccess_Fill_da(string strSql, string constr)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(constr);
            try
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(strSql, con);

                da.SelectCommand.CommandTimeout = 1000;
                da.Fill(dt);
                con.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Dispose();
                con.Close();
                con = null;
            }
            return dt;
        }

        //DBアクセス2
        public DataSet DataBaseAccess_Fill_ds(string strSql, string constr)
        {
            DataSet myDataSet = new DataSet();
            MySqlConnection con = new MySqlConnection(constr);

            try
            {
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = new MySqlCommand(strSql, con);
                da.SelectCommand.CommandTimeout = 1000;

                da.Fill(myDataSet);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Dispose();
                con.Close();
                con = null;
            }

            return myDataSet;
        }
    }
}
