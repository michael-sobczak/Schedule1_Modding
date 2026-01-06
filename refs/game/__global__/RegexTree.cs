internal sealed class RegexTree // TypeDefIndex: 9572
{
	// Fields
	public readonly RegexNode Root; // 0x10
	public readonly Hashtable Caps; // 0x18
	public readonly int[] CapNumList; // 0x20
	public readonly int CapTop; // 0x28
	public readonly Hashtable CapNames; // 0x30
	public readonly string[] CapsList; // 0x38
	public readonly RegexOptions Options; // 0x40

	// Methods

	// RVA: 0x263AC00 Offset: 0x2639600 VA: 0x18263AC00
	internal void .ctor(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options) { }
}
