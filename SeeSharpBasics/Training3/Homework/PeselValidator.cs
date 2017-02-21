namespace SeeSharpBasics.Training3.Homework
{
    public abstract class PeselValidator
    {
        public abstract bool IsPeselValid(string peselCandidate); // 84 08 08 18074

        protected abstract bool IsPeselDateValid(string year, string month, string day); // 84 08 08
    }
}