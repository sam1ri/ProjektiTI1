﻿using System.Configuration;
using System.Data.SqlClient;

namespace DA_HumanRes_OneTouch
{
    class DbConnection
    {
        public static string conString = ConfigurationManager.ConnectionStrings["constringHumres"].ConnectionString.ToString();

        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
    }
}
