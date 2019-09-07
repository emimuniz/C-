using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_EF.Models
{
    public class ClienteContext : DbContext
    {
        //não ira permitir a criação de uma novo banco de dados e tabela
        public ClienteContext() : base("ClienteContext")
        {
            Database.SetInitializer<ClienteContext>(null);
        }

        public DbSet<Cliente> clientes { get; set; }
    }
}