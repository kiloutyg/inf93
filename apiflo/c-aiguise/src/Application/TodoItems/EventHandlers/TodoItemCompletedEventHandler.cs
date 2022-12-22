using c_aiguise.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace c_aiguise.Application.TodoItems.EventHandlers;

public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("c_aiguise Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
