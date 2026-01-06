public abstract class SceneProcessorBase : MonoBehaviour // TypeDefIndex: 12786
{
	// Fields
	protected SceneManager SceneManager; // 0x20
	protected Scene MovedObjectsScene; // 0x28
	protected Scene DelayedDestroyScene; // 0x2C
	protected Scene FallbackActiveScene; // 0x30

	// Methods

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0 Slot: 4
	public virtual void Initialize(SceneManager manager) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void LoadStart(LoadQueueData queueData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void LoadEnd(LoadQueueData queueData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void UnloadStart(LoadQueueData queueData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void UnloadEnd(LoadQueueData queueData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public virtual void UnloadStart(UnloadQueueData queueData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public virtual void UnloadEnd(UnloadQueueData queueData) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void BeginLoadAsync(string sceneName, LoadSceneParameters parameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void BeginUnloadAsync(Scene scene);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool IsPercentComplete();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float GetPercentComplete();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 15
	public virtual void AddLoadedScene(Scene scene) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract List<Scene> GetLoadedScenes();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void ActivateLoadedScenes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IEnumerator AsyncsIsDone();

	// RVA: 0xD8A530 Offset: 0xD88F30 VA: 0x180D8A530 Slot: 19
	public virtual Scene GetMovedObjectsScene() { }

	// RVA: 0xD8A450 Offset: 0xD88E50 VA: 0x180D8A450 Slot: 20
	public virtual Scene GetDelayedDestroyScene() { }

	// RVA: 0xD8A4C0 Offset: 0xD88EC0 VA: 0x180D8A4C0 Slot: 21
	public virtual Scene GetFallbackActiveScene() { }

	// RVA: 0xD8A3C0 Offset: 0xD88DC0 VA: 0x180D8A3C0 Slot: 22
	public virtual Scene FindOrCreateScene(string name) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
