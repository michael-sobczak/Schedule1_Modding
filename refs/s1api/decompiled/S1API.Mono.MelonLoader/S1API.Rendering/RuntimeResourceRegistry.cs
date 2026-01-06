using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using S1API.Logging;
using UnityEngine;

namespace S1API.Rendering;

public static class RuntimeResourceRegistry
{
	private static readonly Log Logger = new Log("S1API.RuntimeResourceRegistry");

	private static readonly Dictionary<string, Object> _registeredAssets = new Dictionary<string, Object>();

	private static bool _isPatched = false;

	public static bool RegisterAsset(string resourcePath, Object asset)
	{
		if (string.IsNullOrEmpty(resourcePath))
		{
			Logger.Error("Cannot register asset: resourcePath is null or empty");
			return false;
		}
		if (asset == (Object)null)
		{
			Logger.Error("Cannot register asset at '" + resourcePath + "': asset is null");
			return false;
		}
		if (_registeredAssets.ContainsKey(resourcePath))
		{
			Logger.Warning("Asset at path '" + resourcePath + "' is already registered. Overwriting with new asset.");
		}
		EnsurePatched();
		_registeredAssets[resourcePath] = asset;
		return true;
	}

	public static bool RegisterGameObject(string resourcePath, GameObject gameObject)
	{
		return RegisterAsset(resourcePath, (Object)(object)gameObject);
	}

	public static bool IsRegistered(string resourcePath)
	{
		return _registeredAssets.ContainsKey(resourcePath);
	}

	public static Object GetRegisteredAsset(string resourcePath)
	{
		_registeredAssets.TryGetValue(resourcePath, out Object value);
		return value;
	}

	public static T GetRegisteredAsset<T>(string resourcePath) where T : Object
	{
		if (_registeredAssets.TryGetValue(resourcePath, out Object value))
		{
			return (T)(object)((value is T) ? value : null);
		}
		return default(T);
	}

	private static void EnsurePatched()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		if (_isPatched)
		{
			return;
		}
		try
		{
			Harmony val = new Harmony("S1API.RuntimeResourceRegistry");
			MethodInfo[] methods = typeof(Resources).GetMethods(BindingFlags.Static | BindingFlags.Public);
			MethodInfo methodInfo = null;
			MethodInfo methodInfo2 = null;
			MethodInfo methodInfo3 = null;
			MethodInfo[] array = methods;
			foreach (MethodInfo methodInfo4 in array)
			{
				if (!(methodInfo4.Name != "Load"))
				{
					ParameterInfo[] parameters = methodInfo4.GetParameters();
					if (methodInfo == null && parameters.Length == 2 && parameters[0].ParameterType == typeof(string) && parameters[1].ParameterType == typeof(Type) && !methodInfo4.IsGenericMethod)
					{
						methodInfo = methodInfo4;
					}
					if (methodInfo2 == null && parameters.Length == 1 && parameters[0].ParameterType == typeof(string) && methodInfo4.ReturnType == typeof(Object) && !methodInfo4.IsGenericMethod)
					{
						methodInfo2 = methodInfo4;
					}
					if (methodInfo3 == null && methodInfo4.IsGenericMethod && parameters.Length == 1 && parameters[0].ParameterType == typeof(string) && methodInfo4.GetGenericArguments().Length == 1)
					{
						methodInfo3 = methodInfo4;
					}
				}
			}
			if (methodInfo != null)
			{
				MethodInfo method = typeof(RuntimeResourceRegistry).GetMethod("ResourcesLoadPrefix", BindingFlags.Static | BindingFlags.NonPublic);
				if (method != null)
				{
					val.Patch((MethodBase)methodInfo, new HarmonyMethod(method), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
				}
			}
			if (methodInfo2 != null)
			{
				MethodInfo method2 = typeof(RuntimeResourceRegistry).GetMethod("ResourcesLoadStringPrefix", BindingFlags.Static | BindingFlags.NonPublic);
				if (method2 != null)
				{
					val.Patch((MethodBase)methodInfo2, new HarmonyMethod(method2), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
				}
			}
			_isPatched = true;
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to patch Resources.Load: " + ex.Message);
			Logger.Error(ex.StackTrace);
		}
	}

	private static bool ResourcesLoadPrefix(string path, Type systemTypeInstance, ref Object __result)
	{
		if (string.IsNullOrEmpty(path))
		{
			return true;
		}
		if (_registeredAssets.TryGetValue(path, out Object value))
		{
			if (systemTypeInstance == null)
			{
				__result = value;
				return false;
			}
			if (systemTypeInstance.IsInstanceOfType(value))
			{
				__result = value;
				return false;
			}
			GameObject val = (GameObject)(object)((value is GameObject) ? value : null);
			if (val != null && typeof(Component).IsAssignableFrom(systemTypeInstance))
			{
				Component val2 = null;
				try
				{
					MethodInfo[] methods = typeof(GameObject).GetMethods(BindingFlags.Instance | BindingFlags.Public);
					MethodInfo methodInfo = null;
					MethodInfo[] array = methods;
					foreach (MethodInfo methodInfo2 in array)
					{
						if (methodInfo2.Name == "GetComponent" && methodInfo2.IsGenericMethod && methodInfo2.GetParameters().Length == 0)
						{
							methodInfo = methodInfo2;
							break;
						}
					}
					if (methodInfo != null)
					{
						MethodInfo methodInfo3 = methodInfo.MakeGenericMethod(systemTypeInstance);
						object? obj = methodInfo3.Invoke(val, null);
						val2 = (Component)((obj is Component) ? obj : null);
					}
				}
				catch (Exception ex)
				{
					Logger.Warning("Failed to get component '" + systemTypeInstance.Name + "' from GameObject: " + ex.Message);
				}
				if ((Object)(object)val2 != (Object)null)
				{
					__result = (Object)(object)val2;
					return false;
				}
				Logger.Warning("Registered GameObject at '" + path + "' does not have component of type '" + systemTypeInstance.Name + "'");
			}
		}
		return true;
	}

	private static bool ResourcesLoadStringPrefix(string path, ref Object __result)
	{
		if (string.IsNullOrEmpty(path))
		{
			return true;
		}
		if (_registeredAssets.TryGetValue(path, out Object value))
		{
			__result = value;
			return false;
		}
		return true;
	}
}
