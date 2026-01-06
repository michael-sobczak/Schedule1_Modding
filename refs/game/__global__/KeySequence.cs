internal class KeySequence // TypeDefIndex: 8252
{
	// Fields
	private TypedObject[] ks; // 0x10
	private int dim; // 0x18
	private int hashcode; // 0x1C
	private int posline; // 0x20
	private int poscol; // 0x24

	// Properties
	public int PosLine { get; }
	public int PosCol { get; }
	public object Item { get; set; }

	// Methods

	// RVA: 0x2564E40 Offset: 0x2563840 VA: 0x182564E40
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_PosLine() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_PosCol() { }

	// RVA: 0x21ACDF0 Offset: 0x21AB7F0 VA: 0x1821ACDF0
	public object get_Item(int index) { }

	// RVA: 0x2564ED0 Offset: 0x25638D0 VA: 0x182564ED0
	public void set_Item(int index, object value) { }

	// RVA: 0x2564C70 Offset: 0x2563670 VA: 0x182564C70
	internal bool IsQualified() { }

	// RVA: 0x2564850 Offset: 0x2563250 VA: 0x182564850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2564740 Offset: 0x2563140 VA: 0x182564740 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2564CE0 Offset: 0x25636E0 VA: 0x182564CE0 Slot: 3
	public override string ToString() { }
}
