using FinanceFlow.Application.AutoMapper;
using FinanceFlow.Application.UseCases.Expenses.DeleteById;
using FinanceFlow.Application.UseCases.Expenses.Get;
using FinanceFlow.Application.UseCases.Expenses.GetAll;
using FinanceFlow.Application.UseCases.Expenses.Register;
using FinanceFlow.Application.UseCases.Expenses.Report;
using FinanceFlow.Application.UseCases.Expenses.Update;
using Microsoft.Extensions.DependencyInjection;
namespace FinanceFlow.Api;

public static class DependecyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services) 
    {
        AddUseCases(services);
        AddAutoMapper(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }
    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterExpensesUseCase, RegisterExpensesUseCase>();
        services.AddScoped<IGetAllExpensesUseCase, GetAllExpensesUseCase>();
        services.AddScoped<IGetExpenseUseCase, GetExpenseUseCase>();
        services.AddScoped<IDeleteExpenseUseCase, DeleteExpenseUseCase>();
        services.AddScoped<IUpdateExpenseUseCase, UpdateExpenseUseCase>();
        services.AddScoped<IGenerateExpensesReportExcelUseCase, GenerateExpensesReportExcelUseCase>();
        services.AddScoped<IGenerateExpensesReportPDFUseCase, GenerateExpensesReportPDFUseCase>();
    }
}
