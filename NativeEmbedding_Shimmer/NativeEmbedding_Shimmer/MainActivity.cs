using Microsoft.Maui.Embedding;
using Android.App;
using Android.OS;
using Syncfusion.Maui.Shimmer;
using Microsoft.Maui.Platform;
using Syncfusion.Maui.Core.Hosting;

namespace NativeEmbedding_Shimmer
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        MauiContext? _mauiContext;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            MauiAppBuilder builder = MauiApp.CreateBuilder();
            builder.UseMauiEmbedding<Microsoft.Maui.Controls.Application>();
            builder.ConfigureSyncfusionCore();
            MauiApp mauiApp = builder.Build();
            _mauiContext = new MauiContext(mauiApp.Services, this);

            SfShimmer shimmer = new SfShimmer()
            {
                Type = ShimmerType.Feed,
                VerticalOptions = LayoutOptions.Fill
            };
            Android.Views.View view = shimmer.ToPlatform(_mauiContext);

            // Set our view from the "main" layout resource
            SetContentView(view);
        }
    }
}