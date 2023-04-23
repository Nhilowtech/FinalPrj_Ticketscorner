using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MovieStoreNhi.Data;
using MovieStoreNhi.Data.Static;
using MovieStoreNhi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreNhi.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "CGV Cinema",
                            Logo = "https://tinyurl.com/mumpjxys",
                            Description = "CJ CGV là một trong top 5 cụm rạp chiếu phim lớn nhất toàn cầu và là nhà phát hành, cụm rạp chiếu phim lớn nhất Việt Nam."
                        },
                        new Cinema()
                        {
                            Name = "BHD Star Cineplex",
                            Logo = "https://tinyurl.com/42ha3494",
                            Description = "Hệ thống rạp chiếu phim BHD Star Cineplex với chất lượng âm thanh & hình ảnh hiện đại nhất."
                        },
                        new Cinema()
                        {
                            Name = "Galaxy Cinema",
                            Logo = "https://tinyurl.com/4ud9mdvh",
                            Description = "Galaxy Cinema liên tục cập nhật lịch chiếu các phim mới trên thế giới. Đừng bỏ lỡ cơ hội xem phim chiếu rạp đạt chuẩn Hollywood chỉ từ 45000 đ."
                        },
                        new Cinema()
                        {
                            Name = "Lotte Cinema",
                            Logo = "https://tinyurl.com/5cyhdnhw",
                            Description = "Lotte Cinema là một chuỗi các rạp chiếu phim thành lập tại Hàn Quốc từ năm 1999 và sau đó mở rộng ra các nước trên thế giới, được điều hành bởi bộ phận Điện ảnh của Lotte Shopping Co."
                        },
                        new Cinema()
                        {
                            Name = "Mega Cinema",
                            Logo = "https://tinyurl.com/yvvutwsm",
                            Description = "Mega GS Cinemas là chuỗi cụm rạp chiếu phim đẳng cấp, chính thức ra mắt lần đầu tiên tại TP.HCM vào tháng 8/2015 tại số 19 Cao Thắng Q.3."
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Gong Yoo",
                            Bio = "Gong Ji-cheol, thường được biết tới bằng nghệ danh Gong Yoo, là một nam diễn viên người Hàn Quốc. Nghệ danh của Gong Yoo được ghép từ họ của bố anh là Gong và của mẹ anh là Yoo.",
                            ProfilePictureURL = "https://tinyurl.com/actor-1"

                        },
                        new Actor()
                        {
                            FullName = "Anh Tú",
                            Bio = "Bùi Anh Tú có nghệ danh là Anh Tú hay Anh Tú Atus là một nam diễn viên kịch nói, diễn viên truyền hình, diễn viên điện ảnh kiêm ca sĩ người Việt Nam. Anh nổi tiếng qua vai diễn đầu tay trong bộ phim Hà Nội em yêu anh năm 2013… Anh từng là diễn viên thuộc biên chế của sân khấu kịch Thế Giới Trẻ.",
                            ProfilePictureURL = "https://tinyurl.com/actor-2"
                        },
                        new Actor()
                        {
                            FullName = "Châu Đông Vũ",
                            Bio = "Châu Đông Vũ là một nữ diễn viên Trung Quốc, được sinh ra ở tỉnh Hà Bắc, thành phố Thạch Gia Trang. Cô tốt nghiệp Học viện điện ảnh Bắc Kinh năm 2011. Năm 2010, cô nổi tiếng nhờ tham gia bộ phim Chuyện tình cây táo gai của đạo diễn Trương Nghệ Mưu và trở thành một thế hệ mới của Mưu Nữ Lang.",
                            ProfilePictureURL = "https://tinyurl.com/actor-3"
                        },
                        new Actor()
                        {
                            FullName = "Tristan Harris",
                            Bio = "Tristan Harris là một nhà đạo đức công nghệ người Mỹ. Ông là giám đốc điều hành và đồng sáng lập của Trung tâm Công nghệ Nhân đạo. Khi mới vào nghề, Harris làm việc với tư cách là nhà đạo đức thiết kế tại Google. ",
                            ProfilePictureURL = "https://tinyurl.com/actor-4"
                        },
                        new Actor()
                        {
                            FullName = "Antonio Banderas",
                            Bio = "TJosé Antonio Domínguez Banderas, thường được biết đến với cái tên chuyên nghiệp Antonio Banderas, là một diễn viên, đạo diễn phim, nhà sản xuất phim, ca sĩ, nhạc sĩ người Tây Ban Nha nổi tiếng với các vai diễn El Mariachi trong Desperado và Once Upon A Time In Mexico...",
                            ProfilePictureURL = "https://tinyurl.com/actor-5"
                        },
                        new Actor()
                        {
                            FullName = "Nicolas Cage",
                            Bio = "Nicolas Kim Coppola, được biết đến với nghệ danh Nicolas Cage, là một diễn viên và nhà làm phim người Mỹ. Sinh ra trong gia đình Coppola, Cage là người nhận được nhiều giải thưởng khác nhau, bao gồm Giải thưởng Viện hàn lâm, Giải thưởng của Nghiệp đoàn Diễn viênmàn ảnh và Giải thưởng Quả cầu vàng.",
                            ProfilePictureURL = "https://tinyurl.com/3c79faat"
                        },
                        new Actor()
                        {
                            FullName = "Đậu Kiêu",
                            Bio = "Đậu Kiêu là một diễn viên người Canada gốc Trung Quốc. Anh bắt đầu nổi tiếng với vai diễn Tôn Kiến Tân trong bộ phim Chuyện tình cây táo gai của đạo diễn Trương Nghệ Mưu.",
                            ProfilePictureURL = "https://tinyurl.com/actor-7"
                        },
                        new Actor()
                        {
                            FullName = "Salma Hayek Pinault",
                            Bio = "Salma Hayek Pinault là một nữ diễn viên, nhà sản xuất phim người México đã từng được đề cử các giải Oscar, Quả Cầu Vàng, Emmy và Daytime Emmy.",
                            ProfilePictureURL = "https://tinyurl.com/actor-8"
                        },
                        new Actor()
                        {
                            FullName = "Florence Pugh",
                            Bio = "Florence Pugh là nữ diễn viên người Anh Quốc. Sinh ra ở Oxford, cô đã bắt đầu diễn xuất vào năm 2014 trong bộ phim truyền hình The Falling.",
                            ProfilePictureURL = "https://tinyurl.com/actor-9"
                        },
                         new Actor()
                        {
                            FullName = "Jung Yu-mi",
                            Bio = "Jung Yu-mi là một nữ diễn viên Hàn Quốc. Jung đã ra mắt bộ phim điện ảnh đầu tay trong Blossom Again, bộ phim mà cô ấy đã nhận được sự công nhận về diễn xuất.",
                            ProfilePictureURL = "https://tinyurl.com/yt9v78ya"
                        },
                          new Actor()
                        {
                            FullName = "Choi Woo-sik",
                            Bio = "Choi Woo-sik là một nam diễn viên người Canada-Hàn Quốc. Anh được khán giả biết đến qua các bộ phim Hoàng tử gác mái, Set Me Free, Chuyến tàu sinh tử, The Witch: Part 1.",
                            ProfilePictureURL = "https://tinyurl.com/actor-11"
                        },
                           new Actor()
                        {
                            FullName = "Mạc Văn Khoa",
                            Bio = "Mạc Văn Khoa (sinh ngày 4 tháng 5 năm 1992, quê ở Chí Linh, Hải Dương) là một nam ca sĩ không chuyên kiêm diễn viên, diễn viên hài kịch người Việt Nam.",
                            ProfilePictureURL = "https://tinyurl.com/actor-12"
                        },
                            new Actor()
                        {
                            FullName = "Cát Tường",
                            Bio = "Cát Tường là một diễn viên, người dẫn chương trình Việt Nam. Cô được phong tặng danh hiệu Nghệ sĩ Ưu tú vào năm 2019.",
                            ProfilePictureURL = "https://tinyurl.com/actor-13"
                        },
                             new Actor()
                        {
                            FullName = "Kara Hayward",
                            Bio = "Kara Hayward là một nữ diễn viên người Mỹ. Cô được biết đến với vai chính Suzy Bishop trong bộ phim điện ảnh Moonrise Kingdom năm 2012, bộ phim này đã mang về cho cô một đề cử cho giải Nghệ sĩ trẻ cho Nữ diễn viên chính xuất sắc nhất trong phim truyện vào năm 2013.",
                            ProfilePictureURL = "https://tinyurl.com/actor-14"
                        },
                              new Actor()
                        {
                            FullName = "Sophia Hammons",
                            Bio = "Diễn viên phim tài liệu The Social Dilenma",
                            ProfilePictureURL = "https://tinyurl.com/actor-15"
                        },
                               new Actor()
                        {
                            FullName = "Nicholas Hoult",
                            Bio = "Nicholas Caradoc Hoult là diễn viên người Anh. Hoult bắt đầu sự nghiệp diễn xuất chuyên nghiệp lúc 7 tuổi trong bộ phim Intimate Relations năm 1996.",
                            ProfilePictureURL = "https://tinyurl.com/actor-16"
                        },
                                new Actor()
                        {
                            FullName = "Bess Rous",
                            Bio = "Bess Rous là một nữ diễn viên người Mỹ. Trên truyền hình, cô xuất hiện trong một loạt phim thường xuyên trong mùa đầu tiên của bộ phim tội phạm TNT Murder in the First và Yahoo! Phim hài khoa học viễn tưởng Other Space.",
                            ProfilePictureURL = "https://tinyurl.com/actor-17"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Yeon Sang Ho",
                            Bio = "Yeon Sang-ho là một đạo diễn và nhà biên kịch phim người Hàn Quốc. Anh ấy nổi tiếng quốc tế nhờ đóng các bộ phim hoạt hình dành cho người lớn The King of Pigs and The Fake, và bộ phim live-action Train to Busan,...",
                            ProfilePictureURL = "https://tinyurl.com/3zjwsdu4"

                        },
                        new Producer()
                        {
                            FullName = "Võ Thanh Hoà",
                            Bio = "Võ Thanh Hòa là một nam đạo diễn, nhà sản xuất phim người Việt Nam. Anh được khán giả biết đến với những bộ phim nổi bật như Siêu Lừa Gặp Siêu Lầy, Nghề Siêu Dễ, Chìa Khoá Trăm Tỷ, Chị Mười Ba Phần 2, ... ",
                            ProfilePictureURL = "https://tinyurl.com/3xyy2txy"
                        },
                        new Producer()
                        {
                            FullName = "Trương Nghệ Mưu",
                            Bio = "Trương Nghệ Mưu là nam đạo diễn, nhà sản xuất kiêm nhà biên kịch phim, từng là diễn viên kiêm nhà quay phim người Trung Quốc.",
                            ProfilePictureURL = "https://tinyurl.com/2p8swu7p"
                        },
                        new Producer()
                        {
                            FullName = "Jeff Orlowski",
                            Bio = "Teff Orlowski-Yang là một nhà làm phim người Mỹ. Ông được biết đến với vai trò đạo diễn và sản xuất bộ phim tài liệu Chasing Ice và Chasing Coral từng đoạt giải Emmy và đạo diễn The Social Dilemma về tác động xã hội gây tổn hại của mạng xã hội.",
                            ProfilePictureURL = "https://tinyurl.com/mub2wa4h"
                        },
                        new Producer()
                        {
                            FullName = "Chris Miller",
                            Bio = "Đạo diễn người Mỹ, phim hoạt hình, và diễn viên lồng tiếng nổi tiếng với việc chỉ đạo bộ phim Shrek.",
                            ProfilePictureURL = "https://tinyurl.com/2s2w43zk"
                        },
                        new Producer()
                        {
                            FullName = "Chris McKay",
                            Bio = "Chris Taylor, là một nhà làm phim và họa sĩ hoạt hình người Mỹ. Ông nổi tiếng với việc chỉ đạo và biên tập ba phần của Robot Chicken và hai phần của Moral Orel. ",
                            ProfilePictureURL = "https://tinyurl.com/ys4pjbwy"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Train To Busan",
                            Description = "Train To Busan là một bộ phim về đại dịch zombie của Hàn Quốc được đạo diễn bởi Yeon Sang-ho.",
                            Price = 85000,
                            ImageURL = "https://tinyurl.com/mvtraintobusan",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Siêu Lừa Gặp Siêu Lầy",
                            Description = "Theo chân của Khoa – tên lừa đảo tầm cỡ “quốc nội” đến đảo Phú Quốc với mong muốn đổi đời.",
                            Price = 75000,
                            ImageURL = "https://tinyurl.com/mvsieuluagapsieulay",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Chuyện Tình Cây Táo Gai",
                            Description = "Câu chuyện tình yêu vô cùng nhẹ nhàng nhưng lại khiến người xem cảm thấy day dứt khôn nguôi.",
                            Price = 85000,
                            ImageURL = "https://tinyurl.com/mvchuyentinhcaytaogai",
                            StartDate = DateTime.Now.AddDays(-1),
                            EndDate = DateTime.Now.AddDays(15),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "The Social Dilenma",
                            Description = "Bộ phim khám phá tác động nguy hiểm của mạng xã hội đến con người bởi những chuyên gia trong ngành.",
                            Price = 75000,
                            ImageURL = "https://tinyurl.com/mvthesocialdilenma",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Puss In Boost: Mèo Đi Hia",
                            Description = "Puss In Boost: Mèo đi hia là bộ phim hoạt hình hài phiêu lưu được sản xuất bởi DreamWorks Animation.",
                            Price = 85000,
                            ImageURL = "https://tinyurl.com/pussinboost",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 5,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Renfield: Tay Sai Của Quỷ",
                            Description = "Bộ phim kinh dị của Mỹ, Renfield phát ốm vì mối quan hệ đồng phụ thuộc kéo dài hàng thế kỷ với Dracula.",
                            Price = 75000,
                            ImageURL = "https://tinyurl.com/mctaysaicuaquy",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 5,
                            ProducerId = 6,
                            MovieCategory = MovieCategory.Horror
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },

                         new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },

                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 8,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 9,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 10,
                            MovieId = 1
                        },


                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 12,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 13,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 14,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 15,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 16,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 17,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}