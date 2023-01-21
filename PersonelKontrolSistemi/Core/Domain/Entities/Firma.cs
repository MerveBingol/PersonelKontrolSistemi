using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class Firma:BaseEntity
    {
        public int SubeId { get; set; }
        public int PersonelId { get; set; }
        public int PersonelHareketleriId { get; set; }
        public string? FirmaAdi { get; set; }
        public ICollection<Sube> subeler { get; set; }
    }
}
    
