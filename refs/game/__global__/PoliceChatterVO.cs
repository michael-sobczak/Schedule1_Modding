public class PoliceChatterVO : VOEmitter // TypeDefIndex: 601
{
	// Fields
	public AudioSourceController StartBeep; // 0x40
	public AudioSourceController StartEndBeep; // 0x48
	public AudioSourceController Static; // 0x50
	private Coroutine chatterRoutine; // 0x58

	// Methods

	// RVA: 0xA9E0C0 Offset: 0xA9CAC0 VA: 0x180A9E0C0 Slot: 5
	public override void Play(EVOLineType lineType) { }

	// RVA: 0xA9E020 Offset: 0xA9CA20 VA: 0x180A9E020
	private void PlayChatter() { }

	// RVA: 0xA9E220 Offset: 0xA9CC20 VA: 0x180A9E220
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(PoliceChatterVO.<<PlayChatter>g__Play|5_0>d))]
	// RVA: 0xA9E1A0 Offset: 0xA9CBA0 VA: 0x180A9E1A0
	private IEnumerator <PlayChatter>g__Play|5_0() { }

	[CompilerGenerated]
	// RVA: 0xA9E170 Offset: 0xA9CB70 VA: 0x180A9E170
	private bool <PlayChatter>b__5_1() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0xA9E210 Offset: 0xA9CC10 VA: 0x180A9E210
	private void <>n__0(EVOLineType lineType) { }
}
