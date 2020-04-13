using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação do primeiro Post
            // Criando 2 comentários
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            
            // Instanciando Post 1
            Post p1 = new Post(   
                DateTime.Parse("21/06/2018 13:05:44"), 
                "Traveling to New Zeland", 
                "I'm going visit this wonderful country!", 
                12
            );

            // Adicionando comentários ao primeiro Post
            p1.AddComment(c1);
            p1.AddComment(c2);


            // Criação do segundo Post
            // Criando 2 comentários
            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the  Force be with you!");

            // Instanciando Post 2
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys!",
                "See you tomorrow!",
                5
            );
            // Adicionando comentários ao segundo Post
            p2.AddComment(c3);
            p2.AddComment(c4);


            // Imprimindo os resultados
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
