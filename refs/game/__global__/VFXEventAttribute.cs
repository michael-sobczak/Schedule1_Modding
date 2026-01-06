public sealed class VFXEventAttribute : IDisposable // TypeDefIndex: 19112
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private bool m_Owner; // 0x18
	private VisualEffectAsset m_VfxAsset; // 0x20

	// Methods

	// RVA: 0x2F5E3E0 Offset: 0x2F5CDE0 VA: 0x182F5E3E0
	private void .ctor(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) { }

	// RVA: 0x2F5DFB0 Offset: 0x2F5C9B0 VA: 0x182F5DFB0
	internal static VFXEventAttribute CreateEventAttributeWrapper() { }

	// RVA: 0x2F5E370 Offset: 0x2F5CD70 VA: 0x182F5E370
	internal void SetWrapValue(IntPtr ptrToEventAttribute) { }

	// RVA: 0x2F5E180 Offset: 0x2F5CB80 VA: 0x182F5E180
	internal static IntPtr Internal_Create() { }

	// RVA: 0x2F5E240 Offset: 0x2F5CC40 VA: 0x182F5E240
	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) { }

	// RVA: 0x2F5E1F0 Offset: 0x2F5CBF0 VA: 0x182F5E1F0
	internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) { }

	// RVA: 0x2F5E300 Offset: 0x2F5CD00 VA: 0x182F5E300
	private void Release() { }

	// RVA: 0x2F5E0C0 Offset: 0x2F5CAC0 VA: 0x182F5E0C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F5E010 Offset: 0x2F5CA10 VA: 0x182F5E010 Slot: 4
	public void Dispose() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2F5E1B0 Offset: 0x2F5CBB0 VA: 0x182F5E1B0
	internal static void Internal_Destroy(IntPtr ptr) { }
}
