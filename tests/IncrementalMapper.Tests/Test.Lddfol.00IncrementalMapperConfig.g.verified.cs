//HintName: IncrementalMapperConfig.g.cs

using System;
using System.Linq.Expressions;

namespace IncrementalMapper;
public class IncrementalMapperConfig 
{
    public IncrementalMapping<TIn, TOut> ConfigureMap<TIn, TOut>()
    {
        return new IncrementalMapping<TIn, TOut>();    
    }
    
}

public class IncrementalMapping<TIn, TOut> 
{
    public IncrementalMapping<TIn, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public enum OtherMembersBehaviour
{
    TryMapByName,
    Ignore
}
