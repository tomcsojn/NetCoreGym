using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NetCoreGym.Models;

namespace NetCoreGym
{
    public class membershipsHandler
    {
        const string connectionString = "server=127.0.0.1;uid=root;database=Gym";
        public static TicketInfo getMembership(int id)
        {
            
            MySqlConnection conn = new MySqlConnection(connectionString);






            //SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //// Read user
            MySqlCommand cmd = new MySqlCommand("CALL get_ticket_info(@ID,@n,@t,@e); select @n, @t, @e; ", conn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@n", "");
            cmd.Parameters.AddWithValue("@t", "");
            cmd.Parameters.AddWithValue("@e", "");
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            TicketInfo ticket = new TicketInfo
            {
                name = reader.GetString(0),
                type_name = reader.GetString(1),
                end = reader.GetDateTime(2)
            };

            return ticket;
        }


    }
}
