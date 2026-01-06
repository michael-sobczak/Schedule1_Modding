public interface ICustomTypeDescriptor // TypeDefIndex: 9723
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AttributeCollection GetAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetClassName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetComponentName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TypeConverter GetConverter();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EventDescriptor GetDefaultEvent();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract PropertyDescriptor GetDefaultProperty();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object GetEditor(Type editorBaseType);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract EventDescriptorCollection GetEvents();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract EventDescriptorCollection GetEvents(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract PropertyDescriptorCollection GetProperties();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract object GetPropertyOwner(PropertyDescriptor pd);
}
