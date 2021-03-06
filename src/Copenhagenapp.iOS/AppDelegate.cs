﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using UIKit;
using CarouselView.FormsPlugin.iOS;

namespace Copenhagenapp.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            global::Xamarin.Forms.Forms.Init();
            global::Rg.Plugins.Popup.Popup.Init();
            global::FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            global::FFImageLoading.ImageService.Instance.Initialize();

            // Code for starting up the Xamarin Test Cloud Agent
#if !APPSTORE_RELEASE
            Xamarin.Calabash.Start();
#endif
            LoadApplication(new App(new iOSInitializer()));
            CarouselViewRenderer.Init();

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
