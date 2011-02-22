using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using MyMvcApp.Models;

namespace MyMvcApp
{
    public static class HtmlConventions
    {
        public static void Configure(ITagConventions tags)
        {
            tags.Always((tag, prop) => tag.Id(buildId(prop.Name)));
            tags.Always((tag, prop) =>
            {
                var helpLinkTag = new HelpLinkTag(prop.Name);
                tag.Next = helpLinkTag;
            });
            tags.IfType<DateTime>((tag, prop) =>
            {
                if (prop.Name.EndsWith("Time")) tag.AddClass("time");
                tag.AddClass("date");
            });
            tags.IfAttribute<StringLengthAttribute>((tag, attr) => tag.Attr("maxlength", attr.MaximumLength));
            tags.IfAttribute<MandatoryAttribute>((tag, attr) => tag.AddClass("required"));
        }

        private static string buildId(string name)
        {
            return Regex.Replace(name, "([a-z])([A-Z])", "$1-$2").ToLower();
        }
    }
}