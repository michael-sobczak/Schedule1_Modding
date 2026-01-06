public class FrameTimingsHUDDisplay : MonoBehaviour // TypeDefIndex: 12
{
	// Fields
	private GUIStyle m_Style; // 0x20
	private readonly FrameTiming[] m_FrameTimings; // 0x28
	public const int SAMPLE_SIZE = 200;
	public List<FrameTimingsHUDDisplay.FrameTimingPoint> frameTimingsHistory; // 0x30

	// Methods

	// RVA: 0x55D3E0 Offset: 0x55BDE0 VA: 0x18055D3E0
	private void Awake() { }

	// RVA: 0x55D4D0 Offset: 0x55BED0 VA: 0x18055D4D0
	private void OnGUI() { }

	// RVA: 0x55D490 Offset: 0x55BE90 VA: 0x18055D490
	private void CaptureTimings() { }

	// RVA: 0x55D9D0 Offset: 0x55C3D0 VA: 0x18055D9D0
	public void .ctor() { }
}
