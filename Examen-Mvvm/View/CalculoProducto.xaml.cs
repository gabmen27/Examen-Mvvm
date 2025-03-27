using Examen_Mvvm.ViewModels;

namespace Examen_Mvvm.View;

public partial class CalculoProducto : ContentPage
{
	CalculoDescuentoProducto viewModel;
	public CalculoProducto()
	{
		InitializeComponent();

		viewModel = new CalculoDescuentoProducto();

		BindingContext = viewModel;


    }
}