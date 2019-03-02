using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Xamarin.Forms;

namespace HtmlParsing
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string html = @"<!DOCTYPE html>  
<html>  
<body>  
<h2>HTML Image Parsing</h2>  
<img src='https://www.w3schools.com/html/img_girl.jpg' alt='Girl in a jacket' width='500' height='600'>  
</body>  
</html>  ";
            myImage.Source = HtmlParsing(html);
        }

        string HtmlParsing(string html)
        {
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);
            //Getting img src value    
            var imgUrl = document.DocumentNode.Descendants("img").FirstOrDefault().GetAttributeValue("src", null);
            return imgUrl;
        }
    }
}
