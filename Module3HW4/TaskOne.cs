using System;

namespace Module3HW4
{
    public class TaskOne
    {
        public event Func<int, int, int> SumEvent;

        public int SumResult(int x, int y)
        {
            SumEvent += Sum;
            SumEvent += Sum;
            var sum = 0;
            foreach (var item in SumEvent.GetInvocationList())
            {
                sum += (int)item.DynamicInvoke(x, y);
            }

            return sum;
        }

        public void TryCatch(Action a)
        {
            try
            {
                a.Invoke();
            }
            catch
            {
            }
        }

        private int Sum(int x, int y) => x + y;
    }
}
