namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //Create a one - dimensional array double[] prices with the values 25.5, 40.0, 33.75.Print
            //the second price(index 1)
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
#endregion
            #region question2
            //            Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            int[,] shelfCopies = new int[2, 2] { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion
            #region question3
            //            Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main
            Program.PrintWelcomeMessage();

            #endregion
            #region question4
            //            Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with
            //"Clean Code"
            PrintBookTitle("clean code");
            #endregion
            #region question5
            //            Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            // i expect to see 450 but it appears just 400 without updating
            //that's because it's not updated in it's reference it was acopy of it in the stack 
            #endregion
            #region question6
            //            Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            double[] pricess = { 25.5, 40.0 };
            ApplyDiscount(pricess);
            Console.WriteLine(pricess[0]);
            //i expect to see 20.5
            //because the array is a reference type it updated the value in it's origin
            #endregion
            #region question7
            //            Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?
            AddBonusPages2(ref pages);
            Console.WriteLine(pages);
            //the difference is that the updated value is done because i send the reference itself


            #endregion
            #region question8
            //            Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward
            double[] prices2 = { 25.5, 40.0 };
            ReplaceArray(ref prices2);
            Console.WriteLine(prices2.Length);
            #endregion

        }


        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");


        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title:" + title);
        }
        static void AddBonusPages(int pages)
        {
            pages = pages + 50;

        }
        static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }
        static void AddBonusPages2(ref int pages)
        {
            pages = pages + 50;

        }
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };

        }


    }
}