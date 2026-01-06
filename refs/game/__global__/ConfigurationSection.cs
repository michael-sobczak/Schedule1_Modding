public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 19406
{
	// Methods

	// RVA: 0x1F79580 Offset: 0x1F77F80 VA: 0x181F79580 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x1F795B0 Offset: 0x1F77FB0 VA: 0x181F795B0 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x1F795E0 Offset: 0x1F77FE0 VA: 0x181F795E0 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x1F79610 Offset: 0x1F78010 VA: 0x181F79610 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }
}
