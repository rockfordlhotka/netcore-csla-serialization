using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Csla;

namespace AndroidApp
{
  [Activity(Label = "AndroidApp", MainLauncher = true)]
  public class MainActivity : Activity
  {
    protected override async void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);

      // Set our view from the "main" layout resource
      SetContentView(Resource.Layout.Main);

      var obj = await Csla.DataPortal.CreateAsync<SomeBusinessClass>();
      obj = obj.Clone();

      var obj2 = await Csla.DataPortal.CreateAsync<ClassLibrary1.SomeBusinessClass>();
      obj2 = obj2.Clone();

    }
  }

  [Serializable]
  public class SomeBusinessClass : BusinessBase<SomeBusinessClass>, ISomeBusinessClass
  {

  }

  public interface ISomeBusinessClass : IBusinessBase
  {

  }
}

