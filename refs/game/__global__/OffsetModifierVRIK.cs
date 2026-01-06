public abstract class OffsetModifierVRIK : MonoBehaviour // TypeDefIndex: 14208
{
	// Fields
	[Tooltip("The master weight")]
	public float weight; // 0x20
	[Tooltip("Reference to the VRIK component")]
	public VRIK ik; // 0x28
	private float lastTime; // 0x30

	// Properties
	protected float deltaTime { get; }

	// Methods

	// RVA: 0x1F24E20 Offset: 0x1F23820 VA: 0x181F24E20
	protected float get_deltaTime() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnModifyOffset();

	// RVA: 0x1F24DA0 Offset: 0x1F237A0 VA: 0x181F24DA0 Slot: 5
	protected virtual void Start() { }

	[IteratorStateMachine(typeof(OffsetModifierVRIK.<Initiate>d__7))]
	// RVA: 0x1F24B10 Offset: 0x1F23510 VA: 0x181F24B10
	private IEnumerator Initiate() { }

	// RVA: 0x1F24B80 Offset: 0x1F23580 VA: 0x181F24B80
	private void ModifyOffset() { }

	// RVA: 0x1F24C60 Offset: 0x1F23660 VA: 0x181F24C60 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x55D3D0 Offset: 0x55BDD0 VA: 0x18055D3D0
	protected void .ctor() { }
}
