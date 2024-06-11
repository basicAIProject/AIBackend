
using AIBackendProject.RunGame;

namespace AIBackendProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            Console.Out.WriteLine(gameManager.GetCurrentPlayer(gameManager._boardManager.Board));
            foreach (var VARIABLE in gameManager.PossibleActions(gameManager._boardManager.Board))
            {
                Console.Out.WriteLine(VARIABLE);   
            }
            /*var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();*/
        }
    }
}
