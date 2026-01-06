internal class PictureTag : LineTag // TypeDefIndex: 5584
{
	// Fields
	internal Picture picture; // 0x90

	// Properties
	public override bool IsTextTag { get; }

	// Methods

	// RVA: 0x22177B0 Offset: 0x22161B0 VA: 0x1822177B0
	internal void .ctor(Line line, int start, Picture picture) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 4
	public override bool get_IsTextTag() { }

	// RVA: 0x2217750 Offset: 0x2216150 VA: 0x182217750 Slot: 7
	public override SizeF SizeOfPosition(Graphics dc, int pos) { }

	// RVA: 0x2217720 Offset: 0x2216120 VA: 0x182217720 Slot: 6
	internal override int MaxHeight() { }

	// RVA: 0x2217780 Offset: 0x2216180 VA: 0x182217780 Slot: 8
	public override string Text() { }
}
