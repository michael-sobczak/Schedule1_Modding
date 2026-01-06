public class AxisControl : InputControl<float> // TypeDefIndex: 7770
{
	// Fields
	public AxisControl.Clamp clamp; // 0x108
	public float clampMin; // 0x10C
	public float clampMax; // 0x110
	public float clampConstant; // 0x114
	public bool invert; // 0x118
	public bool normalize; // 0x119
	public float normalizeMin; // 0x11C
	public float normalizeMax; // 0x120
	public float normalizeZero; // 0x124
	public bool scale; // 0x128
	public float scaleFactor; // 0x12C

	// Methods

	// RVA: 0x2777510 Offset: 0x2775F10 VA: 0x182777510
	protected float Preprocess(float value) { }

	// RVA: 0x2778700 Offset: 0x2777100 VA: 0x182778700
	private float Unpreprocess(float value) { }

	// RVA: 0x27788A0 Offset: 0x27772A0 VA: 0x1827788A0
	public void .ctor() { }

	// RVA: 0x2778550 Offset: 0x2776F50 VA: 0x182778550 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2778640 Offset: 0x2777040 VA: 0x182778640 Slot: 17
	public override float ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x2778770 Offset: 0x2777170 VA: 0x182778770 Slot: 18
	public override void WriteValueIntoState(float value, void* statePtr) { }

	// RVA: 0x27782C0 Offset: 0x2776CC0 VA: 0x1827782C0 Slot: 12
	public override bool CompareValue(void* firstStatePtr, void* secondStatePtr) { }

	// RVA: 0x2778430 Offset: 0x2776E30 VA: 0x182778430 Slot: 6
	public override float EvaluateMagnitude(void* statePtr) { }

	// RVA: 0x2778350 Offset: 0x2776D50 VA: 0x182778350
	private float EvaluateMagnitude(float value) { }

	// RVA: 0x2778120 Offset: 0x2776B20 VA: 0x182778120 Slot: 15
	protected override FourCC CalculateOptimizedControlDataType() { }
}
