﻿using Bogus;
using FinanceFlow.Communication.Requests.Login;

namespace commonTestUtilities.Requests.User;

public class RequestLoginJsonBuilder
{
    public static RequestLoginJson Build()
    {
        return new Faker<RequestLoginJson>()
            .RuleFor(user => user.Email, faker => faker.Internet.Email())
            .RuleFor(user => user.Password, faker => faker.Internet.Password(prefix: "!Aa1"));
            
    }
}
