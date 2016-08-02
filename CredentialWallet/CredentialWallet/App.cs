using CredentialWallet.Interfaces.Credential;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace CredentialWallet
{
    public class App : Application
    {

        public static UnityContainer Container { get; set; }
        public static string AppName { get; set; } = "YourApp";

        public App()
        {

            //Bootstrapper bs = new Bootstrapper();
            //App.Container = (UnityContainer)bs.Container;
            //bs.Run(this);
            
            // The root page of your application

            MainPage = Container.Resolve(typeof (Login), "login") as Login;
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
