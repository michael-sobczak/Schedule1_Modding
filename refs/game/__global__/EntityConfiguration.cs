public class EntityConfiguration // TypeDefIndex: 1201
{
	// Fields
	private const int NameCharacterLimit = 28;
	[CompilerGenerated]
	private ConfigurationReplicator <Replicator>k__BackingField; // 0x10
	[CompilerGenerated]
	private IConfigurable <Configurable>k__BackingField; // 0x18
	public List<ConfigField> Fields; // 0x20
	public UnityEvent onChanged; // 0x28
	[CompilerGenerated]
	private bool <IsSelected>k__BackingField; // 0x30
	[CompilerGenerated]
	private StringField <Name>k__BackingField; // 0x38

	// Properties
	public ConfigurationReplicator Replicator { get; set; }
	public IConfigurable Configurable { get; set; }
	public bool IsSelected { get; set; }
	public StringField Name { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ConfigurationReplicator get_Replicator() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_Replicator(ConfigurationReplicator value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IConfigurable get_Configurable() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_Configurable(IConfigurable value) { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IsSelected() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	protected void set_IsSelected(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public StringField get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_Name(StringField value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 4
	public virtual bool AllowRename() { }

	// RVA: 0x5FF790 Offset: 0x5FE190 VA: 0x1805FF790
	public void .ctor(ConfigurationReplicator replicator, IConfigurable configurable, string defaultName) { }

	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	protected void InvokeChanged() { }

	// RVA: 0x5FF740 Offset: 0x5FE140 VA: 0x1805FF740
	public void ReplicateField(ConfigField field, NetworkConnection conn) { }

	// RVA: 0x5FF5A0 Offset: 0x5FDFA0 VA: 0x1805FF5A0
	public void ReplicateAllFields(NetworkConnection conn, bool replicateDefaults = True) { }

	// RVA: 0x5FF4F0 Offset: 0x5FDEF0 VA: 0x1805FF4F0 Slot: 5
	public virtual void Destroy() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void Reset() { }

	// RVA: 0x578DC0 Offset: 0x5777C0 VA: 0x180578DC0 Slot: 7
	public virtual void Selected() { }

	// RVA: 0x5FF4E0 Offset: 0x5FDEE0 VA: 0x1805FF4E0 Slot: 8
	public virtual void Deselected() { }

	// RVA: 0x5FF760 Offset: 0x5FE160 VA: 0x1805FF760 Slot: 9
	public virtual bool ShouldSave() { }

	// RVA: 0x5FF510 Offset: 0x5FDF10 VA: 0x1805FF510 Slot: 10
	public virtual string GetSaveString() { }

	// RVA: -1 Offset: -1
	public T GetField<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82C50 Offset: 0xE81650 VA: 0x180E82C50
	|-EntityConfiguration.GetField<object>
	*/

	[CompilerGenerated]
	// RVA: 0x5CA850 Offset: 0x5C9250 VA: 0x1805CA850
	private void <.ctor>b__20_0(string <p0>) { }
}
