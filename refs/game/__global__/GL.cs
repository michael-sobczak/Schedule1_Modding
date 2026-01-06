public sealed class GL // TypeDefIndex: 11649
{
	// Properties
	public static bool wireframe { get; set; }
	[NativeProperty("UserBackfaceMode")]
	public static bool invertCulling { set; }
	public static Matrix4x4 modelview { set; }

	// Methods

	[NativeName("ImmediateVertex")]
	// RVA: 0x2C8A6A0 Offset: 0x2C890A0 VA: 0x182C8A6A0
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x2C8A700 Offset: 0x2C89100 VA: 0x182C8A700
	public static void Vertex(Vector3 v) { }

	[NativeName("ImmediateTexCoordAll")]
	// RVA: 0x2C8A640 Offset: 0x2C89040 VA: 0x182C8A640
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x2C8A5F0 Offset: 0x2C88FF0 VA: 0x182C8A5F0
	public static void TexCoord2(float x, float y) { }

	[NativeName("ImmediateTexCoord")]
	// RVA: 0x2C8A4A0 Offset: 0x2C88EA0 VA: 0x182C8A4A0
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	// RVA: 0x2C8A440 Offset: 0x2C88E40 VA: 0x182C8A440
	public static void MultiTexCoord2(int unit, float x, float y) { }

	[NativeName("ImmediateColor")]
	// RVA: 0x2C8A310 Offset: 0x2C88D10 VA: 0x182C8A310
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x2C8A060 Offset: 0x2C88A60 VA: 0x182C8A060
	public static void Color(Color c) { }

	// RVA: 0x2C8A7C0 Offset: 0x2C891C0 VA: 0x182C8A7C0
	public static bool get_wireframe() { }

	// RVA: 0x2C8A890 Offset: 0x2C89290 VA: 0x182C8A890
	public static void set_wireframe(bool value) { }

	// RVA: 0x2C8A7F0 Offset: 0x2C891F0 VA: 0x182C8A7F0
	public static void set_invertCulling(bool value) { }

	// RVA: 0x2C8A5B0 Offset: 0x2C88FB0 VA: 0x182C8A5B0
	private static void SetViewMatrix(Matrix4x4 m) { }

	// RVA: 0x2C8A830 Offset: 0x2C89230 VA: 0x182C8A830
	public static void set_modelview(Matrix4x4 value) { }

	[FreeFunction("GLPushMatrixScript")]
	// RVA: 0x2C8A540 Offset: 0x2C88F40 VA: 0x182C8A540
	public static void PushMatrix() { }

	[FreeFunction("GLPopMatrixScript")]
	// RVA: 0x2C8A510 Offset: 0x2C88F10 VA: 0x182C8A510
	public static void PopMatrix() { }

	[FreeFunction("GLLoadOrthoScript")]
	// RVA: 0x2C8A390 Offset: 0x2C88D90 VA: 0x182C8A390
	public static void LoadOrtho() { }

	[FreeFunction("GLLoadProjectionMatrixScript")]
	// RVA: 0x2C8A400 Offset: 0x2C88E00 VA: 0x182C8A400
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunction("GLGetGPUProjectionMatrix")]
	// RVA: 0x2C8A2A0 Offset: 0x2C88CA0 VA: 0x182C8A2A0
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunction]
	// RVA: 0x2C8A1C0 Offset: 0x2C88BC0 VA: 0x182C8A1C0
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x2C8A1C0 Offset: 0x2C88BC0 VA: 0x182C8A1C0
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunction("GLBegin", ThrowsException = True)]
	// RVA: 0x2C89F50 Offset: 0x2C88950 VA: 0x182C89F50
	public static void Begin(int mode) { }

	[FreeFunction("GLEnd")]
	// RVA: 0x2C8A0B0 Offset: 0x2C88AB0 VA: 0x182C8A0B0
	public static void End() { }

	[FreeFunction]
	// RVA: 0x2C8A150 Offset: 0x2C88B50 VA: 0x182C8A150
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x2C89F90 Offset: 0x2C88990 VA: 0x182C89F90
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x2C8A000 Offset: 0x2C88A00 VA: 0x182C8A000
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunction("SetGLViewport")]
	// RVA: 0x2C8A780 Offset: 0x2C89180 VA: 0x182C8A780
	public static void Viewport(Rect pixelRect) { }

	// RVA: 0x2C8A570 Offset: 0x2C88F70 VA: 0x182C8A570
	private static void SetViewMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x2C8A3C0 Offset: 0x2C88DC0 VA: 0x182C8A3C0
	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x2C8A240 Offset: 0x2C88C40 VA: 0x182C8A240
	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0x2C8A0E0 Offset: 0x2C88AE0 VA: 0x182C8A0E0
	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x2C8A740 Offset: 0x2C89140 VA: 0x182C8A740
	private static void Viewport_Injected(ref Rect pixelRect) { }
}
