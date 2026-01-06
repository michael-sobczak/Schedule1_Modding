using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.AvatarFramework;
using S1API.Logging;
using S1API.Rendering;
using UnityEngine;

namespace S1API.Internal.Patches;

[HarmonyPatch]
internal static class AvatarAccessoryPatches
{
	[HarmonyPatch]
	internal static class AvatarApplyAccessorySettingsPatch
	{
		private static MethodBase TargetMethod()
		{
			return typeof(Avatar).GetMethod("ApplyAccessorySettings", BindingFlags.Instance | BindingFlags.Public);
		}

		private static void Postfix(Avatar __instance)
		{
			try
			{
				FieldInfo field = typeof(Avatar).GetField("appliedAccessories", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (field == null)
				{
					return;
				}
				object value = field.GetValue(__instance);
				if (value == null)
				{
					return;
				}
				Type type = value.GetType();
				if (!type.IsArray)
				{
					return;
				}
				int length = ((Array)value).Length;
				for (int i = 0; i < length; i++)
				{
					object value2 = ((Array)value).GetValue(i);
					if (value2 == null)
					{
						continue;
					}
					PropertyInfo property = value2.GetType().GetProperty("AssetPath");
					if (property == null)
					{
						continue;
					}
					string text = property.GetValue(value2) as string;
					if (string.IsNullOrEmpty(text))
					{
						continue;
					}
					Dictionary<string, Texture2D> textureReplacements = AccessoryFactory.GetTextureReplacements(text);
					if (textureReplacements == null || textureReplacements.Count == 0)
					{
						continue;
					}
					PropertyInfo property2 = value2.GetType().GetProperty("gameObject");
					if (!(property2 == null))
					{
						object? value3 = property2.GetValue(value2);
						GameObject val = (GameObject)((value3 is GameObject) ? value3 : null);
						if (!((Object)(object)val == (Object)null))
						{
							ApplyTexturesToAccessoryInstance(val, textureReplacements);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("Error applying custom textures to accessories: " + ex.Message);
			}
		}

		private static void ApplyTexturesToAccessoryInstance(GameObject accessoryObj, Dictionary<string, Texture2D> textureReplacements)
		{
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			if ((Object)(object)accessoryObj == (Object)null || textureReplacements == null || textureReplacements.Count == 0)
			{
				return;
			}
			Il2CppArrayBase<Renderer> componentsInChildren = accessoryObj.GetComponentsInChildren<Renderer>(true);
			foreach (Renderer item in componentsInChildren)
			{
				if ((Object)(object)item == (Object)null)
				{
					continue;
				}
				Il2CppReferenceArray<Material> materials = item.materials;
				bool flag = false;
				for (int i = 0; i < ((Il2CppArrayBase<Material>)(object)materials).Length; i++)
				{
					if ((Object)(object)((Il2CppArrayBase<Material>)(object)materials)[i] == (Object)null)
					{
						continue;
					}
					Material val = new Material(((Il2CppArrayBase<Material>)(object)materials)[i]);
					foreach (KeyValuePair<string, Texture2D> textureReplacement in textureReplacements)
					{
						if (val.HasProperty(textureReplacement.Key))
						{
							val.SetTexture(textureReplacement.Key, (Texture)(object)textureReplacement.Value);
							flag = true;
						}
					}
					if (flag)
					{
						((Il2CppArrayBase<Material>)(object)materials)[i] = val;
					}
				}
				if (flag)
				{
					item.materials = materials;
				}
			}
		}
	}

	private static readonly Log Logger = new Log("AvatarAccessoryPatches");
}
