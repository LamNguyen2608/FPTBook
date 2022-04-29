using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();

                //Category
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                        new Category()
                        {
                            Name = "Sci-Fi",
                            Description = "GUD STUFF"
                        },
                        new Category()
                        {
                            Name = "Romance",
                            Description = "GUD STUFF"
                        },
                        new Category()
                        {
                            Name = "Andventure",
                            Description = "Great"
                        }
                    });
                    context.SaveChanges();
                }
                //Author
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            ProfilePicURL = "https://scontent.fsgn2-3.fna.fbcdn.net/v/t1.6435-9/203589948_2926974034208058_4104748504906292142_n.jpg?_nc_cat=108&ccb=1-5&_nc_sid=174925&_nc_ohc=gasEaPrW82EAX_eDzK8&_nc_ht=scontent.fsgn2-3.fna&oh=00_AT_GXBJdPNrGlXWpIlqjM7U8750xvEKaM0InwKDT7HLMiw&oe=62909356",
                            Fullname = "Lam Nguyen",
                            Bio = "Im sexy and I know it",
                        },
                        new Author()
                        {
                            ProfilePicURL = "https://scontent.fsgn2-1.fna.fbcdn.net/v/t39.30808-6/275363632_653552649243916_4816462566131814621_n.jpg?_nc_cat=107&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=sOZgwDVKM0gAX-5zMPl&_nc_ht=scontent.fsgn2-1.fna&oh=00_AT_ndRAMxSd-IfzNV42EEAhjxgrUIa9SXV5UaKp6pU_5Jw&oe=627098F7",
                            Fullname = "Minh Nguyen",
                            Bio = "Chiem Bao",
                        },
                        new Author()
                        {
                            ProfilePicURL = "https://scontent.fsgn2-5.fna.fbcdn.net/v/t31.18172-8/19095538_1342524682535337_2406438795458636461_o.jpg?_nc_cat=102&ccb=1-5&_nc_sid=ad2b24&_nc_ohc=49emui0_zCEAX_YytlL&_nc_ht=scontent.fsgn2-5.fna&oh=00_AT9d23ZVlSC6hS5P_Hj1-jlWRCt4BpNYX1TGEQKz7AYocA&oe=6291820B",
                            Fullname = "An Doan",
                            Bio = "I have small dick",
                        }
                    });
                    context.SaveChanges();
                }
                //Book
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Name = "Sea of Tranquility",
                            ImageURL = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1639057096-517pnkf8SSS._SL500_.jpg?crop=1xw:1xh;center,top&resize=768:*",
                            Description = "Sea of Tranquility, Mandel’s sensational sixth novel, offers immense pleasures of puzzle box plotting and high-flying imagination. As devoted readers have come to expect from her fiction, the novel braids together a rich ensemble of characters, revealing the surprising linkages between their disparate lives.",
                            Price = 1000,
                            Quantity = 2,
                            Rating = 5,
                            catId = 1,
                            authorId = 2
                        },
                        new Book()
                        {
                            Name = "The Candy House",
                            ImageURL = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1639169194-514tcZRdGuL._SL500_.jpg?crop=1xw:1xh;center,top&resize=768:*",
                            Description = "One of our great American storytellers returns with a rare literary sequel of the very rarest quality. The Candy House enlarges A Visit From the Goon Squad not just by revisiting its memorable characters, but by doubling down on its formal conceits, with many chapters written in texts and emails.",
                            Price = 110000,
                            Quantity = 2,
                            Rating = 5,
                            catId = 1,
                            authorId = 3
                        },
                        new Book()
                        {
                            Name = "The Immortal King Rao",
                            ImageURL = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1647627427-51PUUy7g7hL._SL500_.jpg?crop=1xw:1xh;center,top&resize=768:*",
                            Description = "Why should television get to have all the fun with Big Tech? In this thrilling story about capitalism, consciousness, and the ties that bind, Vara brings the ethical questions of our time to speculative fiction. In a not-so-distant future, Athena Rao stands accused of murdering her father, the legendary tech mogul King Rao.",
                            Price = 110000,
                            Quantity = 20,
                            Rating = 5,
                            catId = 2,
                            authorId = 1
                        },
                        new Book()
                        {
                            Name = "Sea of Tranquility, by Emily St. John Mandel",
                            ImageURL = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1639057096-517pnkf8SSS._SL500_.jpg?crop=1xw:1xh;center,top&resize=768:*",
                            Description = "Sea of Tranquility, Mandel’s sensational sixth novel, offers immense pleasures of puzzle box plotting and high-flying imagination. As devoted readers have come to expect from her fiction, the novel braids together a rich ensemble of characters, revealing the surprising linkages between their disparate lives.",
                            Price = 100000,
                            Quantity = 2,
                            Rating = 5,
                            catId = 1,
                            authorId = 2
                        },
                        new Book()
                        {
                            Name = "Scoundrel",
                            ImageURL = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1637779640-51UOZU8nXQS._SL500_.jpg?crop=1xw:1xh;center,top&resize=768:*",
                            Description = "One of our finest true crime writers returns with the chilling story of Edgar Smith, a convicted murderer freed from Death Row by virtue of his connections with various powerful people, including National Review founder William F. Buckley. Smith’s deceptions set him free and catapulted him to literary fame, but ultimately, he nearly took another innocent woman’s life, leaving blood on the hands of Buckley and his other champions. ",
                            Price = 120000,
                            Quantity = 8,
                            Rating = 5,
                            catId = 2,
                            authorId = 3
                        },
                    });
                    context.SaveChanges();

                }
            }
        }
    }
}

