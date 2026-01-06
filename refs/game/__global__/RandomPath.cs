public class RandomPath : ABPath // TypeDefIndex: 13321
{
	// Fields
	public int searchLength; // 0x138
	public int spread; // 0x13C
	public float aimStrength; // 0x140
	private PathNode chosenNodeR; // 0x148
	private PathNode maxGScoreNodeR; // 0x150
	private int maxGScore; // 0x158
	public Vector3 aim; // 0x15C
	private int nodesEvaluatedRep; // 0x168
	private readonly Random rnd; // 0x170

	// Properties
	public override bool FloodingPath { get; }
	protected override bool hasEndPoint { get; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 17
	public override bool get_FloodingPath() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 28
	protected override bool get_hasEndPoint() { }

	// RVA: 0xB8DB30 Offset: 0xB8C530 VA: 0x180B8DB30 Slot: 20
	protected override void Reset() { }

	// RVA: 0xB7FB80 Offset: 0xB7E580 VA: 0x180B7FB80
	public void .ctor() { }

	// RVA: 0xB8D650 Offset: 0xB8C050 VA: 0x180B8D650
	public static RandomPath Construct(Vector3 start, int length, OnPathDelegate callback) { }

	// RVA: 0xB8DD00 Offset: 0xB8C700 VA: 0x180B8DD00
	protected RandomPath Setup(Vector3 start, int length, OnPathDelegate callback) { }

	// RVA: 0xB8DBE0 Offset: 0xB8C5E0 VA: 0x180B8DBE0 Slot: 23
	protected override void ReturnPath() { }

	// RVA: 0xB8D910 Offset: 0xB8C310 VA: 0x180B8D910 Slot: 24
	protected override void Prepare() { }

	// RVA: 0xB8D710 Offset: 0xB8C110 VA: 0x180B8D710 Slot: 26
	protected override void Initialize() { }

	// RVA: 0xB8D300 Offset: 0xB8BD00 VA: 0x180B8D300 Slot: 27
	protected override void CalculateStep(long targetTick) { }
}
