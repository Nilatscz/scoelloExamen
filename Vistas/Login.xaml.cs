namespace scoelloExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string[] usuarios = new string[] { "estudiante2024", "examen1", "NombreEstudiante"};
        string[] Contraseña = new string[] { "uisrael2024", "parcial1", "2024"};
        int i = 0;
        for (i = 0; i <= 2; i++)
        {
            if ((TxtUsuario.Text == usuarios[i]) && (TxtContraseña.Text ==
           Contraseña[i]))
            {
                String usuar = TxtUsuario.Text;
                //envio de datos a travez de una variable
                Navigation.PushAsync(new Registro(usuar));
                i = 3; break;
            }
            else
            {
                if (i == 2)
                {
                    DisplayAlert("Alerta", "Usuario o Contraseña Incorrecta",
                   "Continuar");
                }
            }

        }

    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acercde());
    }
}