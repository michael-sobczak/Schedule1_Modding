public interface IVolume // TypeDefIndex: 13882
{
	// Properties
	public abstract bool isGlobal { get; set; }
	public abstract List<Collider> colliders { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isGlobal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_isGlobal(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<Collider> get_colliders();
}
