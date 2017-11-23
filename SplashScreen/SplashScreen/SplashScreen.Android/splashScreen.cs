using Android.App;
using Android.Content.PM;
using Android.OS;


namespace SplashScreen.Droid
{
    [Activity(Label = "App9", Icon = "@drawable/icon", Theme = "@style/SplashTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]


    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle saveInstanceState)
        {
            base.OnCreate(saveInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();

            // desativa a atividade de animacao do slide
            OverridePendingTransition(0, 0);
        }
    }
}