internal class DependencyTreeSortFailedException : Exception // TypeDefIndex: 17851
{
	// Methods

	// RVA: 0x2B9E9B0 Offset: 0x2B9D3B0 VA: 0x182B9E9B0
	public void .ctor(DependencyTree tree, ICollection<int> target) { }

	// RVA: 0x2B9E920 Offset: 0x2B9D320 VA: 0x182B9E920
	public void .ctor(DependencyTree tree, ICollection<int> target, Exception inner) { }

	// RVA: 0x2B9E850 Offset: 0x2B9D250 VA: 0x182B9E850
	private static string CreateExceptionMessage(DependencyTree tree, ICollection<int> target, Exception inner) { }
}
