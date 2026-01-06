public class AnimationLink : NodeLink2 // TypeDefIndex: 13156
{
	// Fields
	public string clip; // 0x90
	public float animSpeed; // 0x98
	public bool reverseAnim; // 0x9C
	public GameObject referenceMesh; // 0xA0
	public AnimationLink.LinkClip[] sequence; // 0xA8
	public string boneRoot; // 0xB0

	// Methods

	// RVA: 0xB02E40 Offset: 0xB01840 VA: 0x180B02E40
	private static Transform SearchRec(Transform tr, string name) { }

	// RVA: 0xB02260 Offset: 0xB00C60 VA: 0x180B02260
	public void CalculateOffsets(List<Vector3> trace, out Vector3 endPosition) { }

	// RVA: 0xB02CC0 Offset: 0xB016C0 VA: 0x180B02CC0 Slot: 19
	public override void OnDrawGizmosSelected() { }

	// RVA: 0xB02F40 Offset: 0xB01940 VA: 0x180B02F40
	public void .ctor() { }
}
