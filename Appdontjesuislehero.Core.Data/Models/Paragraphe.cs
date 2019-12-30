using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Appdontjesuislehero.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        /// <summary>
        ///  id auto incrémenté de la base
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// numéro à afficher
        /// </summary>

        public int Numero { get; set; }
        public string Titre { get; set; }
        /// <summary>
        /// descrîption du paragraphe
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// question du paragraphe
        /// </summary>
        //existe mais non utilisé par la bdd
        [NotMapped]
        public Question MaQuestion { get; set; }
        
    }
}
