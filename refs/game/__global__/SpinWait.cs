public struct SpinWait // TypeDefIndex: 3936
{
	// Fields
	internal static readonly int SpinCountforSpinBeforeWait; // 0x0
	private int _count; // 0x0

	// Properties
	public int Count { get; }
	public bool NextSpinWillYield { get; }

	// Methods

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_Count() { }

	// RVA: 0x1CE4F20 Offset: 0x1CE3920 VA: 0x181CE4F20
	public bool get_NextSpinWillYield() { }

	// RVA: 0x1CE4D50 Offset: 0x1CE3750 VA: 0x181CE4D50
	public void SpinOnce() { }

	// RVA: 0x1CE4DA0 Offset: 0x1CE37A0 VA: 0x181CE4DA0
	public void SpinOnce(int sleep1Threshold) { }

	// RVA: 0x1CE4BC0 Offset: 0x1CE35C0 VA: 0x181CE4BC0
	private void SpinOnceCore(int sleep1Threshold) { }

	// RVA: 0x1CE4EA0 Offset: 0x1CE38A0 VA: 0x181CE4EA0
	private static void .cctor() { }
}
