internal class EraInfo // TypeDefIndex: 4831
{
	// Fields
	internal int era; // 0x10
	internal long ticks; // 0x18
	internal int yearOffset; // 0x20
	internal int minEraYear; // 0x24
	internal int maxEraYear; // 0x28
	[OptionalField(VersionAdded = 4)]
	internal string eraName; // 0x30
	[OptionalField(VersionAdded = 4)]
	internal string abbrevEraName; // 0x38
	[OptionalField(VersionAdded = 4)]
	internal string englishEraName; // 0x40

	// Methods

	// RVA: 0x1BA96B0 Offset: 0x1BA80B0 VA: 0x181BA96B0
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	// RVA: 0x1BA95A0 Offset: 0x1BA7FA0 VA: 0x181BA95A0
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }
}
