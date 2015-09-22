using DeviceOrientation.Forms.Plugin.Abstractions;
using Xamarin.Forms;
using XfOrientation.Views;

namespace XfOrientation
{
  public partial class ExtendedLayoutPage : BaseContentPage
  {
    public ExtendedLayoutPage(MovieQuote movieQuote)
    {
      InitializeComponent();
      MovieQuote = movieQuote;
      BindingContext = this;
    }

    public MovieQuote MovieQuote { get; set; }

    protected override void OnOrientationChanged(OrientationValue newOrientation)
    {
      RightContent.IsVisible = newOrientation != OrientationValue.Portrait;
    }
  }
}