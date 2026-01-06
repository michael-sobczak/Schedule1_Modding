public class PlayerEnergy : MonoBehaviour // TypeDefIndex: 1343
{
	// Fields
	public const float CRITICAL_THRESHOLD = 20;
	public const float MAX_ENERGY = 100;
	public const float SPRINT_DRAIN_MULTIPLIER = 1.3;
	[CompilerGenerated]
	private float <CurrentEnergy>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <EnergyDrinksConsumed>k__BackingField; // 0x24
	public bool DEBUG_DISABLE_ENERGY; // 0x28
	[Header("Settings")]
	public float EnergyDuration_Hours; // 0x2C
	public float EnergyRechargeTime_Hours; // 0x30
	public UnityEvent onEnergyChanged; // 0x38
	public UnityEvent onEnergyDepleted; // 0x40

	// Properties
	public float CurrentEnergy { get; set; }
	public int EnergyDrinksConsumed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_CurrentEnergy() { }

	[CompilerGenerated]
	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	protected void set_CurrentEnergy(float value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_EnergyDrinksConsumed() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	protected void set_EnergyDrinksConsumed(int value) { }

	// RVA: 0x653DE0 Offset: 0x6527E0 VA: 0x180653DE0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x653CC0 Offset: 0x6526C0 VA: 0x180653CC0
	private void MinPass() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ChangeEnergy(float change) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SetEnergy(float newEnergy) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void RestoreEnergy() { }

	// RVA: 0x653DD0 Offset: 0x6527D0 VA: 0x180653DD0
	private void SleepEnd() { }

	// RVA: 0x653CB0 Offset: 0x6526B0 VA: 0x180653CB0
	public void IncrementEnergyDrinks() { }

	// RVA: 0x653DD0 Offset: 0x6527D0 VA: 0x180653DD0
	private void ResetEnergyDrinks() { }

	// RVA: 0x654000 Offset: 0x652A00 VA: 0x180654000
	public void .ctor() { }
}
