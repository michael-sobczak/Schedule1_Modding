public interface ICombatTargetable : IDamageable, ISightable // TypeDefIndex: 1985
{
	// Properties
	public abstract NetworkObject NetworkObject { get; }
	public virtual Vector3 CenterPoint { get; }
	public abstract Transform CenterPointTransform { get; }
	public abstract Vector3 LookAtPoint { get; }
	public abstract bool IsCurrentlyTargetable { get; }
	public abstract float RangedHitChanceMultiplier { get; }
	public abstract Vector3 Velocity { get; }
	public virtual bool IsPlayer { get; }
	public virtual Player AsPlayer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetworkObject get_NetworkObject();

	// RVA: 0x79C000 Offset: 0x79AA00 VA: 0x18079C000 Slot: 1
	public virtual Vector3 get_CenterPoint() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Transform get_CenterPointTransform();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector3 get_LookAtPoint();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsCurrentlyTargetable();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_RangedHitChanceMultiplier();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Vector3 get_Velocity();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void RecordLastKnownPosition(bool resetTimeSinceLastSeen);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float GetSearchTime();

	// RVA: 0x79C080 Offset: 0x79AA80 VA: 0x18079C080 Slot: 9
	public virtual bool get_IsPlayer() { }

	// RVA: 0x79BF90 Offset: 0x79A990 VA: 0x18079BF90 Slot: 10
	public virtual Player get_AsPlayer() { }

	// RVA: 0x79BEC0 Offset: 0x79A8C0 VA: 0x18079BEC0 Slot: 11
	public virtual bool IsNull() { }
}
