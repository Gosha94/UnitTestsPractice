namespace BusinessLogic.App.Logic
{
    public class InMemoryCalculator
    {
        private int _sum = 0;

        public void Add (int number)
        {
            _sum += number;
        }

        public int FinalSum ()
        {
            int temp = _sum;
            _sum = 0;
            return temp;
        }

    }
}
