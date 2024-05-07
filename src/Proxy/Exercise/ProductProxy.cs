namespace Proxy.Exercise
{
    internal class ProductProxy : Product
    {
        private readonly DbContext _dbContext;
        public ProductProxy(int id, DbContext dbContext) : base(id)
        {
            _dbContext = dbContext;
        }

        public void SetName(string name)
        {
            base.SetName(name);
            _dbContext.MarkAsChanged(this);
        }
    }
}
