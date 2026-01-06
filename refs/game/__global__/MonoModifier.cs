public abstract class MonoModifier : VersionedMonoBehaviour, IPathModifier // TypeDefIndex: 13289
{
	// Fields
	public Seeker seeker; // 0x28

	// Properties
	public abstract int Order { get; }

	// Methods

	// RVA: 0xB683B0 Offset: 0xB66DB0 VA: 0x180B683B0 Slot: 13
	protected virtual void OnEnable() { }

	// RVA: 0xB68330 Offset: 0xB66D30 VA: 0x180B68330 Slot: 14
	protected virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int get_Order();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	public virtual void PreProcess(Path path) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Apply(Path path);

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
