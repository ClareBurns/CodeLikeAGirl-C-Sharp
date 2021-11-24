using System;

namespace Lesson_8_GiftCard
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointsCard = new GiftCard(); //this initialises it as 100! Doesn't need to take anything inside
            pointsCard.SpendPoints(700);
            pointsCard.SpendPoints(400);
        }
    }

    public class GiftCard
    {
        private int _pointsBalance;

        public GiftCard()
        {
            _pointsBalance = 1000;
        }

        public void SpendPoints(int points)
        {
            if (_pointsBalance >= points)
            {
                _pointsBalance -= points; //here you can change the pointsBalance but only through a method in the class, no other methods. 
                Console.WriteLine($"{points} points spent!");
            }
            else
            {
                Console.WriteLine("You don't have enough points");
            }
        }
    }
}
