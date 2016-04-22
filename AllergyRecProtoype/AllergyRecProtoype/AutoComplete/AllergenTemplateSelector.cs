using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AllergyRecProtoype
{
    public class AllergenTemplateSelector: DataTemplateSelector
    {
        public DataTemplate AllergenTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Allergen)
                return AllergenTemplate;
            return base.SelectTemplate(item, container);
        }
    }
}
