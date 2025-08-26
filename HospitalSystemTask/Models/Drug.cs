using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemTask.Models
{
    internal class Drug
    {
        [Key]
        public int Code { get; set; }
        public string Dosage { get; set; }

        public ICollection<Drug_Brand> Brands { get; set; } = new HashSet<Drug_Brand>();

        public ICollection<Nurse_Drug_Patient>? Nurse_Drug_Patients { get; set; } = new HashSet<Nurse_Drug_Patient>();


    }
}
