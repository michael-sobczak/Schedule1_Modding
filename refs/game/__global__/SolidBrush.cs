public sealed class SolidBrush : Brush // TypeDefIndex: 17101
{
	// Fields
	private Color _color; // 0x20
	private bool _immutable; // 0x38

	// Methods

	// RVA: 0x214DD60 Offset: 0x214C760 VA: 0x18214DD60
	public void .ctor(Color color) { }

	// RVA: 0x214DD20 Offset: 0x214C720 VA: 0x18214DD20
	internal void .ctor(Color color, bool immutable) { }

	// RVA: 0x214DEA0 Offset: 0x214C8A0 VA: 0x18214DEA0
	internal void .ctor(IntPtr nativeBrush) { }

	// RVA: 0x214DAC0 Offset: 0x214C4C0 VA: 0x18214DAC0 Slot: 8
	public override object Clone() { }

	// RVA: 0x214DC30 Offset: 0x214C630 VA: 0x18214DC30 Slot: 9
	protected override void Dispose(bool disposing) { }
}
