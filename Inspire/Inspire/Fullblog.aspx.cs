using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inspire
{
    public partial class Fullblog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = "fullblog.xml";
            string fullblog = "";

            if (File.Exists(Server.MapPath(path)))
            {

                // Đọc file
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(string));
                StreamReader file = new StreamReader(Server.MapPath(path));
                fullblog = (string) reader.Deserialize(file);
                file.Close();
            }


            blogContent.InnerHtml = fullblog;
        }
    }
}