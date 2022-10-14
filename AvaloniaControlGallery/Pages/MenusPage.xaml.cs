using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaControlGallery.Pages;

public class MenusPage : UserControl
{
    public MenusPage()
    {
        this.InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}