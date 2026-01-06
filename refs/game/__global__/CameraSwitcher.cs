public class CameraSwitcher : MonoBehaviour // TypeDefIndex: 13552
{
	// Fields
	public Camera[] m_Cameras; // 0x20
	private int m_CurrentCameraIndex; // 0x28
	private Camera m_OriginalCamera; // 0x30
	private Vector3 m_OriginalCameraPosition; // 0x38
	private Quaternion m_OriginalCameraRotation; // 0x44
	private Camera m_CurrentCamera; // 0x58
	private GUIContent[] m_CameraNames; // 0x60
	private int[] m_CameraIndices; // 0x68
	private DebugUI.EnumField m_DebugEntry; // 0x70
	private int m_DebugEntryEnumIndex; // 0x78

	// Methods

	// RVA: 0x29E5270 Offset: 0x29E3C70 VA: 0x1829E5270
	private void OnEnable() { }

	// RVA: 0x29E51D0 Offset: 0x29E3BD0 VA: 0x1829E51D0
	private void OnDisable() { }

	// RVA: 0x29E5160 Offset: 0x29E3B60 VA: 0x1829E5160
	private int GetCameraCount() { }

	// RVA: 0x29E5180 Offset: 0x29E3B80 VA: 0x1829E5180
	private Camera GetNextCamera() { }

	// RVA: 0x29E5990 Offset: 0x29E4390 VA: 0x1829E5990
	private void SetCameraIndex(int index) { }

	// RVA: 0x29E5C80 Offset: 0x29E4680 VA: 0x1829E5C80
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	private int <OnEnable>b__10_0() { }

	[CompilerGenerated]
	// RVA: 0x29E5C70 Offset: 0x29E4670 VA: 0x1829E5C70
	private void <OnEnable>b__10_1(int value) { }

	[CompilerGenerated]
	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	private int <OnEnable>b__10_2() { }

	[CompilerGenerated]
	// RVA: 0x96CF20 Offset: 0x96B920 VA: 0x18096CF20
	private void <OnEnable>b__10_3(int value) { }
}
