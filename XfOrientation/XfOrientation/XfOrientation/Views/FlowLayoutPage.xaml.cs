using XfOrientation.Views;

namespace XfOrientation
{
  public partial class FlowLayoutPage : BaseContentPage
  {
    public FlowLayoutPage(MovieQuote movieQuote)
    {
      InitializeComponent();
      MovieQuote = movieQuote;
      BindingContext = this;
    }
    public MovieQuote MovieQuote { get; set; }
    public int CalculatedFontSize { get; set; }

    protected override void OnSizeAllocated(double width, double height)
    {
      base.OnSizeAllocated(width, height);
      QuoteLabel.FontSize = FontSizeHelper.CalculateFontSize(MovieQuote.Quote, width/1.5, height/1.5);

    }

    
  }
}