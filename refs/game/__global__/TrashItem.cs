public class TrashItem : MonoBehaviour, IGUIDRegisterable, ISaveable // TypeDefIndex: 2248
{
	// Fields
	public const float POSITION_CHANGE_THRESHOLD = 1;
	public const float LINEAR_DRAG = 0.1;
	public const float ANGULAR_DRAG = 0.1;
	public const float MIN_Y = -100;
	public const int INTERACTION_PRIORITY = 5;
	public Rigidbody Rigidbody; // 0x20
	public Draggable Draggable; // 0x28
	[Header("Settings")]
	public string ID; // 0x30
	[Range(0, 5)]
	public int Size; // 0x38
	[Range(0, 10)]
	public int SellValue; // 0x3C
	public bool CanGoInContainer; // 0x40
	public Collider[] colliders; // 0x48
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x50
	[CompilerGenerated]
	private Property <CurrentProperty>k__BackingField; // 0x60
	private Vector3 lastPosition; // 0x68
	public Action<TrashItem> onDestroyed; // 0x78
	private bool collidersEnabled; // 0x80
	private float timeOnPhysicsEnabled; // 0x84
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x88
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x90
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x98

	// Properties
	public Guid GUID { get; set; }
	public Property CurrentProperty { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84E920 Offset: 0x84D320 VA: 0x18084E920 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x84EA10 Offset: 0x84D410 VA: 0x18084EA10
	protected void set_GUID(Guid value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Property get_CurrentProperty() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	protected void set_CurrentProperty(Property value) { }

	// RVA: 0x84E9A0 Offset: 0x84D3A0 VA: 0x18084E9A0 Slot: 7
	public string get_SaveFolderName() { }

	// RVA: 0x84E930 Offset: 0x84D330 VA: 0x18084E930 Slot: 8
	public string get_SaveFileName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080 Slot: 11
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030 Slot: 12
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480 Slot: 13
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510 Slot: 14
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x614460 Offset: 0x612E60 VA: 0x180614460 Slot: 15
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x614500 Offset: 0x612F00 VA: 0x180614500 Slot: 16
	public void set_HasChanged(bool value) { }

	// RVA: 0x84CD00 Offset: 0x84B700 VA: 0x18084CD00
	protected void Awake() { }

	// RVA: 0x84E5E0 Offset: 0x84CFE0 VA: 0x18084E5E0
	protected void Start() { }

	// RVA: 0x84D6A0 Offset: 0x84C0A0 VA: 0x18084D6A0 Slot: 30
	public virtual void InitializeSaveable() { }

	// RVA: 0x84DB10 Offset: 0x84C510 VA: 0x18084DB10
	protected void OnValidate() { }

	// RVA: 0x84D7E0 Offset: 0x84C1E0 VA: 0x18084D7E0
	protected void MinPass() { }

	// RVA: 0x84D590 Offset: 0x84BF90 VA: 0x18084D590
	protected void Hovered() { }

	// RVA: 0x84D730 Offset: 0x84C130 VA: 0x18084D730
	protected void Interacted() { }

	// RVA: 0x84E3F0 Offset: 0x84CDF0 VA: 0x18084E3F0 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0x84E590 Offset: 0x84CF90 VA: 0x18084E590
	public void SetVelocity(Vector3 velocity) { }

	// RVA: 0x84D260 Offset: 0x84BC60 VA: 0x18084D260
	public void DestroyTrash() { }

	// RVA: 0x84D160 Offset: 0x84BB60 VA: 0x18084D160 Slot: 31
	public virtual void Deinitialize() { }

	// RVA: 0x84D9F0 Offset: 0x84C3F0 VA: 0x18084D9F0
	private void OnDestroy() { }

	// RVA: 0x84DCA0 Offset: 0x84C6A0 VA: 0x18084DCA0
	private void RecheckPosition() { }

	// RVA: 0x84D420 Offset: 0x84BE20 VA: 0x18084D420 Slot: 32
	public virtual TrashItemData GetData() { }

	// RVA: 0x84D550 Offset: 0x84BF50 VA: 0x18084D550 Slot: 33
	public virtual string GetSaveString() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 34
	public virtual bool ShouldSave() { }

	// RVA: 0x84DE10 Offset: 0x84C810 VA: 0x18084DE10
	private void RecheckProperty() { }

	// RVA: 0x84E2A0 Offset: 0x84CCA0 VA: 0x18084E2A0
	public void SetContinuousCollisionDetection() { }

	// RVA: 0x84E350 Offset: 0x84CD50 VA: 0x18084E350
	public void SetDiscreteCollisionDetection() { }

	// RVA: 0x84E530 Offset: 0x84CF30 VA: 0x18084E530
	public void SetPhysicsActive(bool active) { }

	// RVA: 0x84E1F0 Offset: 0x84CBF0 VA: 0x18084E1F0
	public void SetCollidersEnabled(bool enabled) { }

	// RVA: 0x84E7F0 Offset: 0x84D1F0 VA: 0x18084E7F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x84E7B0 Offset: 0x84D1B0 VA: 0x18084E7B0
	private void <Awake>b__44_0() { }

	[CompilerGenerated]
	// RVA: 0x84E7C0 Offset: 0x84D1C0 VA: 0x18084E7C0
	private void <Awake>b__44_1(Impact impact) { }
}
