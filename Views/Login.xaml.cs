namespace rtoasaS2A.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        string fecha = dFechas.Date.ToString();
        lblFecha.Text = fecha; // hms - 
    }

    private void btnSeleccion_Clicked(object sender, EventArgs e)
    {
		if (pkCiudades.SelectedIndex == -1)
		{
			DisplayAlert("ERROR", "No existe el dato", "Cerrar");

		}
		else {
		string dato = pkCiudades.Items[pkCiudades.SelectedIndex];
		DisplayAlert("Alerta", "La ciudad es " + dato, "Cerrar");
        }

		//////fechas
		string fecha = dFechas.Date.ToString();
        lblFecha.Text = fecha; // hms - 


    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {

    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {

    }
}