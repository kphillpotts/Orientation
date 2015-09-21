using Xamarin.Forms;

namespace XfOrientation
{
  public partial class FlowLayoutPage : ContentPage
  {
    public FlowLayoutPage(MovieQuote movieQuote)
    {
      InitializeComponent();
      MovieQuote = movieQuote;
      BindingContext = this;
    }

    public MovieQuote MovieQuote { get; set; }
  }
}