﻿using FinanceFlow.Domain.Entities;

namespace WebApi.Test.Resouces;

public class UserIdentityManager
{
    private User _user;
    private string _password;
    private string _token;

    public UserIdentityManager(User user, string password, string token)
    {
        _password = password;
        _user = user;
        _token = token;
    }

    public string GetEmail() => _user.Email;
    public string GetName() => _user.Name;
    public string GetPassword() => _password;
    public string GetToken() => _token;

}
