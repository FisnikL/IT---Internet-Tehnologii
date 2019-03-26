using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // lblVreme1.Text = DateTime.Now.ToString();

            if (!Page.IsPostBack) // Prashanje 16:
                                  // -- So ovoj usllov se postignuva efektot deka pri klik na BUTTON, se osvezhuva samo
                                  //    vremeto kaj vtorata LABELA
                                  // -- Ako ne beshe ovoj uslov, kako na prvata verzija, kje se osvezhuvashe vremeto i
                                  //    kaj vtorata labela
                lblVreme1.Text = DateTime.Now.ToString();
        }

        protected void btnVreme1_Click(object sender, EventArgs e)
        {
            lblVreme2.Text = DateTime.Now.ToString();
        }
    }
}
 