public class E01_MetaDataController : SplineController // TypeDefIndex: 10749
{
	// Fields
	[Section("MetaController", True, False, 100, Sort = 0)]
	[SerializeField]
	[RangeEx(0, 30, "", "")]
	private float m_MaxHeight; // 0x108

	// Properties
	public float MaxHeight { get; set; }

	// Methods

	// RVA: 0x528060 Offset: 0x526A60 VA: 0x180528060
	public float get_MaxHeight() { }

	// RVA: 0x528220 Offset: 0x526C20 VA: 0x180528220
	public void set_MaxHeight(float value) { }

	// RVA: 0x528030 Offset: 0x526A30 VA: 0x180528030 Slot: 31
	protected override void UserAfterInit() { }

	// RVA: 0x528030 Offset: 0x526A30 VA: 0x180528030 Slot: 32
	protected override void UserAfterUpdate() { }

	// RVA: 0x528070 Offset: 0x526A70 VA: 0x180528070
	private void setHeight() { }

	// RVA: 0x528040 Offset: 0x526A40 VA: 0x180528040
	public void .ctor() { }
}
