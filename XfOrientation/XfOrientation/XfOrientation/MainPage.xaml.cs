using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XfOrientation.Views;

namespace XfOrientation
{
  public partial class MainPage : BaseContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      MovieQuotes = new List<MovieQuote>(MovieQuoteGenerater.MovieQuotes);
      LayoutType = 0;
      this.BindingContext = this;
    }

    // determine which layout type to use
    private int _layoutType;

    public int LayoutType
    {
      get { return _layoutType; }
      set { _layoutType = value; }
    }

    // list of all the movie quotes
    public List<MovieQuote> MovieQuotes { get; set; }

    private void List_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
      Page nextPage = null;

      MovieQuote quote = e.Item as MovieQuote;
      if (quote == null)
        return;

      if (LayoutType == 0)
        nextPage = new FluidLayoutPage(quote);
      else if (LayoutType == 1)
        nextPage = new ExtendedLayoutPage(quote);
      else if (LayoutType == 2)
        nextPage = new ComplimentaryLayoutPage(quote);
      
      list.SelectedItem = null;

      Navigation.PushAsync(nextPage);
    }
  }
}
