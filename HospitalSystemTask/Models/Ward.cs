using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int Nurse_Num {  get; set; }

    }
}
