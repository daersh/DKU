﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKU_ServerCore.Packets.var.server
{
    [Serializable]
    public class S_UserCharaDataRes : Data<S_UserCharaDataRes>
    {
        public int bitmask;
        //public short lastloginshift;
    }
}
