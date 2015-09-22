using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    protected virtual void OnOrientationChanged (OrientationValue newOrientation) { }

    protected override void OnSizeAllocated(double width, double height)
    {
      base.OnSizeAllocated(width, height);

      // block against repeated calls
      if (width != _width || height != _height)
      {
        _width = width;
        _height = height;

        OnOrientationChanged(width > height ? OrientationValue.Landscape : OrientationValue.Portrait);
      }
    }
  }
}
