using GameProject1.Concrete;
using GameProject1.Entities;
using System;

namespace GameProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new ValidateManager());
            
            gamerManager.Save(new Gamer { Id = 1,FirstName = "Elif", LastName = "Aydın", NationalityId = "123456789" });
            gamerManager.Delete(new Gamer { Id = 2, FirstName = "Kader", LastName = "Demir", NationalityId = "987654321" });
            gamerManager.Update(new Gamer { Id = 3,FirstName = "Nur", LastName = "Acartürk", NationalityId = "012345678" });



            CampaignManager campaignManager = new CampaignManager();
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager.Add(new Campaign()
            {
                
                CampaignName = "Yaz Kampanyası",
                CampaignDetail = "Öğrenci İndirimi",
            });
            campaignManager1.Update(new Campaign()
            {
                
                CampaignName = "Kış Kampanyası",
                CampaignDetail = "Çalışan İndirimi",
            });
            campaignManager1.Delete(new Campaign()
            {
               
                CampaignName = "Yeni Yıl Kampanyası",
                CampaignDetail = "Herkes İçin İndirim",
            });

           

            SalesManager saleManager = new SalesManager(new CampaignManager());
            saleManager.Add(new Gamer { Id = 1 }, new Campaign { CampaignName = "Kış Kampanyası" });


        }
    }
}
