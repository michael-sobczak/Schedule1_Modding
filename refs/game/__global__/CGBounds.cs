public class CGBounds : CGData // TypeDefIndex: 10605
{
	// Fields
	protected Nullable<Bounds> mBounds; // 0x20

	// Properties
	public Bounds Bounds { get; set; }
	public float Depth { get; }

	// Methods

	// RVA: 0x4D6A30 Offset: 0x4D5430 VA: 0x1804D6A30
	public Bounds get_Bounds() { }

	// RVA: 0x4D6B40 Offset: 0x4D5540 VA: 0x1804D6B40
	public void set_Bounds(Bounds value) { }

	// RVA: 0x4D6AC0 Offset: 0x4D54C0 VA: 0x1804D6AC0
	public float get_Depth() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x4D6990 Offset: 0x4D5390 VA: 0x1804D6990
	public void .ctor(Bounds bounds) { }

	// RVA: 0x4D6840 Offset: 0x4D5240 VA: 0x1804D6840
	public void .ctor(CGBounds source) { }

	// RVA: 0x4D67B0 Offset: 0x4D51B0 VA: 0x1804D67B0 Slot: 8
	public virtual void RecalculateBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public override T Clone<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B1D0 Offset: 0xE59BD0 VA: 0x180E5B1D0
	|-CGBounds.Clone<object>
	*/

	// RVA: 0x4D6670 Offset: 0x4D5070 VA: 0x1804D6670
	public static void Copy(CGBounds dest, CGBounds source) { }
}
