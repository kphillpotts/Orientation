using Xamarin.Forms;

namespace XfOrientation.Views
{
  public class BaseContentPage : ContentPage
  {
    protected enum OrientationValue
    {
      Portrait,
      Landscape
    }

    private double _width, _height;


    protected override void OnSizeAllocated(double width, double height)
    {
      base.OnSizeAllocated(width, height);

      if (width != _width || height != _height)
      {
        _width = width;
        _height = height;

        OnOrientationChanged(width > height ? OrientationValue.Landscape : OrientationValue.Portrait);
      }
    }

    protected virtual void OnOrientationChanged(OrientationValue newOrientation) { }


  }
}