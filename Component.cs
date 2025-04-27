namespace ViniMediator;

public abstract class Component
{
    protected IMediator _mediator = null!;

    public void SetMediator(IMediator mediator)
    => _mediator = mediator;
}