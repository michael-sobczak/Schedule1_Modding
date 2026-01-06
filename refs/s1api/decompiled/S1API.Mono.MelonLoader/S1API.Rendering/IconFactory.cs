using System;
using System.Collections;
using System.Collections.Generic;
using MelonLoader;
using S1API.Entities;
using S1API.Internal.Utils;
using S1API.Logging;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace S1API.Rendering;

public static class IconFactory
{
	private class SkinnedMeshRendererState
	{
		public SkinnedMeshRenderer SkinnedRenderer { get; set; }

		public MeshFilter? MeshFilter { get; set; }

		public MeshRenderer? MeshRenderer { get; set; }

		public Mesh? BakedMesh { get; set; }

		public SkinnedMeshRendererState(SkinnedMeshRenderer skinnedRenderer)
		{
			SkinnedRenderer = skinnedRenderer;
		}
	}

	private class AccessoryIconRequest
	{
		public string AccessoryPath { get; set; }

		public Color AccessoryColor { get; set; }

		public int IconSize { get; set; }

		public Action<Texture2D> Callback { get; set; }
	}

	private static readonly Log Logger = new Log("IconFactory");

	private static readonly object _accessoryIconQueueLock = new object();

	private static readonly Queue<AccessoryIconRequest> _accessoryIconQueue = new Queue<AccessoryIconRequest>();

	private static bool _isProcessingAccessoryIcons = false;

	internal static IconGenerator S1IconGenerator => Singleton<IconGenerator>.Instance;

	internal static MugshotGenerator S1MugshotGenerator => Singleton<MugshotGenerator>.Instance;

