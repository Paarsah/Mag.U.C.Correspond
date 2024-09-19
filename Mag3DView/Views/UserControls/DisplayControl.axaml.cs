using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Mag3DView.Views.UserControls
{
    public partial class DisplayControl : UserControl
    {
        public DisplayControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
