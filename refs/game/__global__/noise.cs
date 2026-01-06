public static class noise // TypeDefIndex: 10937
{
	// Methods

	// RVA: 0x2971830 Offset: 0x2970230 VA: 0x182971830
	public static float2 cellular(float2 P) { }

	// RVA: 0x2970530 Offset: 0x296EF30 VA: 0x182970530
	public static float2 cellular2x2(float2 P) { }

	// RVA: 0x2970A30 Offset: 0x296F430 VA: 0x182970A30
	public static float2 cellular2x2x2(float3 P) { }

	// RVA: 0x29722E0 Offset: 0x2970CE0 VA: 0x1829722E0
	public static float2 cellular(float3 P) { }

	// RVA: 0x29791B0 Offset: 0x2977BB0 VA: 0x1829791B0
	public static float cnoise(float2 P) { }

	// RVA: 0x297A4F0 Offset: 0x2978EF0 VA: 0x18297A4F0
	public static float pnoise(float2 P, float2 rep) { }

	// RVA: 0x2977E20 Offset: 0x2976820 VA: 0x182977E20
	public static float cnoise(float3 P) { }

	// RVA: 0x297DAC0 Offset: 0x297C4C0 VA: 0x18297DAC0
	public static float pnoise(float3 P, float3 rep) { }

	// RVA: 0x2974FB0 Offset: 0x29739B0 VA: 0x182974FB0
	public static float cnoise(float4 P) { }

	// RVA: 0x297ABC0 Offset: 0x29795C0 VA: 0x18297ABC0
	public static float pnoise(float4 P, float4 rep) { }

	// RVA: 0x2979DF0 Offset: 0x29787F0 VA: 0x182979DF0
	private static float mod289(float x) { }

	// RVA: 0x2979F30 Offset: 0x2978930 VA: 0x182979F30
	private static float2 mod289(float2 x) { }

	// RVA: 0x2979E70 Offset: 0x2978870 VA: 0x182979E70
	private static float3 mod289(float3 x) { }

	// RVA: 0x2979FC0 Offset: 0x29789C0 VA: 0x182979FC0
	private static float4 mod289(float4 x) { }

	// RVA: 0x297A1C0 Offset: 0x2978BC0 VA: 0x18297A1C0
	private static float3 mod7(float3 x) { }

	// RVA: 0x297A0C0 Offset: 0x2978AC0 VA: 0x18297A0C0
	private static float4 mod7(float4 x) { }

	// RVA: 0x297A450 Offset: 0x2978E50 VA: 0x18297A450
	private static float permute(float x) { }

	// RVA: 0x297A340 Offset: 0x2978D40 VA: 0x18297A340
	private static float3 permute(float3 x) { }

	// RVA: 0x297A280 Offset: 0x2978C80 VA: 0x18297A280
	private static float4 permute(float4 x) { }

	// RVA: 0x2983D00 Offset: 0x2982700 VA: 0x182983D00
	private static float taylorInvSqrt(float r) { }

	// RVA: 0x2983C70 Offset: 0x2982670 VA: 0x182983C70
	private static float4 taylorInvSqrt(float4 r) { }

	// RVA: 0x2979A00 Offset: 0x2978400 VA: 0x182979A00
	private static float2 fade(float2 t) { }

	// RVA: 0x2979A90 Offset: 0x2978490 VA: 0x182979A90
	private static float3 fade(float3 t) { }

	// RVA: 0x2979840 Offset: 0x2978240 VA: 0x182979840
	private static float4 fade(float4 t) { }

	// RVA: 0x2979B90 Offset: 0x2978590 VA: 0x182979B90
	private static float4 grad4(float j, float4 ip) { }

	// RVA: 0x297F810 Offset: 0x297E210 VA: 0x18297F810
	private static float2 rgrad2(float2 p, float rot) { }

	// RVA: 0x2981D30 Offset: 0x2980730 VA: 0x182981D30
	public static float snoise(float2 v) { }

	// RVA: 0x2982270 Offset: 0x2980C70 VA: 0x182982270
	public static float snoise(float3 v) { }

	// RVA: 0x2980BA0 Offset: 0x297F5A0 VA: 0x182980BA0
	public static float snoise(float3 v, out float3 gradient) { }

	// RVA: 0x297F9C0 Offset: 0x297E3C0 VA: 0x18297F9C0
	public static float snoise(float4 v) { }

	// RVA: 0x297EEB0 Offset: 0x297D8B0 VA: 0x18297EEB0
	public static float3 psrdnoise(float2 pos, float2 per, float rot) { }

	// RVA: 0x297F410 Offset: 0x297DE10 VA: 0x18297F410
	public static float3 psrdnoise(float2 pos, float2 per) { }

	// RVA: 0x297F460 Offset: 0x297DE60 VA: 0x18297F460
	public static float psrnoise(float2 pos, float2 per, float rot) { }

	// RVA: 0x297F450 Offset: 0x297DE50 VA: 0x18297F450
	public static float psrnoise(float2 pos, float2 per) { }

	// RVA: 0x29831E0 Offset: 0x2981BE0 VA: 0x1829831E0
	public static float3 srdnoise(float2 pos, float rot) { }

	// RVA: 0x29831B0 Offset: 0x2981BB0 VA: 0x1829831B0
	public static float3 srdnoise(float2 pos) { }

	// RVA: 0x2983800 Offset: 0x2982200 VA: 0x182983800
	public static float srnoise(float2 pos, float rot) { }

	// RVA: 0x29837F0 Offset: 0x29821F0 VA: 0x1829837F0
	public static float srnoise(float2 pos) { }
}
