using System.Windows;
using System.Windows.Controls;

namespace AllergyRecProtoype
{
    public class AllergenTemplateSelector: DataTemplateSelector
    {
        public DataTemplate AllergenTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is AllergenViewModel)
                return AllergenTemplate;
            return base.SelectTemplate(item, container);
        }
    }
}
