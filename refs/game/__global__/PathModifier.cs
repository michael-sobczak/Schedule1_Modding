public abstract class PathModifier : IPathModifier // TypeDefIndex: 13288
{
	// Fields
	public Seeker seeker; // 0x10

	// Properties
	public abstract int Order { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Order();

	// RVA: 0xB6F0F0 Offset: 0xB6DAF0 VA: 0x180B6F0F0
	public void Awake(Seeker seeker) { }

	// RVA: 0xB6F180 Offset: 0xB6DB80 VA: 0x180B6F180
	public void OnDestroy(Seeker seeker) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void PreProcess(Path path) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Apply(Path path);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
