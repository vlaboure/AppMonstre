using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Appdontjesuislehero.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure
    {
        public int ID { get; set; }

        public string Titre { get; set; }
    }
}
