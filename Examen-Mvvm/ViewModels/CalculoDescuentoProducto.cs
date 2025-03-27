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

        [ObservableProperty]
        double descuento1;
        
        [ObservableProperty]
        double descuento2;

        [ObservableProperty]
        double descuento3;

        [ObservableProperty]
        string txtDescuento1;

        [ObservableProperty]
        string txtDescuento2;
       

        [ObservableProperty]
        string txtDescuento3;


        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                if (Precio1 < 0)
                {
                    Alerta("ADVERTENCIA", "Ingrese un Precio Valido");
                }
                else if (Precio2 < 0)
                {
                    Alerta("ADVERTENCIA", "Ingrese un Precio Valido");
                }
                else if (Precio3 < 0)
                {
                    Alerta("ADVERTENCIA", "Ingrese un Precio Valido");
                }
                else
                {

                    if (Precio1 >= 10000.00)
                    {
                        TxtDescuento1 = "Descuento del 30%, total a Pagar: ";
                        Descuento1 = Precio1-(Precio1 * 0.3);
                    }
                    if (Precio2 >= 10000.00)
                    {
                        TxtDescuento2 = "Descuento del 30%, total a Pagar:";
                        Descuento2 = Precio2 - (Precio2 * 0.3);
                    }
                    if (Precio3 >= 10000.00)
                    {
                        TxtDescuento3 = "Descuento del 30%, total a Pagar:";
                        Descuento3 = Precio3 - (Precio3 * 0.3);
                    }

                    if (Precio1 >= 5000 && Precio1 <= 9999.99) {
                        TxtDescuento1 = "Descuento del 20%, total a Pagar:";
                        Descuento1 = Precio1 - (Precio1 * 0.2);
                    }
                    if (Precio2 >= 5000 && Precio2 <= 9999.99)
                    {
                        TxtDescuento2 = "Descuento del 20%, total a Pagar:";
                        Descuento2 = Precio2 - (Precio2 * 0.2);
                    }
                    if (Precio1 >= 5000 && Precio1 <= 9999.99)
                    {
                        TxtDescuento3 = "Descuento del 20%, total a Pagar:";
                        Descuento3 = Precio3 - (Precio3 * 0.2);
                    }

                    if (Precio1 >= 1000 && Precio1 <= 4999.99)
                    {
                        TxtDescuento1 = "Descuento del 10%, total a Pagar:";
                        Descuento1 = Precio1 - (Precio1 * 0.1);
                    }
                    if (Precio2 >= 1000 && Precio2 <= 4999.99)
                    {
                        TxtDescuento2 = "Descuento del 10%, total a Pagar:";
                        Descuento2 = Precio1 - (Precio1 * 0.1);
                    }
                    if (Precio3 >= 1000 && Precio1 <= 4999.99)
                    {
                        TxtDescuento3 = "Descuento del 10%, total a Pagar:";
                        Descuento3 = Precio1 - (Precio1 * 0.1);
                    }
                    
                    if(Precio1 >= 0 && Precio1<=999.99){
                        TxtDescuento1 = "No Aplica Descuento, total a Pagar:";
                        Descuento1 = Precio1;
                    }
                    if (Precio2 >= 0 && Precio2 <= 999.99) {
                        TxtDescuento2 = "No Aplica Descuento, total a Pagar:";
                        Descuento2 = Precio2;
                    }
                    if (Precio3 >= 0 && Precio3 <= 999.99)
                    {
                        TxtDescuento3 = "No Aplica Descuento, total a Pagar:";
                        Descuento3 = Precio3;
                    }


                }

            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }


        [RelayCommand]
        private void Limpiar() {
            Precio1 = 0;
            Precio2 = 0;
            Precio3 = 0;

            Descuento1 = 0;
            Descuento2 = 0;
            Descuento3 = 0;

            TxtDescuento1 = "";
            TxtDescuento2 = "";
            TxtDescuento3 = "";

        }
    }
}
