using System;
using System.Collections.Generic;
using System.Text;

namespace BO_HumRes_OneTouch
{
    public static class GlobalModel
    {
        private static int userId; // to be removed the initial value

        public static string Language = "sq-AL";

        public static string Name { get; set; }
        public static string LastName { get; set; }
        public static DateTime BirthDate { get; set; }
        public static string Gender{ get; set; }
        public static float Salary { get; set; }
        public static string Email { get; set; }
        public static int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
    }
}
