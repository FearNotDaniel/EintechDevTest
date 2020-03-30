using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EintechDevTest.Web.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public int GroupID { get; set; }
    }
}
