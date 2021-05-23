using System;
using System.Collections.Generic;
using System.Text;

namespace BO_HumRes_OneTouch
{
    public static class GlobalModel
    {
        private static int userId = 1; // to be removed the initial value

        public static int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
    }
}
