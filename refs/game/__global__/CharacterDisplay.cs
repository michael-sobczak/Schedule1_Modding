public class CharacterDisplay : Singleton<CharacterDisplay> // TypeDefIndex: 2575
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	public CharacterDisplay.SlotAlignmentPoint[] AlignmentPoints; // 0x30
	[Header("References")]
	public Transform Container; // 0x38
	public Avatar ParentAvatar; // 0x40
	public Avatar Avatar; // 0x48
	public Transform AvatarContainer; // 0x50
	private float targetRotation; // 0x58

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsOpen(bool value) { }

	// RVA: 0x8D9B00 Offset: 0x8D8500 VA: 0x1808D9B00 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8D9E70 Offset: 0x8D8870 VA: 0x1808D9E70
	public void SetOpen(bool open) { }

	// RVA: 0x8DA070 Offset: 0x8D8A70 VA: 0x1808DA070
	private void Update() { }

	// RVA: 0x8D9C90 Offset: 0x8D8690 VA: 0x1808D9C90
	public void SetAppearance(AvatarSettings settings) { }

	// RVA: 0x8DA1F0 Offset: 0x8D8BF0 VA: 0x1808DA1F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8DA040 Offset: 0x8D8A40 VA: 0x1808DA040
	private void <Awake>b__11_0() { }
}
