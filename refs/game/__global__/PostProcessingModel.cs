public abstract class PostProcessingModel // TypeDefIndex: 217
{
	// Fields
	[SerializeField]
	[GetSet("enabled")]
	private bool m_Enabled; // 0x10

	// Properties
	public bool enabled { get; set; }

	// Methods

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_enabled() { }

	// RVA: 0x69F000 Offset: 0x69DA00 VA: 0x18069F000
	public void set_enabled(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Reset();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void OnValidate() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
