public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 17723
{
	// Fields
	private static readonly EntityTagHeaderValue any; // 0x0
	[CompilerGenerated]
	private bool <IsWeak>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Tag>k__BackingField; // 0x18

	// Properties
	public bool IsWeak { get; set; }
	public string Tag { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_IsWeak() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	internal void set_IsWeak(bool value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Tag() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_Tag(string value) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2182120 Offset: 0x2180B20 VA: 0x182182120 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21821C0 Offset: 0x2180BC0 VA: 0x1821821C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21825C0 Offset: 0x2180FC0 VA: 0x1821825C0
	public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) { }

	// RVA: 0x21822A0 Offset: 0x2180CA0 VA: 0x1821822A0
	private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out Token t) { }

	// RVA: 0x21826C0 Offset: 0x21810C0 VA: 0x1821826C0
	internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) { }

	// RVA: 0x2182250 Offset: 0x2180C50 VA: 0x182182250 Slot: 3
	public override string ToString() { }

	// RVA: 0x2182770 Offset: 0x2181170 VA: 0x182182770
	private static void .cctor() { }
}
