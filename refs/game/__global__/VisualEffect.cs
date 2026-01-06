public class VisualEffect : Behaviour // TypeDefIndex: 19123
{
	// Fields
	private VFXEventAttribute m_cachedEventAttribute; // 0x18
	public Action<VFXOutputEventArgs> outputEventReceived; // 0x20

	// Properties
	public VisualEffectAsset visualEffectAsset { get; }

	// Methods

	// RVA: 0x2F5F0E0 Offset: 0x2F5DAE0 VA: 0x182F5F0E0
	public VisualEffectAsset get_visualEffectAsset() { }

	// RVA: 0x2F5ED70 Offset: 0x2F5D770 VA: 0x182F5ED70
	public VFXEventAttribute CreateVFXEventAttribute() { }

	[RequiredByNativeCode]
	// RVA: 0x2F5EED0 Offset: 0x2F5D8D0 VA: 0x182F5EED0
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5F080 Offset: 0x2F5DA80 VA: 0x182F5F080
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) { }
}
