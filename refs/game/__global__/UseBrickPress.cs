public class UseBrickPress : Task // TypeDefIndex: 808
{
	// Fields
	public const float PRODUCT_SCALE = 0.75;
	[CompilerGenerated]
	private string <TaskName>k__BackingField; // 0xA0
	protected UseBrickPress.EStep currentStep; // 0xA8
	protected BrickPress press; // 0xB0
	protected ProductItemInstance product; // 0xB8
	protected List<FunctionalProduct> products; // 0xC0
	protected Draggable container; // 0xC8

	// Properties
	public override string TaskName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 4
	public override string get_TaskName() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00 Slot: 5
	protected override void set_TaskName(string value) { }

	// RVA: 0x5B1000 Offset: 0x5AFA00 VA: 0x1805B1000
	public void .ctor(BrickPress _press, ProductItemInstance _product) { }

	// RVA: 0x5B0FA0 Offset: 0x5AF9A0 VA: 0x1805B0FA0 Slot: 9
	public override void Update() { }

	// RVA: 0x5B0AA0 Offset: 0x5AF4A0 VA: 0x1805B0AA0 Slot: 6
	public override void StopTask() { }

	// RVA: 0x5B07C0 Offset: 0x5AF1C0 VA: 0x1805B07C0
	private void CheckMould() { }

	// RVA: 0x5B04E0 Offset: 0x5AEEE0 VA: 0x1805B04E0
	private void BeginPress() { }

	// RVA: 0x5B0890 Offset: 0x5AF290 VA: 0x1805B0890
	private void FinishPress() { }

	[IteratorStateMachine(typeof(UseBrickPress.<<-ctor>g__CheckMould|11_0>d))]
	[CompilerGenerated]
	// RVA: 0x5B0F30 Offset: 0x5AF930 VA: 0x1805B0F30
	private IEnumerator <.ctor>g__CheckMould|11_0() { }

	[IteratorStateMachine(typeof(UseBrickPress.<<FinishPress>g__Wait|16_0>d))]
	[CompilerGenerated]
	// RVA: 0x5B0EC0 Offset: 0x5AF8C0 VA: 0x1805B0EC0
	private IEnumerator <FinishPress>g__Wait|16_0() { }
}
