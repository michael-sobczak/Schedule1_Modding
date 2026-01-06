public static class CameraExtensions // TypeDefIndex: 9041
{
	// Methods

	[Extension]
	// RVA: 0x2B2EA10 Offset: 0x2B2D410 VA: 0x182B2EA10
	public static UniversalAdditionalCameraData GetUniversalAdditionalCameraData(Camera camera) { }

	[Extension]
	// RVA: 0x2B2EAA0 Offset: 0x2B2D4A0 VA: 0x182B2EAA0
	public static VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(Camera camera) { }

	[Extension]
	// RVA: 0x2B2ED40 Offset: 0x2B2D740 VA: 0x182B2ED40
	public static void SetVolumeFrameworkUpdateMode(Camera camera, VolumeFrameworkUpdateMode mode) { }

	[Extension]
	// RVA: 0x2B2EE30 Offset: 0x2B2D830 VA: 0x182B2EE30
	public static void UpdateVolumeStack(Camera camera) { }

	[Extension]
	// RVA: 0x2B2EEE0 Offset: 0x2B2D8E0 VA: 0x182B2EEE0
	public static void UpdateVolumeStack(Camera camera, UniversalAdditionalCameraData cameraData) { }

	[Extension]
	// RVA: 0x2B2E910 Offset: 0x2B2D310 VA: 0x182B2E910
	public static void DestroyVolumeStack(Camera camera) { }

	[Extension]
	// RVA: 0x2B2E890 Offset: 0x2B2D290 VA: 0x182B2E890
	public static void DestroyVolumeStack(Camera camera, UniversalAdditionalCameraData cameraData) { }

	[Extension]
	// RVA: 0x2B2EB40 Offset: 0x2B2D540 VA: 0x182B2EB40
	internal static void GetVolumeLayerMaskAndTrigger(Camera camera, UniversalAdditionalCameraData cameraData, out LayerMask layerMask, out Transform trigger) { }
}
