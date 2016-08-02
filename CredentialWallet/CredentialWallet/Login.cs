using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using CredentialWallet.Interfaces.Credential;
using Xamarin.Forms;
using static Xamarin.Forms.Color;

namespace CredentialWallet
{
    public class Login : ContentPage
    {
        private readonly ICredentialWallet _credentialWallet;
        private readonly WebView _webView;

        public Login(ICredentialWallet credentialWallet)
        {
            
            _credentialWallet = credentialWallet;

            _credentialWallet.Save("Pubudu", "1", "xxxx-xxxx-xxxx-xxx");
            
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,

                //This is not a  good practise use grid instead of stack layout

                Children = {
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Children = { new Label { Text = _credentialWallet.PersonId } }
                    },
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Children = { new Label { Text = _credentialWallet.Token } }
                    },

                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Children = { new Label { Text = _credentialWallet.UserName } }
                    }

                    
                }
            };


        }
        
    }
}
