public class RegionInfo // TypeDefIndex: 4858
{
	// Fields
	private static RegionInfo currentRegion; // 0x0
	private int regionId; // 0x10
	private string iso2Name; // 0x18
	private string iso3Name; // 0x20
	private string win3Name; // 0x28
	private string englishName; // 0x30
	private string nativeName; // 0x38
	private string currencySymbol; // 0x40
	private string isoCurrencySymbol; // 0x48
	private string currencyEnglishName; // 0x50
	private string currencyNativeName; // 0x58

	// Properties
	public static RegionInfo CurrentRegion { get; }
	[ComVisible(False)]
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODO("DisplayName currently only returns the EnglishName")]
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisible(False)]
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisible(False)]
	public virtual string NativeName { get; }
	[ComVisible(False)]
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }

	// Methods

	// RVA: 0x1C02890 Offset: 0x1C01290 VA: 0x181C02890
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x1C026F0 Offset: 0x1C010F0 VA: 0x181C026F0
	public void .ctor(int culture) { }

	// RVA: 0x1C02320 Offset: 0x1C00D20 VA: 0x181C02320
	public void .ctor(string name) { }

	// RVA: 0x1C024E0 Offset: 0x1C00EE0 VA: 0x181C024E0
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x1C02210 Offset: 0x1C00C10 VA: 0x181C02210
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x1C02880 Offset: 0x1C01280 VA: 0x181C02880
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x1C02960 Offset: 0x1C01360 VA: 0x181C02960 Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x1C02150 Offset: 0x1C00B50 VA: 0x181C02150 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1C022C0 Offset: 0x1C00CC0 VA: 0x181C022C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C02300 Offset: 0x1C00D00 VA: 0x181C02300 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C02100 Offset: 0x1C00B00 VA: 0x181C02100
	internal static void ClearCachedData() { }
}
