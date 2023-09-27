using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public string EmployeeName { get; set; }

        public string City { get; set; }

        public string Nationality { get; set; }

        public string ZipCode { get; set; }
    }
}
