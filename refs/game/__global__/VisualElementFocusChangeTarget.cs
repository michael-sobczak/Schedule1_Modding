internal class VisualElementFocusChangeTarget : FocusChangeDirection // TypeDefIndex: 7038
{
	// Fields
	private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Focusable <target>k__BackingField; // 0x18

	// Properties
	public Focusable target { get; set; }

	// Methods

	// RVA: 0x2DF2DE0 Offset: 0x2DF17E0 VA: 0x182DF2DE0
	public static VisualElementFocusChangeTarget GetPooled(Focusable target) { }

	// RVA: 0x2DF2D50 Offset: 0x2DF1750 VA: 0x182DF2D50 Slot: 5
	protected override void Dispose() { }

	// RVA: 0x2DF2D00 Offset: 0x2DF1700 VA: 0x182DF2D00 Slot: 6
	internal override void ApplyTo(FocusController focusController, Focusable f) { }

	// RVA: 0x2DF2F90 Offset: 0x2DF1990 VA: 0x182DF2F90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Focusable get_target() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_target(Focusable value) { }

	// RVA: 0x2DF2E80 Offset: 0x2DF1880 VA: 0x182DF2E80
	private static void .cctor() { }
}
