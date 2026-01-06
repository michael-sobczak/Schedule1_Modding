public class LawManager : Singleton<LawManager> // TypeDefIndex: 1305
{
	// Fields
	public const int DISPATCH_OFFICER_COUNT = 2;
	public static float DISPATCH_VEHICLE_USE_THRESHOLD; // 0x0

	// Methods

	// RVA: 0x614B20 Offset: 0x613520 VA: 0x180614B20 Slot: 4
	protected override void Start() { }

	// RVA: 0x614540 Offset: 0x612F40 VA: 0x180614540
	public void PoliceCalled(Player target, Crime crime) { }

	// RVA: 0x6146E0 Offset: 0x6130E0 VA: 0x1806146E0
	public PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers) { }

	// RVA: 0x614960 Offset: 0x613360 VA: 0x180614960
	public PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route) { }

	// RVA: 0x614CE0 Offset: 0x6136E0 VA: 0x180614CE0
	public void .ctor() { }

	// RVA: 0x614CA0 Offset: 0x6136A0 VA: 0x180614CA0
	private static void .cctor() { }
}
