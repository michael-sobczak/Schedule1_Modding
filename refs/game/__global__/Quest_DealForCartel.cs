public class Quest_DealForCartel : Quest // TypeDefIndex: 705
{
	// Fields
	public QuestEntry MainEntry; // 0x138
	public QuestEntry EndTruceEntry; // 0x140
	private CartelDealInfo dealInfo; // 0x148

	// Methods

	// RVA: 0xAE1080 Offset: 0xADFA80 VA: 0x180AE1080
	public void Initialize(CartelDealInfo dealInfo) { }

	// RVA: 0xAE0FB0 Offset: 0xADF9B0 VA: 0x180AE0FB0 Slot: 34
	public override void Begin(bool network = True) { }

	// RVA: 0xAE1360 Offset: 0xADFD60 VA: 0x180AE1360 Slot: 43
	protected override void MinPass() { }

	// RVA: 0xAE1450 Offset: 0xADFE50 VA: 0x180AE1450
	private void UpdateTimingLabel() { }

	// RVA: 0xAE1390 Offset: 0xADFD90 VA: 0x180AE1390
	public void NotifyDealCompleted() { }

	// RVA: 0xAE13F0 Offset: 0xADFDF0 VA: 0x180AE13F0
	public void NotifyTruceEnded() { }

	// RVA: 0xAE1890 Offset: 0xAE0290 VA: 0x180AE1890
	public void .ctor() { }
}
