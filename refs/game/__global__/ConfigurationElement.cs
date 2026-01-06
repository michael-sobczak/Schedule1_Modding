public abstract class ConfigurationElement // TypeDefIndex: 19405
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1F79550 Offset: 0x1F77F50 VA: 0x181F79550 Slot: 4
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x1F794C0 Offset: 0x1F77EC0 VA: 0x181F794C0 Slot: 5
	protected internal virtual bool IsModified() { }

	// RVA: 0x1F79520 Offset: 0x1F77F20 VA: 0x181F79520 Slot: 6
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x1F794F0 Offset: 0x1F77EF0 VA: 0x181F794F0 Slot: 7
	protected internal virtual void ResetModified() { }
}
