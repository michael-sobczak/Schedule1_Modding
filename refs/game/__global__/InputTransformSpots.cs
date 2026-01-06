public class InputTransformSpots : CGModule // TypeDefIndex: 10735
{
	// Fields
	[HideInInspector]
	[OutputSlotInfo(typeof(CGSpots))]
	public CGModuleOutputSlot OutSpots; // 0xC0
	[ArrayEx]
	[SerializeField]
	private List<InputTransformSpots.TransformSpot> transformSpots; // 0xC8
	private readonly Dictionary<CGSpot, InputTransformSpots.TransformSpot> outputToInputDictionary; // 0xD0

	// Properties
	public List<InputTransformSpots.TransformSpot> TransformSpots { get; set; }

	// Methods

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public List<InputTransformSpots.TransformSpot> get_TransformSpots() { }

	// RVA: 0x534180 Offset: 0x532B80 VA: 0x180534180
	public void set_TransformSpots(List<InputTransformSpots.TransformSpot> value) { }

	// RVA: 0x533F70 Offset: 0x532970 VA: 0x180533F70 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x5341C0 Offset: 0x532BC0 VA: 0x1805341C0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x534480 Offset: 0x532E80 VA: 0x180534480 Slot: 13
	public override void Reset() { }

	[UsedImplicitly]
	// RVA: 0x534680 Offset: 0x533080 VA: 0x180534680
	private void Update() { }

	// RVA: 0x5341D0 Offset: 0x532BD0 VA: 0x1805341D0 Slot: 14
	public override void Refresh() { }

	// RVA: 0x534420 Offset: 0x532E20 VA: 0x180534420 Slot: 5
	protected override void ResetOnEnable() { }

	// RVA: 0x5348E0 Offset: 0x5332E0 VA: 0x1805348E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5344F0 Offset: 0x532EF0 VA: 0x1805344F0
	private CGSpot <Refresh>b__9_1(InputTransformSpots.TransformSpot s) { }
}
