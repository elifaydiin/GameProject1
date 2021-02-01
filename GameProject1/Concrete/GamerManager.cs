using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    class GamerManager : IGamerService
    {
       IValidateService _validateService;

        public GamerManager(IValidateService validateService)
        {
            _validateService = validateService;
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+""+gamer.LastName+" silindi.");
        }

        public void Save(Gamer gamer)
        {
            if(_validateService.CheckGamer(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " güncellendi.");
        }
    }
}
