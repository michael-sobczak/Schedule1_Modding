public class SoapAttribute : Attribute // TypeDefIndex: 4355
{
	// Fields
	private bool _useAttribute; // 0x10
	protected string ProtXmlNamespace; // 0x18
	protected object ReflectInfo; // 0x20

	// Properties
	public virtual bool UseAttribute { get; }
	public virtual string XmlNamespace { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40 Slot: 7
	public virtual bool get_UseAttribute() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public virtual string get_XmlNamespace() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0 Slot: 9
	internal virtual void SetReflectionObject(object reflectionObject) { }
}
