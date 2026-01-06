internal static class BigIntegerCalculator // TypeDefIndex: 18598
{
	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x219A6F0 Offset: 0x21990F0 VA: 0x18219A6F0
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x219A7C0 Offset: 0x21991C0 VA: 0x18219A7C0
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x219A640 Offset: 0x2199040 VA: 0x18219A640
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x219A5D0 Offset: 0x2198FD0 VA: 0x18219A5D0
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x219C1B0 Offset: 0x219ABB0 VA: 0x18219C1B0
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x219BF70 Offset: 0x219A970 VA: 0x18219BF70
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x219C100 Offset: 0x219AB00 VA: 0x18219C100
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x219A8D0 Offset: 0x21992D0 VA: 0x18219A8D0
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x219ADE0 Offset: 0x21997E0 VA: 0x18219ADE0
	public static uint[] Divide(uint[] left, uint right) { }

	// RVA: 0x219B8A0 Offset: 0x219A2A0 VA: 0x18219B8A0
	public static uint Remainder(uint[] left, uint right) { }

	// RVA: 0x219AEC0 Offset: 0x21998C0 VA: 0x18219AEC0
	public static uint[] Divide(uint[] left, uint[] right) { }

	// RVA: 0x219B7A0 Offset: 0x219A1A0 VA: 0x18219B7A0
	public static uint[] Remainder(uint[] left, uint[] right) { }

	// RVA: 0x219AA10 Offset: 0x2199410 VA: 0x18219AA10
	private static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x219A5A0 Offset: 0x2198FA0 VA: 0x18219A5A0
	private static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x219BF20 Offset: 0x219A920 VA: 0x18219BF20
	private static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q) { }

	// RVA: 0x219A9D0 Offset: 0x21993D0 VA: 0x18219A9D0
	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	// RVA: 0x219A950 Offset: 0x2199350 VA: 0x18219A950
	private static uint[] CreateCopy(uint[] value) { }

	// RVA: 0x219B000 Offset: 0x2199A00 VA: 0x18219B000
	private static int LeadingZeros(uint value) { }

	// RVA: 0x219BD30 Offset: 0x219A730 VA: 0x18219BD30
	public static uint[] Square(uint[] value) { }

	// RVA: 0x219B910 Offset: 0x219A310 VA: 0x18219B910
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x219B6D0 Offset: 0x219A0D0 VA: 0x18219B6D0
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x219B070 Offset: 0x2199A70 VA: 0x18219B070
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x219B190 Offset: 0x2199B90 VA: 0x18219B190
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x219BE10 Offset: 0x219A810 VA: 0x18219BE10
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x219C270 Offset: 0x219AC70 VA: 0x18219C270
	private static void .cctor() { }
}
