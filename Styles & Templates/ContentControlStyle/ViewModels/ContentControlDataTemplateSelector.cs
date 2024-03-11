using System.Windows;
using System.Windows.Controls;

namespace ContentControlStyle
{
    public class ContentControlDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate StuDataTemplate { get; set; }
        public DataTemplate TeaDataTemplate { get; set; }


        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var vm = item as PersonViewModel;
            if (vm == null)
            {
                return null;
            }

            if (vm.Name.EndsWith("y"))
            {
                return TeaDataTemplate;
            }

            return StuDataTemplate;
        }
    }
}
