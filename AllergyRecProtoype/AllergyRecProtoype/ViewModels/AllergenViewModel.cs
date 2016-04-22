using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllergyRecProtoype
{
    class AllergenViewModel: BaseViewModel
    {
        private readonly Allergen _allergen;

        public AllergenViewModel(Allergen allergen)
        {
            _allergen = allergen;
        }

        public string Name
        {
            get { return _allergen.Name; }
            set
            {
                _allergen.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Value
        {
            get { return _allergen.Value; }
            set
            {
                _allergen.Value = value;
                OnPropertyChanged("Value");
            }
        }
    }
}
