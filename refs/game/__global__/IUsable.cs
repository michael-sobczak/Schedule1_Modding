public interface IUsable // TypeDefIndex: 1228
{
	// Properties
	public virtual bool IsInUse { get; }
	public virtual bool IsUsedByLocalPlayer { get; }
	public abstract NetworkObject NPCUserObject { get; set; }
	public abstract NetworkObject PlayerUserObject { get; set; }
	public virtual string UserName { get; }

	// Methods

	// RVA: 0x611380 Offset: 0x60FD80 VA: 0x180611380 Slot: 0
	public virtual bool get_IsInUse() { }

	// RVA: 0x611450 Offset: 0x60FE50 VA: 0x180611450 Slot: 1
	public virtual bool get_IsUsedByLocalPlayer() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract NetworkObject get_NPCUserObject();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_NPCUserObject(NetworkObject value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract NetworkObject get_PlayerUserObject();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_PlayerUserObject(NetworkObject value);

	// RVA: 0x611510 Offset: 0x60FF10 VA: 0x180611510 Slot: 6
	public virtual string get_UserName() { }

	// RVA: 0x6112F0 Offset: 0x60FCF0 VA: 0x1806112F0 Slot: 7
	public virtual bool IsInUseByNPC(NPC npc) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetPlayerUser(NetworkObject playerObject);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetNPCUser(NetworkObject playerObject);
}
