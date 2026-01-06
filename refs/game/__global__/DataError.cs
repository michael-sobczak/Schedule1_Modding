internal sealed class DataError // TypeDefIndex: 12891
{
	// Fields
	private string _rowError; // 0x10
	private int _count; // 0x18
	private DataError.ColumnError[] _errorList; // 0x20

	// Properties
	internal string Text { get; set; }
	internal bool HasErrors { get; }

	// Methods

	// RVA: 0x206DBE0 Offset: 0x206C5E0 VA: 0x18206DBE0
	internal void .ctor() { }

	// RVA: 0x206DB40 Offset: 0x206C540 VA: 0x18206DB40
	internal void .ctor(string rowError) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal string get_Text() { }

	// RVA: 0x206DC70 Offset: 0x206C670 VA: 0x18206DC70
	internal void set_Text(string value) { }

	// RVA: 0x206DC40 Offset: 0x206C640 VA: 0x18206DC40
	internal bool get_HasErrors() { }

	// RVA: 0x206D820 Offset: 0x206C220 VA: 0x18206D820
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x206D520 Offset: 0x206BF20 VA: 0x18206D520
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x206D3E0 Offset: 0x206BDE0 VA: 0x18206D3E0
	internal void Clear(DataColumn column) { }

	// RVA: 0x206D490 Offset: 0x206BE90 VA: 0x18206D490
	internal void Clear() { }

	// RVA: 0x206D5D0 Offset: 0x206BFD0 VA: 0x18206D5D0
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x206DAE0 Offset: 0x206C4E0 VA: 0x18206DAE0
	private void SetText(string errorText) { }

	// RVA: 0x206D6C0 Offset: 0x206C0C0 VA: 0x18206D6C0
	internal int IndexOf(DataColumn column) { }
}
