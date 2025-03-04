namespace Transport.Queries
{
    using MediatR;

    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
}
