﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaliteGiris.IEfDal;
using KaliteGiris.EfDal;
using KaliteGiris.Entities;
using System.Data.Entity;

namespace KaliteGiris.EfDal
{
    public class KayitDuzenleEf
    {
        public int kayitDuzenleEf(LabTalep veri)
        {
            int sonuc = 0;

            using (var context = new LabDataModel())
            {
                var data = context.LabTalep.FirstOrDefault(x=>x.LabTalepId == veri.LabTalepId);
                data.Aciklama = veri.Aciklama;
                data.AlimTipiId = veri.AlimTipiId;
                data.DurumId = veri.DurumId;
                data.FirmaId = veri.FirmaId;
                data.GKKSonucId = veri.GKKSonucId;
                data.IrsaliyeNo = veri.IrsaliyeNo;
                data.Malzeme = veri.Malzeme;
                data.PersonelId = veri.PersonelId;
                data.RaporTarihi = veri.RaporTarihi;
                data.Sira = veri.Sira;
                data.SonucDurumId = veri.SonucDurumId;
                data.SozlesmeNo = veri.SozlesmeNo;
                data.Tarih = veri.Tarih;
                data.UpdatededDate = veri.UpdatededDate;
                context.SaveChanges();
                sonuc = 1;
            }

            return sonuc;
        }
    }
}
