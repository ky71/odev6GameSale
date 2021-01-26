using Odev6GameSale.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);


    }
}
