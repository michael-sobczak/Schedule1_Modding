public struct DealWindowInfo // TypeDefIndex: 1515
{
	// Fields
	public const int WINDOW_DURATION_MINS = 360;
	public const int WINDOW_COUNT = 4;
	public int StartTime; // 0x0
	public int EndTime; // 0x4
	public static readonly DealWindowInfo Morning; // 0x0
	public static readonly DealWindowInfo Afternoon; // 0x8
	public static readonly DealWindowInfo Night; // 0x10
	public static readonly DealWindowInfo LateNight; // 0x18

	// Methods

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(int startTime, int endTime) { }

	// RVA: 0x6D2210 Offset: 0x6D0C10 VA: 0x1806D2210
	public static DealWindowInfo GetWindowInfo(EDealWindow window) { }

	// RVA: 0x6D2300 Offset: 0x6D0D00 VA: 0x1806D2300
	public static EDealWindow GetWindow(int time) { }

	// RVA: 0x6D2420 Offset: 0x6D0E20 VA: 0x1806D2420
	private static void .cctor() { }
}
