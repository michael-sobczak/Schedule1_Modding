public class ProductConsumeAnimation : MonoBehaviour // TypeDefIndex: 2466
{
	// Fields
	[SerializeField]
	[CompilerGenerated]
	private string <ConsumeDescription>k__BackingField; // 0x20
	[CompilerGenerated]
	[SerializeField]
	private float <PrepareDuration>k__BackingField; // 0x28
	[CompilerGenerated]
	[SerializeField]
	private float <EffectsApplyDelay>k__BackingField; // 0x2C
	[FormerlySerializedAs("ConsumeAnimationBool")]
	[SerializeField]
	private string _thirdPersonAnimationBool; // 0x30
	[FormerlySerializedAs("ConsumeAnimationTrigger")]
	[SerializeField]
	private string _thirdPersonAnimationTrigger; // 0x38
	[SerializeField]
	private AvatarEquippable _thirdPersonEquippable; // 0x40
	[Header("References")]
	public AudioSourceController ConsumeSound; // 0x48
	[Header("Events")]
	public UnityEvent onPrepareStart; // 0x50
	public UnityEvent onPrepareCancel; // 0x58
	public UnityEvent onConsume; // 0x60

	// Properties
	public string ConsumeDescription { get; set; }
	public float PrepareDuration { get; set; }
	public float EffectsApplyDelay { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_ConsumeDescription() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_ConsumeDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_PrepareDuration() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	private void set_PrepareDuration(float value) { }

	[CompilerGenerated]
	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_EffectsApplyDelay() { }

	[CompilerGenerated]
	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	private void set_EffectsApplyDelay(float value) { }

	// RVA: 0x892B70 Offset: 0x891570 VA: 0x180892B70
	public void StartPrepare() { }

	// RVA: 0x79B2F0 Offset: 0x799CF0 VA: 0x18079B2F0
	public void CancelPrepare() { }

	// RVA: 0x8928E0 Offset: 0x8912E0 VA: 0x1808928E0
	public void StartConsume() { }

	// RVA: 0x892B90 Offset: 0x891590 VA: 0x180892B90
	public void StopConsume() { }

	// RVA: 0x892CB0 Offset: 0x8916B0 VA: 0x180892CB0
	public void .ctor() { }
}
