using DeviceOrientation.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace XfOrientation.Views
{
  public partial class ComplimentaryLayoutPage : ContentPage
  {
    private readonly MovieQuote _movieQuote;
    private readonly LandscapeContent _landscape;
    private readonly PortraitContent _portrait;

    public ComplimentaryLayoutPage(MovieQuote movieQuote)
    {
      InitializeComponent();
      _movieQuote = movieQuote;

      var svc = DependencyService.Get<IDeviceOrientation>();
      var orientation = svc.GetOrientation();

      _portrait = new PortraitContent(_movieQuote);
      _landscape = new LandscapeContent(_movieQuote);

      HandleOrientationChange(orientation);
    }

    public ContentView I { get; private set; }

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
      if (orientation == DeviceOrientations.Portrait)
        Content = _portrait;
      else
        Content = _landscape;
    }
  }
}