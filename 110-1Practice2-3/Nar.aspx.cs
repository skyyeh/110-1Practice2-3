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
            int num = 153;  
            int num_new, rem, sum = 0; 

            num_new = num;

            while (num_new != 0)
            {
                rem = num_new % 10; 
                sum = sum + (rem * rem * rem); 
                num_new = num_new / 10; 
            }
            

            if (sum == num)
            {
                Response.Write("True");
            }
            else
            {
                Response.Write("Flase");
            }
             






        }
    }
}