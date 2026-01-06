public class AvatarSeat : MonoBehaviour // TypeDefIndex: 3146
{
	// Fields
	[CompilerGenerated]
	private NPC <Occupant>k__BackingField; // 0x20
	public Transform SittingPoint; // 0x28
	public Transform AccessPoint; // 0x30

	// Properties
	public bool IsOccupied { get; }
	public NPC Occupant { get; set; }

	// Methods

	// RVA: 0x9B3B20 Offset: 0x9B2520 VA: 0x1809B3B20
	public bool get_IsOccupied() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public NPC get_Occupant() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Occupant(NPC value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x9B3A10 Offset: 0x9B2410 VA: 0x1809B3A10
	public void SetOccupant(NPC npc) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
