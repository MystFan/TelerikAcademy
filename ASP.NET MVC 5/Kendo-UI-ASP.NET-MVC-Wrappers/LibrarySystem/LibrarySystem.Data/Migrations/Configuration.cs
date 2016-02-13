namespace LibrarySystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<LibrarySystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LibrarySystemDbContext context)
        {
            PasswordHasher hasher = new PasswordHasher();

            var UserManager = new UserManager<User>(new UserStore<User>(context));
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!context.Books.Any())
            {
                string[] categories = new string[]
                {
                    "Agriculture",
                    "Architecture",
                    "Art",
                    "Triller",
                    "Biography & Memoir",
                    "Business",
                    "Children's Fiction",
                    "Children's Non-Fiction",
                    "Cooking, Food & Wine",
                    "Crafts & Hobbies",
                    "Crime",
                    "Family & Parenting",
                    "Fiction",
                    "Fun & Games",
                    "Gardening",
                    "Health, Mind, & Body",
                    "History",
                    "Home Reference / How-to",
                    "Humor",
                    "Medical",
                    "Music",
                    "Mystery novel",
                    "Performing Arts",
                    "Pets",
                    "Philosophy",
                    "Photography",
                    "Reference",
                    "Romantic Comedy",
                    "Religion",
                    "Self-Help",
                    "Social Science",
                    "Sports & Recreation",
                    "Transportation",
                    "Travel"
                };

                for (int i = 0; i < categories.Length; i++)
                {
                    context.Categories.Add(new Category()
                    {
                        Name = categories[i]
                    });
                }

                context.SaveChanges();

                User user = new User()
                {
                    UserName = "Anonimous",
                    Email = "user@abv.bg",
                    PasswordHash = hasher.HashPassword("123456")
                };

                context.Users.Add(user);
                context.SaveChanges();
                UserManager.UpdateSecurityStamp(user.Id);

                context.Books.Add(new Book()
                {
                    Title = "The Hunger Games",
                    ShortReview = @"The nation of Panem, formed from a post-apocalyptic North America, is a country that consists of a wealthy Capitol region surrounded by 12 poorer districts. Early in its history, a rebellion led by a 13th district against the Capitol resulted in its destruction and the creation of an annual televised event known as the Hunger Games. In punishment, and as a reminder of the power and grace of the Capitol, each district must yield one boy and one girl between the ages of 12 and 18 through a lottery system to participate in the games. The 'tributes' are chosen during the annual Reaping and are forced to fight to the death, leaving only one survivor to claim victory.
                                    When 16-year-old Katniss's young sister, Prim, is selected as District 12's female representative, Katniss volunteers to take her place. She and her male counterpart Peeta, are pitted against bigger, stronger representatives, some of whom have trained for this their whole lives. , she sees it as a death sentence. But Katniss has been close to death before. For her, survival is second nature.",
                    DateCreate = DateTime.UtcNow,
                    CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Fiction").Id,
                    Author = new Author()
                    {
                        Name = "Suzanne Collins"
                    },
                    UserId = user.Id,
                    ISBN = "AB12345678"
                });

                context.Books.Add(new Book()
                {
                    Title = "To Kill a Mockingbird",
                    ShortReview = @"The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.
                                    Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior—to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature.",
                    DateCreate = DateTime.UtcNow,
                    CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Triller").Id,
                    Author = new Author()
                    {
                        Name = "Harper Lee"
                    },
                    UserId = user.Id,
                    ISBN = "AB12399678"
                });

                context.Books.Add(new Book()
                {
                    Title = "Pride and Prejudice",
                    ShortReview = @"So begins Pride and Prejudice, Jane Austen's witty comedy of manners--one of the most popular novels of all time--that features splendidly civilized sparring between the proud Mr. Darcy and the prejudiced Elizabeth Bennet as they play out their spirited courtship in a series of eighteenth-century drawing-room intrigues.",
                    DateCreate = DateTime.UtcNow,
                    CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Romantic Comedy").Id,
                    Author = new Author()
                    {
                        Name = "Jane Austen"
                    },
                    UserId = user.Id,
                    ISBN = "0679783261"
                });

                context.Books.Add(new Book()
                {
                    Title = "The Book Thief",
                    ShortReview = @"It’s just a small story really, about among other things: a girl, some words, an accordionist, some fanatical Germans, a Jewish fist-fighter, and quite a lot of thievery. . . .
                                    Set during World War II in Germany, Markus Zusak’s groundbreaking new novel is the story of Liesel Meminger, a foster girl living outside of Munich. Liesel scratches out a meager existence for herself by stealing when she encounters something she can’t resist–books. With the help of her accordion-playing foster father, she learns to read and shares her stolen books with her neighbors during bombing raids as well as with the Jewish man hidden in her basement before he is marched to Dachau.
                                    This is an unforgettable story about the ability of books to feed the soul.",
                    DateCreate = DateTime.UtcNow,
                    CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Crime").Id,
                    Author = new Author()
                    {
                        Name = "Markus Zusak"
                    },
                    UserId = user.Id,
                    ISBN = "0375831002"
                });

                context.Books.Add(new Book()
                {
                    Title = "The Da Vinci Code",
                    ShortReview = @"An ingenious code hidden in the works of Leonardo da Vinci. A desperate race through the cathedrals and castles of Europe. An astonishing truth concealed for centuries . . . unveiled at last.
                                    While in Paris, Harvard symbologist Robert Langdon is awakened by a phone call in the dead of the night. The elderly curator of the Louvre has been murdered inside the museum, his body covered in baffling symbols. As Langdon and gifted French cryptologist Sophie Neveu sort through the bizarre riddles, they are stunned to discover a trail of clues hidden in the works of Leonardo da Vinci—clues visible for all to see and yet ingeniously disguised by the painter.
                                    Even more startling, the late curator was involved in the Priory of Sion—a secret society whose members included Sir Isaac Newton, Victor Hugo, and Da Vinci—and he guarded a breathtaking historical secret. Unless Langdon and Neveu can decipher the labyrinthine puzzle—while avoiding the faceless adversary who shadows their every move—the explosive, ancient truth will be lost forever.",
                    DateCreate = DateTime.UtcNow,
                    CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Mystery novel").Id,
                    Author = new Author()
                    {
                        Name = "Dan Brown"
                    },
                    UserId = user.Id,
                    ISBN = "0307277674"
                });

                context.SaveChanges();
            }

            string roleName = "Admin";
            IdentityResult roleResult;

            if (!RoleManager.RoleExists(roleName))
            {
                roleResult = RoleManager.Create(new IdentityRole(roleName));
                var admin = new User
                {
                    Email = "admin@site.com",
                    PasswordHash = hasher.HashPassword("admin"),
                    UserName = "admin@site.com"
                };


                context.Users.Add(admin);
                context.SaveChanges();
                UserManager.UpdateSecurityStamp(admin.Id);

                UserManager.AddToRole(admin.Id, roleName);
            }
        }
    }
}
