using System;
using System.Diagnostics;
using System.Threading.Tasks;
using NServiceBus;

namespace Community.NServiceBus.WebHost.Demo
{
    public class DemoMessageHandler : IHandleMessages<DemoMessage>
    {
        public Task Handle(DemoMessage message, IMessageHandlerContext context)
        {
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }

            return Task.CompletedTask;
        }
    }
}