internal struct TextCoreSettings : IEquatable<TextCoreSettings> // TypeDefIndex: 7134
{
	// Fields
	public Color faceColor; // 0x0
	public Color outlineColor; // 0x10
	public float outlineWidth; // 0x20
	public Color underlayColor; // 0x24
	public Vector2 underlayOffset; // 0x34
	public float underlaySoftness; // 0x3C

	// Methods

	// RVA: 0x2E1E220 Offset: 0x2E1CC20 VA: 0x182E1E220 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2E1E2D0 Offset: 0x2E1CCD0 VA: 0x182E1E2D0 Slot: 4
	public bool Equals(TextCoreSettings other) { }

	// RVA: 0x2E1E470 Offset: 0x2E1CE70 VA: 0x182E1E470 Slot: 2
	public override int GetHashCode() { }
}
