public class PositionHistoryTracker : MonoBehaviour // TypeDefIndex: 1931
{
	// Fields
	[Tooltip("Frequency (in seconds) to record the position.")]
	public float recordingFrequency; // 0x20
	[Tooltip("Duration (in seconds) to store the position history.")]
	public float historyDuration; // 0x24
	public List<Vector3> positionHistory; // 0x28
	private float lastRecordTime; // 0x30

	// Properties
	public float RecordedTime { get; }

	// Methods

	// RVA: 0x79FCC0 Offset: 0x79E6C0 VA: 0x18079FCC0
	public float get_RecordedTime() { }

	// RVA: 0x79FAC0 Offset: 0x79E4C0 VA: 0x18079FAC0
	private void Start() { }

	// RVA: 0x79FAE0 Offset: 0x79E4E0 VA: 0x18079FAE0
	private void Update() { }

	// RVA: 0x79F9A0 Offset: 0x79E3A0 VA: 0x18079F9A0
	private void RecordPosition() { }

	// RVA: 0x79F8F0 Offset: 0x79E2F0 VA: 0x18079F8F0
	public Vector3 GetPositionXSecondsAgo(float secondsAgo) { }

	// RVA: 0x79F8A0 Offset: 0x79E2A0 VA: 0x18079F8A0
	public void ClearHistory() { }

	// RVA: 0x79FC30 Offset: 0x79E630 VA: 0x18079FC30
	public void .ctor() { }
}
