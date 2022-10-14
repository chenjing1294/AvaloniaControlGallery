using System.Collections.Generic;

namespace AvaloniaControlGallery.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private bool _isMenuItemChecked;

    public bool IsMenuItemChecked
    {
        get => _isMenuItemChecked;
        set => SetField(ref _isMenuItemChecked, value, nameof(IsMenuItemChecked));
    }

    public MainWindowViewModel()
    {
    }


    public string Greeting => "Welcome to Avalonia!";

    public List<string> SearchItems { get; } = new List<string>
    {
        "TextBlock",
        "CheckBox",
        "ComboBox",
        "TextBox",
        "Calendar"
    };
}