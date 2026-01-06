public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 12886
{
	// Fields
	private DataColumn _column; // 0x10
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGenerated]
	private object <ProposedValue>k__BackingField; // 0x20

	// Properties
	public object ProposedValue { get; set; }

	// Methods

	// RVA: 0x2069990 Offset: 0x2068390 VA: 0x182069990
	internal void .ctor(DataRow row) { }

	// RVA: 0x2069A00 Offset: 0x2068400 VA: 0x182069A00
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public object get_ProposedValue() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_ProposedValue(object value) { }

	// RVA: 0x2069950 Offset: 0x2068350 VA: 0x182069950
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }
}
