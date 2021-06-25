using System;
using System.Collections.Generic;
using System.Text;

namespace BO_HumRes_OneTouch {
    public class CV {

        public int Id { get; set; }
        public int UserId { get; set; }

        public List<Skills> skills { get; set; }
        public List<Education> education { get; set; }
        public List<Experience> experience { get; set; }


    }
}
