using MoviesDatabaseWindowsFormApp.Context;
using MoviesDatabaseWindowsFormApp.Entities;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace MoviesDatabaseWindowsFormApp
{
    public partial class Form1 : Form
    {
        MovieDbContext context = new MovieDbContext();
        string moviesFilePath;
        string usersFilePath;
        string ratingsFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the browse button click event. Allows the user to select multiple text files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Awaiting Action";

            OpenFileDialog ofd = new OpenFileDialog();

            // Enabling the user to select multiple files
            ofd.Multiselect = true;
            // Adding filter to select only txt files
            ofd.Filter = "Text files (*.txt)|*.txt";

            ofd.ShowDialog();

            foreach (string file in ofd.FileNames)
            {
                // Determining file type and setting the appropriate file path
                if (file.EndsWith("Movies.txt"))
                    moviesFilePath = file;
                else if (file.EndsWith("Users.txt"))
                    usersFilePath = file;
                else if (file.EndsWith("Ratings.txt"))
                    ratingsFilePath = file;
                else
                    MessageBox.Show("Please select the txt files for Movies, Users or Ratings.");
            }

            // Displaying selected file paths
            txtMoviesFile.Text = string.IsNullOrEmpty(moviesFilePath) ? "Not selected" : moviesFilePath;
            txtUsersFile.Text = string.IsNullOrEmpty(usersFilePath) ? "Not selected" : usersFilePath;
            txtRatingsFile.Text = string.IsNullOrEmpty(ratingsFilePath) ? "Not selected" : ratingsFilePath;
        }

        /// <summary>
        /// Event handler for the insert button click event. Reads and inserts data from selected files into the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            // Checking if at least onefile is selected
            if (string.IsNullOrEmpty(moviesFilePath)
                && string.IsNullOrEmpty(usersFilePath)
                && string.IsNullOrEmpty(ratingsFilePath))
            {
                MessageBox.Show("Please select at least one file (Movies, Users, or Ratings) before inserting data.");
                return;
            }

            // Reading and inserting data from each file
            int moviesInserted = 0, usersInserted = 0, ratingsInserted = 0;

            if (!string.IsNullOrEmpty(moviesFilePath))
                moviesInserted = ReadAndInsertMovies(moviesFilePath);

            if (!string.IsNullOrEmpty(usersFilePath))
                usersInserted = ReadAndInsertUsers(usersFilePath);

            if (!string.IsNullOrEmpty(ratingsFilePath))
                ratingsInserted = ReadAndInsertRatings(ratingsFilePath);

            // Displaying success message
            string statusMessage = $"Data insertion completed successfully.\nMovies inserted: {moviesInserted}, " +
                $"Users inserted: {usersInserted}, Ratings inserted: {ratingsInserted}";
            labelStatus.Text = statusMessage;

            // Setting the file paths to empty string after inserting the data.
            txtMoviesFile.Text = "";
            txtUsersFile.Text = "";
            txtRatingsFile.Text = "";
        }

        /// <summary>
        /// Reads and inserts movie data from a text file into the database.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public int ReadAndInsertMovies(string filePath)
        {
            List<Movie> movies = new List<Movie>();
            int rowsInserted = 0;

            //FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] movieInfo = line.Split('|');

                    Movie movie = new Movie
                    {
                        // Not selecting the MovieID since it is auto-incremented.
                        //MovieID = int.Parse(movieInfo[0]),
                        Title = !string.IsNullOrEmpty(movieInfo[1]) ? movieInfo[1] : "Unknown",
                        IMDbLink = !string.IsNullOrEmpty(movieInfo[4]) ? movieInfo[4] : "Unknown",
                        ReleaseDate = (movieInfo[2] == "" ? DateTime.MinValue : DateTime.Parse(movieInfo[2])),
                        Action = movieInfo[5] == "1",
                        Adventure = movieInfo[6] == "1",
                        Comedy = movieInfo[7] == "1",
                        Drama = movieInfo[8] == "1",
                        Romance = movieInfo[9] == "1",
                        Thriller = movieInfo[10] == "1",
                        ScienceFiction = movieInfo[11] == "1",
                        Animation = movieInfo[12] == "1",
                        Fantasy = movieInfo[13] == "1",
                        Horror = movieInfo[14] == "1",
                        Musical = movieInfo[15] == "1",
                        Mystery = movieInfo[16] == "1",
                        Documentary = movieInfo[17] == "1",
                        War = movieInfo[18] == "1",
                        Crime = movieInfo[19] == "1",
                        Western = movieInfo[20] == "1",
                        FilmNoir = movieInfo[21] == "1",
                        Childrens = movieInfo[22] == "1",
                        Other = movieInfo[23] == "1"
                    };

                    movies.Add(movie);
                }
            }
            context.Movies.AddRange(movies);
            rowsInserted = context.SaveChanges();

            return rowsInserted;
        }

        /// <summary>
        /// Reads and inserts user data from a text file into the database.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public int ReadAndInsertUsers(string filePath)
        {
            List<User> users = new List<User>();
            int rowsInserted = 0;

            //FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] userInfo = line.Split('|');

                    User user = new User
                    {
                        // Not selecting the UserID since it is auto-incremented.
                        //UserID = int.Parse(userInfo[0]),
                        Age = int.Parse(userInfo[1]),
                        Gender = userInfo[2],
                        Occupation = userInfo[3],
                        ZipCode = userInfo[4]
                    };

                    users.Add(user);
                }
            }
            context.Users.AddRange(users);
            rowsInserted = context.SaveChanges();

            return rowsInserted;
        }

        /// <summary>
        /// Reads and inserts rating data from a text file into the database.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public int ReadAndInsertRatings(string filePath)
        {
            // Checking if both movies and users files have been selected since Ratings table contains foreign key
            // references from Movies and Users table.
            if (string.IsNullOrEmpty(moviesFilePath) || string.IsNullOrEmpty(usersFilePath))
            {
                MessageBox.Show("Please select the Movies and Users files in addition to the Ratings file.");
                return 0;
            }

            List<Rating> ratings = new List<Rating>();
            int rowsInserted = 0;

            //FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] ratingInfo = line.Split('\t');

                    Rating rating = new Rating
                    {
                        UserID = int.Parse(ratingInfo[0]),
                        MovieID = int.Parse(ratingInfo[1]),
                        RatingValue = int.Parse(ratingInfo[2]),
                        Timestamp = int.Parse(ratingInfo[3])
                    };

                    ratings.Add(rating);
                }
            }

            context.Ratings.AddRange(ratings);
            rowsInserted = context.SaveChanges();

            return rowsInserted;
        }
    }
}
