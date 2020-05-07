using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bar_API
{
    public partial class _Default : Page
    {
        static string fileName = @"E:\ITP 244\Bar_API\Bar_API\Va-Covid19-1.txt";
        string file = File.ReadAllText(fileName);
        /*
         * file data         
         * positive,negative,recovered,death,total
            6500,37669,752,195,44665
        */
        public string data = "[\n";

        protected void Page_Load(object sender, EventArgs e)
        {
            string[] fileData = file.Split('\n'); //[0]=Status,Value,{role: 'style'} [1]=Positive,6500,green [2]=Negative,37669,red [3]=recovered,37669,pink [4]=death,195,black [5]total,44665,blue

            /* [
               ["Element", "Density", { role: "style" }],
               ["Copper", 8.94, "#b87333"],
               ["Silver", 10.49, "silver"],
               ["Gold", 19.30, "gold"],
               ["Platinum", 21.45, "color: #e5e4e2"]
             ]*/

            /*   [
                 ["Status", "Value", {role: style}],
                 ["Positive", "6500", green],
                 ["Negative", "37669", red
                 ["Recovered", "752", pink],
                 ["Death", "195", black],
                 ["Total", "44665", blue]
                 ]*/


            //data += "['" + fileData[0] + "],\n";
            for(int i = 0; i < fileData.Length; i++)
            {
                data += "[" + fileData[i] + "],";
            }

            data += "\n]";

        }
       
    }
}