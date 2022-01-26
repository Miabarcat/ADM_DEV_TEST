namespace ADM_DEV_TEST.DL.Services
{
    public class Test1Service : ITest1Service
    {

        public int MultiplyNumbers(int Num1, int Num2)
        {
            int res = 0;
            for (var i = 1; i <= Num1; i++)
            {
                res += Num2;
            }

            return res;
        }
    }
}
