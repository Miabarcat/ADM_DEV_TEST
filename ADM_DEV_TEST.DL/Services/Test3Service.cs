namespace ADM_DEV_TEST.DL.Services
{
    public class Test3Service : ITest3Service
    {
        public int NbRepeatWord(string txt, string word)
        {
            string[]? txtList = txt.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int res = txtList.Where(x => x.Trim() == word.Trim()).Count();

            return res;
        }
    }
}
