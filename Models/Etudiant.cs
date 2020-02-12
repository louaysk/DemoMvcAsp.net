using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEtudiant.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool Homme { get; set;}
        public DateTime Date { get; set; }
        public float moyenne { get; set; }

    } }
