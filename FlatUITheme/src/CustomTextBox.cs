using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FlatUITheme.src
{
    public class CustomTextBox : TextBox
    {
        public static readonly DependencyProperty DefaultTextProperty = DependencyProperty.Register(
            name: "DefaultText",
            propertyType: typeof(string),
            ownerType: typeof(CustomTextBox),
            typeMetadata: new FrameworkPropertyMetadata(defaultValue: "Search"));
        public string DefaultText
        {
            get { return (string)GetValue(DefaultTextProperty); }
            set { SetValue(DefaultTextProperty, value); }
        }
    }
}
