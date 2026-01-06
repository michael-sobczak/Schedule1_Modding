public class FlockScare : MonoBehaviour // TypeDefIndex: 77
{
	// Fields
	public LandingSpotController[] landingSpotControllers; // 0x20
	public float scareInterval; // 0x28
	public float distanceToScare; // 0x2C
	public int checkEveryNthLandingSpot; // 0x30
	public int InvokeAmounts; // 0x34
	private int lsc; // 0x38
	private int ls; // 0x3C
	private LandingSpotController currentController; // 0x40

	// Methods

	// RVA: 0x55CDB0 Offset: 0x55B7B0 VA: 0x18055CDB0
	private void CheckProximityToLandingSpots() { }

	// RVA: 0x55D0C0 Offset: 0x55BAC0 VA: 0x18055D0C0
	private void IterateLandingSpots() { }

	// RVA: 0x55CC40 Offset: 0x55B640 VA: 0x18055CC40
	private bool CheckDistanceToLandingSpot(LandingSpotController lc) { }

	// RVA: 0x55D030 Offset: 0x55BA30 VA: 0x18055D030
	private void Invoker() { }

	// RVA: 0x55D1A0 Offset: 0x55BBA0 VA: 0x18055D1A0
	private void OnEnable() { }

	// RVA: 0x55D160 Offset: 0x55BB60 VA: 0x18055D160
	private void OnDisable() { }

	// RVA: 0x55D270 Offset: 0x55BC70 VA: 0x18055D270
	public void .ctor() { }
}
