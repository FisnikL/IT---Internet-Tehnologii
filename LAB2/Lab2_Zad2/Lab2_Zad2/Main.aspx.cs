using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2_Zad2
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex += 1;
        }

        protected void btnPrev_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex -= 1;
        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            int workingExperience;
            if (int.TryParse(txtGodini.Text, out workingExperience) && workingExperience >= 5)
            {
                lblKorisnik.Text = txtID.Text;
                lblKorisnikMail.Text = lblMail.Text;
                lblUspesnoKreiranje.Visible = true;
            }
            else
            {
                lblUspesnoKreiranje.Visible = false;
                lblGreska.Text = "Немате доволно работно искуство";
            }
            btnNext_Click(sender, e);
        }

        protected void btnPocetok_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
}