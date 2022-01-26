namespace ADM_DEV_TEST.DL.Services
{
    public class Test4Service : ITest4Service
    {
        public bool TxtPalindrome(string txt)
        {
            bool res = true;

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] != txt[txt.Length - 1 - i])
                {
                    res = false;
                }
            }

            return res;
        }
    }
}
