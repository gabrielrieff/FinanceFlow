﻿using FinanceFlow.Domain.Entities;
using FinanceFlow.Domain.Repositories.Expenses;
using Moq;

namespace commonTestUtilities.Repositories.Expenses;

public class ExpensesReadOnlyRepositoryBuilder
{
    private readonly Mock<IExpensesReadOnlyRepository> _repository;

    public ExpensesReadOnlyRepositoryBuilder()
    {
        _repository = new Mock<IExpensesReadOnlyRepository>();
    }

    public ExpensesReadOnlyRepositoryBuilder GetAll(User user, List<Expense> expenses)
    {
        _repository.Setup(repo => repo.GetAll(user)).ReturnsAsync(expenses);
        return this;
    }
    
    public ExpensesReadOnlyRepositoryBuilder FilterByMonth(User user, List<Expense> expenses)
    {
        _repository.Setup(repo => repo.FilterByMonth(user, It.IsAny<DateOnly>())).ReturnsAsync(expenses);
        return this;
    }

    public ExpensesReadOnlyRepositoryBuilder GetById(User user, Expense? expenses)
    {
        if (expenses is not null)
            _repository.Setup(repo => repo.GetById(user, expenses.Id)).ReturnsAsync(expenses);

        return this;
    }


    public IExpensesReadOnlyRepository Build() => _repository.Object;

}
