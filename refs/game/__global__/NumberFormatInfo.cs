public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 4836
{
	// Fields
	private static NumberFormatInfo invariantInfo; // 0x0
	internal int[] numberGroupSizes; // 0x10
	internal int[] currencyGroupSizes; // 0x18
	internal int[] percentGroupSizes; // 0x20
	internal string positiveSign; // 0x28
	internal string negativeSign; // 0x30
	internal string numberDecimalSeparator; // 0x38
	internal string numberGroupSeparator; // 0x40
	internal string currencyGroupSeparator; // 0x48
	internal string currencyDecimalSeparator; // 0x50
	internal string currencySymbol; // 0x58
	internal string ansiCurrencySymbol; // 0x60
	internal string nanSymbol; // 0x68
	internal string positiveInfinitySymbol; // 0x70
	internal string negativeInfinitySymbol; // 0x78
	internal string percentDecimalSeparator; // 0x80
	internal string percentGroupSeparator; // 0x88
	internal string percentSymbol; // 0x90
	internal string perMilleSymbol; // 0x98
	[OptionalField(VersionAdded = 2)]
	internal string[] nativeDigits; // 0xA0
	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem; // 0xA8
	internal int numberDecimalDigits; // 0xAC
	internal int currencyDecimalDigits; // 0xB0
	internal int currencyPositivePattern; // 0xB4
	internal int currencyNegativePattern; // 0xB8
	internal int numberNegativePattern; // 0xBC
	internal int percentPositivePattern; // 0xC0
	internal int percentNegativePattern; // 0xC4
	internal int percentDecimalDigits; // 0xC8
	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution; // 0xCC
	internal bool isReadOnly; // 0xD0
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; // 0xD1
	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant; // 0xD2
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber; // 0xD3
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency; // 0xD4
	private const NumberStyles InvalidNumberStyles = -1024;

	// Properties
	public static NumberFormatInfo InvariantInfo { get; }
	public int CurrencyDecimalDigits { get; }
	public string CurrencyDecimalSeparator { get; }
	public bool IsReadOnly { get; }
	public int[] CurrencyGroupSizes { get; }
	public int[] NumberGroupSizes { get; }
	public int[] PercentGroupSizes { get; }
	public string CurrencyGroupSeparator { get; }
	public string CurrencySymbol { get; }
	public static NumberFormatInfo CurrentInfo { get; }
	public string NaNSymbol { get; set; }
	public int CurrencyNegativePattern { get; }
	public int NumberNegativePattern { get; }
	public int PercentPositivePattern { get; }
	public int PercentNegativePattern { get; }
	public string NegativeInfinitySymbol { get; }
	public string NegativeSign { get; }
	public int NumberDecimalDigits { get; }
	public string NumberDecimalSeparator { get; }
	public string NumberGroupSeparator { get; }
	public int CurrencyPositivePattern { get; }
	public string PositiveInfinitySymbol { get; }
	public string PositiveSign { get; }
	public int PercentDecimalDigits { get; }
	public string PercentDecimalSeparator { get; }
	public string PercentGroupSeparator { get; }
	public string PercentSymbol { get; }
	public string PerMilleSymbol { get; }

	// Methods

	// RVA: 0x1BEC4E0 Offset: 0x1BEAEE0 VA: 0x181BEC4E0
	public void .ctor() { }

	[OnSerializing]
	// RVA: 0x1BEC130 Offset: 0x1BEAB30 VA: 0x181BEC130
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializing]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x1BEC4F0 Offset: 0x1BEAEF0 VA: 0x181BEC4F0
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x1BEC460 Offset: 0x1BEAE60 VA: 0x181BEC460
	private void VerifyWritable() { }

	// RVA: 0x1BECC50 Offset: 0x1BEB650 VA: 0x181BECC50
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x1BEBE70 Offset: 0x1BEA870 VA: 0x181BEBE70
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x1BEBD70 Offset: 0x1BEA770 VA: 0x181BEBD70 Slot: 4
	public object Clone() { }

	// RVA: 0xBBA740 Offset: 0xBB9140 VA: 0x180BBA740
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0x5187E0 Offset: 0x5171E0 VA: 0x1805187E0
	public bool get_IsReadOnly() { }

	// RVA: 0x1BECAC0 Offset: 0x1BEB4C0 VA: 0x181BECAC0
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x1BECD70 Offset: 0x1BEB770 VA: 0x181BECD70
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x1BECDF0 Offset: 0x1BEB7F0 VA: 0x181BECDF0
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_CurrencySymbol() { }

	// RVA: 0x1BECB40 Offset: 0x1BEB540 VA: 0x181BECB40
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public string get_NaNSymbol() { }

	// RVA: 0x1BECE70 Offset: 0x1BEB870 VA: 0x181BECE70
	public void set_NaNSymbol(string value) { }

	// RVA: 0x6A4D80 Offset: 0x6A3780 VA: 0x1806A4D80
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x4E8B70 Offset: 0x4E7570 VA: 0x1804E8B70
	public int get_NumberNegativePattern() { }

	// RVA: 0x505900 Offset: 0x504300 VA: 0x180505900
	public int get_PercentPositivePattern() { }

	// RVA: 0x526FE0 Offset: 0x5259E0 VA: 0x180526FE0
	public int get_PercentNegativePattern() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_NegativeSign() { }

	// RVA: 0xBBA750 Offset: 0xBB9150 VA: 0x180BBA750
	public int get_NumberDecimalDigits() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_NumberGroupSeparator() { }

	// RVA: 0x10F9570 Offset: 0x10F7F70 VA: 0x1810F9570
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_PositiveSign() { }

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350
	public int get_PercentDecimalDigits() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public string get_PercentGroupSeparator() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public string get_PercentSymbol() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_PerMilleSymbol() { }

	// RVA: 0x1BEBDE0 Offset: 0x1BEA7E0 VA: 0x181BEBDE0 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x1BEC1C0 Offset: 0x1BEABC0 VA: 0x181BEC1C0
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x1BEC370 Offset: 0x1BEAD70 VA: 0x181BEC370
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x1BEC290 Offset: 0x1BEAC90 VA: 0x181BEC290
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }
}
