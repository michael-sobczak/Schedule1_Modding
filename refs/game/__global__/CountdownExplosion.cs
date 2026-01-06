public class CountdownExplosion : MonoBehaviour // TypeDefIndex: 3382
{
	// Fields
	public const float COUNTDOWN = 30;
	public const float TICK_SPACING_MAX = 1;
	public const float TICK_SPACING_MIN = 0.1;
	public AudioSourceController TickSound; // 0x20
	private Coroutine countdownRoutine; // 0x28

	// Methods

	// RVA: 0xA63B10 Offset: 0xA62510 VA: 0x180A63B10
	public void Trigger() { }

	// RVA: 0x442290 Offset: 0x440C90 VA: 0x180442290
	public void StopCountdown() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[IteratorStateMachine(typeof(CountdownExplosion.<<Trigger>g__Routine|5_0>d))]
	[CompilerGenerated]
	// RVA: 0xA63C10 Offset: 0xA62610 VA: 0x180A63C10
	private IEnumerator <Trigger>g__Routine|5_0() { }
}
