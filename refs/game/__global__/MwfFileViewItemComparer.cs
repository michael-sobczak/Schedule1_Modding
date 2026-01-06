internal class MwfFileViewItemComparer : IComparer // TypeDefIndex: 5339
{
	// Fields
	private int column_index; // 0x10
	private bool asc; // 0x14

	// Properties
	public int ColumnIndex { set; }
	public bool Ascendent { get; set; }

	// Methods

	// RVA: 0x233B9A0 Offset: 0x233A3A0 VA: 0x18233B9A0
	public void .ctor(bool asc) { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_ColumnIndex(int value) { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_Ascendent() { }

	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	public void set_Ascendent(bool value) { }

	// RVA: 0x233B810 Offset: 0x233A210 VA: 0x18233B810 Slot: 4
	public int Compare(object a, object b) { }
}
