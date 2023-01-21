using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PersonelHareketleri : BaseEntity
    {
        
        public int FirmaId { get; set; }
        public int SubeId { get; set; }
        public int PersonelId { get; set; }
        public DateTime PersonelGirisSaati { get; set; }
        public DateTime PersonelCikisSaati { get; set; }
    }
}
