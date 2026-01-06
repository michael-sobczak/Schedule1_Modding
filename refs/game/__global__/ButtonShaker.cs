public class ButtonShaker // TypeDefIndex: 16870
{
	// Fields
	private const string SHAKE_START_CLASS = "shakeStart";
	private const string SHAKE_STOP_CLASS = "shakeEnd";
	private Button targetButton; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(Button buttonToShake) { }

	[AsyncStateMachine(typeof(ButtonShaker.<ApplyShakeAsync>d__4))]
	// RVA: 0xCC85E0 Offset: 0xCC6FE0 VA: 0x180CC85E0
	public Task ApplyShakeAsync(int msDelayBetweenShakes = 40, int iterations = 2) { }

	[AsyncStateMachine(typeof(ButtonShaker.<shakeOnce>d__5))]
	// RVA: 0xCC86E0 Offset: 0xCC70E0 VA: 0x180CC86E0
	private Task shakeOnce(int msDelayBetweenShakes) { }
}
