public interface IGUIDRegisterable // TypeDefIndex: 586
{
	// Properties
	public abstract Guid GUID { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Guid get_GUID();

	// RVA: 0xA9DA10 Offset: 0xA9C410 VA: 0x180A9DA10 Slot: 1
	public virtual void SetGUID(string guid) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetGUID(Guid guid);
}
