using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XfOrientation.Views;

namespace XfOrientation
{
  public partial class OrientationPage : BaseContentPage
  {
    private int _layoutType;

    public OrientationPage()
    {
      InitializeComponent();
      MovieQuotes = new List<MovieQuote>(MovieQuoteGenerater.MovieQuotes);
      LayoutType = 0;
      this.BindingContext = this;
    }

    public int LayoutType
    {
      get { return _layoutType; }
      set { _layoutType = value; }
    }


    public List<MovieQuote> MovieQuotes { get; set; }

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

    private void List_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
      
    }

    private void List_OnItemTapped(object sender, ItemTappedEventArgs e)
    {

      Page nextPage = null;

      MovieQuote quote = e.Item as MovieQuote;
      if (quote == null)
        return;

      if (LayoutType == 0)
        nextPage = new FlowLayoutPage(quote);
      else if (LayoutType == 1)
        nextPage = new ExtendedLayoutPage(quote);
      else if (LayoutType == 2)
        nextPage = new ComplimentaryLayoutPage(quote);
      
      list.SelectedItem = null;

      Navigation.PushAsync(nextPage);



    }
  }
}
