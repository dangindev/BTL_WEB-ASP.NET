using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspire
{
    public class Post
    {
        private string urlImage = "Images/post-image1.png";
        private string category = "Design";
        private string title = "Blog hom nay";
        private string content = "Creativity doesn’t just happen. The most inspired and innovative teams and individual designers need to be a part of a culture that enables forward-thinking, acceleration, and efficiency. It’s a…";
        private string author = "Carrie Cousines – April 4, 2020";

        public Post()
        {

        }
        public string getHtml()
        {

            string htmlString;
            htmlString = "<div class='post'> "
                       + "<div class='post__image'>"
                       + "<img src = " + urlImage + " />"
                       + "</div>"
                       + "<h4>" + category + "</h4>"
                       + "<h2 class='post__title'> " + title + "</h2> "
                       + "<p class='post__desc'>" + content + "</p>"
                       + "<p class='post__author'>" + author + "</p>"
                       + "</div>";
            return htmlString;
        }
    }
}