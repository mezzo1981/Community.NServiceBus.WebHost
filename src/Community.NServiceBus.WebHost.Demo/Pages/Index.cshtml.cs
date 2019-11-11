using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NServiceBus;

namespace Community.NServiceBus.WebHost.Demo.Pages
{
    public class IndexModel : PageModel
    {
        // The message session can be injected via DI
        private IMessageSession messageSession;

        public IndexModel(IMessageSession messageSession)
        {
            this.messageSession = messageSession;
        }

        public async Task OnGet()
        {
            await messageSession.SendLocal(new DemoMessage());
        }
    }
}
