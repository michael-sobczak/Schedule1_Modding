internal static class EventInterestReflectionUtils // TypeDefIndex: 7029
{
	// Fields
	private static readonly Dictionary<Type, EventInterestReflectionUtils.DefaultEventInterests> s_DefaultEventInterests; // 0x0
	private static readonly Dictionary<Type, EventCategory> s_EventCategories; // 0x8

	// Methods

	// RVA: 0x2DDDA00 Offset: 0x2DDC400 VA: 0x182DDDA00
	internal static void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories) { }

	// RVA: 0x2DDD7E0 Offset: 0x2DDC1E0 VA: 0x182DDD7E0
	private static int ComputeDefaultEventInterests(Type elementType, string methodName) { }

	// RVA: 0x2DDDC30 Offset: 0x2DDC630 VA: 0x182DDDC30
	internal static EventCategory GetEventCategory(Type eventType) { }

	// RVA: 0x2DDDE60 Offset: 0x2DDC860 VA: 0x182DDDE60
	private static void .cctor() { }
}
