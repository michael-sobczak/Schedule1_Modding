public class Alert // TypeDefIndex: 17532
{
	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Properties
	public AlertLevel Level { get; }
	public AlertDescription Description { get; }

	// Methods

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public AlertLevel get_Level() { }

	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	public AlertDescription get_Description() { }

	// RVA: 0x1A6EA40 Offset: 0x1A6D440 VA: 0x181A6EA40
	public void .ctor(AlertDescription description) { }

	// RVA: 0x1A6EAE0 Offset: 0x1A6D4E0 VA: 0x181A6EAE0
	private void inferAlertLevel() { }

	// RVA: 0x1A6E9A0 Offset: 0x1A6D3A0 VA: 0x181A6E9A0 Slot: 3
	public override string ToString() { }
}
