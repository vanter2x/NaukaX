using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace SeeSharpBasics.Training3.Homework.SlawekKowal
{
    public class SlawekKBankResolver: BankResolver
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