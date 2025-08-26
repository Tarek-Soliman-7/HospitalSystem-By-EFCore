using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemTask.Models
{
    [Owned]
    internal class Drug_Brand
    {
        
        public int Code { get; set; }
        public string Brand { get; set; } = null!;

        public Drug Drug { get; set; } = null!;

    }
}
