public abstract class BaseVariable // TypeDefIndex: 607
{
	// Fields
	public EVariableReplicationMode ReplicationMode; // 0x10
	public string Name; // 0x18
	public bool Persistent; // 0x20
	public EVariableMode VariableMode; // 0x24
	[CompilerGenerated]
	private Player <Owner>k__BackingField; // 0x28

	// Properties
	public Player Owner { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Player get_Owner() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_Owner(Player value) { }

	// RVA: 0xA95B70 Offset: 0xA94570 VA: 0x180A95B70
	public void .ctor(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetValue();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetValue(object value, bool replicate = True);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ReplicateValue(NetworkConnection conn);

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public virtual bool EvaluateCondition(Condition.EConditionType operation, string value) { }
}
