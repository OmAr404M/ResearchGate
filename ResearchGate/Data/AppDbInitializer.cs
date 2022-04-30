
using ResearchGate.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResearchGate.Data;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Comment
                if (!context.Comments.Any())
                {
                    context.Comments.AddRange(new List<Comment>()
                    {
                        new Comment()
                        {
                            Body = "Comment 1",

                        },
                      new Comment()
                        {
                            Body = "Comment 2",

                        },new Comment()
                        {
                            Body = "Comment 3",

                        },new Comment()
                        {
                            Body = "Comment 4",

                        },new Comment()
                        {
                            Body = "Comment 5",

                       }
                       });
                    context.SaveChanges();
                }
                //Auther
                if (!context.Authers.Any())
                {
                    context.Authers.AddRange(new List<Auther>()
                    {
                        new Auther()
                        {
                            FirstName = "Actor f",
                            LastName = "Actor l",
                            Uni = "helwan",
                            Dept ="cs",
                            Email = "email",
                            Mobile = 01129552459,
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Auther()
                        {
                            FirstName = "Actor f",
                            LastName = "Actor l",
                            Uni = "helwan",
                            Dept ="cs",
                            Email = "email",
                            Mobile = 01129552459,
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },

                    });
                    context.SaveChanges();
                }
                //Paper
                if (!context.Papers.Any())
                {
                    context.Papers.AddRange(new List<Paper>()
                    {
                        new Paper()
                        {
                            Title = "Paper 1",
                            Body ="This is the the first Paper",
                            CreatedDate = DateTime.Now.AddDays(-10),
                            CommentId = 3,
                            LikeId= 3
                        },
                        new Paper()
                        {
                            Title = "Paper 1",
                            Body ="This is the the first Paper",
                            CreatedDate = DateTime.Now.AddDays(-10),
                            CommentId = 1,
                            LikeId= 1
                        },
                         new Paper()
                        {
                            Title = "Paper 1",
                            Body ="This is the the first Paper",
                            CreatedDate = DateTime.Now.AddDays(-10),
                            CommentId = 4,
                            LikeId= 4
                        },
                          new Paper()
                        {
                            Title = "Paper 1",
                            Body ="This is the the first Paper",
                            CreatedDate = DateTime.Now.AddDays(-10),
                            CommentId = 1,
                            LikeId= 2
                        },
                           new Paper()
                        {
                            Title = "Paper 1",
                            Body ="This is the the first Paper",
                            CreatedDate = DateTime.Now.AddDays(-10),
                            CommentId = 1,
                            LikeId= 3
                        },
                            new Paper()
                        {
                            Title = "Paper 1",
                            Body ="This is the the first Paper",
                            CreatedDate = DateTime.Now.AddDays(-10),
                            CommentId = 1,
                            LikeId= 5
                        },

                    });
                    context.SaveChanges();
                }
                //Likes
                if (!context.Likes.Any())
                {
                    context.Likes.AddRange(new List<Like>()
                    {
                        new Like()
                        {
                            Type = "Like",
                            
                        },
                         new Like()
                        {
                            Type = "dislike",

                        },

                    });
                    context.SaveChanges();
                }
                //Auther & Paper
                if (!context.Authers_Papers.Any())
                {
                    context.Authers_Papers.AddRange(new List<Auther_Paper>()
                    {
                       new Auther_Paper()
                        {
                            AutherId = 1,
                            PaperId = 1
                        },
                        new Auther_Paper()
                        {
                            AutherId = 3,
                            PaperId = 1
                        },

                         new Auther_Paper()
                        {
                            AutherId = 1,
                            PaperId = 2
                        },
                         new Auther_Paper()
                        {
                            AutherId = 4,
                            PaperId = 2
                        },

                        new Auther_Paper()
                        {
                            AutherId = 1,
                            PaperId = 3
                        },
                        new Auther_Paper()
                        {
                            AutherId = 2,
                            PaperId = 3
                        },
                        new Auther_Paper()
                        {
                            AutherId = 5,
                            PaperId = 3
                        },


                        new Auther_Paper()
                        {
                            AutherId = 2,
                            PaperId = 4
                        },
                        new Auther_Paper()
                        {
                            AutherId = 3,
                            PaperId = 4
                        },
                        new Auther_Paper()
                        {
                            AutherId = 4,
                            PaperId = 4
                        },


                        new Auther_Paper()
                        {
                            AutherId = 2,
                            PaperId = 5
                        },
                        new Auther_Paper()
                        {
                            AutherId = 3,
                            PaperId = 5
                        },
                        new Auther_Paper()
                        {
                            AutherId = 4,
                            PaperId = 5
                        },
                        new Auther_Paper()
                        {
                            AutherId = 5,
                            PaperId = 5
                        },


                        new Auther_Paper()
                        {
                            AutherId = 3,
                            PaperId = 6
                        },
                        new Auther_Paper()
                        {
                            AutherId = 4,
                            PaperId = 6
                        },
                        new Auther_Paper()
                        {
                            AutherId = 5,
                            PaperId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        
            
        
    }
}
