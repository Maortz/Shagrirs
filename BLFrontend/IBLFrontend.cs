﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;
using System.ComponentModel;

namespace BLFrontend
{
    interface IBLFrontend
    {
        BindingList<Shagrir> GetShagrirs();
        bool AddShagrir(Shagrir shagrirToAdd);
    }
}
