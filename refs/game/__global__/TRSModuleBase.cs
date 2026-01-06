public abstract class TRSModuleBase : CGModule // TypeDefIndex: 10604
{
	// Fields
	[SerializeField]
	[VectorEx("", "")]
	private Vector3 m_Transpose; // 0xC0
	[SerializeField]
	[VectorEx("", "")]
	private Vector3 m_Rotation; // 0xCC
	[SerializeField]
	[VectorEx("", "")]
	private Vector3 m_Scale; // 0xD8

	// Properties
	public Vector3 Transpose { get; set; }
	public Vector3 Rotation { get; set; }
	public Vector3 Scale { get; set; }
	public Matrix4x4 Matrix { get; }

	// Methods

	// RVA: 0x4EFF90 Offset: 0x4EE990 VA: 0x1804EFF90
	public Vector3 get_Transpose() { }

	// RVA: 0x4F00F0 Offset: 0x4EEAF0 VA: 0x1804F00F0
	public void set_Transpose(Vector3 value) { }

	// RVA: 0x4EFF50 Offset: 0x4EE950 VA: 0x1804EFF50
	public Vector3 get_Rotation() { }

	// RVA: 0x4EFFB0 Offset: 0x4EE9B0 VA: 0x1804EFFB0
	public void set_Rotation(Vector3 value) { }

	// RVA: 0x4EFF70 Offset: 0x4EE970 VA: 0x1804EFF70
	public Vector3 get_Scale() { }

	// RVA: 0x4F0050 Offset: 0x4EEA50 VA: 0x1804F0050
	public void set_Scale(Vector3 value) { }

	// RVA: 0x4EFE40 Offset: 0x4EE840 VA: 0x1804EFE40
	public Matrix4x4 get_Matrix() { }

	// RVA: 0x4EF730 Offset: 0x4EE130 VA: 0x1804EF730
	protected Matrix4x4 ApplyTrsOnShape(CGShape shape) { }

	// RVA: 0x4EFB50 Offset: 0x4EE550 VA: 0x1804EFB50 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x4EFBA0 Offset: 0x4EE5A0 VA: 0x1804EFBA0 Slot: 13
	public override void Reset() { }

	// RVA: 0x4EFDE0 Offset: 0x4EE7E0 VA: 0x1804EFDE0
	protected void .ctor() { }
}
