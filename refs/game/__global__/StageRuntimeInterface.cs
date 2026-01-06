public class StageRuntimeInterface // TypeDefIndex: 13943
{
	// Fields
	private Func<bool, GameObject> m_AddGameObject; // 0x10
	private Func<Camera> m_GetCamera; // 0x18
	private Func<Light> m_GetSunLight; // 0x20
	public object SRPData; // 0x28

	// Properties
	public Camera camera { get; }
	public Light sunLight { get; }

	// Methods

	// RVA: 0x43EE90 Offset: 0x43D890 VA: 0x18043EE90
	public void .ctor(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight) { }

	// RVA: 0x2A583C0 Offset: 0x2A56DC0 VA: 0x182A583C0
	public GameObject AddGameObject(bool persistent = False) { }

	// RVA: 0x2A583E0 Offset: 0x2A56DE0 VA: 0x182A583E0
	public Camera get_camera() { }

	// RVA: 0x2A58400 Offset: 0x2A56E00 VA: 0x182A58400
	public Light get_sunLight() { }
}
