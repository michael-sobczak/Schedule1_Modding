public class SoilChunk : Clickable // TypeDefIndex: 2381
{
	// Fields
	[CompilerGenerated]
	private float <CurrentLerp>k__BackingField; // 0x50
	public Transform EndTransform; // 0x58
	public float LerpTime; // 0x60
	private Vector3 localPos_Start; // 0x64
	private Vector3 localEulerAngles_Start; // 0x70
	private Vector3 localScale_Start; // 0x7C
	private Coroutine lerpRoutine; // 0x88

	// Properties
	public float CurrentLerp { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_CurrentLerp() { }

	[CompilerGenerated]
	// RVA: 0x6FF440 Offset: 0x6FDE40 VA: 0x1806FF440
	protected void set_CurrentLerp(float value) { }

	// RVA: 0x87F650 Offset: 0x87E050 VA: 0x18087F650 Slot: 8
	protected virtual void Awake() { }

	// RVA: 0x87F700 Offset: 0x87E100 VA: 0x18087F700
	public void SetLerpedTransform(float _lerp) { }

	// RVA: 0x87FA00 Offset: 0x87E400 VA: 0x18087FA00 Slot: 6
	public override void StartClick(RaycastHit hit) { }

	// RVA: 0x87FAE0 Offset: 0x87E4E0 VA: 0x18087FAE0
	public void StopLerp() { }

	// RVA: 0x87FB70 Offset: 0x87E570 VA: 0x18087FB70
	public void .ctor() { }

	[IteratorStateMachine(typeof(SoilChunk.<<StartClick>g__Lerp|12_0>d))]
	[CompilerGenerated]
	// RVA: 0x87FB00 Offset: 0x87E500 VA: 0x18087FB00
	private IEnumerator <StartClick>g__Lerp|12_0() { }
}
