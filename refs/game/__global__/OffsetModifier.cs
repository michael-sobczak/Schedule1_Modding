public abstract class OffsetModifier : MonoBehaviour // TypeDefIndex: 14206
{
	// Fields
	[Tooltip("The master weight")]
	public float weight; // 0x20
	[Tooltip("Reference to the FBBIK component")]
	public FullBodyBipedIK ik; // 0x28
	protected float lastTime; // 0x30

	// Properties
	protected float deltaTime { get; }

	// Methods

	// RVA: 0x1F24E20 Offset: 0x1F23820 VA: 0x181F24E20
	protected float get_deltaTime() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnModifyOffset();

	// RVA: 0x1F251B0 Offset: 0x1F23BB0 VA: 0x181F251B0 Slot: 5
	protected virtual void Start() { }

	[IteratorStateMachine(typeof(OffsetModifier.<Initiate>d__8))]
	// RVA: 0x1F24F20 Offset: 0x1F23920 VA: 0x181F24F20
	private IEnumerator Initiate() { }

	// RVA: 0x1F24F90 Offset: 0x1F23990 VA: 0x181F24F90
	private void ModifyOffset() { }

	// RVA: 0x1F24E40 Offset: 0x1F23840 VA: 0x181F24E40
	protected void ApplyLimits(OffsetModifier.OffsetLimits[] limits) { }

	// RVA: 0x1F25070 Offset: 0x1F23A70 VA: 0x181F25070 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x55D3D0 Offset: 0x55BDD0 VA: 0x18055D3D0
	protected void .ctor() { }
}