	public static Texture2D? GenerateIcon(Transform model, int size = 512, bool bakeSkinnedMeshes = true)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)S1IconGenerator == (Object)null)
		{
			Logger.Error("IconGenerator not found in scene. Cannot generate icon.");
			return null;
		}
		if ((Object)(object)model == (Object)null)
		{
			Logger.Error("Model transform is null when generating icon.");
			return null;
		}
		try
		{
			Transform parent = model.parent;
			Vector3 localPosition = model.localPosition;
			Quaternion localRotation = model.localRotation;
			Vector3 localScale = model.localScale;
			bool activeSelf = ((Component)model).gameObject.activeSelf;
			model.SetParent(S1IconGenerator.ItemContainer, false);
			model.localPosition = Vector3.zero;
			model.localRotation = Quaternion.identity;
			model.localScale = Vector3.one;
			((Component)model).gameObject.SetActive(true);
			int num = LayerMask.NameToLayer("IconGeneration");
			if (num != -1)
			{
				LayerUtility.SetLayerRecursively(((Component)S1IconGenerator.ItemContainer).gameObject, num);
			}
			Logger.Msg($"Icon generation for '{((Object)model).name}': world pos={model.position}, layer={((Component)model).gameObject.layer} ({LayerMask.LayerToName(((Component)model).gameObject.layer)}), container pos={S1IconGenerator.ItemContainer.position}");
			List<SkinnedMeshRendererState> list = null;
			if (bakeSkinnedMeshes)
			{
				list = BakeSkinnedMeshRenderers(((Component)model).gameObject);
				Logger.Msg($"Baked {list.Count} SkinnedMeshRenderer(s)");
			}
			CenterModelInContainer(model, S1IconGenerator.ItemContainer);
			int iconSize = S1IconGenerator.IconSize;
			bool modifyLighting = S1IconGenerator.ModifyLighting;
			S1IconGenerator.IconSize = size;
			S1IconGenerator.ModifyLighting = true;
			Texture2D texture = S1IconGenerator.GetTexture(model);
			Logger.Msg("Generated texture: " + (((Object)(object)texture != (Object)null) ? $"{((Texture)texture).width}x{((Texture)texture).height}" : "null"));
			S1IconGenerator.IconSize = iconSize;
			S1IconGenerator.ModifyLighting = modifyLighting;
			if (list != null)
			{
				RestoreSkinnedMeshRenderers(list);
			}
			model.SetParent(parent, false);
			model.localPosition = localPosition;
			model.localRotation = localRotation;
			model.localScale = localScale;
			((Component)model).gameObject.SetActive(activeSelf);
			return texture;
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to generate icon for " + ((Object)model).name + ": " + ex.Message);
			return null;
		}
	}

	public static Texture2D? GeneratePackagingIcon(string packagingID, string productID)
	{
		if ((Object)(object)S1IconGenerator == (Object)null)
		{
			Logger.Error("IconGenerator not found in scene. Cannot generate icon.");
			return null;
		}
		try
		{
			return S1IconGenerator.GeneratePackagingIcon(packagingID, productID);
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to generate packaging icon for P:" + packagingID + " Prod:" + productID + ": " + ex.Message);
			return null;
		}
	}

	public static Sprite? GenerateIconSprite(Transform model, int size = 512, bool bakeSkinnedMeshes = true)
	{
		return ImageUtils.TextureToSprite(GenerateIcon(model, size, bakeSkinnedMeshes));
	}

	public static Sprite? GeneratePackagingIconSprite(string packagingID, string productID)
	{
		return ImageUtils.TextureToSprite(GeneratePackagingIcon(packagingID, productID));
	}

	public static void GenerateAccessoryIcon(string accessoryPath, Action<Texture2D> callback, Color? accessoryColor = null, int size = 512)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(accessoryPath))
		{
			Logger.Error("Accessory path is null or empty when generating accessory icon.");
			callback?.Invoke(null);
			return;
		}
		if (callback == null)
		{
			Logger.Error("Callback is null when generating accessory icon.");
			return;
		}
		AccessoryIconRequest item = new AccessoryIconRequest
		{
			AccessoryPath = accessoryPath,
			AccessoryColor = (Color)(((_003F?)accessoryColor) ?? Color.white),
			IconSize = size,
			Callback = callback
		};
		lock (_accessoryIconQueueLock)
		{
			_accessoryIconQueue.Enqueue(item);
			if (!_isProcessingAccessoryIcons)
			{
				_isProcessingAccessoryIcons = true;
				MelonCoroutines.Start(ProcessAccessoryIconQueue());
			}
		}
	}

	public static void GenerateAccessoryIconSprite(string accessoryPath, Action<Sprite> callback, Color? accessoryColor = null, int size = 512)
	{
		GenerateAccessoryIcon(accessoryPath, delegate(Texture2D texture)
		{
			callback?.Invoke(ImageUtils.TextureToSprite(texture));
		}, accessoryColor, size);
	}

	private static List<SkinnedMeshRendererState> BakeSkinnedMeshRenderers(GameObject gameObject)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		List<SkinnedMeshRendererState> list = new List<SkinnedMeshRendererState>();
		SkinnedMeshRenderer[] componentsInChildren = gameObject.GetComponentsInChildren<SkinnedMeshRenderer>();
		SkinnedMeshRenderer[] array = componentsInChildren;
		foreach (SkinnedMeshRenderer val in array)
		{
			SkinnedMeshRendererState skinnedMeshRendererState = new SkinnedMeshRendererState(val);
			skinnedMeshRendererState.BakedMesh = new Mesh();
			val.BakeMesh(skinnedMeshRendererState.BakedMesh);
			skinnedMeshRendererState.MeshFilter = ((Component)val).gameObject.AddComponent<MeshFilter>();
			skinnedMeshRendererState.MeshRenderer = ((Component)val).gameObject.AddComponent<MeshRenderer>();
			skinnedMeshRendererState.MeshFilter.sharedMesh = skinnedMeshRendererState.BakedMesh;
			((Renderer)skinnedMeshRendererState.MeshRenderer).sharedMaterials = ((Renderer)val).sharedMaterials;
			((Renderer)val).enabled = false;
			list.Add(skinnedMeshRendererState);
		}
		return list;
	}

	private static void RestoreSkinnedMeshRenderers(List<SkinnedMeshRendererState> states)
	{
		foreach (SkinnedMeshRendererState state in states)
		{
			if ((Object)(object)state.SkinnedRenderer != (Object)null)
			{
				((Renderer)state.SkinnedRenderer).enabled = true;
			}
			if ((Object)(object)state.MeshRenderer != (Object)null)
			{
				Object.Destroy((Object)(object)state.MeshRenderer);
			}
			if ((Object)(object)state.MeshFilter != (Object)null)
			{
				Object.Destroy((Object)(object)state.MeshFilter);
			}
			if ((Object)(object)state.BakedMesh != (Object)null)
			{
				Object.Destroy((Object)(object)state.BakedMesh);
			}
		}
	}

	private static void CenterModelInContainer(Transform model, Transform container)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		Renderer[] componentsInChildren = ((Component)model).GetComponentsInChildren<Renderer>();
		if (componentsInChildren.Length == 0)
		{
			return;
		}
		Bounds bounds = default(Bounds);
		((Bounds)(ref bounds))._002Ector(model.position, Vector3.zero);
		bool flag = false;
		Renderer[] array = componentsInChildren;
		foreach (Renderer val in array)
		{
			if (val.enabled)
			{
				if (!flag)
				{
					bounds = val.bounds;
					flag = true;
				}
				else
				{
					((Bounds)(ref bounds)).Encapsulate(val.bounds);
				}
			}
		}
		if (flag)
		{
			Vector3 val2 = container.position - ((Bounds)(ref bounds)).center;
			model.position += val2;
			Logger.Msg($"Recentered model '{((Object)model).name}'. Old Bounds Center: {((Bounds)(ref bounds)).center}, New Center: {container.position}, Offset: {val2}");
		}
		else
		{
			Logger.Warning("Could not calculate bounds for " + ((Object)model).name + " (no enabled renderers?). Icon might be empty.");
		}
	}

	private static IEnumerator ProcessAccessoryIconQueue()
	{
		while (true)
		{
			AccessoryIconRequest next = null;
			lock (_accessoryIconQueueLock)
			{
				if (_accessoryIconQueue.Count <= 0)
				{
					_isProcessingAccessoryIcons = false;
					break;
				}
				next = _accessoryIconQueue.Dequeue();
			}
			if (next == null)
			{
				yield return null;
				continue;
			}
			MugshotGenerator generator = S1MugshotGenerator;
			Avatar mugshotRig = (((Object)(object)generator != (Object)null) ? generator.MugshotRig : null);
			IconGenerator iconGenerator = (((Object)(object)generator != (Object)null) ? generator.Generator : null);
			if ((Object)(object)mugshotRig == (Object)null)
			{
				Logger.Error("MugshotGenerator or MugshotRig not found. Cannot generate accessory icon.");
				next.Callback?.Invoke(null);
				yield return null;
				continue;
			}
			Transform mugshotParent = ((Component)mugshotRig).transform.parent;
			if ((Object)(object)mugshotParent != (Object)null)
			{
				((Component)mugshotParent).gameObject.SetActive(true);
			}
			((Component)mugshotRig).gameObject.SetActive(true);
			AvatarSettings mugshotSettings = CreateMinimalAvatarSettings(next.AccessoryPath, next.AccessoryColor);
			mugshotSettings.Height = 1f;
			mugshotRig.LoadAvatarSettings(mugshotSettings);
			SetLayerRecursively(((Component)mugshotRig).gameObject, LayerMask.NameToLayer("IconGeneration"));
			SkinnedMeshRenderer[] skinnedMeshRenderers = ((Component)mugshotRig).GetComponentsInChildren<SkinnedMeshRenderer>();
			SkinnedMeshRenderer[] array = skinnedMeshRenderers;
			foreach (SkinnedMeshRenderer smr in array)
			{
				smr.updateWhenOffscreen = true;
			}
			int originalSize = (((Object)(object)iconGenerator != (Object)null) ? iconGenerator.IconSize : 512);
			if ((Object)(object)iconGenerator != (Object)null)
			{
				iconGenerator.IconSize = next.IconSize;
			}
			yield return (object)new WaitForEndOfFrame();
			bool completed = false;
			Texture2D capturedTexture = null;
			mugshotRig.GetMugshot((Action<Texture2D>)delegate(Texture2D generatedMugshot)
			{
				try
				{
					if ((Object)(object)generatedMugshot != (Object)null)
					{
						generatedMugshot.Apply();
						capturedTexture = generatedMugshot;
						Logger.Msg($"Generated accessory icon for '{next.AccessoryPath}': {((Texture)generatedMugshot).width}x{((Texture)generatedMugshot).height}");
					}
					else
					{
						Logger.Error("Failed to generate accessory icon for '" + next.AccessoryPath + "': texture is null");
					}
				}
				catch (Exception ex)
				{
					Logger.Error("Failed to finalize accessory icon: " + ex.Message);
				}
				finally
				{
					completed = true;
				}
			});
			while (!completed)
			{
				yield return null;
			}
			next.Callback?.Invoke(capturedTexture);
			if ((Object)(object)iconGenerator != (Object)null)
			{
				iconGenerator.IconSize = originalSize;
			}
			if ((Object)(object)generator != (Object)null && (Object)(object)generator.DefaultSettings != (Object)null)
			{
				mugshotRig.LoadAvatarSettings(generator.DefaultSettings);
			}
			((Component)mugshotRig).gameObject.SetActive(false);
			yield return (object)new WaitForSeconds(0.05f);
		}
	}

	private static AvatarSettings CreateMinimalAvatarSettings(string accessoryPath, Color accessoryColor)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		Player local = Player.Local;
		AvatarSettings val2;
		if (local != null && local.CurrentAvatarSettings != null)
		{
			object currentAvatarSettings = local.CurrentAvatarSettings;
			BasicAvatarSettings val = (BasicAvatarSettings)((currentAvatarSettings is BasicAvatarSettings) ? currentAvatarSettings : null);
			if ((Object)(object)val != (Object)null)
			{
				val2 = val.GetAvatarSettings();
				Logger.Msg("Using local player's avatar settings for accessory icon");
			}
			else
			{
				val2 = CreateFallbackAvatarSettings();
			}
		}
		else
		{
			val2 = CreateFallbackAvatarSettings();
		}
		val2.AccessorySettings.Add(new AccessorySetting
		{
			path = accessoryPath,
			color = accessoryColor
		});
		return val2;
	}

	private static AvatarSettings CreateFallbackAvatarSettings()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		Logger.Msg("Local player not available, using fallback avatar settings for accessory icon");
		AvatarSettings val = ScriptableObject.CreateInstance<AvatarSettings>();
		val.SkinColor = Color32.op_Implicit(new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue));
		val.Height = 1f;
		val.Gender = 0.5f;
		val.Weight = 0.5f;
		val.EyeBallTint = Color.white;
		val.PupilDilation = 1f;
		val.HairPath = string.Empty;
		val.HairColor = Color.black;
		val.LeftEyeRestingState = new EyeLidConfiguration
		{
			topLidOpen = 0.5f,
			bottomLidOpen = 0.5f
		};
		val.RightEyeRestingState = new EyeLidConfiguration
		{
			topLidOpen = 0.5f,
			bottomLidOpen = 0.5f
		};
		val.LeftEyeLidColor = Color32.op_Implicit(new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue));
		val.RightEyeLidColor = Color32.op_Implicit(new Color32((byte)150, (byte)120, (byte)95, byte.MaxValue));
		val.EyebrowScale = 1f;
		val.EyebrowThickness = 1f;
		val.EyebrowRestingHeight = 0f;
		val.EyebrowRestingAngle = 0f;
		val.FaceLayerSettings.Add(new LayerSetting
		{
			layerPath = "Avatar/Layers/Face/Face_Neutral",
			layerTint = Color.white
		});
		val.FaceLayerSettings.Add(new LayerSetting
		{
			layerPath = "Avatar/Layers/Face/EyeShadow",
			layerTint = new Color(0f, 0f, 0f, 0.7f)
		});
		val.BodyLayerSettings.Add(new LayerSetting
		{
			layerPath = "Avatar/Layers/Top/T-Shirt",
			layerTint = Color.white
		});
		return val;
	}

	private static void SetLayerRecursively(GameObject obj, int layer)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if ((Object)(object)obj == (Object)null)
		{
			return;
		}
		obj.layer = layer;
		foreach (Transform item in obj.transform)
		{
			Transform val = item;
			SetLayerRecursively(((Component)val).gameObject, layer);
		}
	}
}
