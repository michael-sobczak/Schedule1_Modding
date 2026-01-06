public class BaseKeyframe : IComparable, IBaseKeyframe // TypeDefIndex: 433
{
	// Fields
	[SerializeField]
	public string m_Id; // 0x10
	[SerializeField]
	private float m_Time; // 0x18
	[SerializeField]
	private InterpolationCurve m_InterpolationCurve; // 0x1C
	[SerializeField]
	private InterpolationDirection m_InterpolationDirection; // 0x20

	// Properties
	public string id { get; set; }
	public float time { get; set; }
	public InterpolationCurve interpolationCurve { get; set; }
	public InterpolationDirection interpolationDirection { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public string get_id() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_id(string value) { }

	// RVA: 0x54BD70 Offset: 0x54A770 VA: 0x18054BD70 Slot: 6
	public float get_time() { }

	// RVA: 0x61B4E0 Offset: 0x619EE0 VA: 0x18061B4E0 Slot: 7
	public void set_time(float value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70 Slot: 8
	public InterpolationCurve get_interpolationCurve() { }

	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80 Slot: 9
	public void set_interpolationCurve(InterpolationCurve value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 10
	public InterpolationDirection get_interpolationDirection() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490 Slot: 11
	public void set_interpolationDirection(InterpolationDirection value) { }

	// RVA: 0x9DDF50 Offset: 0x9DC950 VA: 0x1809DDF50
	public void .ctor(float time) { }

	// RVA: 0x9DDEA0 Offset: 0x9DC8A0 VA: 0x1809DDEA0 Slot: 4
	public int CompareTo(object other) { }
}
