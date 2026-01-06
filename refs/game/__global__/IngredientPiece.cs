public class IngredientPiece : MonoBehaviour // TypeDefIndex: 2423
{
	// Fields
	public const float LIQUID_FRICTION = 100;
	[CompilerGenerated]
	private float <CurrentDissolveAmount>k__BackingField; // 0x20
	[CompilerGenerated]
	private LiquidContainer <CurrentLiquidContainer>k__BackingField; // 0x28
	[Header("References")]
	public Transform ModelContainer; // 0x30
	public ParticleSystem DissolveParticles; // 0x38
	[Header("Settings")]
	public bool DetectLiquid; // 0x40
	public bool DisableInteractionInLiquid; // 0x41
	[Range(0, 2)]
	public float LiquidFrictionMultiplier; // 0x44
	private Draggable draggable; // 0x48
	private float defaultDrag; // 0x50
	private Coroutine dissolveParticleRoutine; // 0x58

	// Properties
	public float CurrentDissolveAmount { get; set; }
	public LiquidContainer CurrentLiquidContainer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_CurrentDissolveAmount() { }

	[CompilerGenerated]
	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	private void set_CurrentDissolveAmount(float value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public LiquidContainer get_CurrentLiquidContainer() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_CurrentLiquidContainer(LiquidContainer value) { }

	// RVA: 0x8727A0 Offset: 0x8711A0 VA: 0x1808727A0
	private void Start() { }

	// RVA: 0x872BB0 Offset: 0x8715B0 VA: 0x180872BB0
	private void Update() { }

	// RVA: 0x872790 Offset: 0x871190 VA: 0x180872790
	private void FixedUpdate() { }

	// RVA: 0x8728A0 Offset: 0x8712A0 VA: 0x1808728A0
	private void UpdateDrag() { }

	// RVA: 0x872440 Offset: 0x870E40 VA: 0x180872440
	private void CheckLiquid() { }

	// RVA: 0x8725D0 Offset: 0x870FD0 VA: 0x1808725D0
	public void DissolveAmount(float amount, bool showParticles = True) { }

	// RVA: 0x872C30 Offset: 0x871630 VA: 0x180872C30
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(IngredientPiece.<<DissolveAmount>g__DissolveParticlesRoutine|22_0>d))]
	// RVA: 0x872830 Offset: 0x871230 VA: 0x180872830
	private IEnumerator <DissolveAmount>g__DissolveParticlesRoutine|22_0() { }
}
