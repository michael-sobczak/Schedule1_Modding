public class SortKey // TypeDefIndex: 4842
{
	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x1BECF60 Offset: 0x1BEB960 VA: 0x181BECF60
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x1BED4B0 Offset: 0x1BEBEB0 VA: 0x181BED4B0
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x1BED3F0 Offset: 0x1BEBDF0 VA: 0x181BED3F0
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x1BED460 Offset: 0x1BEBE60 VA: 0x181BED460
	internal void .ctor(string localeName, string str, CompareOptions options, byte[] keyData) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x1BED180 Offset: 0x1BEBB80 VA: 0x181BED180 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1BED220 Offset: 0x1BEBC20 VA: 0x181BED220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BED290 Offset: 0x1BEBC90 VA: 0x181BED290 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BED590 Offset: 0x1BEBF90 VA: 0x181BED590
	internal void .ctor() { }
}
