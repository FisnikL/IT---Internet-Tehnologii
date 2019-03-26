using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_2
{
    public partial class Default3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtLozinka.Focus();
        }

        protected void btnProveri_Click(object sender, EventArgs e)
        {
            string lozinka = txtLozinka.Text;
            if(lozinka == "мрежно програмирање")
            {
                txtPoraka.ReadOnly = false;
                txtPoraka.Text = "";
                txtPoraka.Focus();
            }
            else
            {
                txtPoraka.ReadOnly = true;
                txtPoraka.Text = "Грешна Лозинка\nОбиди се повторни!";
                //txtPoraka.ReadOnly = true;
                txtLozinka.Focus();
                
            }
        }

        protected void txtPoraka_TextChanged(object sender, EventArgs e)
        {
            btnPrvaStrana.Enabled = true;
            btnPrvaStrana.PostBackUrl = "~/Default.aspx";
        }
    }
}