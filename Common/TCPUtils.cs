using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Base;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace vTCPServer.Common
{
    public enum TCPStatus
    {
        CLOSED,
        LISTENING,
        SYN_RECEIVED,
        SYN_SEND,
        ESTABLISHED,
        CLOSE_WAIT,
        LAST_ACK,
        FIN_WAIT_1,
        FIN_WAIT_2,
        TIME_WAIT,
        CLOSING,
        NULL,
    }

    public class EndPointInfo
    {
        public string DestinationMac { get; set; }
        public string SourceMac { get; set; }
        public string DestinationIp { get; set; }
        public string SourceIp { get; set; }
        public ushort DestinationPort { get; set; }
        public ushort SourcePort { get; set; }
    }

    public static class TCPUtils
    {
        public static uint seqNum = 100;
        public static uint ackNum = 1000;
        public static ushort windowSize = 4096;

        public static PacketDevice GetNICDevice()
        {
            // Retrieve the device list from the local machine
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;

            if (allDevices.Count == 0)
            {
                Console.WriteLine("No interfaces found! Make sure WinPcap is installed.");
                return null;
            }

            // Print the device list
            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];
                Console.Write((i + 1) + ". " + device.Name);
                if (device.Description != null)
                    Console.WriteLine(" (" + device.Description + ")");
                else
                    Console.WriteLine(" (No description available)");
            }

            int deviceIndex = 0;
            do
            {
                Console.WriteLine("Enter the interface number (1-" + allDevices.Count + "):");
                string deviceIndexString = Console.ReadLine();
                if (!int.TryParse(deviceIndexString, out deviceIndex) ||
                    deviceIndex < 1 || deviceIndex > allDevices.Count)
                {
                    deviceIndex = 0;
                }
            } while (deviceIndex == 0);

            return allDevices[deviceIndex - 1];
        }

        public static void PacketInfoPrinter(Packet packet, TCPStatus tcpStatus = TCPStatus.NULL)
        {
            Console.WriteLine("{0}:{1} ---> {2}:{3}  [{4}]",
                packet.Ethernet.IpV4.Source, packet.Ethernet.IpV4.Tcp.SourcePort,
                packet.Ethernet.IpV4.Destination, packet.Ethernet.IpV4.Tcp.DestinationPort,
                packet.Ethernet.IpV4.Tcp.ControlBits.ToString());

            if (tcpStatus != TCPStatus.NULL)
                Console.WriteLine("*** Status: {0} ***", tcpStatus);

            //    
            //      0                   1                   2                   3   
            //      0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 
            //     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
            //     |          Source Port          |       Destination Port        |
            //     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
            //     |                        Sequence Number                        |
            //     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
            //     |                    Acknowledgment Number                      |
            //     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
            //     |  Data |           |U|A|P|R|S|F|                               |
            //     | Offset| Reserved  |R|C|S|S|Y|I|            Window             |
            //     |       |           |G|K|H|T|N|N|                               |
            //     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
            //     |           Checksum            |         Urgent Pointer        |
            //     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
            //     |                    Options                    |    Padding    |
            //     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
            //     |                             data                              |
            //     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
            //    string lineSpliter = "+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+";
            //    Console.WriteLine(lineSpliter);
            //    Console.WriteLine(string.Format("|{0, -31}|{1, -31}|", packet.Ethernet.IpV4.Tcp.SourcePort, packet.Ethernet.IpV4.Tcp.DestinationPort));
            //    Console.WriteLine(lineSpliter);
            //    Console.WriteLine(string.Format("|{0, -63}|", packet.Ethernet.IpV4.Tcp.SequenceNumber));
            //    Console.WriteLine(lineSpliter);
            //    Console.WriteLine(string.Format("|{0, -63}|", packet.Ethernet.IpV4.Tcp.AcknowledgmentNumber));
            //    Console.WriteLine(lineSpliter);
            //    Console.WriteLine(string.Format("|{0, -7}|{1, -11}|{2}|{3}|{4}|{5}|{6}|{7}|{7, -31}|", packet.Ethernet.IpV4.Tcp.HeaderLength,string.Empty,
            //        (int)packet.Ethernet.IpV4.Tcp.ControlBits>>5 & 1, (int)packet.Ethernet.IpV4.Tcp.ControlBits>>4 & 1,
            //        (int)packet.Ethernet.IpV4.Tcp.ControlBits>>3 & 1, (int)packet.Ethernet.IpV4.Tcp.ControlBits>>2 & 1,
            //        (int)packet.Ethernet.IpV4.Tcp.ControlBits>>1 & 1, (int)packet.Ethernet.IpV4.Tcp.ControlBits & 1,
            //        packet.Ethernet.IpV4.Tcp.Window));
            //    Console.WriteLine(lineSpliter);
            //    Console.WriteLine(string.Format("|{0, -31}|{1, -31}|", packet.Ethernet.IpV4.Tcp.Checksum, packet.Ethernet.IpV4.Tcp.UrgentPointer));
            //    Console.WriteLine(lineSpliter);
            //    Console.WriteLine(string.Format("|{0, -47}|{1, -15}|", packet.Ethernet.IpV4.Tcp.Options, string.Empty));
            //    Console.WriteLine(lineSpliter);
            //    Console.WriteLine();
            //    

        }

        public static Packet BuildTcpPacket(EndPointInfo endPointInfo, TcpControlBits tcpControlBits, List<TcpOption> tcpOptionList = null, bool withPayload = false, string payloadData = "")
        {
            EthernetLayer ethernetLayer =
                new EthernetLayer
                {
                    Source = new MacAddress(endPointInfo.SourceMac),
                    Destination = new MacAddress(endPointInfo.DestinationMac),
                    EtherType = EthernetType.None, // Will be filled automatically.
                };

            IpV4Layer ipV4Layer =
                new IpV4Layer
                {
                    Source = new IpV4Address(endPointInfo.SourceIp),
                    CurrentDestination = new IpV4Address(endPointInfo.DestinationIp),
                    Fragmentation = IpV4Fragmentation.None,
                    HeaderChecksum = null, // Will be filled automatically.
                    Identification = 123,
                    Options = IpV4Options.None,
                    Protocol = null, // Will be filled automatically.
                    Ttl = 10,
                    TypeOfService = 0,
                };

            TcpLayer tcpLayer =
                new TcpLayer
                {
                    SourcePort = endPointInfo.SourcePort,
                    DestinationPort = endPointInfo.DestinationPort,
                    Checksum = null, // Will be filled automatically.
                    SequenceNumber = seqNum,
                    AcknowledgmentNumber = ackNum,
                    ControlBits = tcpControlBits,
                    Window = windowSize,
                    UrgentPointer = 0,
                    Options = (tcpOptionList == null) ? TcpOptions.None : new TcpOptions(tcpOptionList),
                };

            PacketBuilder builder;

            if (withPayload)
            {
                PayloadLayer payloadLayer = new PayloadLayer
                {
                    Data = new Datagram(System.Text.Encoding.ASCII.GetBytes(payloadData)),
                };

                builder = new PacketBuilder(ethernetLayer, ipV4Layer, tcpLayer, payloadLayer);

                return builder.Build(DateTime.Now);
            }

            builder = new PacketBuilder(ethernetLayer, ipV4Layer, tcpLayer);

            return builder.Build(DateTime.Now);
        }

        public static Packet BuildTcpResponsePacket(Packet packet, TcpControlBits tcpControlBits)
        {
            EthernetLayer ethernetHeader = new EthernetLayer
            {
                Source = new MacAddress(packet.Ethernet.Destination.ToString()),
                Destination = new MacAddress(packet.Ethernet.Source.ToString()),
                EtherType = EthernetType.None, // Will be filled automatically.
            };

            IpV4Layer ipHeader = new IpV4Layer
            {
                Source = new IpV4Address(packet.Ethernet.IpV4.Destination.ToString()),
                CurrentDestination = new IpV4Address(packet.Ethernet.IpV4.Source.ToString()),
                Fragmentation = IpV4Fragmentation.None,
                HeaderChecksum = null, // Will be filled automatically.
                Identification = 123,
                Options = IpV4Options.None,
                Protocol = null, // Will be filled automatically.
                Ttl = 100,
                TypeOfService = 0,
            };

            TcpLayer tcpHeader = new TcpLayer
            {
                SourcePort = packet.Ethernet.IpV4.Tcp.DestinationPort,
                DestinationPort = packet.Ethernet.IpV4.Tcp.SourcePort,
                Checksum = null, // Will be filled automatically.
                SequenceNumber = seqNum = packet.Ethernet.IpV4.Tcp.AcknowledgmentNumber,
                AcknowledgmentNumber = ackNum = packet.Ethernet.IpV4.Tcp.SequenceNumber + (uint)((packet.Ethernet.IpV4.Tcp.Payload.Length > 0) ? packet.Ethernet.IpV4.Tcp.Payload.Length : 1),
                ControlBits = tcpControlBits,
                Window = windowSize,
                UrgentPointer = 0,
                Options = TcpOptions.None,
            };


            PacketBuilder builder = new PacketBuilder(ethernetHeader, ipHeader, tcpHeader);

            return builder.Build(DateTime.Now);
        }
    }
}
