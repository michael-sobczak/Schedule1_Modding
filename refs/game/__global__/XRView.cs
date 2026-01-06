internal struct XRView // TypeDefIndex: 13499
{
	// Fields
	internal readonly Matrix4x4 projMatrix; // 0x0
	internal readonly Matrix4x4 viewMatrix; // 0x40
	internal readonly Rect viewport; // 0x80
	internal readonly Mesh occlusionMesh; // 0x90
	internal readonly int textureArraySlice; // 0x98
	internal readonly Vector2 eyeCenterUV; // 0x9C

	// Methods

	// RVA: 0x29E4F00 Offset: 0x29E3900 VA: 0x1829E4F00
	internal void .ctor(Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Rect viewport, Mesh occlusionMesh, int textureArraySlice) { }

	// RVA: 0x29E4E60 Offset: 0x29E3860 VA: 0x1829E4E60
	private static Vector2 ComputeEyeCenterUV(Matrix4x4 proj) { }
}
