using System;

namespace BO_HumRes_OneTouch {
    public class Experience {

        public int Id { get; set; }
        public int CVId { get; set; }
        public string RoleName { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}