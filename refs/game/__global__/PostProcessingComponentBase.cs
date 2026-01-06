public abstract class PostProcessingComponentBase // TypeDefIndex: 212
{
	// Fields
	public PostProcessingContext context; // 0x10

	// Properties
	public abstract bool active { get; }

	// Methods

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	public virtual DepthTextureMode GetCameraFlags() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_active();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void OnEnable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract PostProcessingModel GetModel();

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
