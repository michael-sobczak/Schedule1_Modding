public class CGGameObject : CGBounds // TypeDefIndex: 10619
{
	// Fields
	public GameObject Object; // 0x40
	public Vector3 Translate; // 0x48
	public Vector3 Rotate; // 0x54
	public Vector3 Scale; // 0x60

	// Properties
	public Matrix4x4 Matrix { get; }

	// Methods

	// RVA: 0x4D9C70 Offset: 0x4D8670 VA: 0x1804D9C70
	public Matrix4x4 get_Matrix() { }

	// RVA: 0x4D97B0 Offset: 0x4D81B0 VA: 0x1804D97B0
	public void .ctor() { }

	// RVA: 0x4D9B10 Offset: 0x4D8510 VA: 0x1804D9B10
	public void .ctor(CGGameObjectProperties properties) { }

	// RVA: 0x4D9940 Offset: 0x4D8340 VA: 0x1804D9940
	public void .ctor(GameObject obj) { }

	// RVA: 0x4D9810 Offset: 0x4D8210 VA: 0x1804D9810
	public void .ctor(GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale) { }

	// RVA: 0x4D95F0 Offset: 0x4D7FF0 VA: 0x1804D95F0
	public void .ctor(CGGameObject source) { }

	// RVA: -1 Offset: -1 Slot: 7
	public override T Clone<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B4A0 Offset: 0xE59EA0 VA: 0x180E5B4A0
	|-CGGameObject.Clone<object>
	*/

	// RVA: 0x4D8D40 Offset: 0x4D7740 VA: 0x1804D8D40 Slot: 8
	public override void RecalculateBounds() { }
}
