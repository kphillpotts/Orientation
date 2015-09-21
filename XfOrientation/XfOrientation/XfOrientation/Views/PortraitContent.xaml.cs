using Xamarin.Forms;

namespace XfOrientation
{
  public partial class PortraitContent : ContentView
  {
    public PortraitContent(MovieQuote movieQuote)
    {
      InitializeComponent();
      this.MovieQuote = movieQuote;
      BindingContext = this;
    }

    public MovieQuote MovieQuote { get; set; }
  }
}