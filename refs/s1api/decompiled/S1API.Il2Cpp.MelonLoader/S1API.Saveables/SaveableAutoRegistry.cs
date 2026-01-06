using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MelonLoader;
using S1API.Internal.Abstraction;

namespace S1API.Saveables;

internal static class SaveableAutoRegistry
{
	private static readonly List<Type> _discoveredSaveableTypes = new List<Type>();

	private static readonly Dictionary<Type, Saveable> _instances = new Dictionary<Type, Saveable>();

	private static bool _discoveryPerformed = false;

	private static readonly object _lock = new object();

	public static IEnumerable<Saveable> GetRegisteredSaveables()
	{
		lock (_lock)
		{
			if (!_discoveryPerformed)
			{
				DiscoverSaveableTypes();
				_discoveryPerformed = true;
			}
			return GetOrCreateInstances();
		}
	}

	private static void DiscoverSaveableTypes()
	{
		try
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				try
				{
					if (assembly == executingAssembly)
					{
						continue;
					}
					string? fullName = assembly.FullName;
					if (fullName != null && fullName.StartsWith("System"))
					{
						continue;
					}
					string? fullName2 = assembly.FullName;
					if (fullName2 != null && fullName2.StartsWith("Unity"))
					{
						continue;
					}
					string? fullName3 = assembly.FullName;
					if (fullName3 != null && fullName3.StartsWith("mscorlib"))
					{
						continue;
					}
					string? fullName4 = assembly.FullName;
					if (fullName4 != null && fullName4.StartsWith("netstandard"))
					{
						continue;
					}
					string? fullName5 = assembly.FullName;
					if (fullName5 != null && fullName5.StartsWith("Microsoft"))
					{
						continue;
					}
					string? fullName6 = assembly.FullName;
					if (fullName6 != null && fullName6.StartsWith("Il2Cpp"))
					{
						continue;
					}
					string? fullName7 = assembly.FullName;
					if (fullName7 != null && fullName7.StartsWith("MelonLoader"))
					{
						continue;
					}
					string? fullName8 = assembly.FullName;
					if ((fullName8 != null && fullName8.StartsWith("0Harmony")) || assembly.IsDynamic)
					{
						continue;
					}
					Type[] array;
					try
					{
						array = assembly.GetTypes();
					}
					catch (ReflectionTypeLoadException ex)
					{
						array = ex.Types.Where((Type t) => t != null).ToArray();
					}
					catch
					{
						goto end_IL_0020;
					}
					Type[] array2 = array;
					foreach (Type type in array2)
					{
						try
						{
							if (!(type == null) && !type.IsAbstract && !type.IsInterface && !type.IsGenericTypeDefinition && IsDirectSaveableInheritor(type))
							{
								_discoveredSaveableTypes.Add(type);
							}
						}
						catch
						{
						}
					}
					end_IL_0020:;
				}
				catch
				{
				}
			}
		}
		catch (Exception ex2)
		{
			try
			{
				MelonLogger.Warning("[S1API] Error during saveable type discovery: " + ex2.Message);
			}
			catch
			{
			}
		}
	}

	private static bool IsDirectSaveableInheritor(Type type)
	{
		if (!typeof(Saveable).IsAssignableFrom(type))
		{
			return false;
		}
		if (type.IsAbstract || type.IsInterface)
		{
			return false;
		}
		Type baseType = type.BaseType;
		return baseType == typeof(Saveable);
	}

	private static IEnumerable<Saveable> GetOrCreateInstances()
	{
		foreach (Type saveableType in _discoveredSaveableTypes)
		{
			if (!_instances.TryGetValue(saveableType, out Saveable instance))
			{
				try
				{
					instance = (Saveable)Activator.CreateInstance(saveableType, nonPublic: true);
					if (instance != null)
					{
						_instances[saveableType] = instance;
					}
				}
				catch
				{
				}
			}
			if (instance != null)
			{
				yield return instance;
			}
			instance = null;
		}
	}

	internal static void ClearCache()
	{
		lock (_lock)
		{
			_discoveredSaveableTypes.Clear();
			_instances.Clear();
			_discoveryPerformed = false;
		}
	}
}
