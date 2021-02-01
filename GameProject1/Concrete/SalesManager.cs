using GameProject1.Abstract;
using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Concrete
{
    class SalesManager : ISalesService
    {
        ICampaignService _campaignService;
        public SalesManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;

        }
        public void Add(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.Id + " Numaralı müşteri " + campaign.CampaignName + " adlı kampanyadan yararlandı ");
        }

        public void Update(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.Id + " Numaralı müşteri " + campaign.CampaignName + " adlı kampanyayı güncelledi. ");
        }
    }
}
