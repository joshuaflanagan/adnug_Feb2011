using System;
using System.Collections.Generic;
using System.Linq;
using HtmlTags;

namespace MyMvcApp
{
    public partial class Tags : ITagConventions
    {
        private readonly IList<Convention> conventions = new List<Convention>();
        public static Tags Configured = new Tags();
        private Tags() {}
        
        public void If(Func<Accessor, bool> condition, Action<HtmlTag, Accessor> modification)
        {
            conventions.Add(new Convention(condition, modification));
        }

        public void Always(Action<HtmlTag, Accessor> modification)
        {
            If(x => true, modification);
        }

        public void IfType<TProperty>(Action<HtmlTag, Accessor> modification)
        {
            If(x =>
            {
                var type = typeof(TProperty);
                var assignable = type.IsAssignableFrom(x.PropertyType);
                if (!assignable && type.IsValueType)
                {
                    assignable = typeof(Nullable<>).MakeGenericType(type).IsAssignableFrom(x.PropertyType);
                }
                return assignable;
            }, modification);
        }

        public void IfAttribute<TAttribute>(Action<HtmlTag, TAttribute> modification) where TAttribute : Attribute
        {
            If(field => field.InnerProperty.GetCustomAttributes(typeof(TAttribute), true).Length > 0,
                (tag, field) =>
                {
                    var attribute = (TAttribute)field.InnerProperty.GetCustomAttributes(typeof(TAttribute), true).First();
                    modification(tag, attribute);
                });
        }


        class Convention
        {
            public Convention(Func<Accessor, bool> condition, Action<HtmlTag, Accessor> modification)
            {
                Condition = condition;
                Modification = modification;
            }

            public Func<Accessor, bool> Condition { get; private set; }
            public Action<HtmlTag, Accessor> Modification { get; private set; }
        }
    }

    public interface ITagConventions
    {
        void If(Func<Accessor, bool> condition, Action<HtmlTag, Accessor> modification);
        void Always(Action<HtmlTag, Accessor> modification);
        void IfType<TProperty>(Action<HtmlTag, Accessor> modification);
        void IfAttribute<TAttribute>(Action<HtmlTag, TAttribute> modification) where TAttribute : Attribute;
    }
}