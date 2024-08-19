namespace MauiApp1
{
	public partial class ShoulderPage : ContentPage
	{
		int count = 0;

		public ShoulderPage()
		{
			//InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;

			//if (count == 1)
			//	CounterBtn.Text = $"Clicked {count} time";
			//else
			//	CounterBtn.Text = $"Clicked {count} times";

			//SemanticScreenReader.Announce(CounterBtn.Text);
		}
	}

}
