namespace MyLibrary
{
    public class DoThings
    {
        public bool DoManyThings(bool param)
        {
            if (param)
            {
                return true;
            }
            int dontused = 10;
            return false;
        }

        public void NoTested()
        {
            int a = 10;
            int b = 20;
            if (a == 10)
            {
                if (b == 20)
                {
                    if (a == 12)
                    {
                        int r = 12;
                    }
                }
            }
        }
    }
}
