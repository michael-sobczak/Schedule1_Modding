internal class PropagationPaths // TypeDefIndex: 6646
{
	// Fields
	private static readonly ObjectPool<PropagationPaths> s_Pool; // 0x0
	public readonly List<VisualElement> trickleDownPath; // 0x10
	public readonly List<VisualElement> targetElements; // 0x18
	public readonly List<VisualElement> bubbleUpPath; // 0x20
	private const int k_DefaultPropagationDepth = 16;
	private const int k_DefaultTargetCount = 4;

	// Methods

	// RVA: 0x2EB4670 Offset: 0x2EB3070 VA: 0x182EB4670
	public void .ctor() { }

	// RVA: 0x2EB4260 Offset: 0x2EB2C60 VA: 0x182EB4260
	public static PropagationPaths Build(VisualElement elem, EventBase evt) { }

	// RVA: 0x2EB4450 Offset: 0x2EB2E50 VA: 0x182EB4450
	public void Release() { }

	// RVA: 0x2EB4560 Offset: 0x2EB2F60 VA: 0x182EB4560
	private static void .cctor() { }
}
