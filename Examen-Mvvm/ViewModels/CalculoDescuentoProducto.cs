using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Examen_Mvvm.ViewModels
{
    public partial class CalculoDescuentoProducto : ObservableObject
    {
        [ObservableProperty]
        private double precio1;
        

        [ObservableProperty]
        private double precio2;

        [ObservableProperty]
        private double precio3;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {

            double descuento1;
            double descuento2;
            double descuento3;
            try
            {
                if (Precio1 <= 0)
                {
                    Alerta("ADVERTENCIA", "Ingrese un monto válido");
                }
                else if (Precio2 <= 0)
                {
                    Alerta("ADVERTENCIA", "Ingrese una tasa anual válida");
                }
                else if (Precio3 <= 0)
                {
                    Alerta("ADVERTENCIA", "Ingrese la cantidad de años válido");
                }
                else {

                    if (Precio1 >= 10000.00) {
                        descuento1 = Precio1* 0.3;
                    }
                
                }
                
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }
    }
