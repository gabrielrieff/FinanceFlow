using FinanceFlow.Communication.Enums;

namespace FinanceFlow.Communication.Requests;

public class RequestExpenseJson
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime Create_at { get; set; }

    public decimal Amount { get; set; }

    public PaymentType PaymentType { get; set; }
}
