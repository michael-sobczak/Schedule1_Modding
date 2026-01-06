public class Collider2D : Behaviour // TypeDefIndex: 18835
{
	// Properties
	public bool isTrigger { get; set; }
	public Vector2 offset { get; }
	public Rigidbody2D attachedRigidbody { get; }
	public Bounds bounds { get; }

	// Methods

	// RVA: 0x2D2DAD0 Offset: 0x2D2C4D0 VA: 0x182D2DAD0
	public bool get_isTrigger() { }

	// RVA: 0x2D2DBB0 Offset: 0x2D2C5B0 VA: 0x182D2DBB0
	public void set_isTrigger(bool value) { }

	// RVA: 0x2D2DB60 Offset: 0x2D2C560 VA: 0x182D2DB60
	public Vector2 get_offset() { }

	[NativeMethod("GetAttachedRigidbody_Binding")]
	// RVA: 0x2D2D9E0 Offset: 0x2D2C3E0 VA: 0x182D2D9E0
	public Rigidbody2D get_attachedRigidbody() { }

	// RVA: 0x2D2DA70 Offset: 0x2D2C470 VA: 0x182D2DA70
	public Bounds get_bounds() { }

	// RVA: 0x2D2D9A0 Offset: 0x2D2C3A0 VA: 0x182D2D9A0
	public bool OverlapPoint(Vector2 point) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2D2DB10 Offset: 0x2D2C510 VA: 0x182D2DB10
	private void get_offset_Injected(out Vector2 ret) { }

	// RVA: 0x2D2DA20 Offset: 0x2D2C420 VA: 0x182D2DA20
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2D2D950 Offset: 0x2D2C350 VA: 0x182D2D950
	private bool OverlapPoint_Injected(ref Vector2 point) { }
}
