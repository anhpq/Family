using System.Data.Entity;
using Repository.Pattern.Ef6;

namespace Arigatou.DTO
{
    public class ModelContext : DataContext
    {
        static ModelContext()
        {
            Database.SetInitializer<ModelContext>(null);
        }
        public ModelContext() : base("name=ArigatouContext")
        {
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : Entity
        {
            return base.Set<TEntity>();
        }
    }
}
