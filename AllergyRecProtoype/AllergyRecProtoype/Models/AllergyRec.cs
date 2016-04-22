using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AllergyRecProtoype
{
    public class AllergyRec
    {
        public bool Reconcile { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Campus { get; set; }
        public string Allergen { get; set; }
        public string Reactions { get; set; }
        public Allergen AllscriptsAllergen { get; set; }
        public string AllscriptsReactions { get; set; }
        public string EnteredOn { get; set; }
        public List<Reaction> ReactionList { get; set; }
    }
}
