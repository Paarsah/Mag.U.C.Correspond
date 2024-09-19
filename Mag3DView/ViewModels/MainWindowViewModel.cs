using ReactiveUI;

namespace Mag3DView.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private string _greeting = "Welcome to Avalonia!";
        private string _displayText = "Display will show here!";

        public string Greeting
        {
            get => _greeting;
            set => this.RaiseAndSetIfChanged(ref _greeting, value);
        }

        public string DisplayText
        {
            get => _displayText;
            set => this.RaiseAndSetIfChanged(ref _displayText, value);
        }
    }
}
