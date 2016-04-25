using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfControls.Editors;

namespace AllergyRecProtoype
{
    public class SuggestionProvider : ISuggestionProvider
    {
        public System.Collections.IEnumerable GetSuggestions(string filter)
        {
            var allergenList = DataManager.Instance.AllergenList.Select(a => new AllergenViewModel(a));
            return allergenList.Where(x => x.Name.ToLower().Contains(filter));
        }
    }
}
