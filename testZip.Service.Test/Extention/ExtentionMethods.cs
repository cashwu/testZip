using NSubstitute;
using System.Data.Entity;
using System.Linq;

namespace testZip.Service.Test.Extention
{
    public static class ExtentionMethods
    {
        public static DbSet<T> Initialize<T>(this DbSet<T> dbSet, IQueryable<T> data) where T : class
        {
            ((IQueryable<T>)dbSet).Provider.Returns(data.Provider);
            ((IQueryable<T>)dbSet).Expression.Returns(data.Expression);
            ((IQueryable<T>)dbSet).ElementType.Returns(data.ElementType);
            ((IQueryable<T>)dbSet).GetEnumerator().Returns(data.GetEnumerator());
            return dbSet;
        }

        public static IDbSet<T> Initialize<T>(this IDbSet<T> dbSet, IQueryable<T> data) where T : class
        {
            ((IQueryable<T>)dbSet).Provider.Returns(data.Provider);
            ((IQueryable<T>)dbSet).Expression.Returns(data.Expression);
            ((IQueryable<T>)dbSet).ElementType.Returns(data.ElementType);
            ((IQueryable<T>)dbSet).GetEnumerator().Returns(data.GetEnumerator());
            return dbSet;
        }
    }
}
