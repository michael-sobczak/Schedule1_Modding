public struct CreationContext : IEquatable<CreationContext> // TypeDefIndex: 7013
{
	// Fields
	public static readonly CreationContext Default; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <target>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualTreeAsset <visualTreeAsset>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Dictionary<string, VisualElement> <slotInsertionPoints>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private List<TemplateAsset.AttributeOverride> <attributeOverrides>k__BackingField; // 0x18

	// Properties
	public VisualElement target { get; set; }
	public VisualTreeAsset visualTreeAsset { get; set; }
	public Dictionary<string, VisualElement> slotInsertionPoints { get; set; }
	internal List<TemplateAsset.AttributeOverride> attributeOverrides { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public VisualElement get_target() { }

	[CompilerGenerated]
	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	private void set_target(VisualElement value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public VisualTreeAsset get_visualTreeAsset() { }

	[CompilerGenerated]
	// RVA: 0xCC9B80 Offset: 0xCC8580 VA: 0x180CC9B80
	private void set_visualTreeAsset(VisualTreeAsset value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Dictionary<string, VisualElement> get_slotInsertionPoints() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_slotInsertionPoints(Dictionary<string, VisualElement> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal List<TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_attributeOverrides(List<TemplateAsset.AttributeOverride> value) { }

	// RVA: 0x2DDD6E0 Offset: 0x2DDC0E0 VA: 0x182DDD6E0
	internal void .ctor(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x2DDD630 Offset: 0x2DDC030 VA: 0x182DDD630
	internal void .ctor(Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x2DDD410 Offset: 0x2DDBE10 VA: 0x182DDD410 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2DDD2B0 Offset: 0x2DDBCB0 VA: 0x182DDD2B0 Slot: 4
	public bool Equals(CreationContext other) { }

	// RVA: 0x2DDD4D0 Offset: 0x2DDBED0 VA: 0x182DDD4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2DDD5F0 Offset: 0x2DDBFF0 VA: 0x182DDD5F0
	private static void .cctor() { }
}
