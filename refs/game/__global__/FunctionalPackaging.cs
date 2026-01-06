public class FunctionalPackaging : Draggable // TypeDefIndex: 2353
{
	// Fields
	[CompilerGenerated]
	private bool <IsSealed>k__BackingField; // 0xC0
	[CompilerGenerated]
	private bool <IsFull>k__BackingField; // 0xC1
	[CompilerGenerated]
	private bool <ReachedOutput>k__BackingField; // 0xC2
	[Header("Settings")]
	public string SealInstruction; // 0xC8
	public bool AutoEnableSealing; // 0xD0
	public float ProductContactTime; // 0xD4
	public float ProductContactMaxVelocity; // 0xD8
	[Header("References")]
	public PackagingDefinition Definition; // 0xE0
	public Transform AlignmentPoint; // 0xE8
	public Transform[] ProductAlignmentPoints; // 0xF0
	public AudioSourceController SealSound; // 0xF8
	protected List<FunctionalProduct> PackedProducts; // 0x100
	public Action onFullyPacked; // 0x108
	public Action onSealed; // 0x110
	public Action onReachOutput; // 0x118
	private PackagingStation station; // 0x120
	private Dictionary<FunctionalProduct, float> productContactTime; // 0x128
	private SmoothedVelocityCalculator VelocityCalculator; // 0x130

	// Properties
	public bool IsSealed { get; set; }
	public bool IsFull { get; set; }
	public bool ReachedOutput { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60
	public bool get_IsSealed() { }

	[CompilerGenerated]
	// RVA: 0x4E8DF0 Offset: 0x4E77F0 VA: 0x1804E8DF0
	protected void set_IsSealed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E8CC0 Offset: 0x4E76C0 VA: 0x1804E8CC0
	public bool get_IsFull() { }

	[CompilerGenerated]
	// RVA: 0x4E8E80 Offset: 0x4E7880 VA: 0x1804E8E80
	protected void set_IsFull(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E8CD0 Offset: 0x4E76D0 VA: 0x1804E8CD0
	public bool get_ReachedOutput() { }

	[CompilerGenerated]
	// RVA: 0x4E8E90 Offset: 0x4E7890 VA: 0x1804E8E90
	protected void set_ReachedOutput(bool value) { }

	// RVA: 0x8591D0 Offset: 0x857BD0 VA: 0x1808591D0 Slot: 14
	public virtual void Initialize(PackagingStation _station, Transform alignment, bool align = True) { }

	// RVA: 0x858830 Offset: 0x857230 VA: 0x180858830
	public void AlignTo(Transform alignment) { }

	// RVA: 0x858D70 Offset: 0x857770 VA: 0x180858D70 Slot: 15
	public virtual void Destroy() { }

	// RVA: 0x858DD0 Offset: 0x8577D0 VA: 0x180858DD0 Slot: 9
	protected override void FixedUpdate() { }

	// RVA: 0x859760 Offset: 0x858160 VA: 0x180859760 Slot: 16
	protected virtual void PackProduct(FunctionalProduct product) { }

	// RVA: 0x859020 Offset: 0x857A20 VA: 0x180859020 Slot: 17
	protected virtual void FullyPacked() { }

	// RVA: 0x8592F0 Offset: 0x857CF0 VA: 0x1808592F0 Slot: 18
	protected virtual void OnTriggerStay(Collider other) { }

	// RVA: 0x77D420 Offset: 0x77BE20 VA: 0x18077D420 Slot: 19
	protected virtual void EnableSealing() { }

	// RVA: 0x859A00 Offset: 0x858400 VA: 0x180859A00 Slot: 20
	public virtual void Seal() { }

	// RVA: 0x859C60 Offset: 0x858660 VA: 0x180859C60
	public void .ctor() { }
}
