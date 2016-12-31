using Android.App;
using Android.Widget;
using Android.OS;

namespace kuak
{
    [Activity(Label = "kuak", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // inciamos esta app
            SetContentView (Resource.Layout.Homa);
        }
    }
}

