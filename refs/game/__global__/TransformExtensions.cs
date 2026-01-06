public static class TransformExtensions // TypeDefIndex: 596
{
	// Methods

	[Extension]
	// RVA: 0xAAE2C0 Offset: 0xAACCC0 VA: 0x180AAE2C0
	public static TransformData GetWorldTransformData(Transform transform) { }

	[Extension]
	// RVA: 0xAAE220 Offset: 0xAACC20 VA: 0x180AAE220
	public static TransformData GetLocalTransformData(Transform transform) { }

	[Extension]
	// RVA: 0xAAE360 Offset: 0xAACD60 VA: 0x180AAE360
	public static void SetLocalTransformData(Transform transform, TransformData data, bool setScale = True) { }

	[Extension]
	// RVA: 0xAAE400 Offset: 0xAACE00 VA: 0x180AAE400
	public static void SetWorldTransformData(Transform transform, TransformData data) { }
}
