
using DKU_ServerCore.Packets.var.client;
using DKU_ServerCore.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKU_Server.Packets.var
{
    public class C_PingReq_Handler
    {
        public static void Method(Packet packet)
        {
            C_PingReq req = Data<C_PingReq>.Deserialize(packet.m_data);
            //TODO
        }
    }
}
