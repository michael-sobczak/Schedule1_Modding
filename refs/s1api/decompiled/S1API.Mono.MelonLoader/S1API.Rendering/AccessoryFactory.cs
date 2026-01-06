using System;
using System.Collections.Generic;
using S1API.Logging;
using ScheduleOne.AvatarFramework;
using UnityEngine;

namespace S1API.Rendering;

public static class AccessoryFactory
{
	private static readonly Log Logger = new Log("AccessoryFactory");

	internal static readonly Dictionary<string, Dictionary<string, Texture2D>> _accessoryTextureRegistry = new Dictionary<string, Dictionary<string, Texture2D>>();

	public static GameObject CloneAccessoryWithCustomTextures(string sourceResourcePath, string newName, Dictionary<string, Texture2D> textureReplacements = null, Color? colorTint = null, string targetResourcePath = null)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			GameObject val = Resources.Load<GameObject>(sourceResourcePath);
			if ((Object)(object)val == (Object)null)
			{
				Logger.Error("Failed to load source accessory at path: " + sourceResourcePath);
				return null;
			}
			GameObject val2 = Object.Instantiate<GameObject>(val);
			((Object)val2).name = newName;
			Object.DontDestroyOnLoad((Object)(object)val2);
			val2.SetActive(false);
			Accessory component = val2.GetComponent<Accessory>();
			if ((Object)(object)component != (Object)null)
			{
				component.AssetPath = targetResourcePath ?? sourceResourcePath;
				component.Name = newName;
			}
			if (textureReplacements != null && textureReplacements.Count > 0)
			{
				ApplyTexturesToAccessory(val2, textureReplacements);
			}
			if (colorTint.HasValue && (Object)(object)component != (Object)null)
			{
				component.ApplyColor(colorTint.Value);
			}
			val2.SetActive(true);
			return val2;
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to clone accessory '" + sourceResourcePath + "': " + ex.Message);
			Logger.Error(ex.StackTrace);
			return null;
		}
	}

	private static void ApplyTexturesToAccessory(GameObject accessory, Dictionary<string, Texture2D> textureReplacements)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		Renderer[] componentsInChildren = accessory.GetComponentsInChildren<Renderer>(true);
		Renderer[] array = componentsInChildren;
		foreach (Renderer val in array)
		{
			Material[] materials = val.materials;
			for (int j = 0; j < materials.Length; j++)
			{
				Material val2 = new Material(materials[j]);
				foreach (KeyValuePair<string, Texture2D> textureReplacement in textureReplacements)
				{
					if (val2.HasProperty(textureReplacement.Key))
					{
						val2.SetTexture(textureReplacement.Key, (Texture)(object)textureReplacement.Value);
					}
				}
				materials[j] = val2;
			}
			val.materials = materials;
		}
	}

	public static bool RegisterAccessory(string resourcePath, GameObject accessory)
	{
		if ((Object)(object)accessory == (Object)null)
		{
			Logger.Error("Cannot register null accessory");
			return false;
		}
		Accessory component = accessory.GetComponent<Accessory>();
		if ((Object)(object)component == (Object)null)
		{
			Logger.Warning("GameObject '" + ((Object)accessory).name + "' does not have an Accessory component. It may not work correctly as clothing.");
		}
		return RuntimeResourceRegistry.RegisterGameObject(resourcePath, accessory);
	}

	public static bool CreateAndRegisterAccessory(string sourceResourcePath, string targetResourcePath, string newName, Dictionary<string, Texture2D> textureReplacements = null, Color? colorTint = null)
	{
		GameObject val = CloneAccessoryWithCustomTextures(sourceResourcePath, newName, textureReplacements, colorTint, targetResourcePath);
		if ((Object)(object)val == (Object)null)
		{
			return false;
		}
		if (textureReplacements != null && textureReplacements.Count > 0)
		{
			_accessoryTextureRegistry[targetResourcePath] = textureReplacements;
		}
		return RegisterAccessory(targetResourcePath, val);
	}

	internal static Dictionary<string, Texture2D> GetTextureReplacements(string resourcePath)
	{
		_accessoryTextureRegistry.TryGetValue(resourcePath, out Dictionary<string, Texture2D> value);
		return value;
	}
}
