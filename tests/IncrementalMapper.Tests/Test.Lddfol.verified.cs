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

    public IncrementalMapping<TIn, TIn2, TOut> ConfigureMap<TIn, TIn2, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TOut> ConfigureMap<TIn, TIn2, TIn3, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>();    
    }

    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> ConfigureMap<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>()
    {
        return new IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>();    
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

public class IncrementalMapping<TIn, TIn2, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> 
{
    public IncrementalMapping<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

