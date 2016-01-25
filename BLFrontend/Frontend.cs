using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;
using System.ComponentModel;
using BLFrontend.ServiceReference;

namespace BLFrontend
{
    [DataObject]
    public class Frontend : IBLFrontend
    {
        BLBackendClient backend = new BLBackendClient();

        public BindingList<Shagrir> GetShagrirs()
        {
            return new BindingList<Shagrir>(backend.GetShagrirs());
        }

        public bool AddShagrir(Shagrir shagrirToAdd)
        {
            return backend.AddShagrir(shagrirToAdd);
        }
    }
}
