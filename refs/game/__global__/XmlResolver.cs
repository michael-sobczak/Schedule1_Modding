public abstract class XmlResolver // TypeDefIndex: 8123
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0x253D760 Offset: 0x253C160 VA: 0x18253D760 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x253D950 Offset: 0x253C350 VA: 0x18253D950 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x253D720 Offset: 0x253C120 VA: 0x18253D720 Slot: 7
	public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
