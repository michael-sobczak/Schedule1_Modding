public class SentryInstance // TypeDefIndex: 1308
{
	// Fields
	public SentryLocation Location; // 0x10
	public int Members; // 0x18
	[Header("Timing")]
	public int StartTime; // 0x1C
	public int EndTime; // 0x20
	[Range(1, 10)]
	public int IntensityRequirement; // 0x24
	public bool OnlyIfCurfewEnabled; // 0x28
	private List<PoliceOfficer> officers; // 0x30

	// Methods

	// RVA: 0x6589F0 Offset: 0x6573F0 VA: 0x1806589F0
	public void Evaluate() { }

	// RVA: 0x658B90 Offset: 0x657590 VA: 0x180658B90
	public void StartEntry() { }

	// RVA: 0x658AF0 Offset: 0x6574F0 VA: 0x180658AF0
	private void MinPass() { }

	// RVA: 0x658850 Offset: 0x657250 VA: 0x180658850
	public void EndSentry() { }

	// RVA: 0x658E30 Offset: 0x657830 VA: 0x180658E30
	public void .ctor() { }
}
