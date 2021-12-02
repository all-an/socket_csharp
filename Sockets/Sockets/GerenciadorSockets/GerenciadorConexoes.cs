using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Sockets.GerenciadorSockets

{
    public class GerenciadorConexoes
    {
        private ConcurrentDictionary<string, WebSocket> _conexoes = new ConcurrentDictionary<string, WebSocket>();

    }
}
