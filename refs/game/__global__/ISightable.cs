public interface ISightable // TypeDefIndex: 826
{
	// Properties
	public abstract NetworkObject NetworkObject { get; }
	public abstract VisionEvent HighestProgressionEvent { get; set; }
	public abstract EntityVisibility VisibilityComponent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetworkObject get_NetworkObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract VisionEvent get_HighestProgressionEvent();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_HighestProgressionEvent(VisionEvent value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract EntityVisibility get_VisibilityComponent();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsCurrentlySightable();
}
