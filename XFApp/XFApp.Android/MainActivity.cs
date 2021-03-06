﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XFApp.Droid
{
  [Activity(Label = "XFApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
  public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
  {
    protected override async void OnCreate(Bundle bundle)
    {
      TabLayoutResource = Resource.Layout.Tabbar;
      ToolbarResource = Resource.Layout.Toolbar;

      base.OnCreate(bundle);

      global::Xamarin.Forms.Forms.Init(this, bundle);

      var obj = await Csla.DataPortal.CreateAsync<ClassLibrary1.SomeBusinessClass>();
      obj = obj.Clone();


      LoadApplication(new App());
    }
  }
}

