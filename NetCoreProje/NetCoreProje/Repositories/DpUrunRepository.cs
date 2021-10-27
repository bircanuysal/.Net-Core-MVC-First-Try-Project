using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using NetCoreProje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje.Repositories
{
    public class DpUrunRepository
    {
        public List<Urun> GetirHepsi()
        {
            using var connection = new SqlConnection("server=BIRCAN-UYSAL\\SQLEXPRESS; database=NetCoreProje;integrated security=true;");
            return connection.GetAll<Urun>().ToList(); //bütün ürünleri getirdik.
        }
    }
}
