namespace scoelloExamen.Vistas;

public partial class Resumen : ContentPage
{
	public Resumen()
	{
		InitializeComponent();
	}

    private void btnfinal_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}