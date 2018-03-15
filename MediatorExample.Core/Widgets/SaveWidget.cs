using MediatorExample.Core.Pipeline;
using MediatR;

namespace MediatorExample.Core.Widgets
{
    public class SaveWidget : IRequest<SaveWidgetResponse>, IHaveAuthorizationData
    {
        public string Message { get; set; }
    }
}
