using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommonData
{
    public class FilialeCommandModel
    {
        [Key]
        public int FilialId { get; set;}
        public String filialName { get; set;}

    }
}
