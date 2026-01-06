public class TaskManager : Singleton<TaskManager> // TypeDefIndex: 782
{
	// Fields
	public Task currentTask; // 0x28
	public AudioSourceController TaskCompleteSound; // 0x30
	public Action<Task> OnTaskStarted; // 0x38

	// Methods

	// RVA: 0x599BA0 Offset: 0x5985A0 VA: 0x180599BA0 Slot: 4
	protected override void Start() { }

	// RVA: 0x599C50 Offset: 0x598650 VA: 0x180599C50 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x599A70 Offset: 0x598470 VA: 0x180599A70
	private void Exit(ExitAction action) { }

	// RVA: 0x599B00 Offset: 0x598500 VA: 0x180599B00 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x599AE0 Offset: 0x5984E0 VA: 0x180599AE0 Slot: 9
	protected virtual void FixedUpdate() { }

	// RVA: 0x599B20 Offset: 0x598520 VA: 0x180599B20
	public void PlayTaskCompleteSound() { }

	// RVA: 0x599B50 Offset: 0x598550 VA: 0x180599B50
	public void StartTask(Task task) { }

	// RVA: 0x599C70 Offset: 0x598670 VA: 0x180599C70
	public void .ctor() { }
}
