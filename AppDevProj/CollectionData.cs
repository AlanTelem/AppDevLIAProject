using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevProj
{
    public class CollectionData
    {
        public string CollectionId { get; set; } = "";
        public string Title { get; set; } = "";
        public List<CollectionItem> Items { get; set; } = new List<CollectionItem>();
    }
}
