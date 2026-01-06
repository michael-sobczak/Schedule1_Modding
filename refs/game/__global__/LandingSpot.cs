public class LandingSpot : MonoBehaviour // TypeDefIndex: 81
{
	// Fields
	[HideInInspector]
	public FlockChild landingChild; // 0x20
	[HideInInspector]
	public bool landing; // 0x28
	private int lerpCounter; // 0x2C
	[HideInInspector]
	public LandingSpotController _controller; // 0x30
	private bool _idle; // 0x38
	public Transform _thisT; // 0x40
	public bool _gotcha; // 0x48

	// Methods

	// RVA: 0x5618E0 Offset: 0x5602E0 VA: 0x1805618E0
	public void Start() { }

	// RVA: 0x560CC0 Offset: 0x55F6C0 VA: 0x180560CC0
	public void OnDrawGizmos() { }

	// RVA: 0x5603B0 Offset: 0x55EDB0 VA: 0x1805603B0
	public void LateUpdate() { }

	// RVA: 0x561A00 Offset: 0x560400 VA: 0x180561A00
	public void StraightenBird() { }

	// RVA: 0x5615D0 Offset: 0x55FFD0 VA: 0x1805615D0
	public void RotateBird() { }

	[IteratorStateMachine(typeof(LandingSpot.<GetFlockChild>d__12))]
	// RVA: 0x55FF00 Offset: 0x55E900 VA: 0x18055FF00
	public IEnumerator GetFlockChild(float minDelay, float maxDelay) { }

	// RVA: 0x55FF90 Offset: 0x55E990 VA: 0x18055FF90
	public void InstantLand() { }

	// RVA: 0x561260 Offset: 0x55FC60 VA: 0x180561260
	public void ReleaseFlockChild() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
