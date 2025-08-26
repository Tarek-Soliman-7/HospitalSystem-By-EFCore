using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemTask.Models
{
    internal class Patient_Con
    {
        public int Pat_Id {  get; set; }
        public Patient Patient { get; set; } = null!;


         public int Con_Id {  get; set; }
        public Consultant Consultant { get; set; } = null!;
    }
}
