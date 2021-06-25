using System;
using System.Collections.Generic;
using System.Text;

namespace BO_HumRes_OneTouch {
    public class ContractBO {
        public string UserName { get; set; }
        public string UserLastName { get; set; }

        public string EmployeeEmail { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedByUser { get; set; }
        public int UpdatedByUser { get; set; }
    }
}
