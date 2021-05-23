using System;

namespace BO_HumRes_OneTouch
{
    public class Base
    {
        public string InsertBy { get; set; }
        public string LastUpdateByUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public int LastUpdateVersion { get; set; }
    }
}
