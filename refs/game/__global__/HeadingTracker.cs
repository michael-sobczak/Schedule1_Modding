public class HeadingTracker // TypeDefIndex: 16265
{
	// Fields
	private HeadingTracker.Item[] mHistory; // 0x10
	private int mTop; // 0x18
	private int mBottom; // 0x1C
	private int mCount; // 0x20
	private Vector3 mHeadingSum; // 0x24
	private float mWeightSum; // 0x30
	private float mWeightTime; // 0x34
	private Vector3 mLastGoodHeading; // 0x38
	private static float mDecayExponent; // 0x0

	// Properties
	public int FilterSize { get; }

	// Methods

	// RVA: 0xC4A930 Offset: 0xC49330 VA: 0x180C4A930
	public void .ctor(int filterSize) { }

	// RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	public int get_FilterSize() { }

	// RVA: 0xC4A3A0 Offset: 0xC48DA0 VA: 0x180C4A3A0
	private void ClearHistory() { }

	// RVA: 0xC4A540 Offset: 0xC48F40 VA: 0x180C4A540
	private static float Decay(float time) { }

	// RVA: 0xC4A190 Offset: 0xC48B90 VA: 0x180C4A190
	public void Add(Vector3 velocity) { }

	// RVA: 0xC4A770 Offset: 0xC49170 VA: 0x180C4A770
	private void PopBottom() { }

	// RVA: 0xC4A400 Offset: 0xC48E00 VA: 0x180C4A400
	public void DecayHistory() { }

	// RVA: 0xC4A590 Offset: 0xC48F90 VA: 0x180C4A590
	public Vector3 GetReliableHeading() { }
}
