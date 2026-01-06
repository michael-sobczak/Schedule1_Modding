public class SceneUnloadData // TypeDefIndex: 12771
{
	// Fields
	public SceneLookupData PreferredActiveScene; // 0x10
	public SceneLookupData[] SceneLookupDatas; // 0x18
	public UnloadParams Params; // 0x20
	public UnloadOptions Options; // 0x28

	// Methods

	// RVA: 0xD8A970 Offset: 0xD89370 VA: 0x180D8A970
	public void .ctor() { }

	// RVA: 0xD8AAA0 Offset: 0xD894A0 VA: 0x180D8AAA0
	public void .ctor(Scene scene) { }

	// RVA: 0xD8A730 Offset: 0xD89130 VA: 0x180D8A730
	public void .ctor(string sceneName) { }

	// RVA: 0xD8A6C0 Offset: 0xD890C0 VA: 0x180D8A6C0
	public void .ctor(int sceneHandle) { }

	// RVA: 0xD8ACF0 Offset: 0xD896F0 VA: 0x180D8ACF0
	public void .ctor(SceneLookupData sceneLookupData) { }

	// RVA: 0xD8A820 Offset: 0xD89220 VA: 0x180D8A820
	public void .ctor(List<Scene> scenes) { }

	// RVA: 0xD8AA40 Offset: 0xD89440 VA: 0x180D8AA40
	public void .ctor(List<string> sceneNames) { }

	// RVA: 0xD8A7C0 Offset: 0xD891C0 VA: 0x180D8A7C0
	public void .ctor(List<int> sceneHandles) { }

	// RVA: 0xD8AB10 Offset: 0xD89510 VA: 0x180D8AB10
	public void .ctor(Scene[] scenes) { }

	// RVA: 0xD8A5D0 Offset: 0xD88FD0 VA: 0x180D8A5D0
	public void .ctor(string[] sceneNames) { }

	// RVA: 0xD8AC00 Offset: 0xD89600 VA: 0x180D8AC00
	public void .ctor(int[] sceneHandles) { }

	// RVA: 0xD8A880 Offset: 0xD89280 VA: 0x180D8A880
	public void .ctor(SceneLookupData[] sceneLookupDatas) { }

	// RVA: 0xD8A5A0 Offset: 0xD88FA0 VA: 0x180D8A5A0
	internal bool DataInvalid() { }
}
