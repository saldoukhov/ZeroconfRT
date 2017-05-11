﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Net.Wifi;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using ZeroconfTest.Xam;

namespace ZeroconfTest.Xamarin.Droid
{
	[Activity (Label = "ZeroconfTest.Xamarin", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

            SetPage (App.GetMainPage ());
		}

	   
	   
	}
}

