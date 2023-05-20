using Domain.Services;
using LiteDB;
using Infrastructure.Database;
using Domain.Entities;
using System.Security.Cryptography;
using Application.Services;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var db = new LiteDatabase(@"TestDatabase.db");
            DomainRepository<TravelTicket> repository = new TravelTicketRepository(db);

            builder.Services.AddScoped<DomainReport, TravelTicketService>(f => new TravelTicketService(repository));

            builder.Services.AddControllers();

            // builder.Services.AddEndpointsApiExplorer();
            // builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}

