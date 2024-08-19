namespace MauiApp1
{
	public partial class ChestPage : ContentPage
	{
		int count = 0;

		public ChestPage()
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
