namespace SeeSharpBasics.Training3.Homework
{
    public abstract class BankResolver
    {
        public abstract string GetBankName(string bankCodeId); // nr konta 1011404325324542543543 => 1140 Mbank 1010 NBP 1440 nordea

        public abstract string GetBankCodeForAccount(string account); // 47 3285 72856047604376035
    }
}