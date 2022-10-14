using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaControlGallery.Pages;

public class DateTimePage : UserControl
{
    public DateTimePage()
    {
        this.InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}