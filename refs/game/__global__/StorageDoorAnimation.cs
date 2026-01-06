public class StorageDoorAnimation : MonoBehaviour // TypeDefIndex: 2410
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	private bool overriddeIsOpen; // 0x21
	private bool overrideState; // 0x22
	[Header("Animations")]
	public Animation[] Anims; // 0x28
	public AnimationClip OpenAnim; // 0x30
	public AnimationClip CloseAnim; // 0x38
	public AudioSourceController OpenSound; // 0x40
	public AudioSourceController CloseSound; // 0x48
	private StorageEntity storageEntity; // 0x50
	private Transform itemContainer; // 0x58

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0x8803B0 Offset: 0x87EDB0 VA: 0x1808803B0
	private void Start() { }

	[Button]
	// RVA: 0x880190 Offset: 0x87EB90 VA: 0x180880190
	public void Open() { }

	[Button]
	// RVA: 0x8800E0 Offset: 0x87EAE0 VA: 0x1808800E0
	public void Close() { }

	// RVA: 0x8801B0 Offset: 0x87EBB0 VA: 0x1808801B0
	public void SetIsOpen(bool open) { }

	// RVA: 0x8800F0 Offset: 0x87EAF0 VA: 0x1808800F0
	private void DisableItems() { }

	// RVA: 0x8801A0 Offset: 0x87EBA0 VA: 0x1808801A0
	public void OverrideState(bool open) { }

	// RVA: 0x820C50 Offset: 0x81F650 VA: 0x180820C50
	public void ResetOverride() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
