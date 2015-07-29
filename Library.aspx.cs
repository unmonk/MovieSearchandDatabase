using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    
    public partial class Library : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            GetData();

        }

        private void GetData()
        {
            MovielinqDataContext dbContext = new MovielinqDataContext();
            GridView1.DataSource = dbContext.Movies;
            GridView1.DataBind();
        }


        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            using (MovielinqDataContext dbContext = new MovielinqDataContext())
            {
                string deleteID = GridView1.DataKeys[e.RowIndex].Value.ToString();
                Movies movie = dbContext.Movies.SingleOrDefault(x => x.Id == deleteID);
                dbContext.Movies.DeleteOnSubmit(movie);
                dbContext.SubmitChanges();
                GetData();
            }
        }
    }
}