public class InputSpots : CGModule // TypeDefIndex: 10732
{
	// Fields
	[OutputSlotInfo(typeof(CGSpots))]
	[HideInInspector]
	public CGModuleOutputSlot OutSpots; // 0xC0
	[ArrayEx]
	[SerializeField]
	private List<CGSpot> m_Spots; // 0xC8

	// Properties
	public List<CGSpot> Spots { get; set; }

	// Methods

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public List<CGSpot> get_Spots() { }

	// RVA: 0x534180 Offset: 0x532B80 VA: 0x180534180
	public void set_Spots(List<CGSpot> value) { }

	// RVA: 0x533F70 Offset: 0x532970 VA: 0x180533F70 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x534060 Offset: 0x532A60 VA: 0x180534060 Slot: 13
	public override void Reset() { }

	// RVA: 0x533FA0 Offset: 0x5329A0 VA: 0x180533FA0 Slot: 14
	public override void Refresh() { }

	// RVA: 0x5340C0 Offset: 0x532AC0 VA: 0x1805340C0
	public void .ctor() { }
}
