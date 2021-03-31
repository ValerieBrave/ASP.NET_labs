using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebSockets;

namespace Lab1b
{
    public class http_handler : IHttpHandler
    {
        WebSocket socket;
        public bool IsReusable
        {
            get { return false; }
        }

        private async Task Send(string s)   //отправка строки
        {
            var sendbuffer = new ArraySegment<byte>(System.Text.Encoding.UTF8.GetBytes("Ответ: " + s));
            await socket.SendAsync(sendbuffer, WebSocketMessageType.Text, true, CancellationToken.None);
        }
        private async Task<string> Receive()
        {
            var buffer = new ArraySegment<byte>(new byte[512]);
            var result = await socket.ReceiveAsync(buffer, CancellationToken.None);
            string rc = System.Text.Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
            return rc;
        }
        private async Task WebSocketRequest(AspNetWebSocketContext context)
        {
            socket = context.WebSocket; //TCP-сокет - ссылка на объект ОС
            string s = await Receive();
            await Send(s);
            while (socket.State == WebSocketState.Open)
            {
                Thread.Sleep(2000);
                await Send(DateTime.Now.ToLongTimeString());    //отправляем каждые две секунды время
            }
        }
        public void ProcessRequest(HttpContext context)
        {
            if (context.IsWebSocketRequest)
                context.AcceptWebSocketRequest(WebSocketRequest);
        }

    }
}
