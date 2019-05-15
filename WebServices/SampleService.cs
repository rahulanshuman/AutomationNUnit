using System;

namespace WebServices
{
    public class SampleService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first");
        }
    }
}
