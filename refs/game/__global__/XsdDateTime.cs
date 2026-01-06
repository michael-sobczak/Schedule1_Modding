internal struct XsdDateTime // TypeDefIndex: 8525
{
	// Fields
	private DateTime dt; // 0x0
	private uint extra; // 0x8
	private static readonly int Lzyyyy; // 0x0
	private static readonly int Lzyyyy_; // 0x4
	private static readonly int Lzyyyy_MM; // 0x8
	private static readonly int Lzyyyy_MM_; // 0xC
	private static readonly int Lzyyyy_MM_dd; // 0x10
	private static readonly int Lzyyyy_MM_ddT; // 0x14
	private static readonly int LzHH; // 0x18
	private static readonly int LzHH_; // 0x1C
	private static readonly int LzHH_mm; // 0x20
	private static readonly int LzHH_mm_; // 0x24
	private static readonly int LzHH_mm_ss; // 0x28
	private static readonly int Lz_; // 0x2C
	private static readonly int Lz_zz; // 0x30
	private static readonly int Lz_zz_; // 0x34
	private static readonly int Lz_zz_zz; // 0x38
	private static readonly int Lz__; // 0x3C
	private static readonly int Lz__mm; // 0x40
	private static readonly int Lz__mm_; // 0x44
	private static readonly int Lz__mm__; // 0x48
	private static readonly int Lz__mm_dd; // 0x4C
	private static readonly int Lz___; // 0x50
	private static readonly int Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Properties
	private XsdDateTime.DateTimeTypeCode InternalTypeCode { get; }
	private XsdDateTime.XsdDateTimeKind InternalKind { get; }
	public int Year { get; }
	public int Month { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Second { get; }
	public int Fraction { get; }
	public int ZoneHour { get; }
	public int ZoneMinute { get; }

	// Methods

	// RVA: 0x24A6F30 Offset: 0x24A5930 VA: 0x1824A6F30
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x24A7160 Offset: 0x24A5B60 VA: 0x1824A7160
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x24A5510 Offset: 0x24A3F10 VA: 0x1824A5510
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x24A6780 Offset: 0x24A5180 VA: 0x1824A6780
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x24A71F0 Offset: 0x24A5BF0 VA: 0x1824A71F0
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x24A73A0 Offset: 0x24A5DA0 VA: 0x1824A73A0
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x24A6DA0 Offset: 0x24A57A0 VA: 0x1824A6DA0
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x24A75C0 Offset: 0x24A5FC0 VA: 0x1824A75C0
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x1BD7CE0 Offset: 0x1BD66E0 VA: 0x181BD7CE0
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x24A76C0 Offset: 0x24A60C0 VA: 0x1824A76C0
	public int get_Year() { }

	// RVA: 0x24A7620 Offset: 0x24A6020 VA: 0x1824A7620
	public int get_Month() { }

	// RVA: 0x24A7410 Offset: 0x24A5E10 VA: 0x1824A7410
	public int get_Day() { }

	// RVA: 0x24A7570 Offset: 0x24A5F70 VA: 0x1824A7570
	public int get_Hour() { }

	// RVA: 0x24A75D0 Offset: 0x24A5FD0 VA: 0x1824A75D0
	public int get_Minute() { }

	// RVA: 0x24A7670 Offset: 0x24A6070 VA: 0x1824A7670
	public int get_Second() { }

	// RVA: 0x24A7460 Offset: 0x24A5E60 VA: 0x1824A7460
	public int get_Fraction() { }

	// RVA: 0x1BD7CF0 Offset: 0x1BD66F0 VA: 0x181BD7CF0
	public int get_ZoneHour() { }

	// RVA: 0x48A510 Offset: 0x488F10 VA: 0x18048A510
	public int get_ZoneMinute() { }

	// RVA: 0x24A7710 Offset: 0x24A6110 VA: 0x1824A7710
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x24A7D70 Offset: 0x24A6770 VA: 0x1824A7D70
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x24A61F0 Offset: 0x24A4BF0 VA: 0x1824A61F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x24A56F0 Offset: 0x24A40F0 VA: 0x1824A56F0
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x24A5A00 Offset: 0x24A4400 VA: 0x1824A5A00
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x24A5E30 Offset: 0x24A4830 VA: 0x1824A5E30
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x24A5640 Offset: 0x24A4040 VA: 0x1824A5640
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x24A6170 Offset: 0x24A4B70 VA: 0x1824A6170
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x24A68E0 Offset: 0x24A52E0 VA: 0x1824A68E0
	private static void .cctor() { }
}
