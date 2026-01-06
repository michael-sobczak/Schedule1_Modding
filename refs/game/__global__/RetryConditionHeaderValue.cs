public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 17764
{
	// Fields
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<TimeSpan> <Delta>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public Nullable<TimeSpan> Delta { get; set; }

	// Methods

	// RVA: 0x21937A0 Offset: 0x21921A0 VA: 0x1821937A0
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x21936C0 Offset: 0x21920C0 VA: 0x1821936C0
	public void .ctor(TimeSpan delta) { }

	[CompilerGenerated]
	// RVA: 0xBBD020 Offset: 0xBBBA20 VA: 0x180BBD020
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	// RVA: 0xCCDAF0 Offset: 0xCCC4F0 VA: 0x180CCDAF0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Nullable<TimeSpan> get_Delta() { }

	[CompilerGenerated]
	// RVA: 0x4F58C0 Offset: 0x4F42C0 VA: 0x1804F58C0
	private void set_Delta(Nullable<TimeSpan> value) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2192FB0 Offset: 0x21919B0 VA: 0x182192FB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2193160 Offset: 0x2191B60 VA: 0x182193160 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2193390 Offset: 0x2191D90 VA: 0x182193390
	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

	// RVA: 0x21931F0 Offset: 0x2191BF0 VA: 0x1821931F0 Slot: 3
	public override string ToString() { }
}
