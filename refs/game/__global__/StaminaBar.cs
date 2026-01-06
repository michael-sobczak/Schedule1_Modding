public class StaminaBar : MonoBehaviour // TypeDefIndex: 2685
{
	// Fields
	public const float StaminaShowTime = 1.5;
	public const float StaminaFadeTime = 0.5;
	[Header("References")]
	public Slider[] Sliders; // 0x20
	public CanvasGroup Group; // 0x28
	private Coroutine routine; // 0x30

	// Methods

	// RVA: 0x903510 Offset: 0x901F10 VA: 0x180903510
	private void Awake() { }

	// RVA: 0x903660 Offset: 0x902060 VA: 0x180903660
	private void PlayerSpawned() { }

	// RVA: 0x903820 Offset: 0x902220 VA: 0x180903820
	private void UpdateStaminaBar(float change) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[IteratorStateMachine(typeof(StaminaBar.<<UpdateStaminaBar>g__Routine|7_0>d))]
	[CompilerGenerated]
	// RVA: 0x9037B0 Offset: 0x9021B0 VA: 0x1809037B0
	private IEnumerator <UpdateStaminaBar>g__Routine|7_0() { }
}
