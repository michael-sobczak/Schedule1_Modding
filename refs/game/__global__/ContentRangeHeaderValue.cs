public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 17722
{
	// Fields
	private string unit; // 0x10
	[CompilerGenerated]
	private Nullable<long> <From>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<long> <Length>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<long> <To>k__BackingField; // 0x38

	// Properties
	public Nullable<long> From { get; set; }
	public Nullable<long> Length { get; set; }
	public Nullable<long> To { get; set; }
	public string Unit { get; }

	// Methods

	// RVA: 0x2181F20 Offset: 0x2180920 VA: 0x182181F20
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public Nullable<long> get_From() { }

	[CompilerGenerated]
	// RVA: 0x691670 Offset: 0x690070 VA: 0x180691670
	private void set_From(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Nullable<long> get_Length() { }

	[CompilerGenerated]
	// RVA: 0x4F58C0 Offset: 0x4F42C0 VA: 0x1804F58C0
	private void set_Length(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x4F9F20 Offset: 0x4F8920 VA: 0x1804F9F20
	public Nullable<long> get_To() { }

	[CompilerGenerated]
	// RVA: 0x1440050 Offset: 0x143EA50 VA: 0x181440050
	private void set_To(Nullable<long> value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Unit() { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2181530 Offset: 0x217FF30 VA: 0x182181530 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2181650 Offset: 0x2180050 VA: 0x182181650 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21819B0 Offset: 0x21803B0 VA: 0x1821819B0
	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) { }

	// RVA: 0x2181760 Offset: 0x2180160 VA: 0x182181760 Slot: 3
	public override string ToString() { }
}
