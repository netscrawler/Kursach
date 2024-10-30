using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class PatientCardViewModel
    {
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string PatientLastName { get; set; }
        public string PatientEmail { get; set; }
        public DateOnly PatientBirthday { get; set; }
        public string Patientphone { get; set; }
        public UInt64 PatientPhoneNumber { get; set; }
        public UInt64 PatientSnils { get; set; }
        public Guid ProcedureCardId { get; set; }
        public string ProcedureName { get; set; }
        public TimeOnly ProcedureLength { get; set; }
        public DateTime ProcedureDate { get; set; }
    }
}
