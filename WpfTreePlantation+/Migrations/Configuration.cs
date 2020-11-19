namespace WpfTreePlantation_.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WpfTreePlantation_.AccountContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WpfTreePlantation_.AccountContext";
            ContextKey = "WpfTreePlantation_.ProcessInfoContext";
        }

        protected override void Seed(WpfTreePlantation_.AccountContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
        //protected override void Seed(WpfTreePlantation_.ProcessInfoContext context)
        //{
        //    //  This method will be called after migrating to the latest version.

        //    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //    //  to avoid creating duplicate seed data.
        //}
    }
}
