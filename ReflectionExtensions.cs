using System;
using System.Collections.Generic;
using System.Reflection;

public static class ReflectionExtensions
{
    public static void Deconstruct(this PropertyInfo p, out bool isStatic,
                                    out bool isReadyOnly, out bool isIndexed,
                                    out Type propertyType) 
    {
        var getter = p.GetMethod;
        isReadyOnly = ! p.CanWrite;
        isStatic = getter.IsStatic;
        isIndexed = p.GetIndexParameters().Length > 0;
        propertyType = p.PropertyType;        
    }

    public static void Deconstruct(this PropertyInfo p, out bool hasGetAndSet,
                                   out bool sameAccess, out string access,
                                   out string getAccess, out string setAccess) 
    {
        
    }
}