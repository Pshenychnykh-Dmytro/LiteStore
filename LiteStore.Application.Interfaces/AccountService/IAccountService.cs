using System.Diagnostics.Eventing.Reader;
using LiteStore.Application.Interfaces.AccountService.Dto;

namespace LiteStore.Application.Interfaces.AccountService
{
    public interface IAccountService
    {
        void CreateAccount(AccountDto accountDto);

        AccountDto FindAccount(string login, string password);
    }
}
