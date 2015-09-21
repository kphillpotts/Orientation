using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceOrientation.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace XfOrientation
{
  public partial class OrientationPage : ContentPage
  {
    public OrientationPage()
    {
      InitializeComponent();
      var svc = DependencyService.Get<DeviceOrientation.Forms.Plugin.Abstractions.IDeviceOrientation>();
      var orientation = svc.GetOrientation();
      MainText.Text = orientation.ToString();

    }

    protected override void OnSizeAllocated(double width, double height)
    {
      base.OnSizeAllocated(width, height);

      if (width > height)
        Debug.WriteLine("Landscape");
      else
        Debug.WriteLine("Portrait");
    }

    private enum DeviceOrienation
    {
      Portrait,
      Landscape
    }

    //public DeviceOrienation IsPortrait(double width, double height)
    //{
    //  return width > height ? DeviceOrienation.Landscape : DeviceOrienation.Portrait;
    //}


    protected override void OnAppearing()
    {
      MessagingCenter.Subscribe<DeviceOrientationChangeMessage>(this, DeviceOrientationChangeMessage.MessageId,
        (message) =>
        {
          HandleOrientationChange(message);
        });
      base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
      MessagingCenter.Unsubscribe<DeviceOrientationChangeMessage>(this, DeviceOrientationChangeMessage.MessageId);
      base.OnDisappearing();
    }

    private void HandleOrientationChange(DeviceOrientationChangeMessage message)
    {
      MainText.Text = message.Orientation.ToString();

      if (message.Orientation == DeviceOrientations.Landscape)
        MainStack.Orientation = StackOrientation.Horizontal;
      else
      {
        MainStack.Orientation = StackOrientation.Vertical;
      }
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
      CarouselPage carousel = new CarouselPage();
      foreach (var movieQuote in MovieQuoteGenerater.MovieQuotes)
      {
        carousel.Children.Add(new ExtendedLayoutPage(movieQuote));
      }

      Navigation.PushAsync(carousel);
    }

    private void ComplimenatryLayout_OnClicked(object sender, EventArgs e)
    {
      CarouselPage carousel = new CarouselPage();
      foreach (var movieQuote in MovieQuoteGenerater.MovieQuotes)
      {
        carousel.Children.Add(new Views.ComplimentaryLayoutPage(movieQuote));
      }

      Navigation.PushAsync(carousel);
    }

    private void FlowLayout_OnClicked(object sender, EventArgs e)
    {

      Navigation.PushAsync(new FlowLayoutPage(MovieQuoteGenerater.GetRandomQuote()));
    }

  
}
}
