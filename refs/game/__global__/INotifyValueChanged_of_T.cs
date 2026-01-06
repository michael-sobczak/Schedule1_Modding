public interface INotifyValueChanged<T> // TypeDefIndex: 6318
{
	// Properties
	public abstract T value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_value();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INotifyValueChanged<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_value(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INotifyValueChanged<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetValueWithoutNotify(T newValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INotifyValueChanged<__Il2CppFullySharedGenericType>.SetValueWithoutNotify
	*/
}
