using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using Mag3DView.ViewModels;

namespace Mag3DView
{
    public partial class EditableControl : UserControl
    {
        public EditableControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OnUpdateButtonClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var textBox = this.FindControl<TextBox>("EditableTextBox");
            var newText = textBox.Text;

            // Find the main window
            var mainWindow = this.FindAncestorOfType<Window>();
            if (mainWindow != null)
            {
                mainWindow.Title = newText;

                if (mainWindow.DataContext is MainWindowViewModel viewModel)
                {
                    viewModel.Greeting = newText;
                    viewModel.DisplayText = newText; // Update DisplayText
                }
            }
        }
    }
}
