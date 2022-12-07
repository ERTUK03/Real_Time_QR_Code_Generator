using Syncfusion.Maui.Barcode;

namespace QR_Code_Generator;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Entry_TextChanged(object sender, EventArgs e)
	{
		qrCode.Value = entry.Text!="" ? entry.Text : qrCode.Value;
    }
}

