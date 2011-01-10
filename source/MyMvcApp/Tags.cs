using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using HtmlTags;
using System.Linq;

namespace MyMvcApp
{
    public static class TagExtensions
    {
        public static HtmlTag InputFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression)
        {
            return new Tags().InputFor(expression);
        }
    }

    public partial class Tags
    {
        public HtmlTag InputFor<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            var accessor = ReflectionHelper.GetAccessor(expression);

            var tag = buildTag(accessor);
            modifyTag(tag, accessor);
            return tag;
        }

        private static HtmlTag buildTag(Accessor accessor)
        {
            // Hardcoded to only build inputs, for this example.
            // In reality, you would register different "builders" 
            //  so the decision is made based on the property being displayed
            return new HtmlTag("input").Attr("name", accessor.Name);
        }

        private static void modifyTag(HtmlTag tag, Accessor accessor)
        {
            foreach (var convention in conventions.Where(x => x.Condition(accessor)))
            {
                convention.Modification(tag, accessor);
            }
        }
    }
}