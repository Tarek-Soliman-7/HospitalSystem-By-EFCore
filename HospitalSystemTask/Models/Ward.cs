using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemTask.Models
{
    internal class Ward
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public Nurse Supervisor { get; set; }

        //[ForeignKey(nameof(Supervisor))]
        public int Nurse_Num {  get; set; }

        public ICollection<Nurse> Nurses { get; set; }=new HashSet<Nurse>();

        public ICollection<Patient> Patients { get; set; } = new HashSet<Patient>();

    }
}
