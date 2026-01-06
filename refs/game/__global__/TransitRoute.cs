public class TransitRoute // TypeDefIndex: 1244
{
	// Fields
	[CompilerGenerated]
	private ITransitEntity <Source>k__BackingField; // 0x10
	[CompilerGenerated]
	private ITransitEntity <Destination>k__BackingField; // 0x18
	protected TransitLineVisuals visuals; // 0x20
	public Action<ITransitEntity> onSourceChange; // 0x28
	public Action<ITransitEntity> onDestinationChange; // 0x30

	// Properties
	public ITransitEntity Source { get; set; }
	public ITransitEntity Destination { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ITransitEntity get_Source() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_Source(ITransitEntity value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ITransitEntity get_Destination() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_Destination(ITransitEntity value) { }

	// RVA: 0x623620 Offset: 0x622020 VA: 0x180623620
	public void .ctor(ITransitEntity source, ITransitEntity destination) { }

	// RVA: 0x622F10 Offset: 0x621910 VA: 0x180622F10
	public void Destroy() { }

	// RVA: 0x623150 Offset: 0x621B50 VA: 0x180623150
	public void SetVisualsActive(bool active) { }

	// RVA: 0x623310 Offset: 0x621D10 VA: 0x180623310
	private void Update() { }

	// RVA: 0x623110 Offset: 0x621B10 VA: 0x180623110 Slot: 4
	public virtual void SetSource(ITransitEntity source) { }

	// RVA: 0x622EE0 Offset: 0x6218E0 VA: 0x180622EE0
	public bool AreEntitiesNonNull() { }

	// RVA: 0x6230D0 Offset: 0x621AD0 VA: 0x1806230D0 Slot: 5
	public virtual void SetDestination(ITransitEntity destination) { }

	// RVA: 0x623570 Offset: 0x621F70 VA: 0x180623570
	private void ValidateEntities() { }
}
