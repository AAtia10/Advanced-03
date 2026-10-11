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


            #region Exercise 3
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook.Add("Ahmed", "01011111111");
            phoneBook.Add("Sara", "01022222222");
            phoneBook.Add("Ali", "01033333333");
            phoneBook.Add("Mona", "01044444444");

            phoneBook["Omar"] = "01055555555";

            phoneBook["Ahmed"] = "01099999999";

            try
            {
                phoneBook.Add("Ahmed", "01066666666");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Add Error: {ex.Message}");
            }

            Console.WriteLine(phoneBook.TryAdd("Ahmed", "01077777777"));

            Console.WriteLine(phoneBook.ContainsKey("Yousef"));

            Console.WriteLine(phoneBook.GetValueOrDefault("Yousef", "Not Found"));

            Console.WriteLine(string.Join(", ", phoneBook.Keys));
            Console.WriteLine(string.Join(", ", phoneBook.Values));


            #endregion


            #region Exercise 4

            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            Console.WriteLine($"Emails Count: {emails.Count}");

            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            HashSet<int> unionSet = new HashSet<int>(setA);
            unionSet.UnionWith(setB);

            Console.WriteLine("Union: " + string.Join(", ", unionSet));



            HashSet<int> intersectSet = new HashSet<int>(setA);
            intersectSet.IntersectWith(setB);

            Console.WriteLine("Intersection: " + string.Join(", ", intersectSet));

            HashSet<int> exceptSet = new HashSet<int>(setA);
            exceptSet.ExceptWith(setB);

            Console.WriteLine("Except: " + string.Join(", ", exceptSet));

            HashSet<int> subset = new HashSet<int> { 1, 2 };

            Console.WriteLine(subset.IsSubsetOf(setA));



            #endregion
        }
    }
}
