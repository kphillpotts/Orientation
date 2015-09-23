using Xamarin.Forms;

namespace XfOrientation
{
  public partial class TabletLandscapeContent : ContentView
  {
    public TabletLandscapeContent(MovieQuote movieQuote)
    {
      InitializeComponent();
      MovieQuote = movieQuote;
      BindingContext = this;
    }

    public MovieQuote MovieQuote { get; set; }
  }
}