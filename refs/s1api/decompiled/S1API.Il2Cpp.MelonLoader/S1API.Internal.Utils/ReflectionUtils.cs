using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace S1API.Internal.Utils;

internal static class ReflectionUtils
{
	private static readonly HashSet<Type> _valueTupleTypes = new HashSet<Type>
	{
		typeof(ValueTuple<>),
		typeof(ValueTuple<, >),
		typeof(ValueTuple<, , >),
		typeof(ValueTuple<, , , >),
		typeof(ValueTuple<, , , , >),
		typeof(ValueTuple<, , , , , >),
		typeof(ValueTuple<, , , , , , >),
		typeof(ValueTuple<, , , , , , , >)
	};

	private static readonly Dictionary<Type, List<string>> _constStringFieldsCache = new Dictionary<Type, List<string>>();

	internal static List<Type> GetDerivedClasses<TBaseClass>()
	{
		List<Type> list = new List<Type>();
		Assembly[] array = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
			where !ShouldSkipAssembly(assembly)
			select assembly).ToArray();
		Assembly[] array2 = array;
		foreach (Assembly asm in array2)
		{
			foreach (Type item in SafeGetTypes(asm))
			{
				try
				{
					if (!(item == null) && typeof(TBaseClass).IsAssignableFrom(item) && item != typeof(TBaseClass) && !item.IsAbstract)
					{
						list.Add(item);
					}
				}
				catch (TypeLoadException)
				{
				}
				catch (Exception)
				{
				}
			}
		}
		return list;
	}

	internal static Type? GetTypeByName(string typeName)
	{
		try
		{
			Type type = Type.GetType(typeName, throwOnError: false, ignoreCase: false);
			if (type != null)
			{
				return type;
			}
		}
		catch
		{
		}
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly item in assemblies.Where((Assembly a) => !ShouldSkipAssembly(a)))
		{
			foreach (Type item2 in SafeGetTypes(item))
			{
				if (item2 == null || (!(item2.Name == typeName) && !(item2.FullName == typeName)))
				{
					continue;
				}
				return item2;
			}
		}
		Assembly[] array = assemblies;
		foreach (Assembly asm in array)
		{
			foreach (Type item3 in SafeGetTypes(asm))
			{
				if (item3 == null || (!(item3.Name == typeName) && !(item3.FullName == typeName) && (item3.FullName == null || !item3.FullName.EndsWith("." + typeName))))
				{
					continue;
				}
				return item3;
			}
		}
		return null;
	}

	internal static bool ShouldSkipAssembly(Assembly assembly)
	{
		string fullName = assembly.FullName;
		if (string.IsNullOrEmpty(fullName))
		{
			return false;
		}
		return fullName.StartsWith("System") || fullName.StartsWith("Unity") || fullName.StartsWith("Il2Cpp") || fullName.StartsWith("mscorlib") || fullName.StartsWith("Mono.") || fullName.StartsWith("netstandard") || fullName.StartsWith("com.rlabrecque") || fullName.StartsWith("__Generated");
	}

	internal static IEnumerable<Type> SafeGetTypes(Assembly asm)
	{
		try
		{
			return asm.GetTypes();
		}
		catch (ReflectionTypeLoadException ex)
		{
			return ex.Types.Where((Type t) => t != null).Cast<Type>();
		}
		catch
		{
			return Array.Empty<Type>();
		}
	}

	internal static FieldInfo[] GetAllFields(Type? type, BindingFlags bindingFlags)
	{
		List<FieldInfo> list = new List<FieldInfo>();
		while (type != null && type != typeof(object))
		{
			list.AddRange(type.GetFields(bindingFlags));
			type = type.BaseType;
		}
		return list.ToArray();
	}

	[Obsolete("Use S1API.Utils.ReflectionUtils.GetMethod instead. This method will be made internal in a future version.")]
	public static MethodInfo? GetMethod(Type? type, string methodName, BindingFlags bindingFlags)
	{
		while (type != null && type != typeof(object))
		{
			MethodInfo method = type.GetMethod(methodName, bindingFlags);
			if (method != null)
			{
				return method;
			}
			type = type.BaseType;
		}
		return null;
	}

	[Obsolete("Use S1API.Utils.ReflectionUtils.IsValueTuple instead. This method will be made internal in a future version.")]
	public static bool IsValueTuple(this object obj)
	{
		if (obj == null)
		{
			return false;
		}
		Type type = obj.GetType();
		if (!type.IsValueType || !type.IsGenericType)
		{
			return false;
		}
		Type genericTypeDefinition = type.GetGenericTypeDefinition();
		return _valueTupleTypes.Contains(genericTypeDefinition);
	}

	[Obsolete("Use S1API.Utils.ReflectionUtils.GetValueTupleItems instead. This method will be made internal in a future version.")]
	public static object[]? GetValueTupleItems(this object obj)
	{
		if (!obj.IsValueTuple())
		{
			return null;
		}
		FieldInfo[] allFields = GetAllFields(obj.GetType(), BindingFlags.Instance | BindingFlags.Public);
		if (allFields == null || allFields.Length == 0)
		{
			return null;
		}
		return allFields.Select((FieldInfo f) => f.GetValue(obj)).ToArray();
	}

	internal static List<string> GetConstStringFields(Type type)
	{
		if (type == null)
		{
			return new List<string>();
		}
		if (_constStringFieldsCache.TryGetValue(type, out List<string> value))
		{
			return value;
		}
		List<string> list = new List<string>();
		FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			if ((object)fieldInfo != null && fieldInfo.IsLiteral && !fieldInfo.IsInitOnly && fieldInfo.FieldType == typeof(string))
			{
				list.Add((string)fieldInfo.GetRawConstantValue());
			}
		}
		_constStringFieldsCache[type] = list;
		return list;
	}

	internal static bool TrySetFieldOrProperty(object target, string memberName, object value)
	{
		if (target == null)
		{
			return false;
		}
		Type type = target.GetType();
		FieldInfo field = type.GetField(memberName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (field != null)
		{
			try
			{
				if (value == null || field.FieldType.IsInstanceOfType(value))
				{
					field.SetValue(target, value);
					return true;
				}
			}
			catch
			{
			}
		}
		PropertyInfo property = type.GetProperty(memberName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (property != null && property.CanWrite)
		{
			try
			{
				if (value == null || property.PropertyType.IsInstanceOfType(value))
				{
					property.SetValue(target, value);
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	internal static object TryGetFieldOrProperty(object target, string memberName)
	{
		if (target == null)
		{
			return null;
		}
		Type type = target.GetType();
		FieldInfo field = type.GetField(memberName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (field != null)
		{
			try
			{
				return field.GetValue(target);
			}
			catch
			{
			}
		}
		PropertyInfo property = type.GetProperty(memberName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (property != null && property.CanRead)
		{
			try
			{
				return property.GetValue(target);
			}
			catch
			{
			}
		}
		return null;
	}

	internal static object TryGetStaticFieldOrProperty(Type type, string memberName)
	{
		if (type == null)
		{
			return null;
		}
		FieldInfo field = type.GetField(memberName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (field != null)
		{
			try
			{
				return field.GetValue(null);
			}
			catch
			{
			}
		}
		PropertyInfo property = type.GetProperty(memberName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (property != null && property.CanRead)
		{
			try
			{
				return property.GetValue(null);
			}
			catch
			{
			}
		}
		return null;
	}

	internal static bool TrySetStaticFieldOrProperty(Type type, string memberName, object value)
	{
		if (type == null)
		{
			return false;
		}
		FieldInfo field = type.GetField(memberName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (field != null)
		{
			try
			{
				if (value == null || field.FieldType.IsInstanceOfType(value))
				{
					field.SetValue(null, value);
					return true;
				}
			}
			catch
			{
			}
		}
		PropertyInfo property = type.GetProperty(memberName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (property != null && property.CanWrite)
		{
			try
			{
				if (value == null || property.PropertyType.IsInstanceOfType(value))
				{
					property.SetValue(null, value);
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}
}
