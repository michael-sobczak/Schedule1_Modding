public interface IGenericSaveable // TypeDefIndex: 843
{
	// Properties
	public abstract Guid GUID { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Guid get_GUID();

	// RVA: 0x5A2F90 Offset: 0x5A1990 VA: 0x1805A2F90 Slot: 1
	public virtual void InitializeSaveable() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Load(GenericSaveData data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract GenericSaveData GetSaveData();
}
