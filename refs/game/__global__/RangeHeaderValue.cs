public class RangeHeaderValue : ICloneable // TypeDefIndex: 17762
{
	// Fields
	private List<RangeItemHeaderValue> ranges; // 0x10
	private string unit; // 0x18

	// Properties
	public ICollection<RangeItemHeaderValue> Ranges { get; }
	public string Unit { get; }

	// Methods

	// RVA: 0x2192A90 Offset: 0x2191490 VA: 0x182192A90
	public void .ctor() { }

	// RVA: 0x2192820 Offset: 0x2191220 VA: 0x182192820
	private void .ctor(RangeHeaderValue source) { }

	// RVA: 0x2192AE0 Offset: 0x21914E0 VA: 0x182192AE0
	public ICollection<RangeItemHeaderValue> get_Ranges() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Unit() { }

	// RVA: 0x2191CB0 Offset: 0x21906B0 VA: 0x182191CB0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2191B80 Offset: 0x2190580 VA: 0x182191B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2191C30 Offset: 0x2190630 VA: 0x182191C30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2191F20 Offset: 0x2190920 VA: 0x182191F20
	public static bool TryParse(string input, out RangeHeaderValue parsedValue) { }

	// RVA: 0x2191D10 Offset: 0x2190710 VA: 0x182191D10 Slot: 3
	public override string ToString() { }
}
