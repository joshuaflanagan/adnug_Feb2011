using System;
using System.ComponentModel.DataAnnotations;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using MyMvcApp.Models;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace MyMvcApp
{
    public class Database 
    {
        public static void BuildSchema()
        {
            new SchemaExport(GetConfiguration()).Create(false, true);
        }

        public static Configuration GetConfiguration()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(x =>
                {
                    x.Database("adnug2011");
                    x.Server(".");
                    x.TrustedConnection();
                }))
            .Mappings(map => map.AutoMappings.Add(
                AutoMap
                .AssemblyOf<Database>(t => typeof(Entity).IsAssignableFrom(t))
                // conventions
                .Conventions.Add<StringLengthConvention>()
                .Conventions.Add<MandatoryConvention>()
                ))
            .BuildConfiguration();
        }
    }

    public class MandatoryConvention : AttributePropertyConvention<MandatoryAttribute> {
        protected override void Apply(MandatoryAttribute attribute, IPropertyInstance instance)
        {
            instance.Not.Nullable();
        }
    }

    public class StringLengthConvention : AttributePropertyConvention<StringLengthAttribute> {
        protected override void Apply(StringLengthAttribute attribute, IPropertyInstance instance)
        {
            instance.Length(attribute.MaximumLength);
        }
    }
}