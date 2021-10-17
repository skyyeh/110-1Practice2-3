using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_3
{
    public partial class Reflect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_M = 663166;
            int a = 1;
            int i_countNum = 1;
            int rm = 10;
            for (int i = 0; i < a; i++)
            {
                if ((i_M / rm) > 0)
                {
                    a += 1;
                    rm = rm * 10;
                }
            }
            if (a == 1)
            {
                Response.Write("False");
            }
            if (a <= 8)
            {
                if ((int)(i_M / Math.Pow(10, (a - 1))) !=
                    (int)(i_M % Math.Pow(10, 2) % 10))
                {
                    Response.Write("False");
                }
                else
                {
                    for (int i = 2; i <= (a / 2); i++)
                    {
                        if ((int)(i_M % Math.Pow(10, a + 1 - i) / Math.Pow(10, (a - i))) ==
                            (int)(i_M % Math.Pow(10, i) / Math.Pow(10, i - 1)))
                        {
                            i_countNum += 1;
                            continue;
                        }
                        else
                        {
                            Response.Write("False");
                            break;
                        }
                    }
                }
                if (i_countNum == a / 2)
                {
                    Response.Write("True");
                }
            }
        }
    }
}