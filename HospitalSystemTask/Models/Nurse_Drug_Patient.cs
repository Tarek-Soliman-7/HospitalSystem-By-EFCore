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
        public Nurse Nurse { get; set; } = null!;
        public int Drug_Code {  get; set; }
        public Drug Drug { get; set; } = null!;
        public int Pat_Id {  get; set; }
        public Patient Patient { get; set; } = null!;
        public DateOnly Date {  get; set; }
        public TimeOnly Time { get; set; }
        public string Dosage { get; set; }
    }
}
