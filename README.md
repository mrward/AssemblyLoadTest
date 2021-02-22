Assembly.LoadFrom difference in .NET 5.0 vs .NET 4.7.2

Assembly.LoadFrom, then Assembly.LoadFile, then Assembly.GetTypes() with .NET 5
will fail if the dll being loaded has a dependency on another dll.

With .NET 4.7.2 the other dll is found and no ReflectionTypeLoadException occurs. 