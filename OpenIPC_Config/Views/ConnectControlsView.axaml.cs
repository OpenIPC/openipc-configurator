using Avalonia.Controls;
using OpenIPC_Config.ViewModels;

namespace OpenIPC_Config.Views;

public partial class ConnectControlsView : UserControl
{
    public ConnectControlsView()
    {
        InitializeComponent();

        if (!Design.IsDesignMode) DataContext = new ConnectControlsViewModel();
    }
}