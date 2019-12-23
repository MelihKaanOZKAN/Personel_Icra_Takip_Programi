using Devart.Data.PostgreSql;
using Npgsql;
using Personel_Icra_Takip_Programı.Report.DB_PITPDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Icra_Takip_Programı.Classlar
{
    static class dbConnection
    {
      private static  NpgsqlConnection con = new NpgsqlConnection();

      

        private static void prepareConnection()
        {
            try
            {
                xmlops xml = new xmlops();
                con = xml.getDBInfo();
            }
            catch (Exception)
            {

                throw;
            }
        }
     
              
        public static PgSqlConnection getPgsqlConnection()
        {
            PgSqlConnection con1 = new PgSqlConnection();
            xmlops xml = new xmlops();
            con1 = xml.getPgSqlDBInfo();

            return con1;
        }
           

        public static void  sendQuery(NpgsqlCommand command)
        {
            try
            {
                if (command.CommandText!=""&&command.CommandText!=string.Empty)
                {
                    prepareConnection();
                    con.Open();
                    command.Connection = con;
                    command.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable getData(NpgsqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {
                if (command.CommandText != "" && command.CommandText != string.Empty)
                {
                    prepareConnection();
                    con.Open();
                    command.Connection = con;
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                    dataAdapter.Fill(dt);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
               
                con.Close();
            }
            return dt;
        }

    }
}
