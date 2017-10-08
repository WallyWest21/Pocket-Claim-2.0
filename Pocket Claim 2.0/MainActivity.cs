using Android.App;
using Android.Widget;
using Android.OS;

namespace Pocket_Claim_2._0
{
    [Activity(Label = "Pocket_Claim_2._0", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

