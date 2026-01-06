internal sealed class ReflectEventDescriptor : EventDescriptor // TypeDefIndex: 9747
{
	// Fields
	private Type _type; // 0x60
	private readonly Type _componentClass; // 0x68
	private MethodInfo _addMethod; // 0x70
	private MethodInfo _removeMethod; // 0x78
	private EventInfo _realEvent; // 0x80
	private bool _filledMethods; // 0x88

	// Properties
	public override Type EventType { get; }

	// Methods

	// RVA: 0x2671F90 Offset: 0x2670990 VA: 0x182671F90
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x2671E30 Offset: 0x2670830 VA: 0x182671E30
	public void .ctor(Type componentClass, EventInfo eventInfo) { }

	// RVA: 0x26721A0 Offset: 0x2670BA0 VA: 0x1826721A0
	public void .ctor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x2672290 Offset: 0x2670C90 VA: 0x182672290 Slot: 13
	public override Type get_EventType() { }

	// RVA: 0x2670A30 Offset: 0x266F430 VA: 0x182670A30 Slot: 14
	public override void AddEventHandler(object component, Delegate value) { }

	// RVA: 0x2670EA0 Offset: 0x266F8A0 VA: 0x182670EA0 Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x2670F20 Offset: 0x266F920 VA: 0x182670F20
	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	// RVA: 0x2671210 Offset: 0x266FC10 VA: 0x182671210
	private void FillMethods() { }

	// RVA: 0x2671730 Offset: 0x2670130 VA: 0x182671730
	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

	// RVA: 0x2671A80 Offset: 0x2670480 VA: 0x182671A80 Slot: 15
	public override void RemoveEventHandler(object component, Delegate value) { }
}
