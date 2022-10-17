using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolarMysql.Data.Cadastro
{
    public class CadastroDbContext : DbContext
    {
        public string strConnection;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //-->Conexao com servidor local
            const string strConnection = "Server=oficiotec.ddns.net;User Id=root;Password=@cpdrede12;Database=Oficio10Dev";
            optionsBuilder
            .UseMySql(strConnection, ServerVersion.AutoDetect(strConnection));

        }


        //public DbSet<Programa> programa { get; set; }
        //public DbSet<sistema> sistema { get; set; }
        //public DbSet<tipomenu> tipomenu { get; set; }
    }
}
