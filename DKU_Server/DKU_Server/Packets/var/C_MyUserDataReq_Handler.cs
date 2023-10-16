
using DKU_ServerCore.Packets.var.client;
using DKU_ServerCore.Packets.var.queue;
using DKU_ServerCore.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DKU_Server.Connections;

namespace DKU_Server.Packets.var
{
    public class C_MyUserDataReq_Handler
    {
        public static void Method(SPacket packet)
        {
            C_MyUserDataReq req = Data<C_MyUserDataReq>.Deserialize(packet.m_data);
            NetworkManager.Instance.world.AddUidUser(req.uid, new LoginData(packet.USER_TOKEN, req.udata));
            Console.WriteLine($"[Login] Hello, {req.udata.nickname}");
        }
    }
}
