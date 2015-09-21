﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DeviceOrientation.Forms.Plugin.WindowsPhone;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace XfOrientation.WinPhone
{
  public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
  {
    public MainPage()
    {
      InitializeComponent();
      SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

      global::Xamarin.Forms.Forms.Init();
      DeviceOrientationImplementation.Init();

      LoadApplication(new XfOrientation.App());
    }
  }
}
