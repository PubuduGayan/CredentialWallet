
using System.Linq;
using CredentialWallet.Droid.Credential;
using CredentialWallet.Interfaces.Credential;
using Xamarin.Forms;
using Xamarin.Auth;


[assembly: Dependency(typeof(CredentialWalletDroid))]
namespace CredentialWallet.Droid.Credential
{
    public class CredentialWalletDroid : ICredentialWallet
    {
        public string PersonId
        {
            get
            {
                var account = AccountStore.Create(Forms.Context).FindAccountsForService(App.AppName).FirstOrDefault();
                return account?.Properties["personId"];
            }
        }

        public string UserName
        {
            get
            {
                var account = AccountStore.Create(Forms.Context).FindAccountsForService(App.AppName).FirstOrDefault();
                return account?.Username;
            }
        }

        public string Token
        {
            get
            {
                var account = AccountStore.Create(Forms.Context).FindAccountsForService(App.AppName).FirstOrDefault();
                return account?.Properties["token"];
            }
        }
        public void Save(string userName, string personId, string token)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(token) ||
                string.IsNullOrWhiteSpace(personId)) return;


            Delete(); // if you don't want delete before you saving new just take of this.

            var account = new Account
            {
                Username = userName
            };

            account.Properties.Add("personId", personId);
            account.Properties.Add("token", token);
            AccountStore.Create(Forms.Context).Save(account, App.AppName);
        }

        public void Delete()
        {
            var accounts = AccountStore.Create(Forms.Context).FindAccountsForService(App.AppName).ToList();
            accounts?.ForEach(f => AccountStore.Create(Forms.Context).Delete(f, App.AppName));
        }
        
    }
}