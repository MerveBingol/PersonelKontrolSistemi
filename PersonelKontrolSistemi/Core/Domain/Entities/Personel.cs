using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Personel : BaseEntity
    {
       
        public int FirmaId { get; set; }
        public int PersonelId { get; set; }
        public int PersonelHareketleriId { get; set; }
        public string? PersonelAdi{ get; set; }
        public string? PersonelSoyadi{ get; set; }
        public string? PersonelEmail { get; set; }
        public string? PersonelSifre{ get; set; }
        public string? PersonelTelNo{ get; set; }

    }
}
