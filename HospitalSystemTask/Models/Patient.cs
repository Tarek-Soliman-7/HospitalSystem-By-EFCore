using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemTask.Models
{
    internal class Patient
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        [ForeignKey(nameof(Id))]
        public int Ward_Id { get; set; }

        [ForeignKey(nameof(Id))]
        public int Con_Id { get; set; }
        public Consultant Consultant { get; set; } = null!;

        public Ward? Ward { get; set; } 

        public ICollection<Patient_Con>? Patient_Cons { get; set; }= new HashSet<Patient_Con>();

        public ICollection<Nurse_Drug_Patient>? Nurse_Drug_Patients { get; set; } = new HashSet<Nurse_Drug_Patient>();
    }
}
