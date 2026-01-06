public sealed class Activator // TypeDefIndex: 3799
{
	// Methods

	// RVA: 0x1C972F0 Offset: 0x1C95CF0 VA: 0x181C972F0
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture) { }

	// RVA: 0x1C97360 Offset: 0x1C95D60 VA: 0x181C97360
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	// RVA: 0x1C975A0 Offset: 0x1C95FA0 VA: 0x181C975A0
	public static object CreateInstance(Type type, object[] args) { }

	// RVA: 0x1C97320 Offset: 0x1C95D20 VA: 0x181C97320
	public static object CreateInstance(Type type, object[] args, object[] activationAttributes) { }

	// RVA: 0x1C975D0 Offset: 0x1C95FD0 VA: 0x181C975D0
	public static object CreateInstance(Type type) { }

	// RVA: 0x1C97350 Offset: 0x1C95D50 VA: 0x181C97350
	public static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x1C97140 Offset: 0x1C95B40 VA: 0x181C97140
	internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBCE00 Offset: 0xDBB800 VA: 0x180DBCE00
	|-Activator.CreateInstance<CoreUnsafeUtils.DefaultKeyGetter<Hash128>>
	|
	|-RVA: 0xDBCAC0 Offset: 0xDBB4C0 VA: 0x180DBCAC0
	|-Activator.CreateInstance<Bounds>
	|-Activator.CreateInstance<BoundsInt>
	|
	|-RVA: 0xDBCC60 Offset: 0xDBB660 VA: 0x180DBCC60
	|-Activator.CreateInstance<Color>
	|-Activator.CreateInstance<Rect>
	|-Activator.CreateInstance<RectInt>
	|-Activator.CreateInstance<Vector4>
	|
	|-RVA: 0xDBD160 Offset: 0xDBBB60 VA: 0x180DBD160
	|-Activator.CreateInstance<int>
	|-Activator.CreateInstance<Int32Enum>
	|
	|-RVA: 0xDBD2F0 Offset: 0xDBBCF0 VA: 0x180DBD2F0
	|-Activator.CreateInstance<object>
	|
	|-RVA: 0xDBD490 Offset: 0xDBBE90 VA: 0x180DBD490
	|-Activator.CreateInstance<Vector2>
	|-Activator.CreateInstance<Vector2Int>
	|
	|-RVA: 0xDBD620 Offset: 0xDBC020 VA: 0x180DBD620
	|-Activator.CreateInstance<Vector3>
	|-Activator.CreateInstance<Vector3Int>
	|
	|-RVA: 0xDBCF90 Offset: 0xDBB990 VA: 0x180DBCF90
	|-Activator.CreateInstance<__Il2CppFullySharedGenericType>
	*/
}
