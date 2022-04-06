using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ProjAppDapperExample.Config;
using ProjAppDapperExample.Model;

namespace ProjAppDapperExample.Repository
{
    public class AeroportoRepository : IAeroportoRepository
    {
        private string _con;
        public AeroportoRepository()
        {
            _con = DataBaseConfiguration.Get();
        }


        public bool Add(Aeroporto aeroporto)
        {
            bool status = false;

            using(var db = new SqlConnection(_con))
            {
                db.Open();
                db.Execute(Aeroporto.INSERT, aeroporto);
                status = true;
                db.Close();
            }

            return status;
        }

        public List<Aeroporto> Getall()
        {
            using(var db = new SqlConnection(_con))
            {
                db.Open();
                var aeroportos = db.Query<Aeroporto>(Aeroporto.GETALL);

                return (List<Aeroporto>) aeroportos;
            }
        }
    }
}
