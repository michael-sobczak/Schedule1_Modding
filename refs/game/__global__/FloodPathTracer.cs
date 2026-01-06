public class FloodPathTracer : ABPath // TypeDefIndex: 13318
{
	// Fields
	protected FloodPath flood; // 0x138

	// Properties
	protected override bool hasEndPoint { get; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 28
	protected override bool get_hasEndPoint() { }

	// RVA: 0xB80420 Offset: 0xB7EE20 VA: 0x180B80420
	public void .ctor() { }

	// RVA: 0xB7FDA0 Offset: 0xB7E7A0 VA: 0x180B7FDA0
	public static FloodPathTracer Construct(Vector3 start, FloodPath flood, OnPathDelegate callback) { }

	// RVA: 0xB80090 Offset: 0xB7EA90 VA: 0x180B80090
	protected void Setup(Vector3 start, FloodPath flood, OnPathDelegate callback) { }

	// RVA: 0xB80060 Offset: 0xB7EA60 VA: 0x180B80060 Slot: 20
	protected override void Reset() { }

	// RVA: 0xB7FF70 Offset: 0xB7E970 VA: 0x180B7FF70 Slot: 26
	protected override void Initialize() { }

	// RVA: 0xB7FD30 Offset: 0xB7E730 VA: 0x180B7FD30 Slot: 27
	protected override void CalculateStep(long targetTick) { }

	// RVA: 0xB80200 Offset: 0xB7EC00 VA: 0x180B80200
	public void Trace(GraphNode from) { }
}
