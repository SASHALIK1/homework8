int totalDebt = 700;
Console.WriteLine($"Боржник має сплатити {totalDebt}");
Console.WriteLine("Введіть суму платежу");
if (int.TryParse(Console.ReadLine(), out int paymentAmount))
{
    Console.WriteLine(CheckCreditStatus(paymentAmount));
}
else
{
    Console.WriteLine("Не вірно введено число");
}

string CheckCreditStatus(int paymentAmount)
{
    if (paymentAmount >= totalDebt)
    {
        double overpayment = paymentAmount - totalDebt;
        return $"Борг повністю погашено. Переплата: {overpayment} грн.";

    }
    else
    {
        double remainingDebt = totalDebt - paymentAmount;
        return $"Залишок боргу: {remainingDebt} грн.";
    }
}