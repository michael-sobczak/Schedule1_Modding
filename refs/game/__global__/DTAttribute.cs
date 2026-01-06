public class DTAttribute : Attribute, IComparable // TypeDefIndex: 10379
{
	// Fields
	[CompilerGenerated]
	private int <TypeSort>k__BackingField; // 0x10
	public int Sort; // 0x14
	public bool ShowBelowProperty; // 0x18
	public int Space; // 0x1C

	// Properties
	public int TypeSort { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_TypeSort() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	protected void set_TypeSort(int value) { }

	// RVA: 0x48C720 Offset: 0x48B120 VA: 0x18048C720 Slot: 8
	public virtual int CompareTo(object obj) { }

	// RVA: 0x48C810 Offset: 0x48B210 VA: 0x18048C810
	public void .ctor(int sortOrder, bool showBelow = False) { }
}
