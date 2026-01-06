internal struct XsdDuration // TypeDefIndex: 8528
{
	// Fields
	private int years; // 0x0
	private int months; // 0x4
	private int days; // 0x8
	private int hours; // 0xC
	private int minutes; // 0x10
	private int seconds; // 0x14
	private uint nanoseconds; // 0x18

	// Properties
	public bool IsNegative { get; }
	public int Years { get; }
	public int Months { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Nanoseconds { get; }

	// Methods

	// RVA: 0x24A9C90 Offset: 0x24A8690 VA: 0x1824A9C90
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x24A9960 Offset: 0x24A8360 VA: 0x1824A9960
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x24A9970 Offset: 0x24A8370 VA: 0x1824A9970
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x24A9F20 Offset: 0x24A8920 VA: 0x1824A9F20
	public void .ctor(string s) { }

	// RVA: 0x24A9BE0 Offset: 0x24A85E0 VA: 0x1824A9BE0
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x24A9F30 Offset: 0x24A8930 VA: 0x1824A9F30
	public bool get_IsNegative() { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_Years() { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_Months() { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_Days() { }

	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public int get_Hours() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Minutes() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_Seconds() { }

	// RVA: 0x24A9F40 Offset: 0x24A8940 VA: 0x1824A9F40
	public int get_Nanoseconds() { }

	// RVA: 0x24A8590 Offset: 0x24A6F90 VA: 0x1824A8590
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x24A85E0 Offset: 0x24A6FE0 VA: 0x1824A85E0
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x24A9330 Offset: 0x24A7D30 VA: 0x1824A9330
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x24A9340 Offset: 0x24A7D40 VA: 0x1824A9340
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x24A8190 Offset: 0x24A6B90 VA: 0x1824A8190 Slot: 3
	public override string ToString() { }

	// RVA: 0x24A81A0 Offset: 0x24A6BA0 VA: 0x1824A81A0
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x24A8780 Offset: 0x24A7180 VA: 0x1824A8780
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x24A8790 Offset: 0x24A7190 VA: 0x1824A8790
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x24A8630 Offset: 0x24A7030 VA: 0x1824A8630
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }
}
