public class CGModuleSlot // TypeDefIndex: 10648
{
	// Fields
	[CompilerGenerated]
	private CGModule <Module>k__BackingField; // 0x10
	[CompilerGenerated]
	private SlotInfo <Info>k__BackingField; // 0x18
	[CompilerGenerated]
	private Vector2 <Origin>k__BackingField; // 0x20
	[CompilerGenerated]
	private Rect <DropZone>k__BackingField; // 0x28
	protected List<CGModuleSlot> mLinkedSlots; // 0x38

	// Properties
	public CGModule Module { get; set; }
	public SlotInfo Info { get; set; }
	public Vector2 Origin { get; set; }
	public Rect DropZone { get; set; }
	public bool IsLinked { get; }
	public bool IsLinkedAndConfigured { get; }
	public IOnRequestProcessing OnRequestModule { get; }
	public IPathProvider PathProvider { get; }
	public IExternalInput ExternalInput { get; }
	public List<CGModuleSlot> LinkedSlots { get; }
	public int Count { get; }
	public string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public CGModule get_Module() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_Module(CGModule value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public SlotInfo get_Info() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_Info(SlotInfo value) { }

	[CompilerGenerated]
	// RVA: 0x4F5860 Offset: 0x4F4260 VA: 0x1804F5860
	public Vector2 get_Origin() { }

	[CompilerGenerated]
	// RVA: 0x4F58D0 Offset: 0x4F42D0 VA: 0x1804F58D0
	public void set_Origin(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Rect get_DropZone() { }

	[CompilerGenerated]
	// RVA: 0x4F58C0 Offset: 0x4F42C0 VA: 0x1804F58C0
	public void set_DropZone(Rect value) { }

	// RVA: 0x4F56F0 Offset: 0x4F40F0 VA: 0x1804F56F0
	public bool get_IsLinked() { }

	// RVA: 0x4F55C0 Offset: 0x4F3FC0 VA: 0x1804F55C0
	public bool get_IsLinkedAndConfigured() { }

	// RVA: 0x4F5820 Offset: 0x4F4220 VA: 0x1804F5820
	public IOnRequestProcessing get_OnRequestModule() { }

	// RVA: 0x4F5880 Offset: 0x4F4280 VA: 0x1804F5880
	public IPathProvider get_PathProvider() { }

	// RVA: 0x4F5580 Offset: 0x4F3F80 VA: 0x1804F5580
	public IExternalInput get_ExternalInput() { }

	// RVA: 0x4F5750 Offset: 0x4F4150 VA: 0x1804F5750
	public List<CGModuleSlot> get_LinkedSlots() { }

	// RVA: 0x4F5530 Offset: 0x4F3F30 VA: 0x1804F5530
	public int get_Count() { }

	// RVA: 0x4F57D0 Offset: 0x4F41D0 VA: 0x1804F57D0
	public string get_Name() { }

	// RVA: 0x4F4A70 Offset: 0x4F3470 VA: 0x1804F4A70
	public bool HasLinkTo(CGModuleSlot other) { }

	// RVA: 0x4F4850 Offset: 0x4F3250 VA: 0x1804F4850
	public List<CGModule> GetLinkedModules() { }

	// RVA: 0x4F4E00 Offset: 0x4F3800 VA: 0x1804F4E00 Slot: 4
	public virtual void LinkTo(CGModuleSlot other) { }

	// RVA: 0x4F4B30 Offset: 0x4F3530 VA: 0x1804F4B30
	protected static void LinkInputAndOutput(CGModuleSlot inputSlot, CGModuleSlot outputSlot) { }

	// RVA: 0x4F53F0 Offset: 0x4F3DF0 VA: 0x1804F53F0 Slot: 5
	public virtual void UnlinkFrom(CGModuleSlot other) { }

	// RVA: 0x4F5290 Offset: 0x4F3C90 VA: 0x1804F5290 Slot: 6
	public virtual void UnlinkAll() { }

	// RVA: 0x4F4EF0 Offset: 0x4F38F0 VA: 0x1804F4EF0
	public void ReInitializeLinkedSlots() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	protected virtual void LoadLinkedSlots() { }

	// RVA: 0x4F4F10 Offset: 0x4F3910 VA: 0x1804F4F10
	public void SetInfoFromField(FieldInfo fieldInfo) { }

	// RVA: 0x4D76B0 Offset: 0x4D60B0 VA: 0x1804D76B0
	public static bool op_Implicit(CGModuleSlot a) { }

	// RVA: 0x4F5180 Offset: 0x4F3B80 VA: 0x1804F5180 Slot: 3
	public override string ToString() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
