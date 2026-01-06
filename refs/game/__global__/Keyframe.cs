public struct Keyframe // TypeDefIndex: 11582
{
	// Fields
	private float m_Time; // 0x0
	private float m_Value; // 0x4
	private float m_InTangent; // 0x8
	private float m_OutTangent; // 0xC
	private int m_WeightedMode; // 0x10
	private float m_InWeight; // 0x14
	private float m_OutWeight; // 0x18

	// Properties
	public float time { get; set; }
	public float value { get; set; }
	public float inTangent { get; set; }
	public float outTangent { get; set; }
	public float inWeight { get; set; }
	public float outWeight { get; set; }
	public WeightedMode weightedMode { get; set; }

	// Methods

	// RVA: 0x2C90210 Offset: 0x2C8EC10 VA: 0x182C90210
	public void .ctor(float time, float value) { }

	// RVA: 0x2C901A0 Offset: 0x2C8EBA0 VA: 0x182C901A0
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x2C901D0 Offset: 0x2C8EBD0 VA: 0x182C901D0
	public void .ctor(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight) { }

	// RVA: 0x454BB0 Offset: 0x4535B0 VA: 0x180454BB0
	public float get_time() { }

	// RVA: 0x4D53B0 Offset: 0x4D3DB0 VA: 0x1804D53B0
	public void set_time(float value) { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_value() { }

	// RVA: 0x4D5390 Offset: 0x4D3D90 VA: 0x1804D5390
	public void set_value(float value) { }

	// RVA: 0x454BA0 Offset: 0x4535A0 VA: 0x180454BA0
	public float get_inTangent() { }

	// RVA: 0x4D53A0 Offset: 0x4D3DA0 VA: 0x1804D53A0
	public void set_inTangent(float value) { }

	// RVA: 0x454B90 Offset: 0x453590 VA: 0x180454B90
	public float get_outTangent() { }

	// RVA: 0x4D5380 Offset: 0x4D3D80 VA: 0x1804D5380
	public void set_outTangent(float value) { }

	// RVA: 0x1670A90 Offset: 0x166F490 VA: 0x181670A90
	public float get_inWeight() { }

	// RVA: 0x474920 Offset: 0x473320 VA: 0x180474920
	public void set_inWeight(float value) { }

	// RVA: 0x2C90230 Offset: 0x2C8EC30 VA: 0x182C90230
	public float get_outWeight() { }

	// RVA: 0x61B4E0 Offset: 0x619EE0 VA: 0x18061B4E0
	public void set_outWeight(float value) { }

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60
	public WeightedMode get_weightedMode() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_weightedMode(WeightedMode value) { }
}
