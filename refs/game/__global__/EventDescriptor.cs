public abstract class EventDescriptor : MemberDescriptor // TypeDefIndex: 9713
{
	// Properties
	public abstract Type EventType { get; }

	// Methods

	// RVA: 0x2668000 Offset: 0x2666A00 VA: 0x182668000
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x2668010 Offset: 0x2666A10 VA: 0x182668010
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Type get_EventType();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void AddEventHandler(object component, Delegate value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void RemoveEventHandler(object component, Delegate value);
}
