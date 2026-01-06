public abstract class ResourceExportingModule : CGModule // TypeDefIndex: 10746
{
	// Methods

	// RVA: 0x539BA0 Offset: 0x5385A0 VA: 0x180539BA0
	public GameObject SaveToScene(Transform parent) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract GameObject SaveResourceToScene(Component managedResource, Transform newParent);

	// RVA: 0x4EDCF0 Offset: 0x4EC6F0 VA: 0x1804EDCF0
	protected void .ctor() { }
}
