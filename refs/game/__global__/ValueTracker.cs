public class ValueTracker // TypeDefIndex: 1944
{
	// Fields
	private float historyDuration; // 0x10
	private List<ValueTracker.Value> valueHistory; // 0x18

	// Methods

	// RVA: 0x7A85B0 Offset: 0x7A6FB0 VA: 0x1807A85B0
	public void .ctor(float HistoryDuration) { }

	// RVA: 0x7A7F20 Offset: 0x7A6920 VA: 0x1807A7F20
	public void Destroy() { }

	// RVA: 0x7A84F0 Offset: 0x7A6EF0 VA: 0x1807A84F0
	public void Update() { }

	// RVA: 0x7A83F0 Offset: 0x7A6DF0 VA: 0x1807A83F0
	public void SubmitValue(float value) { }

	// RVA: 0x7A8350 Offset: 0x7A6D50 VA: 0x1807A8350
	public float RecordedHistoryLength() { }

	// RVA: 0x7A8200 Offset: 0x7A6C00 VA: 0x1807A8200
	public float GetLowestValue() { }

	// RVA: 0x7A8070 Offset: 0x7A6A70 VA: 0x1807A8070
	public float GetAverageValue() { }
}
