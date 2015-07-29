using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        
        TMDbClient client = new TMDbClient("c1c52570949a004440ef5e1d32411542");
        private string searchThis = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            searchResults.Visible = false;
            noFoundLabel.Visible = false;
            Image1.ImageUrl = "/Content/noImage.png";
            Image2.ImageUrl = "/Content/noImage.png";
            Image3.ImageUrl = "/Content/noImage.png";
        }

        protected void searchQuery_TextChanged(object sender, EventArgs e)
        {
            searchThis = searchQuery.Text.ToString();
        }
        protected void searchButton_Click(object sender, EventArgs e)
        {
            getSearchData();
            checkDB();
        }

        protected void getSearchData()
        {
            searchResults.Visible = true;
            SearchContainer<SearchMovie> results = client.SearchMovie(searchThis);
            int i = 1;
            {
                foreach (SearchMovie result in results.Results.Take(3))
                {
                    if (result != null)
                    {
                        if (i == 1)
                        {
                            movieTitle1.Text = result.Title;
                            movieID1.Text = result.Id.ToString();
                            movieDate1.Text = result.ReleaseDate.ToString();
                            moviePop1.Text = result.Popularity.ToString();
                            if (result.PosterPath != null)
                            {
                                Image1.ImageUrl = "http://cf2.imgobject.com/t/p/original" + result.PosterPath.ToString();
                                Image1.Width = 160;
                                Image1.Height = 240;
                            }
                        }
                        if (i == 2)
                        {
                            movieTitle2.Text = result.Title;
                            movieID2.Text = result.Id.ToString();
                            movieDate2.Text = result.ReleaseDate.ToString();
                            moviePop2.Text = result.Popularity.ToString();
                            if (result.PosterPath != null)
                            {
                                Image2.ImageUrl = "http://cf2.imgobject.com/t/p/original" + result.PosterPath.ToString();
                                Image2.Width = 160;
                                Image2.Height = 240;
                            }
                        }
                        if (i == 3)
                        {
                            movieTitle3.Text = result.Title;
                            movieID3.Text = result.Id.ToString();
                            movieDate3.Text = result.ReleaseDate.ToString();
                            moviePop3.Text = result.Popularity.ToString();
                            if (result.PosterPath != null)
                            {
                                Image3.ImageUrl = "http://cf2.imgobject.com/t/p/original" + result.PosterPath.ToString();
                                Image3.Width = 160;
                                Image3.Height = 240;
                            }
                            i = 1;
                        }
                        i++;
                    }
                    else
                    {
                        searchResults.Visible = false;
                        noFoundLabel.Visible = true;
                        i = 1;
                    }
                }
            }
        }

        public void checkDB()
        {
            using (MovielinqDataContext dbContext = new MovielinqDataContext())
            {
                var check1 = dbContext.Movies.SingleOrDefault(p => p.Id == movieID1.Text);
                if (check1 != null)
                {
                    LibraryButton1.Visible = true;
                }
                var check2 = dbContext.Movies.SingleOrDefault(p => p.Id == movieID2.Text);
                if (check1 != null)
                {
                    LibraryButton2.Visible = true;
                }
                var check3 = dbContext.Movies.SingleOrDefault(p => p.Id == movieID3.Text);
                if (check1 != null)
                {
                    LibraryButton3.Visible = true;
                }
            }
        }

        protected void LibraryButton1_Click(object sender, EventArgs e)
        {
            using (MovielinqDataContext dbContext = new MovielinqDataContext())
            {
                Movies newMovie = new Movies()
                {
                    Id = movieID1.Text,
                    Title = movieTitle1.Text,
                    ReleaseDate = movieDate1.Text,
                    Popularity = moviePop1.Text,
                };
                dbContext.Movies.InsertOnSubmit(newMovie);
                dbContext.SubmitChanges();
                
            }

          
            
        }
        protected void LibraryButton2_Click(object sender, EventArgs e)
        {
            using (MovielinqDataContext dbContext = new MovielinqDataContext())
            {
                Movies newMovie = new Movies()
                {
                    Id = movieID2.Text,
                    Title = movieTitle2.Text,
                    ReleaseDate = movieDate2.Text,
                    Popularity = moviePop2.Text,
                };
                dbContext.Movies.InsertOnSubmit(newMovie);
                dbContext.SubmitChanges();
                
            }



        }
        protected void LibraryButton3_Click(object sender, EventArgs e)
        {
            using (MovielinqDataContext dbContext = new MovielinqDataContext())
            {
                Movies newMovie = new Movies()
                {
                    Id = movieID3.Text,
                    Title = movieTitle3.Text,
                    ReleaseDate = movieDate3.Text,
                    Popularity = moviePop3.Text,
                };
                dbContext.Movies.InsertOnSubmit(newMovie);
                dbContext.SubmitChanges();
                
            }



        }

    }
}