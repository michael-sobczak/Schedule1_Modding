public class DefaultSceneProcessor : SceneProcessorBase // TypeDefIndex: 12758
{
	// Fields
	protected List<AsyncOperation> LoadingAsyncOperations; // 0x38
	protected List<Scene> Scenes; // 0x40
	protected AsyncOperation CurrentAsyncOperation; // 0x48

	// Methods

	// RVA: 0xD59DA0 Offset: 0xD587A0 VA: 0x180D59DA0 Slot: 5
	public override void LoadStart(LoadQueueData queueData) { }

	// RVA: 0xD59DA0 Offset: 0xD587A0 VA: 0x180D59DA0 Slot: 6
	public override void LoadEnd(LoadQueueData queueData) { }

	// RVA: 0xD59DC0 Offset: 0xD587C0 VA: 0x180D59DC0
	private void ResetValues() { }

	// RVA: 0xD59E40 Offset: 0xD58840 VA: 0x180D59E40 Slot: 9
	public override void UnloadStart(UnloadQueueData queueData) { }

	// RVA: 0xD59BD0 Offset: 0xD585D0 VA: 0x180D59BD0 Slot: 11
	public override void BeginLoadAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0xD59CE0 Offset: 0xD586E0 VA: 0x180D59CE0 Slot: 12
	public override void BeginUnloadAsync(Scene scene) { }

	// RVA: 0xD59D70 Offset: 0xD58770 VA: 0x180D59D70 Slot: 13
	public override bool IsPercentComplete() { }

	// RVA: 0xD59D50 Offset: 0xD58750 VA: 0x180D59D50 Slot: 14
	public override float GetPercentComplete() { }

	// RVA: 0xD59AB0 Offset: 0xD584B0 VA: 0x180D59AB0 Slot: 15
	public override void AddLoadedScene(Scene scene) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 16
	public override List<Scene> GetLoadedScenes() { }

	// RVA: 0xD59950 Offset: 0xD58350 VA: 0x180D59950 Slot: 17
	public override void ActivateLoadedScenes() { }

	[IteratorStateMachine(typeof(DefaultSceneProcessor.<AsyncsIsDone>d__14))]
	// RVA: 0xD59B60 Offset: 0xD58560 VA: 0x180D59B60 Slot: 18
	public override IEnumerator AsyncsIsDone() { }

	// RVA: 0xD59EA0 Offset: 0xD588A0 VA: 0x180D59EA0
	public void .ctor() { }
}
