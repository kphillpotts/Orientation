using System;
using Xamarin.Forms;
using XfOrientation.Views;

namespace XfOrientation
{
  public partial class OrientationPage : BaseContentPage
  {
    public OrientationPage()
    {
      InitializeComponent();
    }

    private void Extended_OnClicked(object sender, EventArgs e)
    {
      CarouselPage carousel = new CarouselPage();
      carousel.Title = "Movie Quotes";
      foreach (var movieQuote in MovieQuoteGenerater.MovieQuotes)
      {
        carousel.Children.Add(new ExtendedLayoutPage(movieQuote));
      }

      Navigation.PushAsync(carousel);
    }

    private void ComplimenatryLayout_OnClicked(object sender, EventArgs e)
    {
      CarouselPage carousel = new CarouselPage();
      carousel.Title = "Movie Quotes";
      foreach (var movieQuote in MovieQuoteGenerater.MovieQuotes)
      {
        carousel.Children.Add(new Views.ComplimentaryLayoutPage(movieQuote));
      }

      Navigation.PushAsync(carousel);
    }

    private void FlowLayout_OnClicked(object sender, EventArgs e)
    {
      CarouselPage carousel = new CarouselPage();
      carousel.Title = "Movie Quotes";
      foreach (var movieQuote in MovieQuoteGenerater.MovieQuotes)
      {
        carousel.Children.Add(new FlowLayoutPage(movieQuote));
      }

      Navigation.PushAsync(carousel);
    }
  }
}
