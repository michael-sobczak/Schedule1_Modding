using System;
using System.Reflection;
using S1API.Internal.Utils;

namespace S1API.Utils;

public static class ReflectionUtils
{
	public static MethodInfo? GetMethod(Type? type, string methodName, BindingFlags bindingFlags)
	{
		return global::S1API.Internal.Utils.ReflectionUtils.GetMethod(type, methodName, bindingFlags);
	}

	public static bool IsValueTuple(this object obj)
	{
		return global::S1API.Internal.Utils.ReflectionUtils.IsValueTuple(obj);
	}

	public static object[]? GetValueTupleItems(this object obj)
	{
		return global::S1API.Internal.Utils.ReflectionUtils.GetValueTupleItems(obj);
	}

	public static bool TrySetFieldOrProperty(object target, string memberName, object value)
	{
		return global::S1API.Internal.Utils.ReflectionUtils.TrySetFieldOrProperty(target, memberName, value);
	}

	public static object? TryGetFieldOrProperty(object target, string memberName)
	{
		return global::S1API.Internal.Utils.ReflectionUtils.TryGetFieldOrProperty(target, memberName);
	}
}
