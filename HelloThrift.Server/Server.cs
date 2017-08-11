using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloThrift.Interface;
using Thrift.Server;
using Thrift.Transport;

namespace HelloThrift.Server
{
    public class Server
    {
        public void Start1()
        {
            try
            {
                // 设置服务端口为7911
                TServerSocket serverTransport = new TServerSocket(7911, 0, false);
                // 关联处理器与服务的实现
                HelloService.Processor processor = new HelloService.Processor(new MyHelloService());

                /* 
                 * 创建服务端对象；
                 * 
                 * 服务端类型
                 * TSimpleServer —— 单线程服务器端使用标准的阻塞式 I/O，
                 * TThreadPoolServer —— 多线程服务器端使用标准的阻塞式 I/O。
                 * 
                 * 由于C#语言的限制无法使用非阻塞的多线程服务端。
                 * 一般开发使用阻塞式多线程服务端即可。
                 * 
                 */
                TServer server = new TSimpleServer(processor, serverTransport);

                Console.WriteLine("Starting server on port 7911 ...");
                server.Serve();
            }
            catch (TTransportException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void Start2()
        {
            try
            {
                // 设置服务端口为7911
                TServerSocket serverTransport = new TServerSocket(7911, 0, false);
                // 关联处理器与服务的实现
                UserService.Processor processor = new UserService.Processor(new MyUserService());

                /* 
                 * 创建服务端对象；
                 * 
                 * 服务端类型
                 * TSimpleServer —— 单线程服务器端使用标准的阻塞式 I/O，
                 * TThreadPoolServer —— 多线程服务器端使用标准的阻塞式 I/O。
                 * 
                 * 由于C#语言的限制无法使用非阻塞的多线程服务端。
                 * 一般开发使用阻塞式多线程服务端即可。
                 * 
                 */
                TServer server = new TSimpleServer(processor, serverTransport);

                Console.WriteLine("Starting server on port 7911 ...");
                server.Serve();
            }
            catch (TTransportException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
