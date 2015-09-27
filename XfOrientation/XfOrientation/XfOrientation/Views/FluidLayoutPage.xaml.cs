using XfOrientation.Views;

namespace XfOrientation
{
  public partial class FluidLayoutPage : BaseContentPage
  {
    public FluidLayoutPage(MovieQuote movieQuote)
    {
      InitializeComponent();
      MovieQuote = movieQuote;
      BindingContext = this;
    }

    public MovieQuote MovieQuote { get; set; }


  }
}