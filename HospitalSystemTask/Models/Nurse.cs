using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int Word_Id { get; set; }


    }
}
