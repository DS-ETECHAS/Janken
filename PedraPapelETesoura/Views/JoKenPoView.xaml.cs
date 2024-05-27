using PedraPapelETesoura.ViewModels;
namespace PedraPapelETesoura.Views;

public partial class JoKenPoView : ContentPage
{
	public JoKenPoView()
	{
		BindingContext = new JokenPoViewModel();

        InitializeComponent();

    }
}