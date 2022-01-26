namespace ADM_DEV_TEST.DL.Services
{
    public class Test2Service : ITest2Service
    {
        public int MaxValue(List<int> Nums)
        {
            int res = Nums.Max();

            return res;
        }
    }
}
