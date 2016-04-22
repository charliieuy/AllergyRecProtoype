using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AllergyRecProtoype
{
    class MainWindowViewModel : BaseViewModel
    {
        private List<AllergyRecViewModel> _allergies;
        public List<AllergyRecViewModel> Allergies
        {
            get { return _allergies; }
            set { _allergies = value; OnPropertyChanged("Allergies"); }
        }

        public List<AllergyRecViewModel> AllergyRecs { get; set; }
        public List<string> Reactions { get; set; }


        public MainWindowViewModel()
        {
            var allergies = DataManager.Instance.Allergies;
            var reactions = DataManager.Instance.ReactionList;

            var reactionListViewModels = new List<ReactionViewModel>();
            reactions.ForEach(r => reactionListViewModels.Add(new ReactionViewModel(r)));

            var allergiesViewModels = new List<AllergyRecViewModel>();
            allergies.ForEach(a => allergiesViewModels.Add(new AllergyRecViewModel(a)));

            //allergiesViewModels.ForEach(a => a.ReactionList.AddRange(reactionListViewModels));
            Allergies = allergiesViewModels.Where(x => x.Reconcile == false).ToList();
            AllergyRecs = allergiesViewModels.Where(x => x.Reconcile == true).ToList();

            Reactions = new List<string>();
            reactions.ForEach(r => Reactions.Add(r.Name));
        }

    }
}
