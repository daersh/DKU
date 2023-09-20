﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using DKU_ServerCore;

namespace DKU_DummyClient
{
    class Program
    {

        static void Main(string[] args)
        {
            Network network = new Network();
            network.Init();

            string host = Dns.GetHostName();
            IPHostEntry entry = Dns.GetHostEntry(host);
            IPAddress ipAddr = entry.AddressList[0];
            Console.WriteLine(ipAddr);
            network.Connect(ipAddr.ToString(), 7777);

            byte[] data = Encoding.Unicode.GetBytes("Hello world!");
            Packet packet = new Packet();
            packet.SetData(data, data.Length);
            network.Send(packet);

            while(true)
            {

            }
        }
    }
}
