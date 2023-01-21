using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class Sube : BaseEntity
    {
        public int FirmaId { get; set; }
        public int PersonelId { get; set; }
        public string? SubeAdi { get; set; }
        public ICollection<Personel> personeller { get; set; }
    }
}
