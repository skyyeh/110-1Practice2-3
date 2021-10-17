using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_3
{
    public partial class Nar : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int i_n = 153;
            int N = 1;
            int rm = 10;
            for (int i = 0; i < N; i++)
            {
                if (i_n / rm > 0)
                {
                    N += 1;
                    rm = rm * 10;
                }
            }

            int i_a = i_n / 100;
            int i_b = (i_n % 100) / 10;
            int i_c = i_n % 10;

            if (Math.Pow(i_a, N) + Math.Pow(i_b, N) + Math.Pow(i_c, N) == i_n)
            {
                Response.Write("True");
            }
            else
            {
                Response.Write("False");
            }


        }
    }
}