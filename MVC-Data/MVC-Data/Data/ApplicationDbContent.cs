using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Data.Models;
using System;

namespace MVC_Data.Data
{
    public class ApplicationDbContent : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContent(DbContextOptions<ApplicationDbContent> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Langs { get; set; }
        public DbSet<PersonLanguage> PersonLanguages { get; set; }

        public DbSet<ApplicationUser> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            //koppling mellan person och car    (Many to many)
            //Koppling mellan person och Language tabellen
            modelbuilder.Entity<PersonLanguage>()
                .HasOne(pl => pl.Person)        //en person
                .WithMany(p => p.PersonLanguages) //flera språk
                .HasForeignKey(p => p.PersonName);
            //Koppling mellan Language och  person  tabellen        (andra hållet)
            modelbuilder.Entity<PersonLanguage>()
                .HasOne(pl => pl.Language)
                .WithMany(l => l.PersonLanguages)
                .HasForeignKey(l => l.LanguageName);


            //Koppling city och people (one to many) (one city has many people)
            modelbuilder.Entity<City>()
                .HasMany(c => c.People)
                .WithOne(p => p.City);

            modelbuilder.Entity<Person>() //to make it mutual:
                .HasOne(p => p.City)
                .WithMany(c => c.People);


            // Seeeds
            City london = new City { Name = "London" };
            City stockholm = new City { Name = "Stockholm" };
            City paris = new City { Name = "Paris" };
            City berlin = new City { Name = "Berlin" };
            City madrid = new City { Name = "Madrid" };
            City lissabon = new City { Name = "Lissabon" };

            modelbuilder.Entity<City>().HasData(london);
            modelbuilder.Entity<City>().HasData(stockholm);
            modelbuilder.Entity<City>().HasData(paris);
            modelbuilder.Entity<City>().HasData(berlin);
            modelbuilder.Entity<City>().HasData(madrid);
            modelbuilder.Entity<City>().HasData(lissabon);


            modelbuilder.Entity<Person>().HasData(new Person { Name = "Zony", Id = 0, PhoneNumber = 3, tempCityName = "stockholm", tempCountryName="sweden", tempLanguageName="swedish" });
            modelbuilder.Entity<Person>().HasData(new Person { Name = "JP", Id=1, PhoneNumber=111, tempCityName = "stockholm", tempCountryName = "sweden", tempLanguageName = "swedish" });
            modelbuilder.Entity<Person>().HasData(new Person { Name = "Hannes", Id = 99, PhoneNumber = 35, tempCityName = "stockholm", tempCountryName = "sweden", tempLanguageName = "swedish" });
            modelbuilder.Entity<Person>().HasData(new Person { Name="Stefan", Id=3, PhoneNumber=333, tempCityName = "stockholm", tempCountryName = "sweden", tempLanguageName = "swedish" });
            modelbuilder.Entity<Person>().HasData(new Person { Name="Ian", Id=4, PhoneNumber=444, tempCityName = "stockholm", tempCountryName = "sweden", tempLanguageName = "swedish" });
            modelbuilder.Entity<Person>().HasData(new Person { Name="George", Id=5, PhoneNumber=555, tempCityName = "stockholm", tempCountryName = "sweden", tempLanguageName = "swedish" });
            modelbuilder.Entity<Person>().HasData(new Person { Name="Svante", Id=6, PhoneNumber=666, tempCityName = "stockholm", tempCountryName = "sweden", tempLanguageName = "swedish" });
            modelbuilder.Entity<Person>().HasData(new Person { Name = "Anders", Id = 7, PhoneNumber = 122, tempCityName = "stockholm", tempCountryName = "sweden", tempLanguageName = "swedish" });



            modelbuilder.Entity<Language>().HasData(new Language { Name = "English", Id=1 });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "Swedish", Id=2 });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "French", Id=3 });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "German", Id=4 });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "Spanish", Id=5 });
            modelbuilder.Entity<Language>().HasData(new Language { Name = "Portugese", Id=6 });



            modelbuilder.Entity<Country>().HasData(new Country { Name = "England", Id = 1 });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "Sweden", Id = 2 });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "France", Id = 3 });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "Germany", Id = 4 });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "Spain", Id = 5 });
            modelbuilder.Entity<Country>().HasData(new Country { Name = "Portugal", Id = 6 });


            //identity seeds
            string roleId = Guid.NewGuid().ToString(); //skapar ett alfanumeriskt värde
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole //roll admin
            {
                Id   = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN"

            });
            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole //roll user
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"
            });

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelbuilder.Entity<ApplicationUser>().HasData(new ApplicationUser //seedad admin settings
            {
                Id= userId,
                Email               = "admin@admin.com",
                NormalizedEmail     = "ADMIN@ADMIN.COM",
                UserName            = "admin@admin.com",
                NormalizedUserName  = "ADMIN@ADMIN.COM",
                FirstName           = "Admin",
                LastName            = "Adminsson",
                BirthDate           = 640424,
                PasswordHash        =hasher.HashPassword(null, "password")
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = userId
            });





        }

    }
}
