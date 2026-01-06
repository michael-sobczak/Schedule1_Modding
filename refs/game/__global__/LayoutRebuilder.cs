public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 16446
{
	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x2F27D20 Offset: 0x2F26720 VA: 0x182F27D20
	private void Initialize(RectTransform controller) { }

	// RVA: 0x2F27B90 Offset: 0x2F26590 VA: 0x182F27B90
	private void Clear() { }

	// RVA: 0x2F29270 Offset: 0x2F27C70 VA: 0x182F29270
	private static void .cctor() { }

	// RVA: 0x2F28B40 Offset: 0x2F27540 VA: 0x182F28B40
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x2F27D70 Offset: 0x2F26770 VA: 0x182F27D70 Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x2F28EE0 Offset: 0x2F278E0 VA: 0x182F28EE0
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x2F27C20 Offset: 0x2F26620 VA: 0x182F27C20
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x2F28B90 Offset: 0x2F27590 VA: 0x182F28B90 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x2F28780 Offset: 0x2F27180 VA: 0x182F28780
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x2F284F0 Offset: 0x2F26EF0 VA: 0x182F284F0
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x2F27E40 Offset: 0x2F26840 VA: 0x182F27E40
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x2F29060 Offset: 0x2F27A60 VA: 0x182F29060
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x2F28370 Offset: 0x2F26D70 VA: 0x182F28370
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x2F27DC0 Offset: 0x2F267C0 VA: 0x182F27DC0 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F27BC0 Offset: 0x2F265C0 VA: 0x182F27BC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F29000 Offset: 0x2F27A00 VA: 0x182F29000 Slot: 3
	public override string ToString() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
