using Web02.Models;

namespace Web02.Services
{
    public class RepositoryOfProjects
    {
        public List<ClassProjects> GetProjects()
        {
            return new List<ClassProjects>() {
                new ClassProjects {
                    Title = "",
                    Description = "WEB realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImageURL = "/images/ASPdev.png"
                    },
                new ClassProjects {
                Title = "Java Script",
                Description = "Animación realizado en JS",
                Link = "https://Monlau.com",
                ImageURL = "/images/rosa.png"
                }
            };
        }
    }
}