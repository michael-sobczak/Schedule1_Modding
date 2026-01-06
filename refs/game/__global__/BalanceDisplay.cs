public class BalanceDisplay : MonoBehaviour // TypeDefIndex: 2555
{
	// Fields
	public const float RESIDUAL_TIME = 3;
	public const float FADE_TIME = 0.25;
	[Header("References")]
	public CanvasGroup Group; // 0x20
	public TextMeshProUGUI BalanceLabel; // 0x28
	[CompilerGenerated]
	private bool <active>k__BackingField; // 0x30
	[CompilerGenerated]
	private float <timeSinceActiveSet>k__BackingField; // 0x34

	// Properties
	public bool active { get; set; }
	public float timeSinceActiveSet { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_active() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	protected void set_active(bool value) { }

	[CompilerGenerated]
	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_timeSinceActiveSet() { }

	[CompilerGenerated]
	// RVA: 0x8928D0 Offset: 0x8912D0 VA: 0x1808928D0
	protected void set_timeSinceActiveSet(float value) { }

	// RVA: 0x8AA1C0 Offset: 0x8A8BC0 VA: 0x1808AA1C0 Slot: 4
	protected virtual void Update() { }

	// RVA: 0x8AA160 Offset: 0x8A8B60 VA: 0x1808AA160
	public void SetBalance(float balance) { }

	// RVA: 0x8AA1B0 Offset: 0x8A8BB0 VA: 0x1808AA1B0
	public void Show() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
