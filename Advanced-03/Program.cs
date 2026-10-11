namespace Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1
            List<int> grades = new List<int>()
        {
            85, 92, 78, 95, 88, 70, 100, 65
        };

            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }

            Console.WriteLine("\nCount: " + grades.Count);
            Console.WriteLine("First Grade: " + grades.First());
            Console.WriteLine("Last Grade: " + grades.Last());

            grades.Sort();
            Console.WriteLine("\nSorted Grades:");

            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }

            int firstAbove90=grades.Find(g => g > 90);
            Console.WriteLine("\nFirst Grade Above 90: " + firstAbove90);

            List<int> gradesBelow75 = grades.FindAll(g => g < 75);
            Console.WriteLine("\nGrades Below 75:");
            foreach (int grade in gradesBelow75)
            {
                Console.Write(grade + " ");
            }

            grades.RemoveAll(g => g < 75);
            Console.WriteLine("\nGrades After Removing Failures:");
            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }

            bool hasPerfectScore = grades.Contains(100);
            Console.WriteLine("\nany grade equals 100: " + hasPerfectScore);

            List<string> gradeStrings = grades.ConvertAll(g => $"{g} string");
            Console.WriteLine("\nGrade Strings:");
            foreach (string gradeString in gradeStrings)
            {
                Console.Write(gradeString + " ");
            }

            #endregion


            #region Exercise 2
            SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");

            Console.WriteLine("\nLeaderboard:");
            foreach (var player in leaderboard)
            {
                Console.WriteLine($"Score: {player.Key}, Name: {player.Value}");
            }
            Console.WriteLine($"\nFirst Key: {leaderboard.First().Key}");
            Console.WriteLine($"First Value: {leaderboard.First().Value}");


            Console.WriteLine(leaderboard.ContainsKey(500));

            Console.WriteLine(leaderboard.GetValueOrDefault(999, "Player not found"));



            leaderboard.Remove(200);

            foreach (var player in leaderboard)
            {
                Console.WriteLine($"Score: {player.Key}, Name: {player.Value}");
            }










            #endregion
        }
    }
}
