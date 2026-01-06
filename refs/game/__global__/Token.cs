internal struct Token // TypeDefIndex: 17740
{
	// Fields
	public static readonly Token Empty; // 0x0
	private readonly Token.Type type; // 0x0
	[CompilerGenerated]
	private int <StartPosition>k__BackingField; // 0x4
	[CompilerGenerated]
	private int <EndPosition>k__BackingField; // 0x8

	// Properties
	public int StartPosition { get; set; }
	public int EndPosition { get; set; }
	public Token.Type Kind { get; }

	// Methods

	// RVA: 0x21949A0 Offset: 0x21933A0 VA: 0x1821949A0
	public void .ctor(Token.Type type, int startPosition, int endPosition) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_StartPosition() { }

	[CompilerGenerated]
	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	private void set_StartPosition(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_EndPosition() { }

	[CompilerGenerated]
	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	private void set_EndPosition(int value) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public Token.Type get_Kind() { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public static Token.Type op_Implicit(Token token) { }

	// RVA: 0x2194850 Offset: 0x2193250 VA: 0x182194850 Slot: 3
	public override string ToString() { }

	// RVA: 0x2194910 Offset: 0x2193310 VA: 0x182194910
	private static void .cctor() { }
}
