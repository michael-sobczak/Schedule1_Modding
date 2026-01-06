public class Quest_SinkOrSwim : Quest // TypeDefIndex: 719
{
	// Fields
	public const int DAYS_TO_COMPLETE = 4;
	public string QuestName; // 0x138
	public int NelsonCallTime; // 0x140
	public Transform LoanSharkVehiclePosition; // 0x148
	public GameObject LoanSharkGraves; // 0x150

	// Methods

	// RVA: 0xAE38E0 Offset: 0xAE22E0 VA: 0x180AE38E0 Slot: 30
	protected override void Awake() { }

	// RVA: 0xAE3FE0 Offset: 0xAE29E0 VA: 0x180AE3FE0 Slot: 31
	protected override void Start() { }

	// RVA: 0xAE2D50 Offset: 0xAE1750 VA: 0x180AE2D50 Slot: 43
	protected override void MinPass() { }

	// RVA: 0xAE3C10 Offset: 0xAE2610 VA: 0x180AE3C10
	private void HourPass() { }

	// RVA: 0xAE3CD0 Offset: 0xAE26D0 VA: 0x180AE3CD0
	private void SleepStart() { }

	// RVA: 0xAE3EE0 Offset: 0xAE28E0 VA: 0x180AE3EE0
	private void SpawnLoanSharkVehicle() { }

	// RVA: 0xAE3920 Offset: 0xAE2320 VA: 0x180AE3920
	private void CheckArrival() { }

	// RVA: 0xAE3C80 Offset: 0xAE2680 VA: 0x180AE3C80 Slot: 40
	public override void SetQuestState(EQuestState state, bool network = True) { }

	// RVA: 0xAE43C0 Offset: 0xAE2DC0 VA: 0x180AE43C0
	private void UpdateName() { }

	// RVA: 0xAE4590 Offset: 0xAE2F90 VA: 0x180AE4590
	public void .ctor() { }
}
