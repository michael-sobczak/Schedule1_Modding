internal class UITKTextHandle : TextHandle // TypeDefIndex: 6915
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <MeasuredSizes>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <RoundedSizes>k__BackingField; // 0x40
	private TextElement m_TextElement; // 0x48
	internal bool isOverridingCursor; // 0x50
	internal int currentLinkIDHash; // 0x54
	internal bool hasLinkTag; // 0x58
	internal bool hasATag; // 0x59
	internal static readonly float k_MinPadding; // 0x0

	// Properties
	public Vector2 MeasuredSizes { get; set; }
	public Vector2 RoundedSizes { get; set; }

	// Methods

	// RVA: 0x2F0E980 Offset: 0x2F0D380 VA: 0x182F0E980
	public void .ctor(TextElement te) { }

	[CompilerGenerated]
	// RVA: 0x57CCD0 Offset: 0x57B6D0 VA: 0x18057CCD0
	public Vector2 get_MeasuredSizes() { }

	[CompilerGenerated]
	// RVA: 0x57CCF0 Offset: 0x57B6F0 VA: 0x18057CCF0
	public void set_MeasuredSizes(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2ACB850 Offset: 0x2ACA250 VA: 0x182ACB850
	public Vector2 get_RoundedSizes() { }

	[CompilerGenerated]
	// RVA: 0x54D020 Offset: 0x54BA20 VA: 0x18054D020
	public void set_RoundedSizes(Vector2 value) { }

	// RVA: 0x2F0C9C0 Offset: 0x2F0B3C0 VA: 0x182F0C9C0
	public float ComputeTextWidth(string textToMeasure, bool wordWrap, float width, float height) { }

	// RVA: 0x2F0C8B0 Offset: 0x2F0B2B0 VA: 0x182F0C8B0
	public float ComputeTextHeight(string textToMeasure, float width, float height) { }

	// RVA: 0x2F0E7F0 Offset: 0x2F0D1F0 VA: 0x182F0E7F0
	public TextInfo Update() { }

	// RVA: 0x2F0C6C0 Offset: 0x2F0B0C0 VA: 0x182F0C6C0
	private void ATagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x2F0C6B0 Offset: 0x2F0B0B0 VA: 0x182F0C6B0
	private void ATagOnPointerOver(PointerOverEvent _) { }

	// RVA: 0x2F0C440 Offset: 0x2F0AE40 VA: 0x182F0C440
	private void ATagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x2F0C6B0 Offset: 0x2F0B0B0 VA: 0x182F0C6B0
	private void ATagOnPointerOut(PointerOutEvent _) { }

	// RVA: 0x2F0DBE0 Offset: 0x2F0C5E0 VA: 0x182F0DBE0
	internal void LinkTagOnPointerDown(PointerDownEvent pde) { }

	// RVA: 0x2F0E4F0 Offset: 0x2F0CEF0 VA: 0x182F0E4F0
	internal void LinkTagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x2F0DEB0 Offset: 0x2F0C8B0 VA: 0x182F0DEB0
	internal void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x2F0E3A0 Offset: 0x2F0CDA0 VA: 0x182F0E3A0
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	// RVA: 0x2F0D800 Offset: 0x2F0C200 VA: 0x182F0D800
	private void HandleLinkTag() { }

	// RVA: 0x2F0D3A0 Offset: 0x2F0BDA0 VA: 0x182F0D3A0
	private void HandleATag() { }

	// RVA: 0x2F0D2A0 Offset: 0x2F0BCA0 VA: 0x182F0D2A0
	private TextOverflowMode GetTextOverflowMode() { }

	// RVA: 0x2F0CAF0 Offset: 0x2F0B4F0 VA: 0x182F0CAF0
	internal void ConvertUssToTextGenerationSettings(TextGenerationSettings tgs) { }

	// RVA: 0x2F0E7C0 Offset: 0x2F0D1C0 VA: 0x182F0E7C0
	internal bool TextLibraryCanElide() { }

	// RVA: 0x2F0D060 Offset: 0x2F0BA60 VA: 0x182F0D060
	internal float GetTextEffectPadding(FontAsset fontAsset) { }

	// RVA: 0x2F0E940 Offset: 0x2F0D340 VA: 0x182F0E940
	private static void .cctor() { }
}
