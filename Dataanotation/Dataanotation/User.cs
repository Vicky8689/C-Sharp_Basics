using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataanotation
{
    internal class User
    {
            [Required(ErrorMessage ="Name is requrid vicky....!")]
            public string Name { get; set; }
            [StringLength(10,ErrorMessage ="email can not be longer than 10. ")]
            public string Email { get; set; }
            
            public User() { }
        
        
    }
}
