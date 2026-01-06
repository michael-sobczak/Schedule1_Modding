internal static class AsyncTaskCache // TypeDefIndex: 4629
{
	// Fields
	internal static readonly Task<bool> TrueTask; // 0x0
	internal static readonly Task<bool> FalseTask; // 0x8
	internal static readonly Task<int>[] Int32Tasks; // 0x10

	// Methods

	// RVA: 0x1B5F310 Offset: 0x1B5DD10 VA: 0x181B5F310
	private static Task<int>[] CreateInt32Tasks() { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4FEA0 Offset: 0xE4E8A0 VA: 0x180E4FEA0
	|-AsyncTaskCache.CreateCacheableTask<Nullable<bool>>
	|
	|-RVA: 0xE4FFC0 Offset: 0xE4E9C0 VA: 0x180E4FFC0
	|-AsyncTaskCache.CreateCacheableTask<Nullable<DateTime>>
	|
	|-RVA: 0xE4FD70 Offset: 0xE4E770 VA: 0x180E4FD70
	|-AsyncTaskCache.CreateCacheableTask<Nullable<DateTimeOffset>>
	|
	|-RVA: 0xE4FCD0 Offset: 0xE4E6D0 VA: 0x180E4FCD0
	|-AsyncTaskCache.CreateCacheableTask<Nullable<Decimal>>
	|
	|-RVA: 0xE4FE10 Offset: 0xE4E810 VA: 0x180E4FE10
	|-AsyncTaskCache.CreateCacheableTask<Nullable<double>>
	|
	|-RVA: 0xE4FF30 Offset: 0xE4E930 VA: 0x180E4FF30
	|-AsyncTaskCache.CreateCacheableTask<Nullable<int>>
	|
	|-RVA: 0xE50170 Offset: 0xE4EB70 VA: 0x180E50170
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<bool, object>>
	|
	|-RVA: 0xE50200 Offset: 0xE4EC00 VA: 0x180E50200
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, object, int>>
	|
	|-RVA: 0xE502A0 Offset: 0xE4ECA0 VA: 0x180E502A0
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, bool, bool, object, object>>
	|
	|-RVA: 0xE4FA00 Offset: 0xE4E400 VA: 0x180E4FA00
	|-AsyncTaskCache.CreateCacheableTask<bool>
	|
	|-RVA: 0xE4FA90 Offset: 0xE4E490 VA: 0x180E4FA90
	|-AsyncTaskCache.CreateCacheableTask<char>
	|
	|-RVA: 0xE4FC40 Offset: 0xE4E640 VA: 0x180E4FC40
	|-AsyncTaskCache.CreateCacheableTask<int>
	|
	|-RVA: 0xE50050 Offset: 0xE4EA50 VA: 0x180E50050
	|-AsyncTaskCache.CreateCacheableTask<object>
	|
	|-RVA: 0xE500E0 Offset: 0xE4EAE0 VA: 0x180E500E0
	|-AsyncTaskCache.CreateCacheableTask<SerializableProjectConfiguration>
	|
	|-RVA: 0xE50340 Offset: 0xE4ED40 VA: 0x180E50340
	|-AsyncTaskCache.CreateCacheableTask<VoidTaskResult>
	|
	|-RVA: 0xE4FB20 Offset: 0xE4E520 VA: 0x180E4FB20
	|-AsyncTaskCache.CreateCacheableTask<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1B5F420 Offset: 0x1B5DE20 VA: 0x181B5F420
	private static void .cctor() { }
}
