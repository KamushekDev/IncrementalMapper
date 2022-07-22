using System.Runtime.CompilerServices;

namespace IncrementalMapper.Tests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init()
    {
        VerifySourceGenerators.Enable();
    }
}