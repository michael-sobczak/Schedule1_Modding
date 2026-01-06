public interface IValueField<T> // TypeDefIndex: 6418
{
	// Properties
	public abstract T value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_value();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueField<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_value(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueField<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueField<__Il2CppFullySharedGenericType>.ApplyInputDeviceDelta
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void StartDragging();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueField<__Il2CppFullySharedGenericType>.StartDragging
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void StopDragging();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueField<__Il2CppFullySharedGenericType>.StopDragging
	*/
}
