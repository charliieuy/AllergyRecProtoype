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
        /// <summary>
        /// IEnumerable required for AutoComplete control provider
        /// </summary>
        public IEnumerable<object> AllergenEnumerable { get { return Allergens.AsEnumerable(); } }

        private List<ReactionViewModel> _reactionsList;
        public List<ReactionViewModel> ReactionsList
        {
            get { return _reactionsList; }
            set { _reactionsList = value; OnPropertyChanged("ReactionsList"); }
        }
        /// <summary>
        /// Multi-Select ComboBox requires dictionary structure
        /// </summary>
        public Dictionary<string, object> ReactionsDictionary
        {
            get
            {
                var Items = new Dictionary<string, object>();
                _reactionsList.ForEach(r => Items.Add(r.Name, r));
                return Items;
            }
        }

        public AllergyRecViewModel(AllergyRec allergyRec)
        {
            _allergyRec = allergyRec;

            // Add allergens from data manager to viewmodel property
            _allergens = new List<AllergenViewModel>();
            DataManager.Instance.AllergenList.ForEach(x => _allergens.Add(new AllergenViewModel(x)));
            // Default selected allergen to empty
            SelectedAllergen = new AllergenViewModel(new Allergen { Name = "", Value = 0 });
            SelectedAllergen.PropertyChanged += (s, e) => { Console.WriteLine("SubItem PropertyChanged"); };

            // Add reactions from data manager to viewmodel property
            _reactionsList = new List<ReactionViewModel>();
            DataManager.Instance.ReactionList.ForEach(x => _reactionsList.Add(new ReactionViewModel(x)));
            // Default selected reactions to empty
            SelectedReactions = new List<ReactionViewModel>();
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

        public List<ReactionViewModel> SelectedReactions
        {
            get { return _allergyRec.AllscriptsReactions.Select(r => new ReactionViewModel(r)).ToList(); }
            set
            {
                value.ForEach(r => _allergyRec.AllscriptsReactions.Add(new Reaction { }));
                OnPropertyChanged("AllscriptsReactions");
            }
        }

        public string EnteredOn
        {
            get { return _allergyRec.EnteredOn; }
            set { _allergyRec.EnteredOn = value; OnPropertyChanged("EnteredOn"); }
        }
    }
}
