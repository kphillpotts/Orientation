using Xamarin.Forms;

namespace XfOrientation
{
  public partial class LandscapeContent : ContentView
  {
    public LandscapeContent(MovieQuote movieQuote)
    {
      InitializeComponent();
      MovieQuote = movieQuote;
      BindingContext = this;
    }

    public MovieQuote MovieQuote { get; set; }
  }
}