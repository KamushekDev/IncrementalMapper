//HintName: IncrementalMapperConfig.g.cs

using System;
using System.Linq.Expressions;

namespace IncrementalMapper;

public enum OtherMembersBehaviour
{
    TryMapByName,
    Ignore
}

public class IncrementalMapperConfig 
{
    public IncrementalMapping<TIn, TOut> ConfigureMap<TIn, TOut>()
    {
        return new IncrementalMapping<TIn, TOut>();    
    }
    public IncrementalMapping<TIn1, TIn2, TOut> ConfigureMap<TIn1, TIn2, TOut>()
    {
        return new IncrementalMapping<TIn1, TIn2, TOut>();    
    }
    public IncrementalMapping<TIn1, TIn2, TIn3, TOut> ConfigureMap<TIn1, TIn2, TIn3, TOut>()
    {
        return new IncrementalMapping<TIn1, TIn2, TIn3, TOut>();    
    }
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TOut>()
    {
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut>();    
    }
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>()
    {
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>();    
    }
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>()
    {
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>();    
    }
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>()
    {
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>();    
    }
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>()
    {
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>();    
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

public class IncrementalMapping<TIn1, TIn2, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}
