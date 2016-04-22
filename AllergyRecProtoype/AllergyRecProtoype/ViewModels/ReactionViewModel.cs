using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllergyRecProtoype
{
    class ReactionViewModel: BaseViewModel
    {
        private readonly Reaction _reaction;

        public ReactionViewModel(Reaction reaction)
        {
            _reaction = reaction;
        }

        public string Name
        {
            get { return _reaction.Name; }
            set
            {
                _reaction.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Value
        {
            get { return _reaction.Value; }
            set
            {
                _reaction.Value = value;
                OnPropertyChanged("Value");
            }
        }
    }
}
