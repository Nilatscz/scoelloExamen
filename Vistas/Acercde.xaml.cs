namespace scoelloExamen.Vistas;

public partial class Acercde : ContentPage
{
	public Acercde()
	{
		InitializeComponent();
	}

    private void btncontinuar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}