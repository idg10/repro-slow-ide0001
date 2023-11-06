using System.Collections;
using System.Linq.Expressions;

namespace MakeIde0001GoSlow
{
    // Based on https://github.com/reaqtive/reaqtor/blob/4fca291cf3721255810f95b17d9c6c78a8114391/Nuqleon/Core/LINQ/Nuqleon.Linq.Expressions.Optimizers/System/Linq/Expressions/MemberTable.cs
    // but pared down to what's required to reproduce the problem. 
    public class MemberTable : IEnumerable<object>
    {
        public void Add(LambdaExpression expression)
        {
        }
        public IEnumerator<object> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(Expression<Action> expression) => Add((LambdaExpression)expression);
        public void Add<T1>(Expression<Action<T1>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2>(Expression<Action<T1, T2>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3>(Expression<Action<T1, T2, T3>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4>(Expression<Action<T1, T2, T3, T4>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5>(Expression<Action<T1, T2, T3, T4, T5>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6>(Expression<Action<T1, T2, T3, T4, T5, T6>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7>(Expression<Action<T1, T2, T3, T4, T5, T6, T7>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> expression) => Add((LambdaExpression)expression);
        public void Add<R>(Expression<Func<R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, R>(Expression<Func<T1, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, R>(Expression<Func<T1, T2, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, R>(Expression<Func<T1, T2, T3, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, R>(Expression<Func<T1, T2, T3, T4, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, R>(Expression<Func<T1, T2, T3, T4, T5, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, R>(Expression<Func<T1, T2, T3, T4, T5, T6, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, R>> expression) => Add((LambdaExpression)expression);
        public void Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, R>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, R>> expression) => Add((LambdaExpression)expression);
    }
}