using Microsoft.EntityFrameworkCore;
using ApiAquiTemBarbearia.Domain.Model.UserAggregate;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Data.SqlClient;

namespace ApiAquiTemBarbearia.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = @"Database=Teste;Server=DESKTOP-D1IK3FL\SQLEXPRESS;";

                SqlConnection SqlConn = new SqlConnection(connectionString);

                SqlConn.Open();

                SqlConn.Close();
            }
        }
         
    }
}
