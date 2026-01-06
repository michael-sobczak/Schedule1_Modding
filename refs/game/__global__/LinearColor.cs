public struct LinearColor // TypeDefIndex: 12322
{
	// Fields
	private float m_red; // 0x0
	private float m_green; // 0x4
	private float m_blue; // 0x8
	private float m_intensity; // 0xC

	// Properties
	public float red { get; set; }
	public float green { get; set; }
	public float blue { get; set; }

	// Methods

	// RVA: 0x454BB0 Offset: 0x4535B0 VA: 0x180454BB0
	public float get_red() { }

	// RVA: 0x2CF2570 Offset: 0x2CF0F70 VA: 0x182CF2570
	public void set_red(float value) { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_green() { }

	// RVA: 0x2CF24B0 Offset: 0x2CF0EB0 VA: 0x182CF24B0
	public void set_green(float value) { }

	// RVA: 0x454BA0 Offset: 0x4535A0 VA: 0x180454BA0
	public float get_blue() { }

	// RVA: 0x2CF23F0 Offset: 0x2CF0DF0 VA: 0x182CF23F0
	public void set_blue(float value) { }

	// RVA: 0x2CF20E0 Offset: 0x2CF0AE0 VA: 0x182CF20E0
	public static LinearColor Convert(Color color, float intensity) { }

	// RVA: 0x2CF20B0 Offset: 0x2CF0AB0 VA: 0x182CF20B0
	public static LinearColor Black() { }
}
