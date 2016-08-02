
namespace CredentialWallet.Interfaces.Credential
{
    public interface ICredentialWallet
    {
        string PersonId { get; }

        string UserName { get; }

        string Token { get; }

        void Save(string userName, string personId, string token);

        void Delete();
        
    }
}
