using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AllergyRecProtoype
{
    class MainWindowViewModel : BaseViewModel
    {
        private List<AllergyRecViewModel> _allergyRecVMList;
        public List<AllergyRecViewModel> AllergyRecVMList
        {
            get { return _allergyRecVMList; }
            set { _allergyRecVMList = value; OnPropertyChanged("Allergies"); }
        }

        public List<AllergyRec> CurrentAllergies { get; set; }

        public MainWindowViewModel()
        {
            var allergyRecs = DataManager.Instance.AllergyRecList;
            var allergyRecVMList = new List<AllergyRecViewModel>();
            allergyRecs.ForEach(a => allergyRecVMList.Add(new AllergyRecViewModel(a)));
            AllergyRecVMList = allergyRecVMList.Where(x => x.Reconcile == false).ToList();

            var reactions = DataManager.Instance.ReactionList;

            var reactionListViewModels = new List<ReactionViewModel>();
            reactions.ForEach(r => reactionListViewModels.Add(new ReactionViewModel(r)));

            CurrentAllergies = allergyRecs.Where(a => a.Reconcile == false).ToList();
        }
    }
}
