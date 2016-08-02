
using Android.App;
using Android.Content.PM;
using Android.OS;
using CredentialWallet.Droid.Credential;
using CredentialWallet.Interfaces.Credential;
using Microsoft.Practices.Unity;

namespace CredentialWallet.Droid
{
    [Activity(Label = "CredentialWallet", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {

            App.Container = new UnityContainer();
            App.Container.RegisterType<ICredentialWallet, CredentialWalletDroid>();

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

