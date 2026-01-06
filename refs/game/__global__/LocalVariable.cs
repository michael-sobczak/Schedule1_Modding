internal sealed class LocalVariable // TypeDefIndex: 15451
{
	// Fields
	public readonly int Index; // 0x10
	private int _flags; // 0x14

	// Properties
	public bool IsBoxed { get; set; }
	public bool InClosure { get; }

	// Methods

	// RVA: 0xB175F0 Offset: 0xB15FF0 VA: 0x180B175F0
	public bool get_IsBoxed() { }

	// RVA: 0x1FF0A80 Offset: 0x1FEF480 VA: 0x181FF0A80
	public void set_IsBoxed(bool value) { }

	// RVA: 0x1FF0A70 Offset: 0x1FEF470 VA: 0x181FF0A70
	public bool get_InClosure() { }

	// RVA: 0x1FF0A30 Offset: 0x1FEF430 VA: 0x181FF0A30
	internal void .ctor(int index, bool closure) { }

	// RVA: 0x1FF0950 Offset: 0x1FEF350 VA: 0x181FF0950 Slot: 3
	public override string ToString() { }
}
