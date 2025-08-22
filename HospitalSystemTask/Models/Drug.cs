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

    }
}
