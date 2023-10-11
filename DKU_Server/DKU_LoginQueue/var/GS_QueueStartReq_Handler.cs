
using DKU_ServerCore.Packets.var.gserver;
using DKU_ServerCore.Packets;
using DKU_LoginQueue;

public class GS_QueueStartReq_Handler
{
    public static void Method(Packet packet)
    {
        GS_QueueStartReq res = Data<GS_QueueStartReq>.Deserialize(packet.m_data);

        NetworkManager.Instance.m_game_server = NetworkManager.Instance.m_wid_list[res.wid];
        Console.WriteLine("Game Server Connected");
    }
}
