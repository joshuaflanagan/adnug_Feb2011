using System;
using HtmlTags;

namespace MyMvcApp
{
    public static class TagDemo
    {
        public static void show_htmltags()
        {
            var tag1 = new HtmlTag("span");
            print(tag1);

            var tag2 = new HtmlTag("span").Text("This is inner text");
            print(tag2);

            var tag3 = new HtmlTag("span")
                .Text("My text")
                .AddClass("important")
                .AddClass("sidebar")
                .Id("sample-tag")
                .Attr("title", "This is a tooltip");
            
            print(tag3);
        }

        private static void print(object item)
        {
            Console.WriteLine();
            Console.WriteLine(item);
        }
    }
}