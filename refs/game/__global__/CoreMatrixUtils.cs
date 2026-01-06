public static class CoreMatrixUtils // TypeDefIndex: 13850
{
	// Methods

	// RVA: 0x2A395B0 Offset: 0x2A37FB0 VA: 0x182A395B0
	public static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation) { }

	// RVA: 0x2A3A110 Offset: 0x2A38B10 VA: 0x182A3A110
	public static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation) { }

	// RVA: 0x2A39C20 Offset: 0x2A38620 VA: 0x182A39C20
	public static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs) { }

	// RVA: 0x2A397F0 Offset: 0x2A381F0 VA: 0x182A397F0
	private static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs) { }

	// RVA: 0x2A39640 Offset: 0x2A38040 VA: 0x182A39640
	private static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs) { }

	// RVA: 0x2A39930 Offset: 0x2A38330 VA: 0x182A39930
	public static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered) { }

	// RVA: 0x2A39D70 Offset: 0x2A38770 VA: 0x182A39D70
	public static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered) { }
}
