internal struct JsonPosition // TypeDefIndex: 11000
{
	// Fields
	private static readonly char[] SpecialCharacters; // 0x0
	internal JsonContainerType Type; // 0x0
	internal int Position; // 0x4
	[Nullable(2)]
	internal string PropertyName; // 0x8
	internal bool HasIndex; // 0x10

	// Methods

	// RVA: 0x1D0EA10 Offset: 0x1D0D410 VA: 0x181D0EA10
	public void .ctor(JsonContainerType type) { }

	// RVA: 0x1D0E490 Offset: 0x1D0CE90 VA: 0x181D0E490
	internal int CalculateLength() { }

	[NullableContext(2)]
	// RVA: 0x1D0E770 Offset: 0x1D0D170 VA: 0x181D0E770
	internal void WriteTo(StringBuilder sb, ref StringWriter writer, ref char[] buffer) { }

	// RVA: 0x1D0E760 Offset: 0x1D0D160 VA: 0x181D0E760
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0x1D0E050 Offset: 0x1D0CA50 VA: 0x181D0E050
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	// RVA: 0x1D0E530 Offset: 0x1D0CF30 VA: 0x181D0E530
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0x1D0E980 Offset: 0x1D0D380 VA: 0x181D0E980
	private static void .cctor() { }
}
