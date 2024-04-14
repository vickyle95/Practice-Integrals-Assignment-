namespace Practice_Integrals__Assignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Vicky Le
            // Date: 4/13/2024
            // App: Visual Studio 2022 - C#
            // Class: Programming 120
            // Assignment: Practice-Integrals

            // Part1();
            // Part2();
        }

        public static void Part1()
        {
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            // Create variables to store the results for the following equations
            int q1 = number1 + number2;
            int q2 = number3 - number1 + number2;
            int q3 = number3 * number2 - number1;
            int q4 = number1 / (number3 - number1);
            int q5 = (number3 + number3 - number2) * 5;

            // Create variables to the store results for the following equations. Use the results from the first 5 numbers.
            int q6 = q1 * q3;
            int q7 = q2 / q4;
            int q8 = q5 + q1 + number2;
            int q9 = q3 - q6 + number1 * q4;
            int q10 = q3 * q2 + q4 + number2 - q6 / q8;

            Console.WriteLine($"Question 1: {number1} + {number2} = {q1}");
            Console.WriteLine($"Question 2: {number3} - {number1} + {number2} = {q2}");
            Console.WriteLine($"Question 3: {number3} * {number2} - {number1} = {q3}");
            Console.WriteLine($"Question 4: {number1} / ({number3} - {number1}) = {q4}");
            Console.WriteLine($"Question 5: ({number3} + {number3} - {number2}) * 5 = {q5}");
            Console.WriteLine($"Question 6: {q1} * {q3} = {q6}");
            Console.WriteLine($"Question 7: {q2} / {q4} = {q7}");
            Console.WriteLine($"Question 8: {q5} + {q1} + {number2} = {q8}");
            Console.WriteLine($"Question 9: {q3} - {q6} + {number1} * {q4} = {q9}");
            Console.WriteLine($"Question 10: {q3} * {q2} + {q4} + {number2} - {q6} / {q8} = {q10}");
        } // Part 1

        public static void Part2()
        {
            // Word problem
            string wordProblem = "Samantha runs a small bakery. In one day, she bakes 5 batches of cookies, with each batch containing 24 cookies. She sells each cookie for $2. At the end of the day, she gives away 10 cookies to her neighbors and had to throw away 8 cookies that were accidentally burnt. How much money did Samantha make from selling the cookies after giving away and throwing away some of them?";

            // int
            int batches = 5;
            int cookiesPerBatch = 24;
            int singleCookiePrice = 2; // Price per cookie in dollars
            int cookiesGivenAway = 10;
            int cookiesThrownAway = 8;

            // Calculation
            int costOfABatchOfCookies = singleCookiePrice * cookiesPerBatch;
            int totalCookies = cookiesPerBatch * batches;
            int totalCost = totalCookies * singleCookiePrice;
            int costOfCookiesGivenAway = cookiesGivenAway * singleCookiePrice;
            int costOfCookiesThrownAway = cookiesThrownAway * singleCookiePrice;
            int totalEarnings = (totalCookies - cookiesGivenAway - cookiesThrownAway) * singleCookiePrice;

            // Showing Results
            Console.WriteLine(wordProblem);
            Console.WriteLine("\n");
            Console.WriteLine($"Cost of a single cookies: ${singleCookiePrice}");
            Console.WriteLine($"Number of cookies in a batch: {cookiesPerBatch}");
            Console.WriteLine($"Cost for a batch of cookies: ${costOfABatchOfCookies}");
            Console.WriteLine($"Total cookies in {batches} batches: {totalCookies}");
            Console.WriteLine($"Total cost for {batches} batches of cookies: ${totalCost}");
            Console.WriteLine($"Number of cookies given away: {cookiesGivenAway}");
            Console.WriteLine($"Cost of cookies given away: ${costOfCookiesGivenAway}");
            Console.WriteLine($"Number of cookies thrown away:{cookiesThrownAway}");
            Console.WriteLine($"Cost of cookies thrown away: ${costOfCookiesThrownAway}");
            Console.WriteLine($"Total earning after giving away some cookies: ${totalEarnings}");
        } // Part 2
    } // class
} // namespace
