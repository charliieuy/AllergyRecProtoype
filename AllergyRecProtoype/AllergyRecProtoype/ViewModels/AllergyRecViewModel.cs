using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AllergyRecProtoype
{
    class AllergyRecViewModel : BaseViewModel
    {
        private readonly AllergyRec _allergyRec;

        public AllergyRecViewModel(AllergyRec allergyRec)
        {
            _allergyRec = allergyRec;
        }

        public bool Reconcile
        {
            get { return _allergyRec.Reconcile; }
            set { _allergyRec.Reconcile = value; OnPropertyChanged("ShowReconcile"); }
        }
        
        public string Category
        {
            get { return _allergyRec.Category; }
            set { _allergyRec.Category = value; OnPropertyChanged("Category"); }
        }

        public string Type
        {
            get { return _allergyRec.Type; }
            set { _allergyRec.Type = value; OnPropertyChanged("Type"); }
        }

        public string Campus
        {
            get { return _allergyRec.Campus; }
            set { _allergyRec.Campus = value; OnPropertyChanged("Campus"); }
        }
        
        public string Allergen
        {
            get { return _allergyRec.Allergen; }
            set { _allergyRec.Allergen = value; OnPropertyChanged("Allergen"); }
        }

        public string Reactions
        {
            get { return _allergyRec.Reactions; }
            set { _allergyRec.Reactions = value; OnPropertyChanged("Reactions"); }
        }

        public string AllscriptsAllergen
        {
            get { return _allergyRec.AllscriptsAllergen; }
            set { _allergyRec.AllscriptsAllergen = value; OnPropertyChanged("AllscriptsAllergen"); }
        }

        public string AllscriptsReactions
        {
            get { return _allergyRec.AllscriptsReactions; }
            set { _allergyRec.AllscriptsReactions = value; OnPropertyChanged("AllscriptsReactions"); }
        }

        public string EnteredOn
        {
            get { return _allergyRec.EnteredOn; }
            set { _allergyRec.EnteredOn = value; OnPropertyChanged("EnteredOn"); }
        }

        public List<ReactionViewModel> ReactionList { get; set; }
    }
}
