public sealed class ComputeShader : Object // TypeDefIndex: 11868
{
	// Methods

	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	// RVA: 0x2CBB170 Offset: 0x2CB9B70 VA: 0x182CBB170
	public int FindKernel(string name) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<float>", HasExplicitThis = True)]
	// RVA: 0x2CBB350 Offset: 0x2CB9D50 VA: 0x182CBB350
	public void SetFloat(int nameID, float val) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = True)]
	// RVA: 0x2CBB400 Offset: 0x2CB9E00 VA: 0x182CBB400
	public void SetInt(int nameID, int val) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<Vector4f>", HasExplicitThis = True)]
	// RVA: 0x2CBB650 Offset: 0x2CBA050 VA: 0x182CBB650
	public void SetVector(int nameID, Vector4 val) { }

	[NativeMethod(Name = "ComputeShaderScripting::SetTexture", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CBB4B0 Offset: 0x2CB9EB0 VA: 0x182CBB4B0
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = True)]
	// RVA: 0x2CBB220 Offset: 0x2CB9C20 VA: 0x182CBB220
	private void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	// RVA: 0x2CBB220 Offset: 0x2CB9C20 VA: 0x182CBB220
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = True)]
	// RVA: 0x2CBB2F0 Offset: 0x2CB9CF0 VA: 0x182CBB2F0
	private void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CBB1C0 Offset: 0x2CB9BC0 VA: 0x182CBB1C0
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeName("DispatchComputeShader")]
	// RVA: 0x2CBB0C0 Offset: 0x2CB9AC0 VA: 0x182CBB0C0
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = True)]
	// RVA: 0x2CBB120 Offset: 0x2CB9B20 VA: 0x182CBB120
	public void EnableKeyword(string keyword) { }

	[FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = True)]
	// RVA: 0x2CBB070 Offset: 0x2CB9A70 VA: 0x182CBB070
	public void DisableKeyword(string keyword) { }

	// RVA: 0x2CBB6A0 Offset: 0x2CBA0A0 VA: 0x182CBB6A0
	private void .ctor() { }

	// RVA: 0x2CBB3A0 Offset: 0x2CB9DA0 VA: 0x182CBB3A0
	public void SetFloat(string name, float val) { }

	// RVA: 0x2CBB450 Offset: 0x2CB9E50 VA: 0x182CBB450
	public void SetInt(string name, int val) { }

	// RVA: 0x2CBB5E0 Offset: 0x2CB9FE0 VA: 0x182CBB5E0
	public void SetVector(string name, Vector4 val) { }

	// RVA: 0x2CBB510 Offset: 0x2CB9F10 VA: 0x182CBB510
	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	// RVA: 0x2CBB280 Offset: 0x2CB9C80 VA: 0x182CBB280
	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x2CBB2F0 Offset: 0x2CB9CF0 VA: 0x182CBB2F0
	public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	// RVA: 0x2CBB590 Offset: 0x2CB9F90 VA: 0x182CBB590
	private void SetVector_Injected(int nameID, ref Vector4 val) { }
}
