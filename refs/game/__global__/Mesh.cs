public sealed class Mesh : Object // TypeDefIndex: 11720
{
	// Properties
	public IndexFormat indexFormat { get; set; }
	public int blendShapeCount { get; }
	public bool isReadable { get; }
	internal bool canAccess { get; }
	public int vertexCount { get; }
	public int subMeshCount { get; set; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { get; set; }
	public Vector4[] tangents { get; set; }
	public Vector2[] uv { get; set; }
	public Vector2[] uv2 { get; set; }
	public Color[] colors { set; }
	public Color32[] colors32 { get; set; }
	public int[] triangles { get; set; }

	// Methods

	[FreeFunction("MeshScripting::CreateMesh")]
	// RVA: 0x2C96060 Offset: 0x2C94A60 VA: 0x182C96060
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCode]
	// RVA: 0x2C98C00 Offset: 0x2C97600 VA: 0x182C98C00
	public void .ctor() { }

	[FreeFunction("MeshScripting::MeshFromInstanceId")]
	// RVA: 0x2C95700 Offset: 0x2C94100 VA: 0x182C95700
	internal static Mesh FromInstanceID(int id) { }

	// RVA: 0x2C98DF0 Offset: 0x2C977F0 VA: 0x182C98DF0
	public IndexFormat get_indexFormat() { }

	// RVA: 0x2C99240 Offset: 0x2C97C40 VA: 0x182C99240
	public void set_indexFormat(IndexFormat value) { }

	[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C96CC0 Offset: 0x2C956C0 VA: 0x182C96CC0
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferDataFromArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C95F30 Offset: 0x2C94930 VA: 0x182C95F30
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C98860 Offset: 0x2C97260 VA: 0x182C98860
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferData", HasExplicitThis = True)]
	// RVA: 0x2C96000 Offset: 0x2C94A00 VA: 0x182C96000
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferDataFromArray", HasExplicitThis = True)]
	// RVA: 0x2C95FA0 Offset: 0x2C949A0 VA: 0x182C95FA0
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = True)]
	// RVA: 0x2C95800 Offset: 0x2C94200 VA: 0x182C95800
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = True)]
	// RVA: 0x2C95C60 Offset: 0x2C94660 VA: 0x182C95C60
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	// RVA: 0x2C95900 Offset: 0x2C94300 VA: 0x182C95900
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C96D10 Offset: 0x2C95710 VA: 0x182C96D10
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C96D80 Offset: 0x2C95780 VA: 0x182C96D80
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	// RVA: 0x2C96260 Offset: 0x2C94C60 VA: 0x182C96260
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	// RVA: 0x2C95EF0 Offset: 0x2C948F0 VA: 0x182C95EF0
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	// RVA: 0x2C968F0 Offset: 0x2C952F0 VA: 0x182C968F0
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	// RVA: 0x2C95740 Offset: 0x2C94140 VA: 0x182C95740
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	// RVA: 0x2C957A0 Offset: 0x2C941A0 VA: 0x182C957A0
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[NativeMethod(Name = "GetBlendShapeChannelCount")]
	// RVA: 0x2C98C70 Offset: 0x2C97670 VA: 0x182C98C70
	public int get_blendShapeCount() { }

	[NativeMethod("GetIsReadable")]
	// RVA: 0x2C98E30 Offset: 0x2C97830 VA: 0x182C98E30
	public bool get_isReadable() { }

	[NativeMethod("CanAccessFromScript")]
	// RVA: 0x2C98D60 Offset: 0x2C97760 VA: 0x182C98D60
	internal bool get_canAccess() { }

	[NativeMethod("GetVertexCount")]
	// RVA: 0x2C99050 Offset: 0x2C97A50 VA: 0x182C99050
	public int get_vertexCount() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	// RVA: 0x2C98EB0 Offset: 0x2C978B0 VA: 0x182C98EB0
	public int get_subMeshCount() { }

	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	// RVA: 0x2C992E0 Offset: 0x2C97CE0 VA: 0x182C992E0
	public void set_subMeshCount(int value) { }

	[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C97A40 Offset: 0x2C96440 VA: 0x182C97A40
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	[FreeFunction("MeshScripting::GetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C95AE0 Offset: 0x2C944E0 VA: 0x182C95AE0
	public SubMeshDescriptor GetSubMesh(int index) { }

	// RVA: 0x2C98D00 Offset: 0x2C97700 VA: 0x182C98D00
	public Bounds get_bounds() { }

	// RVA: 0x2C99120 Offset: 0x2C97B20 VA: 0x182C99120
	public void set_bounds(Bounds value) { }

	[NativeMethod("Clear")]
	// RVA: 0x2C95420 Offset: 0x2C93E20 VA: 0x182C95420
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethod("RecalculateBounds")]
	// RVA: 0x2C96320 Offset: 0x2C94D20 VA: 0x182C96320
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("RecalculateNormals")]
	// RVA: 0x2C96510 Offset: 0x2C94F10 VA: 0x182C96510
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("RecalculateTangents")]
	// RVA: 0x2C96700 Offset: 0x2C95100 VA: 0x182C96700
	private void RecalculateTangentsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("MarkDynamic")]
	// RVA: 0x2C960A0 Offset: 0x2C94AA0 VA: 0x182C960A0
	private void MarkDynamicImpl() { }

	[NativeMethod("UploadMeshData")]
	// RVA: 0x2C98B40 Offset: 0x2C97540 VA: 0x182C98B40
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunction(Name = "MeshScripting::GetPrimitiveType", HasExplicitThis = True)]
	// RVA: 0x2C95B50 Offset: 0x2C94550 VA: 0x182C95B50
	private MeshTopology GetTopologyImpl(int submesh) { }

	[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
	// RVA: 0x2C954B0 Offset: 0x2C93EB0 VA: 0x182C954B0
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[NativeMethod("Optimize")]
	// RVA: 0x2C96150 Offset: 0x2C94B50 VA: 0x182C96150
	private void OptimizeImpl() { }

	// RVA: 0x2C95DF0 Offset: 0x2C947F0 VA: 0x182C95DF0
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x2C95650 Offset: 0x2C94050 VA: 0x182C95650
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF00EC0 Offset: 0xEFF8C0 VA: 0x180F00EC0
	|-Mesh.GetAllocArrayFromChannel<Color32>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF01020 Offset: 0xEFFA20 VA: 0x180F01020
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	|
	|-RVA: 0xF00FC0 Offset: 0xEFF9C0 VA: 0x180F00FC0
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C97680 Offset: 0x2C96080 VA: 0x182C97680
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF027B0 Offset: 0xF011B0 VA: 0x180F027B0
	|-Mesh.SetArrayForChannel<Color32>
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF01760 Offset: 0xF00160 VA: 0x180F01760
	|-Mesh.SetArrayForChannel<Color>
	|-Mesh.SetArrayForChannel<Vector2>
	|-Mesh.SetArrayForChannel<Vector3>
	|-Mesh.SetArrayForChannel<Vector4>
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF03070 Offset: 0xF01A70 VA: 0x180F03070
	|-Mesh.SetListForChannel<Color32>
	|-Mesh.SetListForChannel<Vector2>
	|-Mesh.SetListForChannel<Vector4>
	|
	|-RVA: 0xF03230 Offset: 0xF01C30 VA: 0x180F03230
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF03150 Offset: 0xF01B50 VA: 0x180F03150
	|-Mesh.SetListForChannel<Color>
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	|
	|-RVA: 0xF03300 Offset: 0xF01D00 VA: 0x180F03300
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF012B0 Offset: 0xEFFCB0 VA: 0x180F012B0
	|-Mesh.GetListForChannel<Vector4>
	|
	|-RVA: 0xF01140 Offset: 0xEFFB40 VA: 0x180F01140
	|-Mesh.GetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF013A0 Offset: 0xEFFDA0 VA: 0x180F013A0
	|-Mesh.GetListForChannel<Vector4>
	|
	|-RVA: 0xF011D0 Offset: 0xEFFBD0 VA: 0x180F011D0
	|-Mesh.GetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C99090 Offset: 0x2C97A90 VA: 0x182C99090
	public Vector3[] get_vertices() { }

	// RVA: 0x2C99530 Offset: 0x2C97F30 VA: 0x182C99530
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x2C98E70 Offset: 0x2C97870 VA: 0x182C98E70
	public Vector3[] get_normals() { }

	// RVA: 0x2C99280 Offset: 0x2C97C80 VA: 0x182C99280
	public void set_normals(Vector3[] value) { }

	// RVA: 0x2C98EF0 Offset: 0x2C978F0 VA: 0x182C98EF0
	public Vector4[] get_tangents() { }

	// RVA: 0x2C99320 Offset: 0x2C97D20 VA: 0x182C99320
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x2C99010 Offset: 0x2C97A10 VA: 0x182C99010
	public Vector2[] get_uv() { }

	// RVA: 0x2C994D0 Offset: 0x2C97ED0 VA: 0x182C994D0
	public void set_uv(Vector2[] value) { }

	// RVA: 0x2C98FD0 Offset: 0x2C979D0 VA: 0x182C98FD0
	public Vector2[] get_uv2() { }

	// RVA: 0x2C99470 Offset: 0x2C97E70 VA: 0x182C99470
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x2C991E0 Offset: 0x2C97BE0 VA: 0x182C991E0
	public void set_colors(Color[] value) { }

	// RVA: 0x2C98DA0 Offset: 0x2C977A0 VA: 0x182C98DA0
	public Color32[] get_colors32() { }

	// RVA: 0x2C99170 Offset: 0x2C97B70 VA: 0x182C99170
	public void set_colors32(Color32[] value) { }

	// RVA: 0x2C98A30 Offset: 0x2C97430 VA: 0x182C98A30
	public void SetVertices(List<Vector3> inVertices) { }

	[ExcludeFromDocs]
	// RVA: 0x2C98930 Offset: 0x2C97330 VA: 0x182C98930
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x2C988B0 Offset: 0x2C972B0 VA: 0x182C988B0
	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2C98AD0 Offset: 0x2C974D0 VA: 0x182C98AD0
	public void SetVertices(Vector3[] inVertices, int start, int length) { }

	// RVA: 0x2C989B0 Offset: 0x2C973B0 VA: 0x182C989B0
	public void SetVertices(Vector3[] inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2C97560 Offset: 0x2C95F60 VA: 0x182C97560
	public void SetNormals(List<Vector3> inNormals) { }

	[ExcludeFromDocs]
	// RVA: 0x2C97460 Offset: 0x2C95E60 VA: 0x182C97460
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x2C973E0 Offset: 0x2C95DE0 VA: 0x182C973E0
	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2C974E0 Offset: 0x2C95EE0 VA: 0x182C974E0
	public void SetNormals(Vector3[] inNormals, int start, int length) { }

	// RVA: 0x2C97600 Offset: 0x2C96000 VA: 0x182C97600
	public void SetNormals(Vector3[] inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2C97AA0 Offset: 0x2C964A0 VA: 0x182C97AA0
	public void SetTangents(List<Vector4> inTangents) { }

	[ExcludeFromDocs]
	// RVA: 0x2C97CC0 Offset: 0x2C966C0 VA: 0x182C97CC0
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x2C97BC0 Offset: 0x2C965C0 VA: 0x182C97BC0
	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2C97B40 Offset: 0x2C96540 VA: 0x182C97B40
	public void SetTangents(Vector4[] inTangents, int start, int length) { }

	// RVA: 0x2C97C40 Offset: 0x2C96640 VA: 0x182C97C40
	public void SetTangents(Vector4[] inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2C96C20 Offset: 0x2C95620 VA: 0x182C96C20
	public void SetColors(List<Color> inColors) { }

	[ExcludeFromDocs]
	// RVA: 0x2C969E0 Offset: 0x2C953E0 VA: 0x182C969E0
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x2C96B10 Offset: 0x2C95510 VA: 0x182C96B10
	public void SetColors(List<Color> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2C96A60 Offset: 0x2C95460 VA: 0x182C96A60
	public void SetColors(List<Color32> inColors) { }

	[ExcludeFromDocs]
	// RVA: 0x2C96B90 Offset: 0x2C95590 VA: 0x182C96B90
	public void SetColors(List<Color32> inColors, int start, int length) { }

	// RVA: 0x2C96950 Offset: 0x2C95350 VA: 0x182C96950
	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF034D0 Offset: 0xF01ED0 VA: 0x180F034D0
	|-Mesh.SetUvsImpl<Vector2>
	|-Mesh.SetUvsImpl<Vector4>
	|
	|-RVA: 0xF033D0 Offset: 0xF01DD0 VA: 0x180F033D0
	|-Mesh.SetUvsImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C98320 Offset: 0x2C96D20 VA: 0x182C98320
	public void SetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x2C98580 Offset: 0x2C96F80 VA: 0x182C98580
	public void SetUVs(int channel, List<Vector4> uvs) { }

	[ExcludeFromDocs]
	// RVA: 0x2C984F0 Offset: 0x2C96EF0 VA: 0x182C984F0
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x2C98660 Offset: 0x2C97060 VA: 0x182C98660
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2C98400 Offset: 0x2C96E00 VA: 0x182C98400
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: 0x2C98210 Offset: 0x2C96C10 VA: 0x182C98210
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x2C98750 Offset: 0x2C97150 VA: 0x182C98750
	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) { }

	// RVA: 0x2C98490 Offset: 0x2C96E90 VA: 0x182C98490
	public void SetUVs(int channel, Vector2[] uvs) { }

	// RVA: 0x2C986F0 Offset: 0x2C970F0 VA: 0x182C986F0
	public void SetUVs(int channel, Vector4[] uvs) { }

	[ExcludeFromDocs]
	// RVA: 0x2C983D0 Offset: 0x2C96DD0 VA: 0x182C983D0
	public void SetUVs(int channel, Vector2[] uvs, int start, int length) { }

	// RVA: 0x2C982E0 Offset: 0x2C96CE0 VA: 0x182C982E0
	public void SetUVs(int channel, Vector2[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2C98630 Offset: 0x2C97030 VA: 0x182C98630
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	// RVA: 0x2C982A0 Offset: 0x2C96CA0 VA: 0x182C982A0
	public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF015B0 Offset: 0xEFFFB0 VA: 0x180F015B0
	|-Mesh.GetUVsImpl<Vector4>
	|
	|-RVA: 0xF01480 Offset: 0xEFFE80 VA: 0x180F01480
	|-Mesh.GetUVsImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C95E80 Offset: 0x2C94880 VA: 0x182C95E80
	public void GetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x2C98860 Offset: 0x2C97260 VA: 0x182C98860
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF038B0 Offset: 0xF022B0 VA: 0x180F038B0
	|-Mesh.SetVertexBufferData<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xF03B10 Offset: 0xF02510 VA: 0x180F03B10
	|-Mesh.SetVertexBufferData<LightUtility.LightMeshVertex>
	*/

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF03610 Offset: 0xF02010 VA: 0x180F03610
	|-Mesh.SetVertexBufferData<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xF03D30 Offset: 0xF02730 VA: 0x180F03D30
	|-Mesh.SetVertexBufferData<BlitUtility.Vertex>
	*/

	// RVA: 0x2C962A0 Offset: 0x2C94CA0 VA: 0x182C962A0
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x2C95070 Offset: 0x2C93A70 VA: 0x182C95070
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x2C95060 Offset: 0x2C93A60 VA: 0x182C95060
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x2C95050 Offset: 0x2C93A50 VA: 0x182C95050
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x2C98F30 Offset: 0x2C97930 VA: 0x182C98F30
	public int[] get_triangles() { }

	// RVA: 0x2C99380 Offset: 0x2C97D80 VA: 0x182C99380
	public void set_triangles(int[] value) { }

	// RVA: 0x2C95CC0 Offset: 0x2C946C0 VA: 0x182C95CC0
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x2C95D50 Offset: 0x2C94750 VA: 0x182C95D50
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocs]
	// RVA: 0x2C95960 Offset: 0x2C94360 VA: 0x182C95960
	public int[] GetIndices(int submesh) { }

	// RVA: 0x2C959F0 Offset: 0x2C943F0 VA: 0x182C959F0
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF02A50 Offset: 0xF01450 VA: 0x180F02A50
	|-Mesh.SetIndexBufferData<ushort>
	|
	|-RVA: 0xF02840 Offset: 0xF01240 VA: 0x180F02840
	|-Mesh.SetIndexBufferData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2C95840 Offset: 0x2C94240 VA: 0x182C95840
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x2C951B0 Offset: 0x2C93BB0 VA: 0x182C951B0
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x2C97D40 Offset: 0x2C96740 VA: 0x182C97D40
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	// RVA: 0x2C97EE0 Offset: 0x2C968E0 VA: 0x182C97EE0
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds) { }

	// RVA: 0x2C97FA0 Offset: 0x2C969A0 VA: 0x182C97FA0
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x2C98170 Offset: 0x2C96B70 VA: 0x182C98170
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x2C98150 Offset: 0x2C96B50 VA: 0x182C98150
	public void SetTriangles(List<int> triangles, int submesh) { }

	[ExcludeFromDocs]
	// RVA: 0x2C97F80 Offset: 0x2C96980 VA: 0x182C97F80
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds) { }

	// RVA: 0x2C98050 Offset: 0x2C96A50 VA: 0x182C98050
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x2C97E00 Offset: 0x2C96800 VA: 0x182C97E00
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x2C96FA0 Offset: 0x2C959A0 VA: 0x182C96FA0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocs]
	// RVA: 0x2C973B0 Offset: 0x2C95DB0 VA: 0x182C973B0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x2C97200 Offset: 0x2C95C00 VA: 0x182C97200
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x2C96ED0 Offset: 0x2C958D0 VA: 0x182C96ED0
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2C96DF0 Offset: 0x2C957F0 VA: 0x182C96DF0
	public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2C972E0 Offset: 0x2C95CE0 VA: 0x182C972E0
	public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: -1 Offset: -1
	public void SetIndices<T>(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF02EA0 Offset: 0xF018A0 VA: 0x180F02EA0
	|-Mesh.SetIndices<ushort>
	|
	|-RVA: 0xF02C50 Offset: 0xF01650 VA: 0x180F02C50
	|-Mesh.SetIndices<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetIndices<T>(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF02F90 Offset: 0xF01990 VA: 0x180F02F90
	|-Mesh.SetIndices<ushort>
	|
	|-RVA: 0xF02D10 Offset: 0xF01710 VA: 0x180F02D10
	|-Mesh.SetIndices<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2C96FC0 Offset: 0x2C959C0 VA: 0x182C96FC0
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x2C970F0 Offset: 0x2C95AF0 VA: 0x182C970F0
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x2C95470 Offset: 0x2C93E70 VA: 0x182C95470
	public void Clear() { }

	[ExcludeFromDocs]
	// RVA: 0x2C96360 Offset: 0x2C94D60 VA: 0x182C96360
	public void RecalculateBounds() { }

	[ExcludeFromDocs]
	// RVA: 0x2C96550 Offset: 0x2C94F50 VA: 0x182C96550
	public void RecalculateNormals() { }

	[ExcludeFromDocs]
	// RVA: 0x2C96740 Offset: 0x2C95140 VA: 0x182C96740
	public void RecalculateTangents() { }

	// RVA: 0x2C96430 Offset: 0x2C94E30 VA: 0x182C96430
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x2C96620 Offset: 0x2C95020 VA: 0x182C96620
	public void RecalculateNormals(MeshUpdateFlags flags) { }

	// RVA: 0x2C96810 Offset: 0x2C95210 VA: 0x182C96810
	public void RecalculateTangents(MeshUpdateFlags flags) { }

	// RVA: 0x2C960E0 Offset: 0x2C94AE0 VA: 0x182C960E0
	public void MarkDynamic() { }

	// RVA: 0x2C98B90 Offset: 0x2C97590 VA: 0x182C98B90
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x2C96190 Offset: 0x2C94B90 VA: 0x182C96190
	public void Optimize() { }

	// RVA: 0x2C95B90 Offset: 0x2C94590 VA: 0x182C95B90
	public MeshTopology GetTopology(int submesh) { }

	[ExcludeFromDocs]
	// RVA: 0x2C95580 Offset: 0x2C93F80 VA: 0x182C95580
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	[ExcludeFromDocs]
	// RVA: 0x2C955F0 Offset: 0x2C93FF0 VA: 0x182C955F0
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	[ExcludeFromDocs]
	// RVA: 0x2C95530 Offset: 0x2C93F30 VA: 0x182C95530
	public void CombineMeshes(CombineInstance[] combine) { }

	// RVA: 0x2C979E0 Offset: 0x2C963E0 VA: 0x182C979E0
	private void SetSubMesh_Injected(int index, ref SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	// RVA: 0x2C95A90 Offset: 0x2C94490 VA: 0x182C95A90
	private void GetSubMesh_Injected(int index, out SubMeshDescriptor ret) { }

	// RVA: 0x2C98CB0 Offset: 0x2C976B0 VA: 0x182C98CB0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2C990D0 Offset: 0x2C97AD0 VA: 0x182C990D0
	private void set_bounds_Injected(ref Bounds value) { }
}
