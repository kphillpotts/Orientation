using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Xamarin.Forms;

namespace XfOrientation.WinPhone
{
  public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
  {
    public MainPage()
    {
      InitializeComponent();

      //if (Device.Idiom == TargetIdiom.Phone)
      //  SupportedOrientations = SupportedPageOrientation.Portrait;

      global::Xamarin.Forms.Forms.Init();

      LoadApplication(new XfOrientation.App());
    }
  }
}
