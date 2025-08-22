using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemTask.Models
{
    internal class Nurse_Drug_Patient
    {
        public int Nur_Num { get; set; }
        public int Drug_Code {  get; set; }
        
        public int Pat_Id {  get; set; }
        public DateOnly Date {  get; set; }
        public TimeOnly Time { get; set; }
        public string Dosage { get; set; }
    }
}
