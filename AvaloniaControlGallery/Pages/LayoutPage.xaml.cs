using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaControlGallery.ViewModels;

namespace AvaloniaControlGallery.Pages;

public class LayoutPage : UserControl
{
    public LayoutPage()
    {
        this.InitializeComponent();

        DataContext = new LayoutPageViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}