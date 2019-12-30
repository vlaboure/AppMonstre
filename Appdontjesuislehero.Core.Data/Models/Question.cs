using System;
using System.Collections.Generic;
using System.Text;

namespace Appdontjesuislehero.Core.Data.Models
{
    public class Question
    {
        public int ID { get; set; }
        /// <summary>
        /// titre de la question
        /// </summary>

        public string Titre { get; set; }
        /// <summary>
        /// liste de réponse à mes questions
        /// </summary>
        public List<Reponse> MesReponses { get; set; }
    }
}
