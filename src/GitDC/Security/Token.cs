namespace GitDC.Security
{
    public class Token
    {
        private const string ContentKey = "GitDCToken";
        private const double AuthPeriod = 21600; // 15 days
        private const double RenewalPeriod = 1440; // 1 day

        private Token() { }


    }
}
