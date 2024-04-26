namespace scoelloExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuar)
	{
		InitializeComponent();
        DisplayAlert("Bienvenido", "" + usuar, "Continuar");
        LblUsuario.Text = "Usuario Conectado: " + usuar;

    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double monto = double.Parse(Txtmontoi.Text);
        if ((monto > 0) && (monto < 1500))
        {
            double saldo = 1500 - monto;
            double cuota = ((1500 * 0.04) + saldo) / 4;
          Lbcuota.Text=cuota.ToString();
        }
        else
        {
            DisplayAlert("Alerta", "cuota inicial no permitida", "Continuar");
        }

   }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Resumen());
    }
}
