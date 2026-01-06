public class GeometryChangedEvent : EventBase<GeometryChangedEvent> // TypeDefIndex: 6565
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Rect <oldRect>k__BackingField; // 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Rect <newRect>k__BackingField; // 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <layoutPass>k__BackingField; // 0xA8

	// Properties
	public Rect oldRect { get; set; }
	public Rect newRect { get; set; }
	internal int layoutPass { get; set; }

	// Methods

	// RVA: 0x2E91EA0 Offset: 0x2E908A0 VA: 0x182E91EA0
	private static void .cctor() { }

	// RVA: 0x2E91D50 Offset: 0x2E90750 VA: 0x182E91D50
	public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect) { }

	// RVA: 0x2E91DE0 Offset: 0x2E907E0 VA: 0x182E91DE0 Slot: 12
	protected override void Init() { }

	// RVA: 0x2E91E50 Offset: 0x2E90850 VA: 0x182E91E50
	private void LocalInit() { }

	[CompilerGenerated]
	// RVA: 0x501580 Offset: 0x4FFF80 VA: 0x180501580
	public Rect get_oldRect() { }

	[CompilerGenerated]
	// RVA: 0x143F120 Offset: 0x143DB20 VA: 0x18143F120
	private void set_oldRect(Rect value) { }

	[CompilerGenerated]
	// RVA: 0x4F6260 Offset: 0x4F4C60 VA: 0x1804F6260
	public Rect get_newRect() { }

	[CompilerGenerated]
	// RVA: 0x143F000 Offset: 0x143DA00 VA: 0x18143F000
	private void set_newRect(Rect value) { }

	[CompilerGenerated]
	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	internal int get_layoutPass() { }

	[CompilerGenerated]
	// RVA: 0x587060 Offset: 0x585A60 VA: 0x180587060
	internal void set_layoutPass(int value) { }

	// RVA: 0x2E91F80 Offset: 0x2E90980 VA: 0x182E91F80
	public void .ctor() { }
}
