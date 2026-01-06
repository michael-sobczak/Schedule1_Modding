public abstract class CurvyInterpolatableMetadataBase<T> : CurvyMetadataBase // TypeDefIndex: 10549
{
	// Properties
	public abstract T MetaDataValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	public abstract T get_MetaDataValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CurvyInterpolatableMetadataBase<__Il2CppFullySharedGenericType>.get_MetaDataValue
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract T Interpolate(CurvyInterpolatableMetadataBase<T> nextMetadata, float interpolationTime);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CurvyInterpolatableMetadataBase<__Il2CppFullySharedGenericType>.Interpolate
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x495E00 Offset: 0x494800 VA: 0x180495E00
	|-CurvyInterpolatableMetadataBase<float>..ctor
	|-CurvyInterpolatableMetadataBase<__Il2CppFullySharedGenericType>..ctor
	*/
}
