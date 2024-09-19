using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using ChessApp.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChessApp
{
    internal static class Program
    {
        public const string UsernameFilePath = "USERNAME TEXT FILE PATH GOES HERE";
        public static ChessDatabase database = new ChessDatabase();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateDatabases();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogIn());
        }

        public static void CreateDatabases()
        {
            try
            {
                database.ExecuteSql("CREATE TABLE Users(Username varchar(10), Password varchar(15) not null, primary key (Username))");
            }
            catch
            {
                // users table already created
            }

            try
            {
                database.ExecuteSql("CREATE TABLE Adjourned(Username varchar(10), BoardState varchar(64) not null, Difficulty integer, WhiteTime integer, BlackTime integer, Increment integer, Turn integer, primary key (Username))");
            }
            catch
            {
                // ajourned table already created
            }

            try
            {
                database.ExecuteSql("CREATE TABLE UserStatistics(Username varchar(10), WhiteWins integer not null, BlackWins integer not null, Draws integer not null, WhiteResigns integer not null, BlackResigns integer not null, WhiteTimeouts integer not null, BlackTimeouts integer not null, WhiteCheckmates integer not null, BlackCheckmates integer not null, EasyWins integer not null, MediumWins integer not null, HardWins integer not null, primary key (Username))");
            }
            catch
            {
                // user statistics table already created
            }
        }

        public static string GetUsername()
        {
            // retrives username from username file
            using (StreamReader reader = new StreamReader(UsernameFilePath))
                return reader.ReadLine();
        }

        public static void ChangeUsername(string username)
        {
            // updates username in username file
            using (StreamWriter writer = new StreamWriter(UsernameFilePath))
                writer.Write(username);
        }

        private static List<User> MergeSort(List<User> usersList)
        {
            if (usersList.Count <= 1) // Base case: if list is already sorted or is empty
                return usersList;

            int middle = usersList.Count / 2;

            // Splitting the list into two halves
            List<User> left = new List<User>();
            List<User> right = new List<User>();

            // Adding first half of usersList to left list
            for (int i = 0; i < middle; i++)
                left.Add(usersList[i]);

            // Adding second half of usersList to right list
            for (int i = middle; i < usersList.Count; i++)
                right.Add(usersList[i]);

            // Recursviely sorting each half of the list
            MergeSort(left);
            MergeSort(right);

            // Merging the sorted halves together
            Merge(usersList, left, right);

            return usersList;
        }

        private static void Merge(List<User> result, List<User> left, List<User> right)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            
            // Comparing elements from the left and right lists and merging them in sorted order
            while (i < left.Count && j < right.Count)
            {
                if (String.Compare(left[i].Username, right[j].Username) < 0)
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            // Copying any remaining elements from left and right lists
            while (i < left.Count)
                result[k++] = left[i++];

            while (j < right.Count)
                result[k++] = right[j++];
        }

        public static bool BinarySearch(List<User> usersList, string targetUsername)
        {
            int left = 0;
            int right = usersList.Count - 1;

            usersList = MergeSort(usersList); // Sorts users alphabetically by username
            
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                int comparisonResult = String.Compare(usersList[middle].Username, targetUsername);

                if (comparisonResult == 0)
                    return true; // Target username found at middle index
                else if (comparisonResult < 0)
                    left = middle + 1; // Target username is in the right half
                else
                    right = middle - 1; // Target username is in the left half
            }

            return false; // Target username was not found in the list)
        }

        public static bool ValidUsername(string username)
        {
            Users users = new Users();
            List<User> usersList = users.GetUsers("SELECT * FROM Users");
            
            // checking whether a user already exists with the specified username
            return !BinarySearch(usersList, username);
        }
    }
}
