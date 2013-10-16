namespace MyLibrary
{
    public class DoThingsDup
    {
      
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
