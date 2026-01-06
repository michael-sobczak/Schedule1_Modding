public class ViewmodelAvatar : Singleton<ViewmodelAvatar> // TypeDefIndex: 1357
{
	// Fields
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; // 0x28
	public Avatar ParentAvatar; // 0x30
	public Animator Animator; // 0x38
	public Avatar Avatar; // 0x40
	public Transform RightHandContainer; // 0x48

	// Properties
	public bool IsVisible { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsVisible() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsVisible(bool value) { }

	// RVA: 0x6716B0 Offset: 0x6700B0 VA: 0x1806716B0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x671C30 Offset: 0x670630 VA: 0x180671C30
	public void SetVisibility(bool isVisible) { }

	// RVA: 0x671850 Offset: 0x670250 VA: 0x180671850
	private void LateUpdate() { }

	// RVA: 0x671850 Offset: 0x670250 VA: 0x180671850
	private void ResetHipTransform() { }

	// RVA: 0x671950 Offset: 0x670350 VA: 0x180671950
	public void SetAppearance(AvatarSettings settings) { }

	// RVA: 0x671930 Offset: 0x670330 VA: 0x180671930
	public void SetAnimatorController(RuntimeAnimatorController controller) { }

	// RVA: 0x671B40 Offset: 0x670540 VA: 0x180671B40
	public void SetOffset(Vector3 offset) { }

	// RVA: 0x671B90 Offset: 0x670590 VA: 0x180671B90
	public void SetRotationOffset(Vector3 eulerAngles) { }

	// RVA: 0x671D20 Offset: 0x670720 VA: 0x180671D20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x671CF0 Offset: 0x6706F0 VA: 0x180671CF0
	private void <Awake>b__8_0() { }
}
