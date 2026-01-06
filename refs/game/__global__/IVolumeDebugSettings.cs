public interface IVolumeDebugSettings // TypeDefIndex: 13693
{
	// Properties
	public abstract int selectedComponent { get; set; }
	public abstract Camera selectedCamera { get; }
	public abstract IEnumerable<Camera> cameras { get; }
	public abstract int selectedCameraIndex { get; set; }
	public abstract VolumeStack selectedCameraVolumeStack { get; }
	public abstract LayerMask selectedCameraLayerMask { get; }
	public abstract Vector3 selectedCameraPosition { get; }
	public abstract Type selectedComponentType { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_selectedComponent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_selectedComponent(int value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Camera get_selectedCamera();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<Camera> get_cameras();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_selectedCameraIndex();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_selectedCameraIndex(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract VolumeStack get_selectedCameraVolumeStack();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract LayerMask get_selectedCameraLayerMask();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Vector3 get_selectedCameraPosition();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_selectedComponentType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_selectedComponentType(Type value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Volume[] GetVolumes();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool VolumeHasInfluence(Volume volume);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool RefreshVolumes(Volume[] newVolumes);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float GetVolumeWeight(Volume volume);
}
