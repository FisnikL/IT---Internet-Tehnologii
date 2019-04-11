using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2_Zad3
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                ViewState["obidi"] = 0;
        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            if(txtKorisnik.Text != "" && txtLozinka.Text != "")
            {
                int obidi = int.Parse(ViewState["obidi"].ToString());
                if(txtLozinka.Text == "mp")
                {
                    Session["korisnik"] = txtKorisnik.Text;
                    Response.Redirect("~/GlavnaStranica.aspx");
                }
                else if(obidi == 3)
                {
                    btnPodnesi.Enabled = false;
                    lblObidi.Text = "Go imash nadminato kvotata za dozvoleni obidi!";
                }
                else
                {
                    obidi++;
                    lblObidi.Text = "Broj na obidi:" + obidi;
                    ViewState["obidi"] = obidi;
                }
            }
        }
    }
}