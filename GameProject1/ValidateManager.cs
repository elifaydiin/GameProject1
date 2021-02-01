using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    class ValidateManager : IValidateService
    {
        public bool CheckGamer(Gamer gamer)
        {
           
            if (gamer.Id==1 && gamer.FirstName=="Elif" && gamer.NationalityId == "123456789")
            {
                return true;
            }
            else
            {
                throw new Exception("Doğrulama yapılamadı");
            }
        }
    }
}
