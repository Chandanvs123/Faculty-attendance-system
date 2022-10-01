using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WrapperDataBase
{
    public class cls_DataBase
    {

        public static String strConString = "server=localhost;User Id=root; password=root;database=college_attendence";

        public static int insertIntoDB(String str_query, ref String Ste_Err)
        {

            try
            {
                MySqlConnection sql_con = new MySqlConnection(strConString);

                sql_con.Open();
                MySqlCommand cmd = new MySqlCommand(str_query, sql_con);
                cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            catch (Exception ex)
            {
                Ste_Err = ex.Message;
                return 0;
            }
            return 1;
        }

        public static int Delete_Command(String str_query, ref String Ste_Err)
        {

            try
            {
                MySqlConnection sql_con = new MySqlConnection(strConString);

                sql_con.Open();
                MySqlCommand cmd = new MySqlCommand(str_query, sql_con);
                int res = cmd.ExecuteNonQuery();
                sql_con.Close();
                return res;
            }
            catch (Exception ex)
            {
                Ste_Err = ex.Message;
                return 0;
            }
        }

        public static int Update_Command(String str_query, ref String Ste_Err)
        {

            try
            {
                MySqlConnection sql_con = new MySqlConnection(strConString);

                sql_con.Open();
                MySqlCommand cmd = new MySqlCommand(str_query, sql_con);
                int res = cmd.ExecuteNonQuery();
                sql_con.Close();
                return res;

            }
            catch (Exception ex)
            {
                Ste_Err = ex.Message;
                return 0;
            }
        }

        public static void return_Dataset(String str_query, ref String Ste_Err, ref DataSet ds)
        {
            try
            {
                MySqlConnection sql_con = new MySqlConnection(strConString);

                sql_con.Open();
                MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                DTA.Fill(ds);
                sql_con.Close();

            }
            catch (Exception ex)
            {
                Ste_Err = ex.Message;

            }

        }

        public static void return_Dataset_table(String str_query, ref String Ste_Err, ref DataSet ds, String item)
        {
            try
            {
                MySqlConnection sql_con = new MySqlConnection(strConString);

                sql_con.Open();
                MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                DTA.Fill(ds);
                sql_con.Close();

            }
            catch (Exception ex)
            {
                Ste_Err = ex.Message;

            }

        }
        public static void return_Dataset_table1(String str_query, ref String Ste_Err, ref DataSet ds, String item)
        {
            try
            {
                MySqlConnection sql_con = new MySqlConnection(strConString);

                sql_con.Open();
                MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                DTA.Fill(ds, item);
                sql_con.Close();

            }
            catch (Exception ex)
            {
                Ste_Err = ex.Message;

            }

        }   
    }
}
