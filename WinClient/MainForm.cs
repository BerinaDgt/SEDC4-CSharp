using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieClasses;


namespace WinClient
{
    public partial class MainForm : Form
    {
        private List<Movie> movies = new List<Movie>();

        public MainForm()
        {
            //var apocalypseNow = new Movie();
            //apocalypseNow.Title = "Apocalypse Now";
            //apocalypseNow.Year = 1979;
            //apocalypseNow.Duration = new TimeSpan(3, 22, 0);
            //apocalypseNow.Genres = new List<Genre>();
            //apocalypseNow.Genres.Add(Genre.War);
            //apocalypseNow.Genres.Add(Genre.Drama);
            //apocalypseNow.Director = new Person();
            //apocalypseNow.Director.FirstName = "Francis";
            //apocalypseNow.Director.LastName = "Ford Coppola";
            //apocalypseNow.Cast = new List<Person>();
            //apocalypseNow.Cast.Add(new Person());
            //apocalypseNow.Cast[0].FirstName = "Martin";
            //apocalypseNow.Cast[0].LastName = "Sheen";
            //apocalypseNow.Cast.Add(new Person());
            //apocalypseNow.Cast[1].FirstName = "Robert";
            //apocalypseNow.Cast[1].LastName = "Duval";
            //apocalypseNow.Cast.Add(new Person());
            //apocalypseNow.Cast[2].FirstName = "Dennis";
            //apocalypseNow.Cast[2].LastName = "Hopper";
            //apocalypseNow.Cast.Add(new Person());
            //apocalypseNow.Cast[3].FirstName = "Marlon";
            //apocalypseNow.Cast[3].LastName = "Brando";

            var apocalypseNow = new Movie("Apocalypse Now", 1979)
            {
                Duration = new TimeSpan(3, 22, 0),
                Genres = new List<Genre> { Genre.War, Genre.Drama },
                Director = new Person { FirstName = "Francis", LastName = "Ford Coppola" },
                Cast = new List<Person>() {
                    new Person {FirstName = "Martin", LastName = "Sheen" },
                    new Person {FirstName = "Robert", LastName = "Duval"},
                    new Person {FirstName = "Dennis", LastName = "Hopper"},
                    new Person { FirstName = "Marlon", LastName = "Brando"}
                },
                ImdbId = "first"
        
            };

            var pulpFiction = new Movie("Pulp Fiction", 1993)
            {
                Duration = new TimeSpan(2, 15, 0),
                Genres = new List<Genre> { Genre.Crime },
                Director = new Person { FirstName = "Quentin", LastName = "Tarantino" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "John", LastName = "Travolta" },
                    new Person {FirstName = "Samuel", LastName = "Jackson" },
                    new Person {FirstName = "Bruce", LastName = "Willis" },
                    new Person { FirstName = "Quentin", LastName="Tarantino"},
                },
                ImdbId = "second"
            };


            var mcFarlandUsa = new Movie("McFarland, USA", 2015)
            {
                Duration = new TimeSpan(2, 21, 0),
                Genres = new List<Genre> { Genre.Drama },
                Director = new Person { FirstName = "Niki", LastName = "Caro" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "Jim", LastName = "White" },
                    new Person {FirstName = "Danny", LastName = "Diaz" },
                    new Person {FirstName = "David", LastName = "Diaz" },
                    new Person { FirstName = "Victor", LastName="Puentes"},
                },
                ImdbId = "third"
            };
            var theLightBetweenOceans = new Movie("The Light Between Oceans", 2016)
            {
                Duration = new TimeSpan(1, 38, 0),
                Genres = new List<Genre> { Genre.Drama },
                Director = new Person { FirstName = "Derek", LastName = "Cianfrance" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "Isabel", LastName = "Sherbes" },
                    new Person {FirstName = "Alicia", LastName = "Weiz" },
                    new Person {FirstName = "Caren", LastName = "Pistorious" },
                    new Person { FirstName = "Leon", LastName="Ford"},
                },
                ImdbId = "fourth"
            };
            var treppasAgainstUs = new Movie("Trespass Against Us", 2016)
            {
                Duration = new TimeSpan(1, 45, 0),
                Genres = new List<Genre> { Genre.Action },
                Director = new Person { FirstName = "Adam ", LastName = "Smith" },
                Cast = new List<Person>
                {
                    new Person {FirstName = "Michael", LastName = "Fassbender" },
                    new Person {FirstName = "Brendan", LastName = "Gleeson" },
                    new Person {FirstName = "Sean", LastName = "Harris" },
                    new Person { FirstName = "Lyndsey", LastName="Marshal"},
                },
                ImdbId = "fifth"
            };


            movies.Add(treppasAgainstUs);
            movies.Add(theLightBetweenOceans);
            movies.Add(mcFarlandUsa);
            movies.Add(pulpFiction);
            movies.Add(apocalypseNow);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lstMovies.DataSource = movies;
        }

    

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
          var movie = (Movie)lstMovies.SelectedItem;
            MessageBox.Show(movie.Title);

        }
    }
}
