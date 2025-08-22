using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int Ward_Id { get; set; }
        public int Con_Id { get; set; }
    }
}
