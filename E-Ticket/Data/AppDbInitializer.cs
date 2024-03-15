using E_Ticket.Data.Enums;
using E_Ticket.Models;

namespace E_Ticket.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var ServicesScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = ServicesScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() {
                        new Actor()
                        {
                            FullName = "Younes Bouab",
                            Bio = "Younes Bouab est un acteur et scénariste marocain, né le 29 avril 1979 à Salé.",
                            ProfilePictureURL = " data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIADgAJQMBIgACEQEDEQH/xAAaAAACAwEBAAAAAAAAAAAAAAAABgQFBwED/8QANBAAAgEDAQQGCAcBAAAAAAAAAQIDAAQREgUhMUEGBxNRkdEUIjIzYXGBwSNCobGys8IV/8QAFwEAAwEAAAAAAAAAAAAAAAAAAQIDAP/EABoRAAMBAQEBAAAAAAAAAAAAAAABAhESIgP/2gAMAwEAAhEDEQA/AMrgiAcFwdPEgcTQltNc3ZgsInlk4gAcqv4LCGFSzuu9cgllbO748OfnU/ohZzQ7SvLuAROmsZJwMIfkd1JdcrSsx00hOuI7vZ9yYr6Io5GWVhvx31MOmRGTcd2pW76a+mezJtoQektHbpKT+C4OCyjJIJ7gKWYBH6FAwkjeTSNXqkHypZrpaGpcPCDHHGEBfGo94zRXvPEoKhTwX7mimwUkNrPFjirXYBmN/J2MD3EPZjto0YBsDgRncTnl86oL+VhL2cbkKBvxzp56mLX/AKE224ggLCOB1cngQX3fXJ8K1LZNNZRG6Q7OvZtkXt3PbS2NnaRjso5DlmJYA/LOcYpXheEwhI2DEfHf4VqfWzKbLoRDbuoD312gA5hFBf8AdR41jGjPGh858h+lemWjJvoo2esjW4L+zk6Sd+RRRbFIF02u6lbhljWqdQUWH25IOfo6/wBnnWSajned5rYuoYZg2u55yRL4A+dUEI/Xvc9ptbZlmrDTb27zMp5l2AH8D41lDt6yj4099ctyJunE6A+6t4oz+rf6pAY5kUd5rAGS0VktYVMRb1BworrTroTDYGORNFSzR9FbVvFbL1Ft2eyNoSH895p8EXzrtFVQghdZM7S9OtsM2feqB9EUfaldGHboTw1DPjRRWMXErJhfaA7150UUVMY//9k="

                        },
                        new Actor()
                        {
                            FullName = "Mohamed Bastaoui",
                            Bio = "né en 1954 à Mrizig, un très petit village près de Khouribga, et mort le 17 décembre 2014 à Rabat",
                            ProfilePictureURL = " data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIADgALAMBIgACEQEDEQH/xAAbAAACAgMBAAAAAAAAAAAAAAAFBgAEAgMHAf/EADIQAAIBAwMBBgQEBwAAAAAAAAECAwQFEQASITEGE0FRYXEHIjLRQlKh4RQjM4KRosH/xAAYAQADAQEAAAAAAAAAAAAAAAACAwQAAf/EABwRAAICAwEBAAAAAAAAAAAAAAABAhEDITESM//aAAwDAQACEQMRAD8A5pBL3Te+iUVaQODoUNEYoYxYpK8MTIlQsQXwwcffUbSZamzfVTTSQkDC+rHGg86zyJtro+8iA+WaLkx+/pootBX1mVp4Wx4bhjOsKe3XOkBeopZFQdTjRpRiLl6luh1+Dlqino7kZJMuNvdsh4xzzoH8QoDS9pZY8nJRSSR10y/BowUNwucZykbRrIo6BfMaG/E+enuPafvqbZtECKSHHJyfuNTxdZ2MfzRz233J1q4lp9okdgis0avgk4zgg66ZeqGCayVH8bUMqqoO9pPpK8g4PkecdNJPYXs5LW9poqeuU00scTzJHMpDbgF2Eg+GXB/tOmrtsa6jgprZVCENU73dUYtuVcdfcn9NUZIbTQOKap2U7XWXPuIaiGBOR82Vzk/5GOmidyq7hVokdJGgaRAX3Jk5Ph11Qo5qx7RG9qmixJ/W3n6TqRz1y1VO0NzhliVSJdqKuAcnwzk6W1ex6aSrYPtt6rKWe6QwOqjdtOByOBkZ986EXJ3epzIcnaNXbDaK253OuFPsUSSM2XbAxnPPHlorXdkK0SKZauijJX6WZ88Eg/h8wdNjCpWSylqhaorjWUd4p7lDXyVlRTyL3c82470Hh83IGMjHrq52tvFX2gvIqZNsJC7Yo1bhRjpn189UKNAuAR0GsKgKZueMnGfy+P8AzThIWsF9ittBNBWKzsqN3GD8yt4Iw8VJ8eq54yONWaq/77TJIttdFkLU6zNgIjlc9fzAEEDH2IaRFdd/0yDhvXXQ/hlcqW4UE1guFPTyCLM8KtCpDj8WeOSM9euD6aFpML1ITLHdTbKp5f54WchpQkjKCRjn0Ois9zhnEbQ0Uso2nczSqeSxJ6ofPWvtxAKbtXWqqgI+xwB05UZ/XOl5Rka3DXZToa2PZtY4bxzrdG6T1WOqEMPfjXmpogTOIkIQ3JT5X9R56u2G4PZr/S1qklIZAWx4xkYb/UnU1NY6H/iSAnaUspyJKeNgfcftpWBxqamuPplw/9k="

                        },
                    });
                    context.SaveChanges();

                }
                //Producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>() {
                        new Producer()
                        {
                            FullName = "Younes Bouab",
                            Bio = "Younes Bouab est un acteur et scénariste marocain, né le 29 avril 1979 à Salé.",
                            ProfilePictureURL = " data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIADgAJQMBIgACEQEDEQH/xAAaAAACAwEBAAAAAAAAAAAAAAAABgQFBwED/8QANBAAAgEDAQQGCAcBAAAAAAAAAQIDAAQREgUhMUEGBxNRkdEUIjIzYXGBwSNCobGys8IV/8QAFwEAAwEAAAAAAAAAAAAAAAAAAQIDAP/EABoRAAMBAQEBAAAAAAAAAAAAAAABAhESIgP/2gAMAwEAAhEDEQA/AMrgiAcFwdPEgcTQltNc3ZgsInlk4gAcqv4LCGFSzuu9cgllbO748OfnU/ohZzQ7SvLuAROmsZJwMIfkd1JdcrSsx00hOuI7vZ9yYr6Io5GWVhvx31MOmRGTcd2pW76a+mezJtoQektHbpKT+C4OCyjJIJ7gKWYBH6FAwkjeTSNXqkHypZrpaGpcPCDHHGEBfGo94zRXvPEoKhTwX7mimwUkNrPFjirXYBmN/J2MD3EPZjto0YBsDgRncTnl86oL+VhL2cbkKBvxzp56mLX/AKE224ggLCOB1cngQX3fXJ8K1LZNNZRG6Q7OvZtkXt3PbS2NnaRjso5DlmJYA/LOcYpXheEwhI2DEfHf4VqfWzKbLoRDbuoD312gA5hFBf8AdR41jGjPGh858h+lemWjJvoo2esjW4L+zk6Sd+RRRbFIF02u6lbhljWqdQUWH25IOfo6/wBnnWSajned5rYuoYZg2u55yRL4A+dUEI/Xvc9ptbZlmrDTb27zMp5l2AH8D41lDt6yj4099ctyJunE6A+6t4oz+rf6pAY5kUd5rAGS0VktYVMRb1BworrTroTDYGORNFSzR9FbVvFbL1Ft2eyNoSH895p8EXzrtFVQghdZM7S9OtsM2feqB9EUfaldGHboTw1DPjRRWMXErJhfaA7150UUVMY//9k="

                        },
                        new Producer()
                        {
                            FullName = "Mohamed Bastaoui",
                            Bio = "né en 1954 à Mrizig, un très petit village près de Khouribga, et mort le 17 décembre 2014 à Rabat",
                            ProfilePictureURL = " data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIADgALAMBIgACEQEDEQH/xAAbAAACAgMBAAAAAAAAAAAAAAAFBgAEAgMHAf/EADIQAAIBAwMBBgQEBwAAAAAAAAECAwQFEQASITEGE0FRYXEHIjLRQlKh4RQjM4KRosH/xAAYAQADAQEAAAAAAAAAAAAAAAACAwQAAf/EABwRAAICAwEBAAAAAAAAAAAAAAABAhEDITESM//aAAwDAQACEQMRAD8A5pBL3Te+iUVaQODoUNEYoYxYpK8MTIlQsQXwwcffUbSZamzfVTTSQkDC+rHGg86zyJtro+8iA+WaLkx+/pootBX1mVp4Wx4bhjOsKe3XOkBeopZFQdTjRpRiLl6luh1+Dlqino7kZJMuNvdsh4xzzoH8QoDS9pZY8nJRSSR10y/BowUNwucZykbRrIo6BfMaG/E+enuPafvqbZtECKSHHJyfuNTxdZ2MfzRz233J1q4lp9okdgis0avgk4zgg66ZeqGCayVH8bUMqqoO9pPpK8g4PkecdNJPYXs5LW9poqeuU00scTzJHMpDbgF2Eg+GXB/tOmrtsa6jgprZVCENU73dUYtuVcdfcn9NUZIbTQOKap2U7XWXPuIaiGBOR82Vzk/5GOmidyq7hVokdJGgaRAX3Jk5Ph11Qo5qx7RG9qmixJ/W3n6TqRz1y1VO0NzhliVSJdqKuAcnwzk6W1ex6aSrYPtt6rKWe6QwOqjdtOByOBkZ986EXJ3epzIcnaNXbDaK253OuFPsUSSM2XbAxnPPHlorXdkK0SKZauijJX6WZ88Eg/h8wdNjCpWSylqhaorjWUd4p7lDXyVlRTyL3c82470Hh83IGMjHrq52tvFX2gvIqZNsJC7Yo1bhRjpn189UKNAuAR0GsKgKZueMnGfy+P8AzThIWsF9ittBNBWKzsqN3GD8yt4Iw8VJ8eq54yONWaq/77TJIttdFkLU6zNgIjlc9fzAEEDH2IaRFdd/0yDhvXXQ/hlcqW4UE1guFPTyCLM8KtCpDj8WeOSM9euD6aFpML1ITLHdTbKp5f54WchpQkjKCRjn0Ois9zhnEbQ0Uso2nczSqeSxJ6ofPWvtxAKbtXWqqgI+xwB05UZ/XOl5Rka3DXZToa2PZtY4bxzrdG6T1WOqEMPfjXmpogTOIkIQ3JT5X9R56u2G4PZr/S1qklIZAWx4xkYb/UnU1NY6H/iSAnaUspyJKeNgfcftpWBxqamuPplw/9k="

                        },
                    });
                    context.SaveChanges();
                }
                //Cinema
              
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>() {
                        new Cinema()
                        {
                            Name = "hollywood",
                            Logo = "https://lh3.googleusercontent.com/p/AF1QipOEtJluiHfmHgc43MbAI_JPLK5kNY5_n8KblhA=s680-w680-h510",
                            Description = " This is the description of the fisrt Cinema"

                        },
                        new Cinema()
                        {
                            Name = "Opera",
                            Logo = "https://lh5.googleusercontent.com/p/AF1QipNZLEHNnk5tvg59GJdo-86_suhOa-s6_PM_HqCS=w284-h160-k-no",
                            Description = " This is the description of the Secound Cinema"

                        },
                    });
                    context.SaveChanges();

                }
                //Movie
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                         new Movie()
                         {
                              Name = "War",
                              Description = "This is the description of the first Cinema",
                              Price=29.50,
                              ImageURL = "https://lh3.googleusercontent.com/p/AF1QipOEtJluiHfmHgc43MbAI_JPLK5kNY5_n8KblhA=s680-w680-h510",
                               StartDate=DateTime.Now.AddDays(-15),
                               EndDate=DateTime.Now.AddDays(-5),
                               CinemaId=1,
                               ProducerId=2,
                               MovieCatagory=MovieCatagory.Documentary
                         },
                         new Movie()
                         {
                              Name = "War",
                              Description = "This is the description of the first Cinema",
                              Price=29.50,
                              ImageURL = "https://lh3.googleusercontent.com/p/AF1QipOEtJluiHfmHgc43MbAI_JPLK5kNY5_n8KblhA=s680-w680-h510",
                               StartDate=DateTime.Now.AddDays(-15),
                               EndDate=DateTime.Now.AddDays(-5),
                               CinemaId=1,
                               ProducerId=2,
                               MovieCatagory=MovieCatagory.Documentary
                         }
                    });
                    context.SaveChanges();
                }
                //Actor_Movie
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {    new Actor_Movie()
                     
                        {
                        ActorId= 1,
                        MovieId= 2,
                        },
                        new Actor_Movie()

                        {
                        ActorId= 2,
                        MovieId= 1,
                        }

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
