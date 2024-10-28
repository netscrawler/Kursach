using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Procedure_Card : Entity_Sush
    {
        public string[] Zhalobi { get; set; } = null!;
        public string[] Diseases { get; set; } = null!;
        public ICollection<Procedure> Procedures { get; set; } = new List<Procedure>();

        public ICollection<Procedures_History> Procedures_History { get; set; }= new List<Procedures_History>();
        public Pacient Pacient { get; set; }
        public Doctor Doctor { get; set; } = null!;

        public string DisplayInfo
        {
            get
            {
                var pacientName = Pacient != null ? Pacient.Name : "Unknown Patient";
                var doctorName = Doctor != null ? Doctor.Name : "Unknown Doctor";
                var zhalobiText = Zhalobi != null && Zhalobi.Length > 0 ? string.Join(", ", Zhalobi) : "No complaints";
                var diseasesText = Diseases != null && Diseases.Length > 0
                    ? string.Join(", ", Diseases)
                    : "No diseases";

                return $"{pacientName} - {doctorName} | Complaints: {zhalobiText} | Diseases: {diseasesText}";
            }
        }


        public void Add(string[] Zhalobi)
        {
            this.Zhalobi = Zhalobi;
        }

        public void AddProc(Procedure procedure)
        {
            this.Procedures.Add(procedure);
        }
        public void New(string[] Zhalobi, Pacient pacient, Doctor doctor, string[] disease)
        {
            this.Zhalobi = Zhalobi;
            this.Pacient = pacient;
            this.Doctor = doctor;
            this.Diseases = disease;
        }

    }
}
