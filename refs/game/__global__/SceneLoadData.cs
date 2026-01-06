public class SceneLoadData // TypeDefIndex: 12769
{
	// Fields
	public SceneLookupData PreferredActiveScene; // 0x10
	public SceneLookupData[] SceneLookupDatas; // 0x18
	public NetworkObject[] MovedNetworkObjects; // 0x20
	public ReplaceOption ReplaceScenes; // 0x28
	public LoadParams Params; // 0x30
	public LoadOptions Options; // 0x38

	// Methods

	// RVA: 0xD810C0 Offset: 0xD7FAC0 VA: 0x180D810C0
	public void .ctor() { }

	// RVA: 0xD81430 Offset: 0xD7FE30 VA: 0x180D81430
	public void .ctor(Scene scene) { }

	// RVA: 0xD81EB0 Offset: 0xD808B0 VA: 0x180D81EB0
	public void .ctor(string sceneName) { }

	// RVA: 0xD811C0 Offset: 0xD7FBC0 VA: 0x180D811C0
	public void .ctor(int sceneHandle) { }

	// RVA: 0xD81AB0 Offset: 0xD804B0 VA: 0x180D81AB0
	public void .ctor(int sceneHandle, string sceneName) { }

	// RVA: 0xD818C0 Offset: 0xD802C0 VA: 0x180D818C0
	public void .ctor(SceneLookupData sceneLookupData) { }

	// RVA: 0xD81E40 Offset: 0xD80840 VA: 0x180D81E40
	public void .ctor(List<Scene> scenes) { }

	// RVA: 0xD816D0 Offset: 0xD800D0 VA: 0x180D816D0
	public void .ctor(List<string> sceneNames) { }

	// RVA: 0xD81240 Offset: 0xD7FC40 VA: 0x180D81240
	public void .ctor(List<int> sceneHandles) { }

	// RVA: 0xD81740 Offset: 0xD80140 VA: 0x180D81740
	public void .ctor(Scene[] scenes) { }

	// RVA: 0xD81420 Offset: 0xD7FE20 VA: 0x180D81420
	public void .ctor(string[] sceneNames) { }

	// RVA: 0xD816C0 Offset: 0xD800C0 VA: 0x180D816C0
	public void .ctor(int[] sceneHandles) { }

	// RVA: 0xD81CE0 Offset: 0xD806E0 VA: 0x180D81CE0
	public void .ctor(SceneLookupData[] sceneLookupDatas) { }

	// RVA: 0xD814B0 Offset: 0xD7FEB0 VA: 0x180D814B0
	public void .ctor(Scene scene, NetworkObject[] movedNetworkObjects) { }

	// RVA: 0xD812B0 Offset: 0xD7FCB0 VA: 0x180D812B0
	public void .ctor(Scene[] scenes, NetworkObject[] movedNetworkObjects) { }

	// RVA: 0xD81750 Offset: 0xD80150 VA: 0x180D81750
	public void .ctor(string[] sceneNames, NetworkObject[] movedNetworkObjects) { }

	// RVA: 0xD81F40 Offset: 0xD80940 VA: 0x180D81F40
	public void .ctor(int[] sceneHandles, NetworkObject[] movedNetworkObjects) { }

	// RVA: 0xD81B70 Offset: 0xD80570 VA: 0x180D81B70
	public void .ctor(SceneLookupData[] sceneLookupDatas, NetworkObject[] movedNetworkObjects) { }

	// RVA: 0xD80F60 Offset: 0xD7F960 VA: 0x180D80F60
	private void Construct(SceneLookupData[] datas, NetworkObject[] movedNetworkObjects) { }

	// RVA: 0xD81010 Offset: 0xD7FA10 VA: 0x180D81010
	public Scene GetFirstLookupScene() { }

	// RVA: 0xD80FE0 Offset: 0xD7F9E0 VA: 0x180D80FE0
	internal bool DataInvalid() { }
}
