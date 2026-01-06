public class SlotReel : MonoBehaviour // TypeDefIndex: 2049
{
	// Fields
	[CompilerGenerated]
	private bool <IsSpinning>k__BackingField; // 0x20
	[CompilerGenerated]
	private SlotMachine.ESymbol <CurrentSymbol>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <CurrentRotation>k__BackingField; // 0x28
	[Header("Settings")]
	public SlotReel.SymbolRotation[] SymbolRotations; // 0x30
	public float SpinSpeed; // 0x38
	[Header("References")]
	public AudioSourceController StopSound; // 0x40
	public UnityEvent onStart; // 0x48
	public UnityEvent onStop; // 0x50

	// Properties
	public bool IsSpinning { get; set; }
	public SlotMachine.ESymbol CurrentSymbol { get; set; }
	public float CurrentRotation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsSpinning() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsSpinning(bool value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public SlotMachine.ESymbol get_CurrentSymbol() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	private void set_CurrentSymbol(SlotMachine.ESymbol value) { }

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_CurrentRotation() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	private void set_CurrentRotation(float value) { }

	// RVA: 0x7F08F0 Offset: 0x7EF2F0 VA: 0x1807F08F0
	private void Awake() { }

	// RVA: 0x7F0B60 Offset: 0x7EF560 VA: 0x1807F0B60
	private void Update() { }

	// RVA: 0x7F0AF0 Offset: 0x7EF4F0 VA: 0x1807F0AF0
	public void Spin() { }

	// RVA: 0x7F0B10 Offset: 0x7EF510 VA: 0x1807F0B10
	public void Stop(SlotMachine.ESymbol endSymbol) { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void SetSymbol(SlotMachine.ESymbol symbol) { }

	// RVA: 0x7F0A50 Offset: 0x7EF450 VA: 0x1807F0A50
	private void SetReelRotation(float rotation) { }

	// RVA: 0x7F0940 Offset: 0x7EF340 VA: 0x1807F0940
	private float GetSymbolRotation(SlotMachine.ESymbol symbol) { }

	// RVA: 0x7F0CC0 Offset: 0x7EF6C0 VA: 0x1807F0CC0
	public void .ctor() { }
}
