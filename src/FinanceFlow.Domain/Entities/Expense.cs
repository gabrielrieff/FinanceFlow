﻿using FinanceFlow.Domain.Enums;

namespace FinanceFlow.Domain.Entities;

public class Expense
{
    public long Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public DateTime Create_at { get; set; }

    public decimal Amount { get; set; }

    public PaymentsType PaymentType { get; set; }
}
