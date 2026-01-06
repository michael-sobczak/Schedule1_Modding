public class ArrayPoolsSettings : DTVersionedMonoBehaviour // TypeDefIndex: 10561
{
	// Fields
	[SerializeField]
	[Tooltip("The maximal number of elements of type Vector2 allowed to be stored in the arrays' pool waiting to be reused")]
	private long vector2Capacity; // 0x30
	[SerializeField]
	[Tooltip("The maximal number of elements of type Vector3 allowed to be stored in the arrays' pool waiting to be reused")]
	private long vector3Capacity; // 0x38
	[Tooltip("The maximal number of elements of type Vector4 allowed to be stored in the arrays' pool waiting to be reused")]
	[SerializeField]
	private long vector4Capacity; // 0x40
	[SerializeField]
	[Tooltip("The maximal number of elements of type Int32 allowed to be stored in the arrays' pool waiting to be reused")]
	private long intCapacity; // 0x48
	[Tooltip("The maximal number of elements of type Single (a.k.a float) allowed to be stored in the arrays' pool waiting to be reused")]
	[SerializeField]
	private long floatCapacity; // 0x50
	[Tooltip("The maximal number of elements of type CGSpots allowed to be stored in the arrays' pool waiting to be reused")]
	[SerializeField]
	private long cgSpotCapacity; // 0x58
	[Tooltip("Log in the console each time an array pool allocates a new array in memory")]
	[SerializeField]
	private bool logAllocations; // 0x60

	// Properties
	public long Vector2Capacity { get; set; }
	public long Vector3Capacity { get; set; }
	public long Vector4Capacity { get; set; }
	public long IntCapacity { get; set; }
	public long FloatCapacity { get; set; }
	public long CGSpotCapacity { get; set; }
	public bool LogAllocations { get; set; }

	// Methods

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public long get_Vector2Capacity() { }

	// RVA: 0x4C2310 Offset: 0x4C0D10 VA: 0x1804C2310
	public void set_Vector2Capacity(long value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public long get_Vector3Capacity() { }

	// RVA: 0x4C2400 Offset: 0x4C0E00 VA: 0x1804C2400
	public void set_Vector3Capacity(long value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public long get_Vector4Capacity() { }

	// RVA: 0x4C24F0 Offset: 0x4C0EF0 VA: 0x1804C24F0
	public void set_Vector4Capacity(long value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public long get_IntCapacity() { }

	// RVA: 0x4C1F80 Offset: 0x4C0980 VA: 0x1804C1F80
	public void set_IntCapacity(long value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public long get_FloatCapacity() { }

	// RVA: 0x4C1E90 Offset: 0x4C0890 VA: 0x1804C1E90
	public void set_FloatCapacity(long value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public long get_CGSpotCapacity() { }

	// RVA: 0x4C1DA0 Offset: 0x4C07A0 VA: 0x1804C1DA0
	public void set_CGSpotCapacity(long value) { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_LogAllocations() { }

	// RVA: 0x4C2070 Offset: 0x4C0A70 VA: 0x1804C2070
	public void set_LogAllocations(bool value) { }

	// RVA: 0x4C17E0 Offset: 0x4C01E0 VA: 0x1804C17E0 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x4C17C0 Offset: 0x4C01C0 VA: 0x1804C17C0 Slot: 4
	protected override void OnEnable() { }

	[UsedImplicitly]
	// RVA: 0x4C1800 Offset: 0x4C0200 VA: 0x1804C1800
	private void Start() { }

	// RVA: 0x4C1810 Offset: 0x4C0210 VA: 0x1804C1810
	private void ValidateAndApply() { }

	// RVA: 0x4C1D40 Offset: 0x4C0740 VA: 0x1804C1D40
	public void .ctor() { }
}
