using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemTask.Models
{
    internal class Nurse
    {
        [Key]
        public int Number { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        public Ward? SupervisedWard { get; set; }
         
        public int Ward_Id { get; set; }
        public Ward? Ward { get; set; }

        public ICollection<Nurse_Drug_Patient>? Nurse_Drug_Patients { get; set; } = new HashSet<Nurse_Drug_Patient>();



    }
}
