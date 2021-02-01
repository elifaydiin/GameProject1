using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    class GamerManager : IGamerService
    {
        private ValidateManager validateManager;

        public GamerManager(ValidateManager validateManager)
        {
            this.validateManager = validateManager;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+""+gamer.LastName+" silindi.");
        }

        public void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " kayit edildi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " güncellendi.");
        }
    }
}
