namespace Domain.Domain.Interfaces.Repositories.UnitWork
{
    public interface IUnitOfWork
    {
        void initializer();
        void persit();
    }
}
