using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwipeBinding : ContentPage
	{
		public SwipeBinding()
		{
			InitializeComponent();
			BindingContext = new SwipeCommandPageViewModel();
		}
	}
}
