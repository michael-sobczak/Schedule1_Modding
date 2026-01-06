public class MenuCommand // TypeDefIndex: 9835
{
	// Fields
	private EventHandler _execHandler; // 0x10
	private int _status; // 0x18
	private IDictionary _properties; // 0x20
	[CompilerGenerated]
	private readonly CommandID <CommandID>k__BackingField; // 0x28

	// Properties
	public virtual IDictionary Properties { get; }
	public virtual CommandID CommandID { get; }

	// Methods

	// RVA: 0x267FF50 Offset: 0x267E950 VA: 0x18267FF50
	public void .ctor(EventHandler handler, CommandID command) { }

	// RVA: 0x267FFB0 Offset: 0x267E9B0 VA: 0x18267FFB0 Slot: 4
	public virtual IDictionary get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 5
	public virtual CommandID get_CommandID() { }

	// RVA: 0x267FE40 Offset: 0x267E840 VA: 0x18267FE40 Slot: 3
	public override string ToString() { }
}
