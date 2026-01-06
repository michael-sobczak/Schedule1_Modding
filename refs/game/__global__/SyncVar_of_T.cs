public class SyncVar<T> : SyncBase // TypeDefIndex: 12646
{
	// Fields
	[CompilerGenerated]
	private Action<T, T, bool> OnChange; // 0x0
	private Nullable<SyncVar.CachedOnChange<T>> _serverOnChange; // 0x0
	private Nullable<SyncVar.CachedOnChange<T>> _clientOnChange; // 0x0
	private T _initialValue; // 0x0
	private T _previousClientValue; // 0x0
	private T _value; // 0x0

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_OnChange(Action<T, T, bool> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3940 Offset: 0x11F2340 VA: 0x1811F3940
	|-SyncVar<bool>.add_OnChange
	|-SyncVar<int>.add_OnChange
	|-SyncVar<Int32Enum>.add_OnChange
	|-SyncVar<object>.add_OnChange
	|-SyncVar<Quaternion>.add_OnChange
	|-SyncVar<float>.add_OnChange
	|-SyncVar<Vector3>.add_OnChange
	|
	|-RVA: 0x12094D0 Offset: 0x1207ED0 VA: 0x1812094D0
	|-SyncVar<__Il2CppFullySharedGenericType>.add_OnChange
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_OnChange(Action<T, T, bool> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3A60 Offset: 0x11F2460 VA: 0x1811F3A60
	|-SyncVar<bool>.remove_OnChange
	|-SyncVar<int>.remove_OnChange
	|-SyncVar<Int32Enum>.remove_OnChange
	|-SyncVar<object>.remove_OnChange
	|-SyncVar<Quaternion>.remove_OnChange
	|-SyncVar<float>.remove_OnChange
	|-SyncVar<Vector3>.remove_OnChange
	|
	|-RVA: 0x12095D0 Offset: 0x1207FD0 VA: 0x1812095D0
	|-SyncVar<__Il2CppFullySharedGenericType>.remove_OnChange
	*/

	// RVA: -1 Offset: -1
	public void .ctor(NetworkBehaviour nb, uint syncIndex, WritePermission writePermission, ReadPermission readPermission, float sendRate, Channel channel, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1209430 Offset: 0x1207E30 VA: 0x181209430
	|-SyncVar<bool>..ctor
	|
	|-RVA: 0x1209300 Offset: 0x1207D00 VA: 0x181209300
	|-SyncVar<int>..ctor
	|-SyncVar<Int32Enum>..ctor
	|
	|-RVA: 0x1208F80 Offset: 0x1207980 VA: 0x181208F80
	|-SyncVar<object>..ctor
	|
	|-RVA: 0x1209390 Offset: 0x1207D90 VA: 0x181209390
	|-SyncVar<Quaternion>..ctor
	|
	|-RVA: 0x1209260 Offset: 0x1207C60 VA: 0x181209260
	|-SyncVar<float>..ctor
	|
	|-RVA: 0x12091A0 Offset: 0x1207BA0 VA: 0x1812091A0
	|-SyncVar<Vector3>..ctor
	|
	|-RVA: 0x1209060 Offset: 0x1207A60 VA: 0x181209060
	|-SyncVar<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Registered() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1206630 Offset: 0x1205030 VA: 0x181206630
	|-SyncVar<bool>.Registered
	|
	|-RVA: 0x12064E0 Offset: 0x1204EE0 VA: 0x1812064E0
	|-SyncVar<int>.Registered
	|-SyncVar<Int32Enum>.Registered
	|-SyncVar<float>.Registered
	|
	|-RVA: 0x1206690 Offset: 0x1205090 VA: 0x181206690
	|-SyncVar<object>.Registered
	|
	|-RVA: 0x1206660 Offset: 0x1205060 VA: 0x181206660
	|-SyncVar<Quaternion>.Registered
	|
	|-RVA: 0x1206510 Offset: 0x1204F10 VA: 0x181206510
	|-SyncVar<Vector3>.Registered
	|
	|-RVA: 0x1206550 Offset: 0x1204F50 VA: 0x181206550
	|-SyncVar<__Il2CppFullySharedGenericType>.Registered
	*/

	// RVA: -1 Offset: -1
	private void SetInitialValues(T next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1206B70 Offset: 0x1205570 VA: 0x181206B70
	|-SyncVar<bool>.SetInitialValues
	|
	|-RVA: 0x1206990 Offset: 0x1205390 VA: 0x181206990
	|-SyncVar<int>.SetInitialValues
	|-SyncVar<Int32Enum>.SetInitialValues
	|
	|-RVA: 0x1206AF0 Offset: 0x12054F0 VA: 0x181206AF0
	|-SyncVar<object>.SetInitialValues
	|
	|-RVA: 0x1206B50 Offset: 0x1205550 VA: 0x181206B50
	|-SyncVar<Quaternion>.SetInitialValues
	|
	|-RVA: 0x1206980 Offset: 0x1205380 VA: 0x181206980
	|-SyncVar<float>.SetInitialValues
	|
	|-RVA: 0x1206B80 Offset: 0x1205580 VA: 0x181206B80
	|-SyncVar<Vector3>.SetInitialValues
	|
	|-RVA: 0x12069A0 Offset: 0x12053A0 VA: 0x1812069A0
	|-SyncVar<__Il2CppFullySharedGenericType>.SetInitialValues
	*/

	// RVA: -1 Offset: -1
	private void UpdateValues(T next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12086B0 Offset: 0x12070B0 VA: 0x1812086B0
	|-SyncVar<bool>.UpdateValues
	|
	|-RVA: 0x12084E0 Offset: 0x1206EE0 VA: 0x1812084E0
	|-SyncVar<int>.UpdateValues
	|-SyncVar<Int32Enum>.UpdateValues
	|
	|-RVA: 0x12084F0 Offset: 0x1206EF0 VA: 0x1812084F0
	|-SyncVar<object>.UpdateValues
	|
	|-RVA: 0x12084B0 Offset: 0x1206EB0 VA: 0x1812084B0
	|-SyncVar<Quaternion>.UpdateValues
	|
	|-RVA: 0x12084D0 Offset: 0x1206ED0 VA: 0x1812084D0
	|-SyncVar<float>.UpdateValues
	|
	|-RVA: 0x1208680 Offset: 0x1207080 VA: 0x181208680
	|-SyncVar<Vector3>.UpdateValues
	|
	|-RVA: 0x1208540 Offset: 0x1206F40 VA: 0x181208540
	|-SyncVar<__Il2CppFullySharedGenericType>.UpdateValues
	*/

	// RVA: -1 Offset: -1
	public void SetValue(T nextValue, bool calledByUser) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1207740 Offset: 0x1206140 VA: 0x181207740
	|-SyncVar<bool>.SetValue
	|
	|-RVA: 0x1207940 Offset: 0x1206340 VA: 0x181207940
	|-SyncVar<int>.SetValue
	|
	|-RVA: 0x1207B30 Offset: 0x1206530 VA: 0x181207B30
	|-SyncVar<Int32Enum>.SetValue
	|
	|-RVA: 0x12074F0 Offset: 0x1205EF0 VA: 0x1812074F0
	|-SyncVar<object>.SetValue
	|
	|-RVA: 0x1208020 Offset: 0x1206A20 VA: 0x181208020
	|-SyncVar<Quaternion>.SetValue
	|
	|-RVA: 0x1208280 Offset: 0x1206C80 VA: 0x181208280
	|-SyncVar<float>.SetValue
	|
	|-RVA: 0x1207D20 Offset: 0x1206720 VA: 0x181207D20
	|-SyncVar<Vector3>.SetValue
	|
	|-RVA: 0x1206BC0 Offset: 0x12055C0 VA: 0x181206BC0
	|-SyncVar<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1
	private void InvokeOnChange(T prev, T next, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1205210 Offset: 0x1203C10 VA: 0x181205210
	|-SyncVar<bool>.InvokeOnChange
	|
	|-RVA: 0x1204C90 Offset: 0x1203690 VA: 0x181204C90
	|-SyncVar<int>.InvokeOnChange
	|-SyncVar<Int32Enum>.InvokeOnChange
	|
	|-RVA: 0x1204890 Offset: 0x1203290 VA: 0x181204890
	|-SyncVar<object>.InvokeOnChange
	|
	|-RVA: 0x1204A60 Offset: 0x1203460 VA: 0x181204A60
	|-SyncVar<Quaternion>.InvokeOnChange
	|
	|-RVA: 0x1204E10 Offset: 0x1203810 VA: 0x181204E10
	|-SyncVar<float>.InvokeOnChange
	|
	|-RVA: 0x1204F90 Offset: 0x1203990 VA: 0x181204F90
	|-SyncVar<Vector3>.InvokeOnChange
	|
	|-RVA: 0x1205380 Offset: 0x1203D80 VA: 0x181205380
	|-SyncVar<__Il2CppFullySharedGenericType>.InvokeOnChange
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override void OnStartCallback(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1205DE0 Offset: 0x12047E0 VA: 0x181205DE0
	|-SyncVar<bool>.OnStartCallback
	|
	|-RVA: 0x12063D0 Offset: 0x1204DD0 VA: 0x1812063D0
	|-SyncVar<int>.OnStartCallback
	|-SyncVar<Int32Enum>.OnStartCallback
	|
	|-RVA: 0x1205CC0 Offset: 0x12046C0 VA: 0x181205CC0
	|-SyncVar<object>.OnStartCallback
	|
	|-RVA: 0x1205A10 Offset: 0x1204410 VA: 0x181205A10
	|-SyncVar<Quaternion>.OnStartCallback
	|
	|-RVA: 0x1205EF0 Offset: 0x12048F0 VA: 0x181205EF0
	|-SyncVar<float>.OnStartCallback
	|
	|-RVA: 0x1205B60 Offset: 0x1204560 VA: 0x181205B60
	|-SyncVar<Vector3>.OnStartCallback
	|
	|-RVA: 0x1206000 Offset: 0x1204A00 VA: 0x181206000
	|-SyncVar<__Il2CppFullySharedGenericType>.OnStartCallback
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override void WriteDelta(PooledWriter writer, bool resetSyncTick = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1208730 Offset: 0x1207130 VA: 0x181208730
	|-SyncVar<bool>.WriteDelta
	|
	|-RVA: 0x1208930 Offset: 0x1207330 VA: 0x181208930
	|-SyncVar<int>.WriteDelta
	|
	|-RVA: 0x1208AB0 Offset: 0x12074B0 VA: 0x181208AB0
	|-SyncVar<Int32Enum>.WriteDelta
	|
	|-RVA: 0x12086C0 Offset: 0x12070C0 VA: 0x1812086C0
	|-SyncVar<object>.WriteDelta
	|
	|-RVA: 0x12089A0 Offset: 0x12073A0 VA: 0x1812089A0
	|-SyncVar<Quaternion>.WriteDelta
	|
	|-RVA: 0x12088C0 Offset: 0x12072C0 VA: 0x1812088C0
	|-SyncVar<float>.WriteDelta
	|
	|-RVA: 0x1208A20 Offset: 0x1207420 VA: 0x181208A20
	|-SyncVar<Vector3>.WriteDelta
	|
	|-RVA: 0x12087A0 Offset: 0x12071A0 VA: 0x1812087A0
	|-SyncVar<__Il2CppFullySharedGenericType>.WriteDelta
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override void WriteFull(PooledWriter obj0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1208BE0 Offset: 0x12075E0 VA: 0x181208BE0
	|-SyncVar<bool>.WriteFull
	|
	|-RVA: 0x1208B80 Offset: 0x1207580 VA: 0x181208B80
	|-SyncVar<int>.WriteFull
	|
	|-RVA: 0x1208B20 Offset: 0x1207520 VA: 0x181208B20
	|-SyncVar<Int32Enum>.WriteFull
	|
	|-RVA: 0x1208F20 Offset: 0x1207920 VA: 0x181208F20
	|-SyncVar<object>.WriteFull
	|
	|-RVA: 0x1208E10 Offset: 0x1207810 VA: 0x181208E10
	|-SyncVar<Quaternion>.WriteFull
	|
	|-RVA: 0x1208C40 Offset: 0x1207640 VA: 0x181208C40
	|-SyncVar<float>.WriteFull
	|
	|-RVA: 0x1208E90 Offset: 0x1207890 VA: 0x181208E90
	|-SyncVar<Vector3>.WriteFull
	|
	|-RVA: 0x1208CA0 Offset: 0x12076A0 VA: 0x181208CA0
	|-SyncVar<__Il2CppFullySharedGenericType>.WriteFull
	*/

	// RVA: -1 Offset: -1
	public T GetValue(bool calledByUser) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1204760 Offset: 0x1203160 VA: 0x181204760
	|-SyncVar<bool>.GetValue
	|
	|-RVA: 0x1204720 Offset: 0x1203120 VA: 0x181204720
	|-SyncVar<int>.GetValue
	|-SyncVar<Int32Enum>.GetValue
	|
	|-RVA: 0x1204830 Offset: 0x1203230 VA: 0x181204830
	|-SyncVar<object>.GetValue
	|
	|-RVA: 0x1204730 Offset: 0x1203130 VA: 0x181204730
	|-SyncVar<Quaternion>.GetValue
	|
	|-RVA: 0x1204750 Offset: 0x1203150 VA: 0x181204750
	|-SyncVar<float>.GetValue
	|
	|-RVA: 0x1204850 Offset: 0x1203250 VA: 0x181204850
	|-SyncVar<Vector3>.GetValue
	|
	|-RVA: 0x1204770 Offset: 0x1203170 VA: 0x181204770
	|-SyncVar<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override void ResetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12067F0 Offset: 0x12051F0 VA: 0x1812067F0
	|-SyncVar<bool>.ResetState
	|
	|-RVA: 0x1206710 Offset: 0x1205110 VA: 0x181206710
	|-SyncVar<int>.ResetState
	|-SyncVar<Int32Enum>.ResetState
	|-SyncVar<float>.ResetState
	|
	|-RVA: 0x1206790 Offset: 0x1205190 VA: 0x181206790
	|-SyncVar<object>.ResetState
	|
	|-RVA: 0x12066D0 Offset: 0x12050D0 VA: 0x1812066D0
	|-SyncVar<Quaternion>.ResetState
	|
	|-RVA: 0x1206740 Offset: 0x1205140 VA: 0x181206740
	|-SyncVar<Vector3>.ResetState
	|
	|-RVA: 0x1206820 Offset: 0x1205220 VA: 0x181206820
	|-SyncVar<__Il2CppFullySharedGenericType>.ResetState
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <SetValue>g__TryDirty|13_0(bool asServer, ref SyncVar.<>c__DisplayClass13_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1208480 Offset: 0x1206E80 VA: 0x181208480
	|-SyncVar<bool>.<SetValue>g__TryDirty|13_0
	|-SyncVar<int>.<SetValue>g__TryDirty|13_0
	|-SyncVar<Int32Enum>.<SetValue>g__TryDirty|13_0
	|-SyncVar<object>.<SetValue>g__TryDirty|13_0
	|-SyncVar<Quaternion>.<SetValue>g__TryDirty|13_0
	|-SyncVar<float>.<SetValue>g__TryDirty|13_0
	|-SyncVar<Vector3>.<SetValue>g__TryDirty|13_0
	|-SyncVar<__Il2CppFullySharedGenericType>.<SetValue>g__TryDirty|13_0
	*/
}
