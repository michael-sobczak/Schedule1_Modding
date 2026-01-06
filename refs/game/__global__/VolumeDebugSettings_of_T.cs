public abstract class VolumeDebugSettings<T> : IVolumeDebugSettings2, IVolumeDebugSettings // TypeDefIndex: 13707
{
	// Fields
	[CompilerGenerated]
	private int <selectedComponent>k__BackingField; // 0x0
	private Camera m_SelectedCamera; // 0x0
	protected int m_SelectedCameraIndex; // 0x0
	private Camera[] m_CamerasArray; // 0x0
	private List<Camera> m_Cameras; // 0x0
	private static List<ValueTuple<string, Type>> s_ComponentPathAndType; // 0x0
	private float[] weights; // 0x0
	private Volume[] volumes; // 0x0
	private VolumeParameter[,] savedStates; // 0x0
	private static List<Type> s_ComponentTypes; // 0x0
	[CompilerGenerated]
	private static List<T> <additionalCameraDatas>k__BackingField; // 0x0

	// Properties
	public int selectedComponent { get; set; }
	public Camera selectedCamera { get; }
	public int selectedCameraIndex { get; set; }
	public IEnumerable<Camera> cameras { get; }
	public abstract VolumeStack selectedCameraVolumeStack { get; }
	public abstract LayerMask selectedCameraLayerMask { get; }
	public abstract Vector3 selectedCameraPosition { get; }
	public Type selectedComponentType { get; set; }
	public List<ValueTuple<string, Type>> volumeComponentsPathAndType { get; }
	public abstract Type targetRenderPipeline { get; }
	[Obsolete("Please use volumeComponentsPathAndType instead, and get the second element of the tuple", False)]
	public static List<Type> componentTypes { get; }
	[Obsolete("Cameras are auto registered/unregistered, use property cameras", False)]
	protected static List<T> additionalCameraDatas { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public int get_selectedComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	|-VolumeDebugSettings<object>.get_selectedComponent
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public void set_selectedComponent(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	|-VolumeDebugSettings<object>.set_selectedComponent
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public Camera get_selectedCamera() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-VolumeDebugSettings<object>.get_selectedCamera
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_selectedCameraIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	|-VolumeDebugSettings<object>.get_selectedCameraIndex
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void set_selectedCameraIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BEE30 Offset: 0x13BD830 VA: 0x1813BEE30
	|-VolumeDebugSettings<object>.set_selectedCameraIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public IEnumerable<Camera> get_cameras() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BE0D0 Offset: 0x13BCAD0 VA: 0x1813BE0D0
	|-VolumeDebugSettings<object>.get_cameras
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public abstract VolumeStack get_selectedCameraVolumeStack();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VolumeDebugSettings<object>.get_selectedCameraVolumeStack
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public abstract LayerMask get_selectedCameraLayerMask();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VolumeDebugSettings<object>.get_selectedCameraLayerMask
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public abstract Vector3 get_selectedCameraPosition();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VolumeDebugSettings<object>.get_selectedCameraPosition
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public Type get_selectedComponentType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BEB60 Offset: 0x13BD560 VA: 0x1813BEB60
	|-VolumeDebugSettings<object>.get_selectedComponentType
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public void set_selectedComponentType(Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BEF30 Offset: 0x13BD930 VA: 0x1813BEF30
	|-VolumeDebugSettings<object>.set_selectedComponentType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public List<ValueTuple<string, Type>> get_volumeComponentsPathAndType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BEBE0 Offset: 0x13BD5E0 VA: 0x1813BEBE0
	|-VolumeDebugSettings<object>.get_volumeComponentsPathAndType
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Type get_targetRenderPipeline();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VolumeDebugSettings<object>.get_targetRenderPipeline
	*/

	// RVA: -1 Offset: -1
	internal VolumeParameter GetParameter(VolumeComponent component, FieldInfo field) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BCFB0 Offset: 0x13BB9B0 VA: 0x1813BCFB0
	|-VolumeDebugSettings<object>.GetParameter
	*/

	// RVA: -1 Offset: -1
	internal VolumeParameter GetParameter(FieldInfo field) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BCEB0 Offset: 0x13BB8B0 VA: 0x1813BCEB0
	|-VolumeDebugSettings<object>.GetParameter
	*/

	// RVA: -1 Offset: -1
	internal VolumeParameter GetParameter(Volume volume, FieldInfo field) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BCD40 Offset: 0x13BB740 VA: 0x1813BCD40
	|-VolumeDebugSettings<object>.GetParameter
	*/

	// RVA: -1 Offset: -1
	private float ComputeWeight(Volume volume, Vector3 triggerPos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BCA10 Offset: 0x13BB410 VA: 0x1813BCA10
	|-VolumeDebugSettings<object>.ComputeWeight
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public Volume[] GetVolumes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BD520 Offset: 0x13BBF20 VA: 0x1813BD520
	|-VolumeDebugSettings<object>.GetVolumes
	*/

	// RVA: -1 Offset: -1
	private VolumeParameter[,] GetStates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BD050 Offset: 0x13BBA50 VA: 0x1813BD050
	|-VolumeDebugSettings<object>.GetStates
	*/

	// RVA: -1 Offset: -1
	private bool ChangedStates(VolumeParameter[,] newStates) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC750 Offset: 0x13BB150 VA: 0x1813BC750
	|-VolumeDebugSettings<object>.ChangedStates
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool RefreshVolumes(Volume[] newVolumes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BD780 Offset: 0x13BC180 VA: 0x1813BD780
	|-VolumeDebugSettings<object>.RefreshVolumes
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public float GetVolumeWeight(Volume volume) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BD4A0 Offset: 0x13BBEA0 VA: 0x1813BD4A0
	|-VolumeDebugSettings<object>.GetVolumeWeight
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool VolumeHasInfluence(Volume volume) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BDE20 Offset: 0x13BC820 VA: 0x1813BDE20
	|-VolumeDebugSettings<object>.VolumeHasInfluence
	*/

	// RVA: -1 Offset: -1
	public static List<Type> get_componentTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BE310 Offset: 0x13BCD10 VA: 0x1813BE310
	|-VolumeDebugSettings<object>.get_componentTypes
	*/

	[Obsolete("Please use componentPathAndType instead, and get the first element of the tuple", False)]
	// RVA: -1 Offset: -1
	public static string ComponentDisplayName(Type component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BC8B0 Offset: 0x13BB2B0 VA: 0x1813BC8B0
	|-VolumeDebugSettings<object>.ComponentDisplayName
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected static List<T> get_additionalCameraDatas() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BE030 Offset: 0x13BCA30 VA: 0x1813BE030
	|-VolumeDebugSettings<object>.get_additionalCameraDatas
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private static void set_additionalCameraDatas(List<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BED50 Offset: 0x13BD750 VA: 0x1813BED50
	|-VolumeDebugSettings<object>.set_additionalCameraDatas
	*/

	[Obsolete("Cameras are auto registered/unregistered", False)]
	// RVA: -1 Offset: -1
	public static void RegisterCamera(T additionalCamera) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BDB20 Offset: 0x13BC520 VA: 0x1813BDB20
	|-VolumeDebugSettings<object>.RegisterCamera
	*/

	[Obsolete("Cameras are auto registered/unregistered", False)]
	// RVA: -1 Offset: -1
	public static void UnRegisterCamera(T additionalCamera) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BDCA0 Offset: 0x13BC6A0 VA: 0x1813BDCA0
	|-VolumeDebugSettings<object>.UnRegisterCamera
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BDFB0 Offset: 0x13BC9B0 VA: 0x1813BDFB0
	|-VolumeDebugSettings<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13BDEA0 Offset: 0x13BC8A0 VA: 0x1813BDEA0
	|-VolumeDebugSettings<object>..cctor
	*/
}
