public interface IComNativeDescriptorHandler // TypeDefIndex: 9722
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AttributeCollection GetAttributes(object component);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetClassName(object component);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TypeConverter GetConverter(object component);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract EventDescriptor GetDefaultEvent(object component);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract PropertyDescriptor GetDefaultProperty(object component);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object GetEditor(object component, Type baseEditorType);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract EventDescriptorCollection GetEvents(object component);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract EventDescriptorCollection GetEvents(object component, Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);
}
