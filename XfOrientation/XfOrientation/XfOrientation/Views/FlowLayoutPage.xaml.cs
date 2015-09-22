using System.Diagnostics;
using Xamarin.Forms;
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

    protected override void OnSizeAllocated(double width, double height)
    {
      base.OnSizeAllocated(width, height);

      if (width > height)
        Debug.WriteLine("Landscape");
      else
        Debug.WriteLine("Portrait");
    }
  }
}