using System.Windows;

namespace EinkaufswagenVisitor;

public partial class BrowserBlackMagic : Window
{
    public BrowserBlackMagic(string content)
    {
        InitializeComponent();
        BlackMagic.NavigateToString(content);
    }

}