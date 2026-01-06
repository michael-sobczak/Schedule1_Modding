public class WaterCollider : MonoBehaviour // TypeDefIndex: 3371
{
	// Fields
	private bool localPlayerBeingWarped; // 0x20
	private List<LandVehicle> warpedVehicles; // 0x28
	public AudioSourceController SplashSound; // 0x30
	public Transform OverrideWarpPoint; // 0x38

	// Methods

	// RVA: 0xA60EE0 Offset: 0xA5F8E0 VA: 0x180A60EE0
	private void OnTriggerEnter(Collider other) { }

	[IteratorStateMachine(typeof(WaterCollider.<WarpPlayer>d__5))]
	// RVA: 0xA613D0 Offset: 0xA5FDD0 VA: 0x180A613D0
	private IEnumerator WarpPlayer() { }

	[IteratorStateMachine(typeof(WaterCollider.<WarpVehicle>d__6))]
	// RVA: 0xA61440 Offset: 0xA5FE40 VA: 0x180A61440
	private IEnumerator WarpVehicle(LandVehicle veh) { }

	// RVA: 0xA614D0 Offset: 0xA5FED0 VA: 0x180A614D0
	public void .ctor() { }
}
