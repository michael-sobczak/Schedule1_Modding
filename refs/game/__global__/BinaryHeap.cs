public class BinaryHeap // TypeDefIndex: 13164
{
	// Fields
	public int numberOfItems; // 0x10
	public float growthFactor; // 0x14
	private const int D = 4;
	private const bool SortGScores = True;
	public const ushort NotInHeap = 65535;
	private BinaryHeap.Tuple[] heap; // 0x18

	// Properties
	public bool isEmpty { get; }

	// Methods

	// RVA: 0xB0B0A0 Offset: 0xB09AA0 VA: 0x180B0B0A0
	public bool get_isEmpty() { }

	// RVA: 0xB0AC90 Offset: 0xB09690 VA: 0x180B0AC90
	private static int RoundUpToNextMultipleMod1(int v) { }

	// RVA: 0xB0B000 Offset: 0xB09A00 VA: 0x180B0B000
	public void .ctor(int capacity) { }

	// RVA: 0xB0A360 Offset: 0xB08D60 VA: 0x180B0A360
	public void Clear() { }

	// RVA: 0xB0A6C0 Offset: 0xB090C0 VA: 0x180B0A6C0
	internal PathNode GetNode(int i) { }

	// RVA: 0xB0ACC0 Offset: 0xB096C0 VA: 0x180B0ACC0
	internal void SetF(int i, uint f) { }

	// RVA: 0xB0A550 Offset: 0xB08F50 VA: 0x180B0A550
	private void Expand() { }

	// RVA: 0xB0A0D0 Offset: 0xB08AD0 VA: 0x180B0A0D0
	public void Add(PathNode node) { }

	// RVA: 0xB0A3C0 Offset: 0xB08DC0 VA: 0x180B0A3C0
	private void DecreaseKey(BinaryHeap.Tuple node, ushort index) { }

	// RVA: 0xB0A8C0 Offset: 0xB092C0 VA: 0x180B0A8C0
	public PathNode Remove() { }

	// RVA: 0xB0ACF0 Offset: 0xB096F0 VA: 0x180B0ACF0
	private void Validate() { }

	// RVA: 0xB0A700 Offset: 0xB09100 VA: 0x180B0A700
	public void Rebuild() { }
}
