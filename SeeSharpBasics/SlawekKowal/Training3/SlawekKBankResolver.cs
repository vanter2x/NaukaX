using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.SlawekKowal.Training3
{
    public class SlawekKBankResolver : BankResolver
    {
        const int Start = 2;
        const int Len = 4;
        readonly SlawekKCodeGenerator _codeGen = new SlawekKCodeGenerator();


        public override string GetBankName(string bankCodeId)
        {

            return _codeGen.BanksList.ContainsKey(bankCodeId) ? _codeGen.BanksList[bankCodeId].ToString() : "brak banku!";
        }

        public override string GetBankCodeForAccount(string account)
        {
            return account.Substring(Start, Len);
        }
    }
}