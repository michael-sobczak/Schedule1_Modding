using System;
using S1API.Logging;
using UnityEngine;

namespace S1API.Rendering;

public static class MaterialHelper
{
	private static readonly Log Logger = new Log("MaterialHelper");

	public static void ReplaceMaterials(GameObject gameObject, Func<Material, bool> predicate, Action<Material> materialModifier)
	{
		if ((Object)(object)gameObject == (Object)null)
		{
			Logger.Warning("ReplaceMaterials called with null GameObject");
			return;
		}
		if (predicate == null || materialModifier == null)
		{
			Logger.Warning("ReplaceMaterials called with null predicate or modifier");
			return;
		}
		try
		{
			Renderer[] componentsInChildren = gameObject.GetComponentsInChildren<Renderer>(true);
			foreach (Renderer val in componentsInChildren)
			{
				if (!((Object)(object)val == (Object)null))
				{
					ProcessRenderer(val, predicate, materialModifier);
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Error in ReplaceMaterials: " + ex.Message);
		}
	}

	public static Material CreateMetallicVariant(Material baseMaterial, Color metalColor, float metallic = 0.8f, float smoothness = 0.5f)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)baseMaterial == (Object)null)
		{
			Logger.Error("CreateMetallicVariant called with null baseMaterial");
			return null;
		}
		try
		{
			Material val = new Material(baseMaterial)
			{
				name = ((Object)baseMaterial).name + "_metallic"
			};
			RemoveAllTextures(val);
			SetColor(val, "_BaseColor", metalColor);
			SetColor(val, "_Color", metalColor);
			SetFloat(val, "_Metallic", Mathf.Clamp01(metallic));
			SetFloat(val, "_Smoothness", Mathf.Clamp01(smoothness));
			SetFloat(val, "_Glossiness", Mathf.Clamp01(smoothness));
			return val;
		}
		catch (Exception ex)
		{
			Logger.Error("Error creating metallic variant: " + ex.Message);
			return null;
		}
	}

	public static void RemoveAllTextures(Material material)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		if ((Object)(object)material == (Object)null)
		{
			return;
		}
		try
		{
			Shader shader = material.shader;
			int propertyCount = shader.GetPropertyCount();
			for (int i = 0; i < propertyCount; i++)
			{
				if ((int)shader.GetPropertyType(i) == 4)
				{
					string propertyName = shader.GetPropertyName(i);
					material.SetTexture(propertyName, (Texture)null);
				}
			}
			material.mainTexture = null;
		}
		catch (Exception ex)
		{
			Logger.Warning("Error removing textures: " + ex.Message);
		}
	}

	public static bool SetColor(Material material, string propertyName, Color color)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)material == (Object)null || string.IsNullOrEmpty(propertyName))
		{
			return false;
		}
		try
		{
			if (material.HasProperty(propertyName))
			{
				material.SetColor(propertyName, color);
				return true;
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Error setting color property '" + propertyName + "': " + ex.Message);
		}
		return false;
	}

	public static bool SetFloat(Material material, string propertyName, float value)
	{
		if ((Object)(object)material == (Object)null || string.IsNullOrEmpty(propertyName))
		{
			return false;
		}
		try
		{
			if (material.HasProperty(propertyName))
			{
				material.SetFloat(propertyName, value);
				return true;
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Error setting float property '" + propertyName + "': " + ex.Message);
		}
		return false;
	}

	public static bool SetTexture(Material material, string propertyName, Texture texture)
	{
		if ((Object)(object)material == (Object)null || string.IsNullOrEmpty(propertyName))
		{
			return false;
		}
		try
		{
			if (material.HasProperty(propertyName))
			{
				material.SetTexture(propertyName, texture);
				return true;
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Error setting texture property '" + propertyName + "': " + ex.Message);
		}
		return false;
	}

	public static void ConfigureMaterial(Material material, Action<Material> configurator)
	{
		if ((Object)(object)material == (Object)null || configurator == null)
		{
			return;
		}
		try
		{
			configurator(material);
		}
		catch (Exception ex)
		{
			Logger.Error("Error configuring material: " + ex.Message);
		}
	}

	private static void ProcessRenderer(Renderer renderer, Func<Material, bool> predicate, Action<Material> materialModifier)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		Material[] materials = renderer.materials;
		bool flag = false;
		for (int i = 0; i < materials.Length; i++)
		{
			Material val = materials[i];
			if (!((Object)(object)val == (Object)null) && predicate(val))
			{
				Material val2 = new Material(val)
				{
					name = ((Object)val).name + "_modified"
				};
				materialModifier(val2);
				materials[i] = val2;
				flag = true;
			}
		}
		if (flag)
		{
			renderer.materials = materials;
		}
	}
}
