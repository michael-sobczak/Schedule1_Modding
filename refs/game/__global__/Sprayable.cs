public class Sprayable : Draggable // TypeDefIndex: 779
{
	// Fields
	[SerializeField]
	[Header("Sprayable Components")]
	private Transform _sprayOrigin; // 0xC0
	[SerializeField]
	[Header("Gizmos")]
	private bool _drawGizmos; // 0xC8
	public Action _onSuccessfulSpray; // 0xD0
	public UnityEvent onSpray; // 0xD8
	private float _sprayRadius; // 0xE0
	private float _sprayDistance; // 0xE4
	private Vector3 _currentTargetPosition; // 0xE8

	// Methods

	// RVA: 0x596AF0 Offset: 0x5954F0 VA: 0x180596AF0
	public void Initialise(float sprayRadius, float sprayDistance) { }

	// RVA: 0x596F40 Offset: 0x595940 VA: 0x180596F40 Slot: 10
	protected override void Update() { }

	// RVA: 0x596B90 Offset: 0x595590 VA: 0x180596B90
	private void Spray() { }

	// RVA: 0x596B70 Offset: 0x595570 VA: 0x180596B70
	public void SetCurrentTarget(Vector3 position) { }

	// RVA: 0x596A00 Offset: 0x595400 VA: 0x180596A00
	private bool DoesHitTarget(Vector3 rayOrigin, Vector3 rayDirection, Vector3 sphereCenter, float sphereRadius, float maxDistance) { }

	// RVA: 0x596DE0 Offset: 0x5957E0 VA: 0x180596DE0
	public void SubscribeToSuccessfulSpray(Action callback) { }

	// RVA: 0x596E90 Offset: 0x595890 VA: 0x180596E90
	public void UnsubscribeFromSuccessfulSpray(Action callback) { }

	// RVA: 0x596B10 Offset: 0x595510 VA: 0x180596B10
	private void OnDrawGizmos() { }

	// RVA: 0x596FD0 Offset: 0x5959D0 VA: 0x180596FD0
	public void .ctor() { }
}
