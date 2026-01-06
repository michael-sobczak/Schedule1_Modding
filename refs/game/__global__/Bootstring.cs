internal class Bootstring // TypeDefIndex: 4856
{
	// Fields
	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C

	// Methods

	// RVA: 0x1BF6180 Offset: 0x1BF4B80 VA: 0x181BF6180
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x1BF5D70 Offset: 0x1BF4770 VA: 0x181BF5D70
	public string Encode(string s, int offset) { }

	// RVA: 0x1BF5D50 Offset: 0x1BF4750 VA: 0x181BF5D50
	private char EncodeDigit(int d) { }

	// RVA: 0x1BF5A70 Offset: 0x1BF4470 VA: 0x181BF5A70
	private int DecodeDigit(char c) { }

	// RVA: 0x1BF59F0 Offset: 0x1BF43F0 VA: 0x181BF59F0
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x1BF5AA0 Offset: 0x1BF44A0 VA: 0x181BF5AA0
	public string Decode(string s, int offset) { }
}
