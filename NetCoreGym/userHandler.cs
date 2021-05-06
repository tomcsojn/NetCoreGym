using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Threading.Tasks;
using NetCoreGym.Models;

namespace NetCoreGym
{
    public class userHandler
    {
        const string connectionString = "server=127.0.0.1;uid=root;database=Gym";

        //public static TicketInfo GetTicket(int id)
        //{

        //    SqlConnection conn = new SqlConnection(connectionString);
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.CommandText = "get_ticket_info";
        //    cmd.Parameters.AddWithValue("@in_id", id);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    reader.Read();
        //    TicketInfo ticket = new TicketInfo
        //    {
        //        name = reader.GetString(0),
        //        type_name = reader.GetString(1),
        //        end = reader.GetDateTime(2)
        //    };
        //    conn.Close();
        //    return ticket;
        //}

        static public int Login(string mail, string pass)
        {

            MySqlConnection conn = new MySqlConnection(connectionString);






            //SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //// Read user
            MySqlCommand cmd = new MySqlCommand("SELECT role_id FROM users where email= @mail and pass=@pass ", conn);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@pass", pass);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            ////User u = new User
            ////{
            ////    name = name,

            ////};
            int result;
            if (reader.HasRows)
            {
                result = reader.GetInt16(0);

            }
            else
            {
                result = -1;
            }


            reader.Close();
            return result;
        }

    }
}
