﻿using Foundation;
using UIKit;
using Urho.iOS;
using System.Threading.Tasks;

namespace Urho.Samples.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			LaunchGame ();
			return true;
		}

		async void LaunchGame()
		{
			await Task.Yield ();
			ApplicationLauncher.Run(() => new _06_SkeletalAnimation(new Context()));
		}
	}
}