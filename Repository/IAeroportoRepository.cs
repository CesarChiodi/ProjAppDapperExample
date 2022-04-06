using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjAppDapperExample.Model;

namespace ProjAppDapperExample.Repository
{
    public interface IAeroportoRepository
    {
        bool Add(Aeroporto aeroporto);
        List<Aeroporto> Getall();
    }
}
