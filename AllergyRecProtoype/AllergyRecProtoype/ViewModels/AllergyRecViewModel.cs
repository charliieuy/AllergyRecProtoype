using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfControls.Editors;

namespace AllergyRecProtoype
{
    class AllergyRecViewModel : BaseViewModel
    {
        private readonly AllergyRec _allergyRec;

        private List<AllergenViewModel> _allergens;
        public List<AllergenViewModel> Allergens
        {
            get { return _allergens; }
            set { _allergens = value; OnPropertyChanged("Allergens"); }
        }

        public IEnumerable<object> AllergenEnumerable { get { return Allergens.AsEnumerable(); } }

        public AllergyRecViewModel(AllergyRec allergyRec)
        {
            _allergyRec = allergyRec;
            _allergens = new List<AllergenViewModel>();
            DataManager.Instance.AllergenList.ForEach(x => _allergens.Add(new AllergenViewModel(x)));

            SelectedAllergen = new AllergenViewModel(new Allergen { Name = "", Value = 0 });
            SelectedAllergen.PropertyChanged += (s, e) => { Console.WriteLine("SubItem PropertyChanged"); };

            //_allergens = DataManager.Instance.AllergenList.Select(x => new AllergenViewModel(x)).ToList();
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

        public AllergenViewModel SelectedAllergen
        {
            get { return new AllergenViewModel(_allergyRec.AllscriptsAllergen); }
            set
            {
                if (value != null)
                    _allergyRec.AllscriptsAllergen = new Allergen { Name = value.Name, Value = value.Value };
                OnPropertyChanged("SelectedAllergen");

            }
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
    }
}
