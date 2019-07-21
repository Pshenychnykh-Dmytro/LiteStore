using LiteStore.Application.Interfaces.AccountService;
using LiteStore.Application.Interfaces.AccountService.Dto;
using System;

namespace LiteStore.Application.Services.AccountService
{
    public class AccountService : IAccountService
    {
        public void CreateAccount(AccountDto accountDto)
        {
            
        }

        public AccountDto FindAccount(string login, string password)
        {
            return null;
        }
    }
}
