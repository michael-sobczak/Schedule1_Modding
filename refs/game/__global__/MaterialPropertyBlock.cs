public sealed class MaterialPropertyBlock // TypeDefIndex: 11665
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[ThreadSafe]
	[NativeName("SetIntFromScript")]
	// RVA: 0x2C917D0 Offset: 0x2C901D0 VA: 0x182C917D0
	private void SetIntImpl(int name, int value) { }

	[NativeName("SetFloatFromScript")]
	[ThreadSafe]
	// RVA: 0x2C91700 Offset: 0x2C90100 VA: 0x182C91700
	private void SetFloatImpl(int name, float value) { }

	[ThreadSafe]
	[NativeName("SetVectorFromScript")]
	// RVA: 0x2C92150 Offset: 0x2C90B50 VA: 0x182C92150
	private void SetVectorImpl(int name, Vector4 value) { }

	[ThreadSafe]
	[NativeName("SetColorFromScript")]
	// RVA: 0x2C91320 Offset: 0x2C8FD20 VA: 0x182C91320
	private void SetColorImpl(int name, Color value) { }

	[ThreadSafe]
	[NativeName("SetMatrixFromScript")]
	// RVA: 0x2C91C00 Offset: 0x2C90600 VA: 0x182C91C00
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	// RVA: 0x2C91DC0 Offset: 0x2C907C0 VA: 0x182C91DC0
	private void SetTextureImpl(int name, Texture value) { }

	[ThreadSafe]
	[NativeName("SetRenderTextureFromScript")]
	// RVA: 0x2C91D60 Offset: 0x2C90760 VA: 0x182C91D60
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[ThreadSafe]
	[NativeName("SetBufferFromScript")]
	// RVA: 0x2C91280 Offset: 0x2C8FC80 VA: 0x182C91280
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[ThreadSafe]
	[NativeName("SetFloatArrayFromScript")]
	// RVA: 0x2C91450 Offset: 0x2C8FE50 VA: 0x182C91450
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[ThreadSafe]
	[NativeName("SetVectorArrayFromScript")]
	// RVA: 0x2C91E90 Offset: 0x2C90890 VA: 0x182C91E90
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[NativeName("SetMatrixArrayFromScript")]
	[ThreadSafe]
	// RVA: 0x2C91900 Offset: 0x2C90300 VA: 0x182C91900
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = True)]
	// RVA: 0x2C91090 Offset: 0x2C8FA90 VA: 0x182C91090
	private static IntPtr CreateImpl() { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x2C910C0 Offset: 0x2C8FAC0 VA: 0x182C910C0
	private static void DestroyImpl(IntPtr mpb) { }

	[ThreadSafe]
	// RVA: 0x2C91000 Offset: 0x2C8FA00 VA: 0x182C91000
	private void Clear(bool keepMemory) { }

	// RVA: 0x2C91050 Offset: 0x2C8FA50 VA: 0x182C91050
	public void Clear() { }

	// RVA: 0x2C914B0 Offset: 0x2C8FEB0 VA: 0x182C914B0
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x2C91F20 Offset: 0x2C90920 VA: 0x182C91F20
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x2C91A50 Offset: 0x2C90450 VA: 0x182C91A50
	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x2C92280 Offset: 0x2C90C80 VA: 0x182C92280
	public void .ctor() { }

	// RVA: 0x2C911A0 Offset: 0x2C8FBA0 VA: 0x182C911A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2C91100 Offset: 0x2C8FB00 VA: 0x182C91100
	private void Dispose() { }

	// RVA: 0x2C91820 Offset: 0x2C90220 VA: 0x182C91820
	public void SetInt(string name, int value) { }

	// RVA: 0x2C918A0 Offset: 0x2C902A0 VA: 0x182C918A0
	public void SetInt(int nameID, int value) { }

	// RVA: 0x2C91750 Offset: 0x2C90150 VA: 0x182C91750
	public void SetFloat(string name, float value) { }

	// RVA: 0x2C91700 Offset: 0x2C90100 VA: 0x182C91700
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x2C917D0 Offset: 0x2C901D0 VA: 0x182C917D0
	public void SetInteger(int nameID, int value) { }

	// RVA: 0x2C921F0 Offset: 0x2C90BF0 VA: 0x182C921F0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x2C921A0 Offset: 0x2C90BA0 VA: 0x182C921A0
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x2C913C0 Offset: 0x2C8FDC0 VA: 0x182C913C0
	public void SetColor(string name, Color value) { }

	// RVA: 0x2C91370 Offset: 0x2C8FD70 VA: 0x182C91370
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x2C91CC0 Offset: 0x2C906C0 VA: 0x182C91CC0
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x2C91C50 Offset: 0x2C90650 VA: 0x182C91C50
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x2C91280 Offset: 0x2C8FC80 VA: 0x182C91280
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x2C91E10 Offset: 0x2C90810 VA: 0x182C91E10
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x2C91DC0 Offset: 0x2C907C0 VA: 0x182C91DC0
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x2C91D60 Offset: 0x2C90760 VA: 0x182C91D60
	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x2C91610 Offset: 0x2C90010 VA: 0x182C91610
	public void SetFloatArray(string name, float[] values) { }

	// RVA: 0x2C92080 Offset: 0x2C90A80 VA: 0x182C92080
	public void SetVectorArray(string name, Vector4[] values) { }

	// RVA: 0x2C91EF0 Offset: 0x2C908F0 VA: 0x182C91EF0
	public void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x2C91960 Offset: 0x2C90360 VA: 0x182C91960
	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	// RVA: 0x2C92100 Offset: 0x2C90B00 VA: 0x182C92100
	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x2C912D0 Offset: 0x2C8FCD0 VA: 0x182C912D0
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x2C91BB0 Offset: 0x2C905B0 VA: 0x182C91BB0
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }
}
