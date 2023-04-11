using Clase04b.Models;

namespace Clase04b.Services;



public static class MovieService{
    static List<Movie> Movies { get; set;}

    static MovieService(){
        Movies = new List<Movie>
        {
            new Movie { Name = "Artificial Intelligence", Code="---", Category="Sci fi", Minutes=140},
            new Movie { Name = "El hombre bicentenario", Code="---", Category="Sci fi", Minutes=120, Review="Excelente película"},
            new Movie { Name = "The avengers", Code="HNL", Category="Sci-fi", Minutes=145},
            new Movie { Name = "Superman", Code="SPM", Category="Action", Minutes=130},
            new Movie { Name = "Batman", Code="ELC", Category="Action", Minutes=120},
            new Movie { Name = "Casino Royale", Code="ENG", Category="Action", Minutes=125},
            new Movie { Name = "El Padrino", Code="ELP", Category="Drama", Minutes=145}
        };
    }

    public static List<Movie> GetAll() => Movies;

    public static void Add(Movie obj){
       if(obj == null){
         return;
       }

       Movies.Add(obj);
    }

    public static void Delete(string code){
        var movieToDelete = Get(code);

        if (movieToDelete != null){
            Movies.Remove(movieToDelete);
        }
    }
    public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());
}