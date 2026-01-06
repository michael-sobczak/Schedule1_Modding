public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 16496
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x2F2E250 Offset: 0x2F2CC50 VA: 0x182F2E250
	protected Graphic get_graphic() { }

	// RVA: 0x2F2E1B0 Offset: 0x2F2CBB0 VA: 0x182F2E1B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F2E110 Offset: 0x2F2CB10 VA: 0x182F2E110 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F2E070 Offset: 0x2F2CA70 VA: 0x182F2E070 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2F2DE30 Offset: 0x2F2C830 VA: 0x182F2DE30 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	protected void .ctor() { }
}
