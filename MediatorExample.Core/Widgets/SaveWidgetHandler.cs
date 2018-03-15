using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorExample.Core.Widgets
{
    public class SaveWidgetHandler : IRequestHandler<SaveWidget, SaveWidgetResponse>
    {
        public async Task<SaveWidgetResponse> Handle(SaveWidget request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new SaveWidgetResponse { Message = "processed: " + request.Message });
        }
    }
}
