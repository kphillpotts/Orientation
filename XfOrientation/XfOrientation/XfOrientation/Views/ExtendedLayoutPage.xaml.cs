using DeviceOrientation.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace XfOrientation
{
  public partial class ExtendedLayoutPage : ContentPage
  {
    public ExtendedLayoutPage(MovieQuote movieQuote)
    {
      InitializeComponent();
      MovieQuote = movieQuote;
      BindingContext = this;

      var svc = DependencyService.Get<IDeviceOrientation>();
      var orientation = svc.GetOrientation();
      HandleOrientationChange(orientation);
    }

    public MovieQuote MovieQuote { get; set; }

    protected override void OnAppearing()
    {
      base.OnAppearing();
      MessagingCenter.Subscribe<DeviceOrientationChangeMessage>(this, DeviceOrientationChangeMessage.MessageId,
        message => { HandleOrientationChange(message.Orientation); });
    }


    protected override void OnDisappearing()
    {
      MessagingCenter.Unsubscribe<DeviceOrientationChangeMessage>(this, DeviceOrientationChangeMessage.MessageId);
      base.OnDisappearing();
    }

    private void HandleOrientationChange(DeviceOrientations orientation)
    {
      RightContent.IsVisible = DeviceOrientations.Landscape == orientation;
    }
  }
}