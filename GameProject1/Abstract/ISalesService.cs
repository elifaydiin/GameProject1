using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Abstract
{
    interface ISalesService
    {
        void Add(Gamer gamer, Campaign campaign);
        void Update(Gamer gamer,Campaign campaign);
    }
}
