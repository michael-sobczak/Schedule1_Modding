internal struct DateTimeRawInfo // TypeDefIndex: 3645
{
	// Fields
	private int* num; // 0x0
	internal int numCount; // 0x8
	internal int month; // 0xC
	internal int year; // 0x10
	internal int dayOfWeek; // 0x14
	internal int era; // 0x18
	internal DateTimeParse.TM timeMark; // 0x1C
	internal double fraction; // 0x20
	internal bool hasSameDateAndTimeSeparators; // 0x28

	// Methods

	// RVA: 0x1C5FC40 Offset: 0x1C5E640 VA: 0x181C5FC40
	internal void Init(int* numberBuffer) { }

	// RVA: 0x1C5FC10 Offset: 0x1C5E610 VA: 0x181C5FC10
	internal void AddNumber(int value) { }

	// RVA: 0x1C5FC30 Offset: 0x1C5E630 VA: 0x181C5FC30
	internal int GetNumber(int index) { }
}
