public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 10910
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	public static readonly float4 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public float4 xxxx { get; }
	[EditorBrowsable(1)]
	public float4 xxxy { get; }
	[EditorBrowsable(1)]
	public float4 xxxz { get; }
	[EditorBrowsable(1)]
	public float4 xxxw { get; }
	[EditorBrowsable(1)]
	public float4 xxyx { get; }
	[EditorBrowsable(1)]
	public float4 xxyy { get; }
	[EditorBrowsable(1)]
	public float4 xxyz { get; }
	[EditorBrowsable(1)]
	public float4 xxyw { get; }
	[EditorBrowsable(1)]
	public float4 xxzx { get; }
	[EditorBrowsable(1)]
	public float4 xxzy { get; }
	[EditorBrowsable(1)]
	public float4 xxzz { get; }
	[EditorBrowsable(1)]
	public float4 xxzw { get; }
	[EditorBrowsable(1)]
	public float4 xxwx { get; }
	[EditorBrowsable(1)]
	public float4 xxwy { get; }
	[EditorBrowsable(1)]
	public float4 xxwz { get; }
	[EditorBrowsable(1)]
	public float4 xxww { get; }
	[EditorBrowsable(1)]
	public float4 xyxx { get; }
	[EditorBrowsable(1)]
	public float4 xyxy { get; }
	[EditorBrowsable(1)]
	public float4 xyxz { get; }
	[EditorBrowsable(1)]
	public float4 xyxw { get; }
	[EditorBrowsable(1)]
	public float4 xyyx { get; }
	[EditorBrowsable(1)]
	public float4 xyyy { get; }
	[EditorBrowsable(1)]
	public float4 xyyz { get; }
	[EditorBrowsable(1)]
	public float4 xyyw { get; }
	[EditorBrowsable(1)]
	public float4 xyzx { get; }
	[EditorBrowsable(1)]
	public float4 xyzy { get; }
	[EditorBrowsable(1)]
	public float4 xyzz { get; }
	[EditorBrowsable(1)]
	public float4 xyzw { get; set; }
	[EditorBrowsable(1)]
	public float4 xywx { get; }
	[EditorBrowsable(1)]
	public float4 xywy { get; }
	[EditorBrowsable(1)]
	public float4 xywz { get; set; }
	[EditorBrowsable(1)]
	public float4 xyww { get; }
	[EditorBrowsable(1)]
	public float4 xzxx { get; }
	[EditorBrowsable(1)]
	public float4 xzxy { get; }
	[EditorBrowsable(1)]
	public float4 xzxz { get; }
	[EditorBrowsable(1)]
	public float4 xzxw { get; }
	[EditorBrowsable(1)]
	public float4 xzyx { get; }
	[EditorBrowsable(1)]
	public float4 xzyy { get; }
	[EditorBrowsable(1)]
	public float4 xzyz { get; }
	[EditorBrowsable(1)]
	public float4 xzyw { get; set; }
	[EditorBrowsable(1)]
	public float4 xzzx { get; }
	[EditorBrowsable(1)]
	public float4 xzzy { get; }
	[EditorBrowsable(1)]
	public float4 xzzz { get; }
	[EditorBrowsable(1)]
	public float4 xzzw { get; }
	[EditorBrowsable(1)]
	public float4 xzwx { get; }
	[EditorBrowsable(1)]
	public float4 xzwy { get; set; }
	[EditorBrowsable(1)]
	public float4 xzwz { get; }
	[EditorBrowsable(1)]
	public float4 xzww { get; }
	[EditorBrowsable(1)]
	public float4 xwxx { get; }
	[EditorBrowsable(1)]
	public float4 xwxy { get; }
	[EditorBrowsable(1)]
	public float4 xwxz { get; }
	[EditorBrowsable(1)]
	public float4 xwxw { get; }
	[EditorBrowsable(1)]
	public float4 xwyx { get; }
	[EditorBrowsable(1)]
	public float4 xwyy { get; }
	[EditorBrowsable(1)]
	public float4 xwyz { get; set; }
	[EditorBrowsable(1)]
	public float4 xwyw { get; }
	[EditorBrowsable(1)]
	public float4 xwzx { get; }
	[EditorBrowsable(1)]
	public float4 xwzy { get; set; }
	[EditorBrowsable(1)]
	public float4 xwzz { get; }
	[EditorBrowsable(1)]
	public float4 xwzw { get; }
	[EditorBrowsable(1)]
	public float4 xwwx { get; }
	[EditorBrowsable(1)]
	public float4 xwwy { get; }
	[EditorBrowsable(1)]
	public float4 xwwz { get; }
	[EditorBrowsable(1)]
	public float4 xwww { get; }
	[EditorBrowsable(1)]
	public float4 yxxx { get; }
	[EditorBrowsable(1)]
	public float4 yxxy { get; }
	[EditorBrowsable(1)]
	public float4 yxxz { get; }
	[EditorBrowsable(1)]
	public float4 yxxw { get; }
	[EditorBrowsable(1)]
	public float4 yxyx { get; }
	[EditorBrowsable(1)]
	public float4 yxyy { get; }
	[EditorBrowsable(1)]
	public float4 yxyz { get; }
	[EditorBrowsable(1)]
	public float4 yxyw { get; }
	[EditorBrowsable(1)]
	public float4 yxzx { get; }
	[EditorBrowsable(1)]
	public float4 yxzy { get; }
	[EditorBrowsable(1)]
	public float4 yxzz { get; }
	[EditorBrowsable(1)]
	public float4 yxzw { get; set; }
	[EditorBrowsable(1)]
	public float4 yxwx { get; }
	[EditorBrowsable(1)]
	public float4 yxwy { get; }
	[EditorBrowsable(1)]
	public float4 yxwz { get; set; }
	[EditorBrowsable(1)]
	public float4 yxww { get; }
	[EditorBrowsable(1)]
	public float4 yyxx { get; }
	[EditorBrowsable(1)]
	public float4 yyxy { get; }
	[EditorBrowsable(1)]
	public float4 yyxz { get; }
	[EditorBrowsable(1)]
	public float4 yyxw { get; }
	[EditorBrowsable(1)]
	public float4 yyyx { get; }
	[EditorBrowsable(1)]
	public float4 yyyy { get; }
	[EditorBrowsable(1)]
	public float4 yyyz { get; }
	[EditorBrowsable(1)]
	public float4 yyyw { get; }
	[EditorBrowsable(1)]
	public float4 yyzx { get; }
	[EditorBrowsable(1)]
	public float4 yyzy { get; }
	[EditorBrowsable(1)]
	public float4 yyzz { get; }
	[EditorBrowsable(1)]
	public float4 yyzw { get; }
	[EditorBrowsable(1)]
	public float4 yywx { get; }
	[EditorBrowsable(1)]
	public float4 yywy { get; }
	[EditorBrowsable(1)]
	public float4 yywz { get; }
	[EditorBrowsable(1)]
	public float4 yyww { get; }
	[EditorBrowsable(1)]
	public float4 yzxx { get; }
	[EditorBrowsable(1)]
	public float4 yzxy { get; }
	[EditorBrowsable(1)]
	public float4 yzxz { get; }
	[EditorBrowsable(1)]
	public float4 yzxw { get; set; }
	[EditorBrowsable(1)]
	public float4 yzyx { get; }
	[EditorBrowsable(1)]
	public float4 yzyy { get; }
	[EditorBrowsable(1)]
	public float4 yzyz { get; }
	[EditorBrowsable(1)]
	public float4 yzyw { get; }
	[EditorBrowsable(1)]
	public float4 yzzx { get; }
	[EditorBrowsable(1)]
	public float4 yzzy { get; }
	[EditorBrowsable(1)]
	public float4 yzzz { get; }
	[EditorBrowsable(1)]
	public float4 yzzw { get; }
	[EditorBrowsable(1)]
	public float4 yzwx { get; set; }
	[EditorBrowsable(1)]
	public float4 yzwy { get; }
	[EditorBrowsable(1)]
	public float4 yzwz { get; }
	[EditorBrowsable(1)]
	public float4 yzww { get; }
	[EditorBrowsable(1)]
	public float4 ywxx { get; }
	[EditorBrowsable(1)]
	public float4 ywxy { get; }
	[EditorBrowsable(1)]
	public float4 ywxz { get; set; }
	[EditorBrowsable(1)]
	public float4 ywxw { get; }
	[EditorBrowsable(1)]
	public float4 ywyx { get; }
	[EditorBrowsable(1)]
	public float4 ywyy { get; }
	[EditorBrowsable(1)]
	public float4 ywyz { get; }
	[EditorBrowsable(1)]
	public float4 ywyw { get; }
	[EditorBrowsable(1)]
	public float4 ywzx { get; set; }
	[EditorBrowsable(1)]
	public float4 ywzy { get; }
	[EditorBrowsable(1)]
	public float4 ywzz { get; }
	[EditorBrowsable(1)]
	public float4 ywzw { get; }
	[EditorBrowsable(1)]
	public float4 ywwx { get; }
	[EditorBrowsable(1)]
	public float4 ywwy { get; }
	[EditorBrowsable(1)]
	public float4 ywwz { get; }
	[EditorBrowsable(1)]
	public float4 ywww { get; }
	[EditorBrowsable(1)]
	public float4 zxxx { get; }
	[EditorBrowsable(1)]
	public float4 zxxy { get; }
	[EditorBrowsable(1)]
	public float4 zxxz { get; }
	[EditorBrowsable(1)]
	public float4 zxxw { get; }
	[EditorBrowsable(1)]
	public float4 zxyx { get; }
	[EditorBrowsable(1)]
	public float4 zxyy { get; }
	[EditorBrowsable(1)]
	public float4 zxyz { get; }
	[EditorBrowsable(1)]
	public float4 zxyw { get; set; }
	[EditorBrowsable(1)]
	public float4 zxzx { get; }
	[EditorBrowsable(1)]
	public float4 zxzy { get; }
	[EditorBrowsable(1)]
	public float4 zxzz { get; }
	[EditorBrowsable(1)]
	public float4 zxzw { get; }
	[EditorBrowsable(1)]
	public float4 zxwx { get; }
	[EditorBrowsable(1)]
	public float4 zxwy { get; set; }
	[EditorBrowsable(1)]
	public float4 zxwz { get; }
	[EditorBrowsable(1)]
	public float4 zxww { get; }
	[EditorBrowsable(1)]
	public float4 zyxx { get; }
	[EditorBrowsable(1)]
	public float4 zyxy { get; }
	[EditorBrowsable(1)]
	public float4 zyxz { get; }
	[EditorBrowsable(1)]
	public float4 zyxw { get; set; }
	[EditorBrowsable(1)]
	public float4 zyyx { get; }
	[EditorBrowsable(1)]
	public float4 zyyy { get; }
	[EditorBrowsable(1)]
	public float4 zyyz { get; }
	[EditorBrowsable(1)]
	public float4 zyyw { get; }
	[EditorBrowsable(1)]
	public float4 zyzx { get; }
	[EditorBrowsable(1)]
	public float4 zyzy { get; }
	[EditorBrowsable(1)]
	public float4 zyzz { get; }
	[EditorBrowsable(1)]
	public float4 zyzw { get; }
	[EditorBrowsable(1)]
	public float4 zywx { get; set; }
	[EditorBrowsable(1)]
	public float4 zywy { get; }
	[EditorBrowsable(1)]
	public float4 zywz { get; }
	[EditorBrowsable(1)]
	public float4 zyww { get; }
	[EditorBrowsable(1)]
	public float4 zzxx { get; }
	[EditorBrowsable(1)]
	public float4 zzxy { get; }
	[EditorBrowsable(1)]
	public float4 zzxz { get; }
	[EditorBrowsable(1)]
	public float4 zzxw { get; }
	[EditorBrowsable(1)]
	public float4 zzyx { get; }
	[EditorBrowsable(1)]
	public float4 zzyy { get; }
	[EditorBrowsable(1)]
	public float4 zzyz { get; }
	[EditorBrowsable(1)]
	public float4 zzyw { get; }
	[EditorBrowsable(1)]
	public float4 zzzx { get; }
	[EditorBrowsable(1)]
	public float4 zzzy { get; }
	[EditorBrowsable(1)]
	public float4 zzzz { get; }
	[EditorBrowsable(1)]
	public float4 zzzw { get; }
	[EditorBrowsable(1)]
	public float4 zzwx { get; }
	[EditorBrowsable(1)]
	public float4 zzwy { get; }
	[EditorBrowsable(1)]
	public float4 zzwz { get; }
	[EditorBrowsable(1)]
	public float4 zzww { get; }
	[EditorBrowsable(1)]
	public float4 zwxx { get; }
	[EditorBrowsable(1)]
	public float4 zwxy { get; set; }
	[EditorBrowsable(1)]
	public float4 zwxz { get; }
	[EditorBrowsable(1)]
	public float4 zwxw { get; }
	[EditorBrowsable(1)]
	public float4 zwyx { get; set; }
	[EditorBrowsable(1)]
	public float4 zwyy { get; }
	[EditorBrowsable(1)]
	public float4 zwyz { get; }
	[EditorBrowsable(1)]
	public float4 zwyw { get; }
	[EditorBrowsable(1)]
	public float4 zwzx { get; }
	[EditorBrowsable(1)]
	public float4 zwzy { get; }
	[EditorBrowsable(1)]
	public float4 zwzz { get; }
	[EditorBrowsable(1)]
	public float4 zwzw { get; }
	[EditorBrowsable(1)]
	public float4 zwwx { get; }
	[EditorBrowsable(1)]
	public float4 zwwy { get; }
	[EditorBrowsable(1)]
	public float4 zwwz { get; }
	[EditorBrowsable(1)]
	public float4 zwww { get; }
	[EditorBrowsable(1)]
	public float4 wxxx { get; }
	[EditorBrowsable(1)]
	public float4 wxxy { get; }
	[EditorBrowsable(1)]
	public float4 wxxz { get; }
	[EditorBrowsable(1)]
	public float4 wxxw { get; }
	[EditorBrowsable(1)]
	public float4 wxyx { get; }
	[EditorBrowsable(1)]
	public float4 wxyy { get; }
	[EditorBrowsable(1)]
	public float4 wxyz { get; set; }
	[EditorBrowsable(1)]
	public float4 wxyw { get; }
	[EditorBrowsable(1)]
	public float4 wxzx { get; }
	[EditorBrowsable(1)]
	public float4 wxzy { get; set; }
	[EditorBrowsable(1)]
	public float4 wxzz { get; }
	[EditorBrowsable(1)]
	public float4 wxzw { get; }
	[EditorBrowsable(1)]
	public float4 wxwx { get; }
	[EditorBrowsable(1)]
	public float4 wxwy { get; }
	[EditorBrowsable(1)]
	public float4 wxwz { get; }
	[EditorBrowsable(1)]
	public float4 wxww { get; }
	[EditorBrowsable(1)]
	public float4 wyxx { get; }
	[EditorBrowsable(1)]
	public float4 wyxy { get; }
	[EditorBrowsable(1)]
	public float4 wyxz { get; set; }
	[EditorBrowsable(1)]
	public float4 wyxw { get; }
	[EditorBrowsable(1)]
	public float4 wyyx { get; }
	[EditorBrowsable(1)]
	public float4 wyyy { get; }
	[EditorBrowsable(1)]
	public float4 wyyz { get; }
	[EditorBrowsable(1)]
	public float4 wyyw { get; }
	[EditorBrowsable(1)]
	public float4 wyzx { get; set; }
	[EditorBrowsable(1)]
	public float4 wyzy { get; }
	[EditorBrowsable(1)]
	public float4 wyzz { get; }
	[EditorBrowsable(1)]
	public float4 wyzw { get; }
	[EditorBrowsable(1)]
	public float4 wywx { get; }
	[EditorBrowsable(1)]
	public float4 wywy { get; }
	[EditorBrowsable(1)]
	public float4 wywz { get; }
	[EditorBrowsable(1)]
	public float4 wyww { get; }
	[EditorBrowsable(1)]
	public float4 wzxx { get; }
	[EditorBrowsable(1)]
	public float4 wzxy { get; set; }
	[EditorBrowsable(1)]
	public float4 wzxz { get; }
	[EditorBrowsable(1)]
	public float4 wzxw { get; }
	[EditorBrowsable(1)]
	public float4 wzyx { get; set; }
	[EditorBrowsable(1)]
	public float4 wzyy { get; }
	[EditorBrowsable(1)]
	public float4 wzyz { get; }
	[EditorBrowsable(1)]
	public float4 wzyw { get; }
	[EditorBrowsable(1)]
	public float4 wzzx { get; }
	[EditorBrowsable(1)]
	public float4 wzzy { get; }
	[EditorBrowsable(1)]
	public float4 wzzz { get; }
	[EditorBrowsable(1)]
	public float4 wzzw { get; }
	[EditorBrowsable(1)]
	public float4 wzwx { get; }
	[EditorBrowsable(1)]
	public float4 wzwy { get; }
	[EditorBrowsable(1)]
	public float4 wzwz { get; }
	[EditorBrowsable(1)]
	public float4 wzww { get; }
	[EditorBrowsable(1)]
	public float4 wwxx { get; }
	[EditorBrowsable(1)]
	public float4 wwxy { get; }
	[EditorBrowsable(1)]
	public float4 wwxz { get; }
	[EditorBrowsable(1)]
	public float4 wwxw { get; }
	[EditorBrowsable(1)]
	public float4 wwyx { get; }
	[EditorBrowsable(1)]
	public float4 wwyy { get; }
	[EditorBrowsable(1)]
	public float4 wwyz { get; }
	[EditorBrowsable(1)]
	public float4 wwyw { get; }
	[EditorBrowsable(1)]
	public float4 wwzx { get; }
	[EditorBrowsable(1)]
	public float4 wwzy { get; }
	[EditorBrowsable(1)]
	public float4 wwzz { get; }
	[EditorBrowsable(1)]
	public float4 wwzw { get; }
	[EditorBrowsable(1)]
	public float4 wwwx { get; }
	[EditorBrowsable(1)]
	public float4 wwwy { get; }
	[EditorBrowsable(1)]
	public float4 wwwz { get; }
	[EditorBrowsable(1)]
	public float4 wwww { get; }
	[EditorBrowsable(1)]
	public float3 xxx { get; }
	[EditorBrowsable(1)]
	public float3 xxy { get; }
	[EditorBrowsable(1)]
	public float3 xxz { get; }
	[EditorBrowsable(1)]
	public float3 xxw { get; }
	[EditorBrowsable(1)]
	public float3 xyx { get; }
	[EditorBrowsable(1)]
	public float3 xyy { get; }
	[EditorBrowsable(1)]
	public float3 xyz { get; set; }
	[EditorBrowsable(1)]
	public float3 xyw { get; set; }
	[EditorBrowsable(1)]
	public float3 xzx { get; }
	[EditorBrowsable(1)]
	public float3 xzy { get; set; }
	[EditorBrowsable(1)]
	public float3 xzz { get; }
	[EditorBrowsable(1)]
	public float3 xzw { get; set; }
	[EditorBrowsable(1)]
	public float3 xwx { get; }
	[EditorBrowsable(1)]
	public float3 xwy { get; set; }
	[EditorBrowsable(1)]
	public float3 xwz { get; set; }
	[EditorBrowsable(1)]
	public float3 xww { get; }
	[EditorBrowsable(1)]
	public float3 yxx { get; }
	[EditorBrowsable(1)]
	public float3 yxy { get; }
	[EditorBrowsable(1)]
	public float3 yxz { get; set; }
	[EditorBrowsable(1)]
	public float3 yxw { get; set; }
	[EditorBrowsable(1)]
	public float3 yyx { get; }
	[EditorBrowsable(1)]
	public float3 yyy { get; }
	[EditorBrowsable(1)]
	public float3 yyz { get; }
	[EditorBrowsable(1)]
	public float3 yyw { get; }
	[EditorBrowsable(1)]
	public float3 yzx { get; set; }
	[EditorBrowsable(1)]
	public float3 yzy { get; }
	[EditorBrowsable(1)]
	public float3 yzz { get; }
	[EditorBrowsable(1)]
	public float3 yzw { get; set; }
	[EditorBrowsable(1)]
	public float3 ywx { get; set; }
	[EditorBrowsable(1)]
	public float3 ywy { get; }
	[EditorBrowsable(1)]
	public float3 ywz { get; set; }
	[EditorBrowsable(1)]
	public float3 yww { get; }
	[EditorBrowsable(1)]
	public float3 zxx { get; }
	[EditorBrowsable(1)]
	public float3 zxy { get; set; }
	[EditorBrowsable(1)]
	public float3 zxz { get; }
	[EditorBrowsable(1)]
	public float3 zxw { get; set; }
	[EditorBrowsable(1)]
	public float3 zyx { get; set; }
	[EditorBrowsable(1)]
	public float3 zyy { get; }
	[EditorBrowsable(1)]
	public float3 zyz { get; }
	[EditorBrowsable(1)]
	public float3 zyw { get; set; }
	[EditorBrowsable(1)]
	public float3 zzx { get; }
	[EditorBrowsable(1)]
	public float3 zzy { get; }
	[EditorBrowsable(1)]
	public float3 zzz { get; }
	[EditorBrowsable(1)]
	public float3 zzw { get; }
	[EditorBrowsable(1)]
	public float3 zwx { get; set; }
	[EditorBrowsable(1)]
	public float3 zwy { get; set; }
	[EditorBrowsable(1)]
	public float3 zwz { get; }
	[EditorBrowsable(1)]
	public float3 zww { get; }
	[EditorBrowsable(1)]
	public float3 wxx { get; }
	[EditorBrowsable(1)]
	public float3 wxy { get; set; }
	[EditorBrowsable(1)]
	public float3 wxz { get; set; }
	[EditorBrowsable(1)]
	public float3 wxw { get; }
	[EditorBrowsable(1)]
	public float3 wyx { get; set; }
	[EditorBrowsable(1)]
	public float3 wyy { get; }
	[EditorBrowsable(1)]
	public float3 wyz { get; set; }
	[EditorBrowsable(1)]
	public float3 wyw { get; }
	[EditorBrowsable(1)]
	public float3 wzx { get; set; }
	[EditorBrowsable(1)]
	public float3 wzy { get; set; }
	[EditorBrowsable(1)]
	public float3 wzz { get; }
	[EditorBrowsable(1)]
	public float3 wzw { get; }
	[EditorBrowsable(1)]
	public float3 wwx { get; }
	[EditorBrowsable(1)]
	public float3 wwy { get; }
	[EditorBrowsable(1)]
	public float3 wwz { get; }
	[EditorBrowsable(1)]
	public float3 www { get; }
	[EditorBrowsable(1)]
	public float2 xx { get; }
	[EditorBrowsable(1)]
	public float2 xy { get; set; }
	[EditorBrowsable(1)]
	public float2 xz { get; set; }
	[EditorBrowsable(1)]
	public float2 xw { get; set; }
	[EditorBrowsable(1)]
	public float2 yx { get; set; }
	[EditorBrowsable(1)]
	public float2 yy { get; }
	[EditorBrowsable(1)]
	public float2 yz { get; set; }
	[EditorBrowsable(1)]
	public float2 yw { get; set; }
	[EditorBrowsable(1)]
	public float2 zx { get; set; }
	[EditorBrowsable(1)]
	public float2 zy { get; set; }
	[EditorBrowsable(1)]
	public float2 zz { get; }
	[EditorBrowsable(1)]
	public float2 zw { get; set; }
	[EditorBrowsable(1)]
	public float2 wx { get; set; }
	[EditorBrowsable(1)]
	public float2 wy { get; set; }
	[EditorBrowsable(1)]
	public float2 wz { get; set; }
	[EditorBrowsable(1)]
	public float2 ww { get; }
	public float Item { get; set; }

	// Methods

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x293DCB0 Offset: 0x293C6B0 VA: 0x18293DCB0
	public void .ctor(float x, float y, float2 zw) { }

	// RVA: 0x293DDD0 Offset: 0x293C7D0 VA: 0x18293DDD0
	public void .ctor(float x, float2 yz, float w) { }

	// RVA: 0x293DE00 Offset: 0x293C800 VA: 0x18293DE00
	public void .ctor(float x, float3 yzw) { }

	// RVA: 0x293DC60 Offset: 0x293C660 VA: 0x18293DC60
	public void .ctor(float2 xy, float z, float w) { }

	// RVA: 0x214CB60 Offset: 0x214B560 VA: 0x18214CB60
	public void .ctor(float2 xy, float2 zw) { }

	// RVA: 0x293DC40 Offset: 0x293C640 VA: 0x18293DC40
	public void .ctor(float3 xyz, float w) { }

	// RVA: 0x22D2A70 Offset: 0x22D1470 VA: 0x1822D2A70
	public void .ctor(float4 xyzw) { }

	// RVA: 0x2712650 Offset: 0x2711050 VA: 0x182712650
	public void .ctor(float v) { }

	// RVA: 0x293DCE0 Offset: 0x293C6E0 VA: 0x18293DCE0
	public void .ctor(bool v) { }

	// RVA: 0x293DD60 Offset: 0x293C760 VA: 0x18293DD60
	public void .ctor(bool4 v) { }

	// RVA: 0x293DD00 Offset: 0x293C700 VA: 0x18293DD00
	public void .ctor(int v) { }

	// RVA: 0x293DDC0 Offset: 0x293C7C0 VA: 0x18293DDC0
	public void .ctor(int4 v) { }

	// RVA: 0x293DBB0 Offset: 0x293C5B0 VA: 0x18293DBB0
	public void .ctor(uint v) { }

	// RVA: 0x293DD10 Offset: 0x293C710 VA: 0x18293DD10
	public void .ctor(uint4 v) { }

	// RVA: 0x2883060 Offset: 0x2881A60 VA: 0x182883060
	public void .ctor(half v) { }

	// RVA: 0x2882ED0 Offset: 0x28818D0 VA: 0x182882ED0
	public void .ctor(half4 v) { }

	// RVA: 0x293DC90 Offset: 0x293C690 VA: 0x18293DC90
	public void .ctor(double v) { }

	// RVA: 0x293DC00 Offset: 0x293C600 VA: 0x18293DC00
	public void .ctor(double4 v) { }

	// RVA: 0x2710A40 Offset: 0x270F440 VA: 0x182710A40
	public static float4 op_Implicit(float v) { }

	// RVA: 0x289BBC0 Offset: 0x289A5C0 VA: 0x18289BBC0
	public static float4 op_Explicit(bool v) { }

	// RVA: 0x289B8B0 Offset: 0x289A2B0 VA: 0x18289B8B0
	public static float4 op_Explicit(bool4 v) { }

	// RVA: 0x289BB20 Offset: 0x289A520 VA: 0x18289BB20
	public static float4 op_Implicit(int v) { }

	// RVA: 0x289BB70 Offset: 0x289A570 VA: 0x18289BB70
	public static float4 op_Implicit(int4 v) { }

	// RVA: 0x2899470 Offset: 0x2897E70 VA: 0x182899470
	public static float4 op_Implicit(uint v) { }

	// RVA: 0x289BC60 Offset: 0x289A660 VA: 0x18289BC60
	public static float4 op_Implicit(uint4 v) { }

	// RVA: 0x293E2F0 Offset: 0x293CCF0 VA: 0x18293E2F0
	public static float4 op_Implicit(half v) { }

	// RVA: 0x289B910 Offset: 0x289A310 VA: 0x18289B910
	public static float4 op_Implicit(half4 v) { }

	// RVA: 0x289BB00 Offset: 0x289A500 VA: 0x18289BB00
	public static float4 op_Explicit(double v) { }

	// RVA: 0x289B860 Offset: 0x289A260 VA: 0x18289B860
	public static float4 op_Explicit(double4 v) { }

	// RVA: 0x1F64FF0 Offset: 0x1F639F0 VA: 0x181F64FF0
	public static float4 op_Multiply(float4 lhs, float4 rhs) { }

	// RVA: 0x1F65040 Offset: 0x1F63A40 VA: 0x181F65040
	public static float4 op_Multiply(float4 lhs, float rhs) { }

	// RVA: 0x293E6E0 Offset: 0x293D0E0 VA: 0x18293E6E0
	public static float4 op_Multiply(float lhs, float4 rhs) { }

	// RVA: 0x293DF00 Offset: 0x293C900 VA: 0x18293DF00
	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	// RVA: 0x293DF50 Offset: 0x293C950 VA: 0x18293DF50
	public static float4 op_Addition(float4 lhs, float rhs) { }

	// RVA: 0x293DEE0 Offset: 0x293C8E0 VA: 0x18293DEE0
	public static float4 op_Addition(float lhs, float4 rhs) { }

	// RVA: 0x28831F0 Offset: 0x2881BF0 VA: 0x1828831F0
	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	// RVA: 0x28831D0 Offset: 0x2881BD0 VA: 0x1828831D0
	public static float4 op_Subtraction(float4 lhs, float rhs) { }

	// RVA: 0x293E700 Offset: 0x293D100 VA: 0x18293E700
	public static float4 op_Subtraction(float lhs, float4 rhs) { }

	// RVA: 0x293DF90 Offset: 0x293C990 VA: 0x18293DF90
	public static float4 op_Division(float4 lhs, float4 rhs) { }

	// RVA: 0x293E020 Offset: 0x293CA20 VA: 0x18293E020
	public static float4 op_Division(float4 lhs, float rhs) { }

	// RVA: 0x293DFE0 Offset: 0x293C9E0 VA: 0x18293DFE0
	public static float4 op_Division(float lhs, float4 rhs) { }

	// RVA: 0x289DAE0 Offset: 0x289C4E0 VA: 0x18289DAE0
	public static float4 op_Modulus(float4 lhs, float4 rhs) { }

	// RVA: 0x293E5E0 Offset: 0x293CFE0 VA: 0x18293E5E0
	public static float4 op_Modulus(float4 lhs, float rhs) { }

	// RVA: 0x293E660 Offset: 0x293D060 VA: 0x18293E660
	public static float4 op_Modulus(float lhs, float4 rhs) { }

	// RVA: 0x293E310 Offset: 0x293CD10 VA: 0x18293E310
	public static float4 op_Increment(float4 val) { }

	// RVA: 0x293DF70 Offset: 0x293C970 VA: 0x18293DF70
	public static float4 op_Decrement(float4 val) { }

	// RVA: 0x293E5A0 Offset: 0x293CFA0 VA: 0x18293E5A0
	public static bool4 op_LessThan(float4 lhs, float4 rhs) { }

	// RVA: 0x293E530 Offset: 0x293CF30 VA: 0x18293E530
	public static bool4 op_LessThan(float4 lhs, float rhs) { }

	// RVA: 0x293E560 Offset: 0x293CF60 VA: 0x18293E560
	public static bool4 op_LessThan(float lhs, float4 rhs) { }

	// RVA: 0x293E480 Offset: 0x293CE80 VA: 0x18293E480
	public static bool4 op_LessThanOrEqual(float4 lhs, float4 rhs) { }

	// RVA: 0x293E500 Offset: 0x293CF00 VA: 0x18293E500
	public static bool4 op_LessThanOrEqual(float4 lhs, float rhs) { }

	// RVA: 0x293E4C0 Offset: 0x293CEC0 VA: 0x18293E4C0
	public static bool4 op_LessThanOrEqual(float lhs, float4 rhs) { }

	// RVA: 0x293E240 Offset: 0x293CC40 VA: 0x18293E240
	public static bool4 op_GreaterThan(float4 lhs, float4 rhs) { }

	// RVA: 0x293E280 Offset: 0x293CC80 VA: 0x18293E280
	public static bool4 op_GreaterThan(float4 lhs, float rhs) { }

	// RVA: 0x293E2C0 Offset: 0x293CCC0 VA: 0x18293E2C0
	public static bool4 op_GreaterThan(float lhs, float4 rhs) { }

	// RVA: 0x293E200 Offset: 0x293CC00 VA: 0x18293E200
	public static bool4 op_GreaterThanOrEqual(float4 lhs, float4 rhs) { }

	// RVA: 0x293E190 Offset: 0x293CB90 VA: 0x18293E190
	public static bool4 op_GreaterThanOrEqual(float4 lhs, float rhs) { }

	// RVA: 0x293E1D0 Offset: 0x293CBD0 VA: 0x18293E1D0
	public static bool4 op_GreaterThanOrEqual(float lhs, float4 rhs) { }

	// RVA: 0x293E740 Offset: 0x293D140 VA: 0x18293E740
	public static float4 op_UnaryNegation(float4 val) { }

	// RVA: 0xC0CF00 Offset: 0xC0B900 VA: 0x180C0CF00
	public static float4 op_UnaryPlus(float4 val) { }

	// RVA: 0x293E120 Offset: 0x293CB20 VA: 0x18293E120
	public static bool4 op_Equality(float4 lhs, float4 rhs) { }

	// RVA: 0x293E0A0 Offset: 0x293CAA0 VA: 0x18293E0A0
	public static bool4 op_Equality(float4 lhs, float rhs) { }

	// RVA: 0x293E040 Offset: 0x293CA40 VA: 0x18293E040
	public static bool4 op_Equality(float lhs, float4 rhs) { }

	// RVA: 0x293E330 Offset: 0x293CD30 VA: 0x18293E330
	public static bool4 op_Inequality(float4 lhs, float4 rhs) { }

	// RVA: 0x293E400 Offset: 0x293CE00 VA: 0x18293E400
	public static bool4 op_Inequality(float4 lhs, float rhs) { }

	// RVA: 0x293E3A0 Offset: 0x293CDA0 VA: 0x18293E3A0
	public static bool4 op_Inequality(float lhs, float4 rhs) { }

	// RVA: 0x28EAF00 Offset: 0x28E9900 VA: 0x1828EAF00
	public float4 get_xxxx() { }

	// RVA: 0x28EAF20 Offset: 0x28E9920 VA: 0x1828EAF20
	public float4 get_xxxy() { }

	// RVA: 0x28EAF40 Offset: 0x28E9940 VA: 0x1828EAF40
	public float4 get_xxxz() { }

	// RVA: 0x28EAEE0 Offset: 0x28E98E0 VA: 0x1828EAEE0
	public float4 get_xxxw() { }

	// RVA: 0x28EAFA0 Offset: 0x28E99A0 VA: 0x1828EAFA0
	public float4 get_xxyx() { }

	// RVA: 0x28EAFC0 Offset: 0x28E99C0 VA: 0x1828EAFC0
	public float4 get_xxyy() { }

	// RVA: 0x28EAFE0 Offset: 0x28E99E0 VA: 0x1828EAFE0
	public float4 get_xxyz() { }

	// RVA: 0x28EAF80 Offset: 0x28E9980 VA: 0x1828EAF80
	public float4 get_xxyw() { }

	// RVA: 0x28EB040 Offset: 0x28E9A40 VA: 0x1828EB040
	public float4 get_xxzx() { }

	// RVA: 0x28EB060 Offset: 0x28E9A60 VA: 0x1828EB060
	public float4 get_xxzy() { }

	// RVA: 0x2716A20 Offset: 0x2715420 VA: 0x182716A20
	public float4 get_xxzz() { }

	// RVA: 0x28EB020 Offset: 0x28E9A20 VA: 0x1828EB020
	public float4 get_xxzw() { }

	// RVA: 0x28EAE70 Offset: 0x28E9870 VA: 0x1828EAE70
	public float4 get_xxwx() { }

	// RVA: 0x28EAE90 Offset: 0x28E9890 VA: 0x1828EAE90
	public float4 get_xxwy() { }

	// RVA: 0x28EAEB0 Offset: 0x28E98B0 VA: 0x1828EAEB0
	public float4 get_xxwz() { }

	// RVA: 0x28EAE50 Offset: 0x28E9850 VA: 0x1828EAE50
	public float4 get_xxww() { }

	// RVA: 0x28EB160 Offset: 0x28E9B60 VA: 0x1828EB160
	public float4 get_xyxx() { }

	// RVA: 0x28EB180 Offset: 0x28E9B80 VA: 0x1828EB180
	public float4 get_xyxy() { }

	// RVA: 0x28EB1A0 Offset: 0x28E9BA0 VA: 0x1828EB1A0
	public float4 get_xyxz() { }

	// RVA: 0x28EB140 Offset: 0x28E9B40 VA: 0x1828EB140
	public float4 get_xyxw() { }

	// RVA: 0x28EB200 Offset: 0x28E9C00 VA: 0x1828EB200
	public float4 get_xyyx() { }

	// RVA: 0x28EB220 Offset: 0x28E9C20 VA: 0x1828EB220
	public float4 get_xyyy() { }

	// RVA: 0x28EB240 Offset: 0x28E9C40 VA: 0x1828EB240
	public float4 get_xyyz() { }

	// RVA: 0x28EB1E0 Offset: 0x28E9BE0 VA: 0x1828EB1E0
	public float4 get_xyyw() { }

	// RVA: 0x28EB260 Offset: 0x28E9C60 VA: 0x1828EB260
	public float4 get_xyzx() { }

	// RVA: 0x28EB280 Offset: 0x28E9C80 VA: 0x1828EB280
	public float4 get_xyzy() { }

	// RVA: 0x28EB2A0 Offset: 0x28E9CA0 VA: 0x1828EB2A0
	public float4 get_xyzz() { }

	// RVA: 0xC0CF00 Offset: 0xC0B900 VA: 0x180C0CF00
	public float4 get_xyzw() { }

	// RVA: 0x22D2A70 Offset: 0x22D1470 VA: 0x1822D2A70
	public void set_xyzw(float4 value) { }

	// RVA: 0x28EB0C0 Offset: 0x28E9AC0 VA: 0x1828EB0C0
	public float4 get_xywx() { }

	// RVA: 0x28EB0E0 Offset: 0x28E9AE0 VA: 0x1828EB0E0
	public float4 get_xywy() { }

	// RVA: 0x28EB100 Offset: 0x28E9B00 VA: 0x1828EB100
	public float4 get_xywz() { }

	// RVA: 0x28ED520 Offset: 0x28EBF20 VA: 0x1828ED520
	public void set_xywz(float4 value) { }

	// RVA: 0x28EB0A0 Offset: 0x28E9AA0 VA: 0x1828EB0A0
	public float4 get_xyww() { }

	// RVA: 0x28EB3A0 Offset: 0x28E9DA0 VA: 0x1828EB3A0
	public float4 get_xzxx() { }

	// RVA: 0x28EB3C0 Offset: 0x28E9DC0 VA: 0x1828EB3C0
	public float4 get_xzxy() { }

	// RVA: 0x28EB3E0 Offset: 0x28E9DE0 VA: 0x1828EB3E0
	public float4 get_xzxz() { }

	// RVA: 0x28EB380 Offset: 0x28E9D80 VA: 0x1828EB380
	public float4 get_xzxw() { }

	// RVA: 0x28EB440 Offset: 0x28E9E40 VA: 0x1828EB440
	public float4 get_xzyx() { }

	// RVA: 0x28EB460 Offset: 0x28E9E60 VA: 0x1828EB460
	public float4 get_xzyy() { }

	// RVA: 0x28EB480 Offset: 0x28E9E80 VA: 0x1828EB480
	public float4 get_xzyz() { }

	// RVA: 0x28EB420 Offset: 0x28E9E20 VA: 0x1828EB420
	public float4 get_xzyw() { }

	// RVA: 0x28ED5D0 Offset: 0x28EBFD0 VA: 0x1828ED5D0
	public void set_xzyw(float4 value) { }

	// RVA: 0x28EB4E0 Offset: 0x28E9EE0 VA: 0x1828EB4E0
	public float4 get_xzzx() { }

	// RVA: 0x28EB500 Offset: 0x28E9F00 VA: 0x1828EB500
	public float4 get_xzzy() { }

	// RVA: 0x28EB520 Offset: 0x28E9F20 VA: 0x1828EB520
	public float4 get_xzzz() { }

	// RVA: 0x28EB4C0 Offset: 0x28E9EC0 VA: 0x1828EB4C0
	public float4 get_xzzw() { }

	// RVA: 0x28EB300 Offset: 0x28E9D00 VA: 0x1828EB300
	public float4 get_xzwx() { }

	// RVA: 0x28EB320 Offset: 0x28E9D20 VA: 0x1828EB320
	public float4 get_xzwy() { }

	// RVA: 0x28ED590 Offset: 0x28EBF90 VA: 0x1828ED590
	public void set_xzwy(float4 value) { }

	// RVA: 0x28EB340 Offset: 0x28E9D40 VA: 0x1828EB340
	public float4 get_xzwz() { }

	// RVA: 0x28EB2E0 Offset: 0x28E9CE0 VA: 0x1828EB2E0
	public float4 get_xzww() { }

	// RVA: 0x28EAC80 Offset: 0x28E9680 VA: 0x1828EAC80
	public float4 get_xwxx() { }

	// RVA: 0x28EACA0 Offset: 0x28E96A0 VA: 0x1828EACA0
	public float4 get_xwxy() { }

	// RVA: 0x28EACC0 Offset: 0x28E96C0 VA: 0x1828EACC0
	public float4 get_xwxz() { }

	// RVA: 0x28EAC60 Offset: 0x28E9660 VA: 0x1828EAC60
	public float4 get_xwxw() { }

	// RVA: 0x28EAD20 Offset: 0x28E9720 VA: 0x1828EAD20
	public float4 get_xwyx() { }

	// RVA: 0x28EAD40 Offset: 0x28E9740 VA: 0x1828EAD40
	public float4 get_xwyy() { }

	// RVA: 0x28EAD60 Offset: 0x28E9760 VA: 0x1828EAD60
	public float4 get_xwyz() { }

	// RVA: 0x28ED4A0 Offset: 0x28EBEA0 VA: 0x1828ED4A0
	public void set_xwyz(float4 value) { }

	// RVA: 0x28EAD00 Offset: 0x28E9700 VA: 0x1828EAD00
	public float4 get_xwyw() { }

	// RVA: 0x28EADC0 Offset: 0x28E97C0 VA: 0x1828EADC0
	public float4 get_xwzx() { }

	// RVA: 0x28EADE0 Offset: 0x28E97E0 VA: 0x1828EADE0
	public float4 get_xwzy() { }

	// RVA: 0x28ED4E0 Offset: 0x28EBEE0 VA: 0x1828ED4E0
	public void set_xwzy(float4 value) { }

	// RVA: 0x28EAE00 Offset: 0x28E9800 VA: 0x1828EAE00
	public float4 get_xwzz() { }

	// RVA: 0x28EADA0 Offset: 0x28E97A0 VA: 0x1828EADA0
	public float4 get_xwzw() { }

	// RVA: 0x28EABE0 Offset: 0x28E95E0 VA: 0x1828EABE0
	public float4 get_xwwx() { }

	// RVA: 0x28EAC00 Offset: 0x28E9600 VA: 0x1828EAC00
	public float4 get_xwwy() { }

	// RVA: 0x28EAC20 Offset: 0x28E9620 VA: 0x1828EAC20
	public float4 get_xwwz() { }

	// RVA: 0x28EABC0 Offset: 0x28E95C0 VA: 0x1828EABC0
	public float4 get_xwww() { }

	// RVA: 0x28EB8E0 Offset: 0x28EA2E0 VA: 0x1828EB8E0
	public float4 get_yxxx() { }

	// RVA: 0x28EB900 Offset: 0x28EA300 VA: 0x1828EB900
	public float4 get_yxxy() { }

	// RVA: 0x28EB920 Offset: 0x28EA320 VA: 0x1828EB920
	public float4 get_yxxz() { }

	// RVA: 0x28EB8C0 Offset: 0x28EA2C0 VA: 0x1828EB8C0
	public float4 get_yxxw() { }

	// RVA: 0x28EB980 Offset: 0x28EA380 VA: 0x1828EB980
	public float4 get_yxyx() { }

	// RVA: 0x28EB9A0 Offset: 0x28EA3A0 VA: 0x1828EB9A0
	public float4 get_yxyy() { }

	// RVA: 0x28EB9C0 Offset: 0x28EA3C0 VA: 0x1828EB9C0
	public float4 get_yxyz() { }

	// RVA: 0x28EB960 Offset: 0x28EA360 VA: 0x1828EB960
	public float4 get_yxyw() { }

	// RVA: 0x28EBA20 Offset: 0x28EA420 VA: 0x1828EBA20
	public float4 get_yxzx() { }

	// RVA: 0x28EBA40 Offset: 0x28EA440 VA: 0x1828EBA40
	public float4 get_yxzy() { }

	// RVA: 0x28EBA60 Offset: 0x28EA460 VA: 0x1828EBA60
	public float4 get_yxzz() { }

	// RVA: 0x28EBA00 Offset: 0x28EA400 VA: 0x1828EBA00
	public float4 get_yxzw() { }

	// RVA: 0x28ED6F0 Offset: 0x28EC0F0 VA: 0x1828ED6F0
	public void set_yxzw(float4 value) { }

	// RVA: 0x28EB840 Offset: 0x28EA240 VA: 0x1828EB840
	public float4 get_yxwx() { }

	// RVA: 0x28EB860 Offset: 0x28EA260 VA: 0x1828EB860
	public float4 get_yxwy() { }

	// RVA: 0x28EB880 Offset: 0x28EA280 VA: 0x1828EB880
	public float4 get_yxwz() { }

	// RVA: 0x28ED6B0 Offset: 0x28EC0B0 VA: 0x1828ED6B0
	public void set_yxwz(float4 value) { }

	// RVA: 0x28EB820 Offset: 0x28EA220 VA: 0x1828EB820
	public float4 get_yxww() { }

	// RVA: 0x28EBB60 Offset: 0x28EA560 VA: 0x1828EBB60
	public float4 get_yyxx() { }

	// RVA: 0x28EBB80 Offset: 0x28EA580 VA: 0x1828EBB80
	public float4 get_yyxy() { }

	// RVA: 0x28EBBA0 Offset: 0x28EA5A0 VA: 0x1828EBBA0
	public float4 get_yyxz() { }

	// RVA: 0x28EBB40 Offset: 0x28EA540 VA: 0x1828EBB40
	public float4 get_yyxw() { }

	// RVA: 0x28EBBF0 Offset: 0x28EA5F0 VA: 0x1828EBBF0
	public float4 get_yyyx() { }

	// RVA: 0x28EBC10 Offset: 0x28EA610 VA: 0x1828EBC10
	public float4 get_yyyy() { }

	// RVA: 0x28EBC30 Offset: 0x28EA630 VA: 0x1828EBC30
	public float4 get_yyyz() { }

	// RVA: 0x28EBBD0 Offset: 0x28EA5D0 VA: 0x1828EBBD0
	public float4 get_yyyw() { }

	// RVA: 0x28EBC90 Offset: 0x28EA690 VA: 0x1828EBC90
	public float4 get_yyzx() { }

	// RVA: 0x28EBCB0 Offset: 0x28EA6B0 VA: 0x1828EBCB0
	public float4 get_yyzy() { }

	// RVA: 0x28EBCD0 Offset: 0x28EA6D0 VA: 0x1828EBCD0
	public float4 get_yyzz() { }

	// RVA: 0x28EBC70 Offset: 0x28EA670 VA: 0x1828EBC70
	public float4 get_yyzw() { }

	// RVA: 0x28EBAC0 Offset: 0x28EA4C0 VA: 0x1828EBAC0
	public float4 get_yywx() { }

	// RVA: 0x28EBAE0 Offset: 0x28EA4E0 VA: 0x1828EBAE0
	public float4 get_yywy() { }

	// RVA: 0x28EBB00 Offset: 0x28EA500 VA: 0x1828EBB00
	public float4 get_yywz() { }

	// RVA: 0x2716A00 Offset: 0x2715400 VA: 0x182716A00
	public float4 get_yyww() { }

	// RVA: 0x28EBDF0 Offset: 0x28EA7F0 VA: 0x1828EBDF0
	public float4 get_yzxx() { }

	// RVA: 0x28EBE10 Offset: 0x28EA810 VA: 0x1828EBE10
	public float4 get_yzxy() { }

	// RVA: 0x28EBE30 Offset: 0x28EA830 VA: 0x1828EBE30
	public float4 get_yzxz() { }

	// RVA: 0x28EBDD0 Offset: 0x28EA7D0 VA: 0x1828EBDD0
	public float4 get_yzxw() { }

	// RVA: 0x28ED780 Offset: 0x28EC180 VA: 0x1828ED780
	public void set_yzxw(float4 value) { }

	// RVA: 0x28EBE90 Offset: 0x28EA890 VA: 0x1828EBE90
	public float4 get_yzyx() { }

	// RVA: 0x28EBEB0 Offset: 0x28EA8B0 VA: 0x1828EBEB0
	public float4 get_yzyy() { }

	// RVA: 0x28EBED0 Offset: 0x28EA8D0 VA: 0x1828EBED0
	public float4 get_yzyz() { }

	// RVA: 0x28EBE70 Offset: 0x28EA870 VA: 0x1828EBE70
	public float4 get_yzyw() { }

	// RVA: 0x28EBF30 Offset: 0x28EA930 VA: 0x1828EBF30
	public float4 get_yzzx() { }

	// RVA: 0x28EBF50 Offset: 0x28EA950 VA: 0x1828EBF50
	public float4 get_yzzy() { }

	// RVA: 0x28EBF70 Offset: 0x28EA970 VA: 0x1828EBF70
	public float4 get_yzzz() { }

	// RVA: 0x28EBF10 Offset: 0x28EA910 VA: 0x1828EBF10
	public float4 get_yzzw() { }

	// RVA: 0x28EBD50 Offset: 0x28EA750 VA: 0x1828EBD50
	public float4 get_yzwx() { }

	// RVA: 0x28ED740 Offset: 0x28EC140 VA: 0x1828ED740
	public void set_yzwx(float4 value) { }

	// RVA: 0x28EBD70 Offset: 0x28EA770 VA: 0x1828EBD70
	public float4 get_yzwy() { }

	// RVA: 0x28EBD90 Offset: 0x28EA790 VA: 0x1828EBD90
	public float4 get_yzwz() { }

	// RVA: 0x28EBD30 Offset: 0x28EA730 VA: 0x1828EBD30
	public float4 get_yzww() { }

	// RVA: 0x28EB640 Offset: 0x28EA040 VA: 0x1828EB640
	public float4 get_ywxx() { }

	// RVA: 0x28EB660 Offset: 0x28EA060 VA: 0x1828EB660
	public float4 get_ywxy() { }

	// RVA: 0x28EB680 Offset: 0x28EA080 VA: 0x1828EB680
	public float4 get_ywxz() { }

	// RVA: 0x28ED620 Offset: 0x28EC020 VA: 0x1828ED620
	public void set_ywxz(float4 value) { }

	// RVA: 0x28EB620 Offset: 0x28EA020 VA: 0x1828EB620
	public float4 get_ywxw() { }

	// RVA: 0x28EB6E0 Offset: 0x28EA0E0 VA: 0x1828EB6E0
	public float4 get_ywyx() { }

	// RVA: 0x28EB700 Offset: 0x28EA100 VA: 0x1828EB700
	public float4 get_ywyy() { }

	// RVA: 0x28EB720 Offset: 0x28EA120 VA: 0x1828EB720
	public float4 get_ywyz() { }

	// RVA: 0x28EB6C0 Offset: 0x28EA0C0 VA: 0x1828EB6C0
	public float4 get_ywyw() { }

	// RVA: 0x28EB780 Offset: 0x28EA180 VA: 0x1828EB780
	public float4 get_ywzx() { }

	// RVA: 0x28ED660 Offset: 0x28EC060 VA: 0x1828ED660
	public void set_ywzx(float4 value) { }

	// RVA: 0x28EB7A0 Offset: 0x28EA1A0 VA: 0x1828EB7A0
	public float4 get_ywzy() { }

	// RVA: 0x28EB7C0 Offset: 0x28EA1C0 VA: 0x1828EB7C0
	public float4 get_ywzz() { }

	// RVA: 0x28EB760 Offset: 0x28EA160 VA: 0x1828EB760
	public float4 get_ywzw() { }

	// RVA: 0x28EB5A0 Offset: 0x28E9FA0 VA: 0x1828EB5A0
	public float4 get_ywwx() { }

	// RVA: 0x28EB5C0 Offset: 0x28E9FC0 VA: 0x1828EB5C0
	public float4 get_ywwy() { }

	// RVA: 0x28EB5E0 Offset: 0x28E9FE0 VA: 0x1828EB5E0
	public float4 get_ywwz() { }

	// RVA: 0x28EB580 Offset: 0x28E9F80 VA: 0x1828EB580
	public float4 get_ywww() { }

	// RVA: 0x28EC310 Offset: 0x28EAD10 VA: 0x1828EC310
	public float4 get_zxxx() { }

	// RVA: 0x28EC330 Offset: 0x28EAD30 VA: 0x1828EC330
	public float4 get_zxxy() { }

	// RVA: 0x28EC350 Offset: 0x28EAD50 VA: 0x1828EC350
	public float4 get_zxxz() { }

	// RVA: 0x28EC2F0 Offset: 0x28EACF0 VA: 0x1828EC2F0
	public float4 get_zxxw() { }

	// RVA: 0x28EC3B0 Offset: 0x28EADB0 VA: 0x1828EC3B0
	public float4 get_zxyx() { }

	// RVA: 0x28EC3D0 Offset: 0x28EADD0 VA: 0x1828EC3D0
	public float4 get_zxyy() { }

	// RVA: 0x28EC3F0 Offset: 0x28EADF0 VA: 0x1828EC3F0
	public float4 get_zxyz() { }

	// RVA: 0x28EC390 Offset: 0x28EAD90 VA: 0x1828EC390
	public float4 get_zxyw() { }

	// RVA: 0x28ED890 Offset: 0x28EC290 VA: 0x1828ED890
	public void set_zxyw(float4 value) { }

	// RVA: 0x28EC450 Offset: 0x28EAE50 VA: 0x1828EC450
	public float4 get_zxzx() { }

	// RVA: 0x28EC470 Offset: 0x28EAE70 VA: 0x1828EC470
	public float4 get_zxzy() { }

	// RVA: 0x28EC490 Offset: 0x28EAE90 VA: 0x1828EC490
	public float4 get_zxzz() { }

	// RVA: 0x28EC430 Offset: 0x28EAE30 VA: 0x1828EC430
	public float4 get_zxzw() { }

	// RVA: 0x28EC270 Offset: 0x28EAC70 VA: 0x1828EC270
	public float4 get_zxwx() { }

	// RVA: 0x28EC290 Offset: 0x28EAC90 VA: 0x1828EC290
	public float4 get_zxwy() { }

	// RVA: 0x28ED850 Offset: 0x28EC250 VA: 0x1828ED850
	public void set_zxwy(float4 value) { }

	// RVA: 0x28EC2B0 Offset: 0x28EACB0 VA: 0x1828EC2B0
	public float4 get_zxwz() { }

	// RVA: 0x28EC250 Offset: 0x28EAC50 VA: 0x1828EC250
	public float4 get_zxww() { }

	// RVA: 0x28EC5B0 Offset: 0x28EAFB0 VA: 0x1828EC5B0
	public float4 get_zyxx() { }

	// RVA: 0x28EC5D0 Offset: 0x28EAFD0 VA: 0x1828EC5D0
	public float4 get_zyxy() { }

	// RVA: 0x28EC5F0 Offset: 0x28EAFF0 VA: 0x1828EC5F0
	public float4 get_zyxz() { }

	// RVA: 0x28EC590 Offset: 0x28EAF90 VA: 0x1828EC590
	public float4 get_zyxw() { }

	// RVA: 0x28ED920 Offset: 0x28EC320 VA: 0x1828ED920
	public void set_zyxw(float4 value) { }

	// RVA: 0x28EC650 Offset: 0x28EB050 VA: 0x1828EC650
	public float4 get_zyyx() { }

	// RVA: 0x28EC670 Offset: 0x28EB070 VA: 0x1828EC670
	public float4 get_zyyy() { }

	// RVA: 0x28EC690 Offset: 0x28EB090 VA: 0x1828EC690
	public float4 get_zyyz() { }

	// RVA: 0x28EC630 Offset: 0x28EB030 VA: 0x1828EC630
	public float4 get_zyyw() { }

	// RVA: 0x28EC6F0 Offset: 0x28EB0F0 VA: 0x1828EC6F0
	public float4 get_zyzx() { }

	// RVA: 0x28EC710 Offset: 0x28EB110 VA: 0x1828EC710
	public float4 get_zyzy() { }

	// RVA: 0x28EC730 Offset: 0x28EB130 VA: 0x1828EC730
	public float4 get_zyzz() { }

	// RVA: 0x28EC6D0 Offset: 0x28EB0D0 VA: 0x1828EC6D0
	public float4 get_zyzw() { }

	// RVA: 0x28EC510 Offset: 0x28EAF10 VA: 0x1828EC510
	public float4 get_zywx() { }

	// RVA: 0x28ED8E0 Offset: 0x28EC2E0 VA: 0x1828ED8E0
	public void set_zywx(float4 value) { }

	// RVA: 0x28EC530 Offset: 0x28EAF30 VA: 0x1828EC530
	public float4 get_zywy() { }

	// RVA: 0x28EC550 Offset: 0x28EAF50 VA: 0x1828EC550
	public float4 get_zywz() { }

	// RVA: 0x28EC4F0 Offset: 0x28EAEF0 VA: 0x1828EC4F0
	public float4 get_zyww() { }

	// RVA: 0x28EC850 Offset: 0x28EB250 VA: 0x1828EC850
	public float4 get_zzxx() { }

	// RVA: 0x28EC870 Offset: 0x28EB270 VA: 0x1828EC870
	public float4 get_zzxy() { }

	// RVA: 0x28EC890 Offset: 0x28EB290 VA: 0x1828EC890
	public float4 get_zzxz() { }

	// RVA: 0x28EC830 Offset: 0x28EB230 VA: 0x1828EC830
	public float4 get_zzxw() { }

	// RVA: 0x28EC8F0 Offset: 0x28EB2F0 VA: 0x1828EC8F0
	public float4 get_zzyx() { }

	// RVA: 0x28EC910 Offset: 0x28EB310 VA: 0x1828EC910
	public float4 get_zzyy() { }

	// RVA: 0x28EC930 Offset: 0x28EB330 VA: 0x1828EC930
	public float4 get_zzyz() { }

	// RVA: 0x28EC8D0 Offset: 0x28EB2D0 VA: 0x1828EC8D0
	public float4 get_zzyw() { }

	// RVA: 0x28EC980 Offset: 0x28EB380 VA: 0x1828EC980
	public float4 get_zzzx() { }

	// RVA: 0x28EC9A0 Offset: 0x28EB3A0 VA: 0x1828EC9A0
	public float4 get_zzzy() { }

	// RVA: 0x28EC9C0 Offset: 0x28EB3C0 VA: 0x1828EC9C0
	public float4 get_zzzz() { }

	// RVA: 0x28EC960 Offset: 0x28EB360 VA: 0x1828EC960
	public float4 get_zzzw() { }

	// RVA: 0x28EC7B0 Offset: 0x28EB1B0 VA: 0x1828EC7B0
	public float4 get_zzwx() { }

	// RVA: 0x28EC7D0 Offset: 0x28EB1D0 VA: 0x1828EC7D0
	public float4 get_zzwy() { }

	// RVA: 0x28EC7F0 Offset: 0x28EB1F0 VA: 0x1828EC7F0
	public float4 get_zzwz() { }

	// RVA: 0x28EC790 Offset: 0x28EB190 VA: 0x1828EC790
	public float4 get_zzww() { }

	// RVA: 0x28EC070 Offset: 0x28EAA70 VA: 0x1828EC070
	public float4 get_zwxx() { }

	// RVA: 0x28EC090 Offset: 0x28EAA90 VA: 0x1828EC090
	public float4 get_zwxy() { }

	// RVA: 0x28ED7C0 Offset: 0x28EC1C0 VA: 0x1828ED7C0
	public void set_zwxy(float4 value) { }

	// RVA: 0x28EC0B0 Offset: 0x28EAAB0 VA: 0x1828EC0B0
	public float4 get_zwxz() { }

	// RVA: 0x28EC050 Offset: 0x28EAA50 VA: 0x1828EC050
	public float4 get_zwxw() { }

	// RVA: 0x28EC110 Offset: 0x28EAB10 VA: 0x1828EC110
	public float4 get_zwyx() { }

	// RVA: 0x28ED800 Offset: 0x28EC200 VA: 0x1828ED800
	public void set_zwyx(float4 value) { }

	// RVA: 0x28EC130 Offset: 0x28EAB30 VA: 0x1828EC130
	public float4 get_zwyy() { }

	// RVA: 0x28EC150 Offset: 0x28EAB50 VA: 0x1828EC150
	public float4 get_zwyz() { }

	// RVA: 0x28EC0F0 Offset: 0x28EAAF0 VA: 0x1828EC0F0
	public float4 get_zwyw() { }

	// RVA: 0x28EC1B0 Offset: 0x28EABB0 VA: 0x1828EC1B0
	public float4 get_zwzx() { }

	// RVA: 0x28EC1D0 Offset: 0x28EABD0 VA: 0x1828EC1D0
	public float4 get_zwzy() { }

	// RVA: 0x28EC1F0 Offset: 0x28EABF0 VA: 0x1828EC1F0
	public float4 get_zwzz() { }

	// RVA: 0x28EC190 Offset: 0x28EAB90 VA: 0x1828EC190
	public float4 get_zwzw() { }

	// RVA: 0x28EBFD0 Offset: 0x28EA9D0 VA: 0x1828EBFD0
	public float4 get_zwwx() { }

	// RVA: 0x28EBFF0 Offset: 0x28EA9F0 VA: 0x1828EBFF0
	public float4 get_zwwy() { }

	// RVA: 0x28EC010 Offset: 0x28EAA10 VA: 0x1828EC010
	public float4 get_zwwz() { }

	// RVA: 0x28EBFB0 Offset: 0x28EA9B0 VA: 0x1828EBFB0
	public float4 get_zwww() { }

	// RVA: 0x28EA4A0 Offset: 0x28E8EA0 VA: 0x1828EA4A0
	public float4 get_wxxx() { }

	// RVA: 0x28EA4C0 Offset: 0x28E8EC0 VA: 0x1828EA4C0
	public float4 get_wxxy() { }

	// RVA: 0x28EA4E0 Offset: 0x28E8EE0 VA: 0x1828EA4E0
	public float4 get_wxxz() { }

	// RVA: 0x28EA480 Offset: 0x28E8E80 VA: 0x1828EA480
	public float4 get_wxxw() { }

	// RVA: 0x28EA540 Offset: 0x28E8F40 VA: 0x1828EA540
	public float4 get_wxyx() { }

	// RVA: 0x28EA560 Offset: 0x28E8F60 VA: 0x1828EA560
	public float4 get_wxyy() { }

	// RVA: 0x28EA580 Offset: 0x28E8F80 VA: 0x1828EA580
	public float4 get_wxyz() { }

	// RVA: 0x28ED2F0 Offset: 0x28EBCF0 VA: 0x1828ED2F0
	public void set_wxyz(float4 value) { }

	// RVA: 0x28EA520 Offset: 0x28E8F20 VA: 0x1828EA520
	public float4 get_wxyw() { }

	// RVA: 0x28EA5E0 Offset: 0x28E8FE0 VA: 0x1828EA5E0
	public float4 get_wxzx() { }

	// RVA: 0x28EA600 Offset: 0x28E9000 VA: 0x1828EA600
	public float4 get_wxzy() { }

	// RVA: 0x28ED330 Offset: 0x28EBD30 VA: 0x1828ED330
	public void set_wxzy(float4 value) { }

	// RVA: 0x28EA620 Offset: 0x28E9020 VA: 0x1828EA620
	public float4 get_wxzz() { }

	// RVA: 0x28EA5C0 Offset: 0x28E8FC0 VA: 0x1828EA5C0
	public float4 get_wxzw() { }

	// RVA: 0x28EA400 Offset: 0x28E8E00 VA: 0x1828EA400
	public float4 get_wxwx() { }

	// RVA: 0x28EA420 Offset: 0x28E8E20 VA: 0x1828EA420
	public float4 get_wxwy() { }

	// RVA: 0x28EA440 Offset: 0x28E8E40 VA: 0x1828EA440
	public float4 get_wxwz() { }

	// RVA: 0x28EA3E0 Offset: 0x28E8DE0 VA: 0x1828EA3E0
	public float4 get_wxww() { }

	// RVA: 0x28EA740 Offset: 0x28E9140 VA: 0x1828EA740
	public float4 get_wyxx() { }

	// RVA: 0x28EA760 Offset: 0x28E9160 VA: 0x1828EA760
	public float4 get_wyxy() { }

	// RVA: 0x28EA780 Offset: 0x28E9180 VA: 0x1828EA780
	public float4 get_wyxz() { }

	// RVA: 0x28ED380 Offset: 0x28EBD80 VA: 0x1828ED380
	public void set_wyxz(float4 value) { }

	// RVA: 0x28EA720 Offset: 0x28E9120 VA: 0x1828EA720
	public float4 get_wyxw() { }

	// RVA: 0x28EA7E0 Offset: 0x28E91E0 VA: 0x1828EA7E0
	public float4 get_wyyx() { }

	// RVA: 0x28EA800 Offset: 0x28E9200 VA: 0x1828EA800
	public float4 get_wyyy() { }

	// RVA: 0x28EA820 Offset: 0x28E9220 VA: 0x1828EA820
	public float4 get_wyyz() { }

	// RVA: 0x28EA7C0 Offset: 0x28E91C0 VA: 0x1828EA7C0
	public float4 get_wyyw() { }

	// RVA: 0x28EA880 Offset: 0x28E9280 VA: 0x1828EA880
	public float4 get_wyzx() { }

	// RVA: 0x28ED3C0 Offset: 0x28EBDC0 VA: 0x1828ED3C0
	public void set_wyzx(float4 value) { }

	// RVA: 0x28EA8A0 Offset: 0x28E92A0 VA: 0x1828EA8A0
	public float4 get_wyzy() { }

	// RVA: 0x28EA8C0 Offset: 0x28E92C0 VA: 0x1828EA8C0
	public float4 get_wyzz() { }

	// RVA: 0x28EA860 Offset: 0x28E9260 VA: 0x1828EA860
	public float4 get_wyzw() { }

	// RVA: 0x28EA6A0 Offset: 0x28E90A0 VA: 0x1828EA6A0
	public float4 get_wywx() { }

	// RVA: 0x28EA6C0 Offset: 0x28E90C0 VA: 0x1828EA6C0
	public float4 get_wywy() { }

	// RVA: 0x28EA6E0 Offset: 0x28E90E0 VA: 0x1828EA6E0
	public float4 get_wywz() { }

	// RVA: 0x28EA680 Offset: 0x28E9080 VA: 0x1828EA680
	public float4 get_wyww() { }

	// RVA: 0x28EA9E0 Offset: 0x28E93E0 VA: 0x1828EA9E0
	public float4 get_wzxx() { }

	// RVA: 0x28EAA00 Offset: 0x28E9400 VA: 0x1828EAA00
	public float4 get_wzxy() { }

	// RVA: 0x28ED410 Offset: 0x28EBE10 VA: 0x1828ED410
	public void set_wzxy(float4 value) { }

	// RVA: 0x28EAA20 Offset: 0x28E9420 VA: 0x1828EAA20
	public float4 get_wzxz() { }

	// RVA: 0x28EA9C0 Offset: 0x28E93C0 VA: 0x1828EA9C0
	public float4 get_wzxw() { }

	// RVA: 0x28EAA80 Offset: 0x28E9480 VA: 0x1828EAA80
	public float4 get_wzyx() { }

	// RVA: 0x28ED450 Offset: 0x28EBE50 VA: 0x1828ED450
	public void set_wzyx(float4 value) { }

	// RVA: 0x28EAAA0 Offset: 0x28E94A0 VA: 0x1828EAAA0
	public float4 get_wzyy() { }

	// RVA: 0x28EAAC0 Offset: 0x28E94C0 VA: 0x1828EAAC0
	public float4 get_wzyz() { }

	// RVA: 0x28EAA60 Offset: 0x28E9460 VA: 0x1828EAA60
	public float4 get_wzyw() { }

	// RVA: 0x28EAB20 Offset: 0x28E9520 VA: 0x1828EAB20
	public float4 get_wzzx() { }

	// RVA: 0x28EAB40 Offset: 0x28E9540 VA: 0x1828EAB40
	public float4 get_wzzy() { }

	// RVA: 0x28EAB60 Offset: 0x28E9560 VA: 0x1828EAB60
	public float4 get_wzzz() { }

	// RVA: 0x28EAB00 Offset: 0x28E9500 VA: 0x1828EAB00
	public float4 get_wzzw() { }

	// RVA: 0x28EA940 Offset: 0x28E9340 VA: 0x1828EA940
	public float4 get_wzwx() { }

	// RVA: 0x28EA960 Offset: 0x28E9360 VA: 0x1828EA960
	public float4 get_wzwy() { }

	// RVA: 0x28EA980 Offset: 0x28E9380 VA: 0x1828EA980
	public float4 get_wzwz() { }

	// RVA: 0x28EA920 Offset: 0x28E9320 VA: 0x1828EA920
	public float4 get_wzww() { }

	// RVA: 0x28EA200 Offset: 0x28E8C00 VA: 0x1828EA200
	public float4 get_wwxx() { }

	// RVA: 0x28EA220 Offset: 0x28E8C20 VA: 0x1828EA220
	public float4 get_wwxy() { }

	// RVA: 0x28EA240 Offset: 0x28E8C40 VA: 0x1828EA240
	public float4 get_wwxz() { }

	// RVA: 0x28EA1E0 Offset: 0x28E8BE0 VA: 0x1828EA1E0
	public float4 get_wwxw() { }

	// RVA: 0x28EA2A0 Offset: 0x28E8CA0 VA: 0x1828EA2A0
	public float4 get_wwyx() { }

	// RVA: 0x28EA2C0 Offset: 0x28E8CC0 VA: 0x1828EA2C0
	public float4 get_wwyy() { }

	// RVA: 0x28EA2E0 Offset: 0x28E8CE0 VA: 0x1828EA2E0
	public float4 get_wwyz() { }

	// RVA: 0x28EA280 Offset: 0x28E8C80 VA: 0x1828EA280
	public float4 get_wwyw() { }

	// RVA: 0x28EA340 Offset: 0x28E8D40 VA: 0x1828EA340
	public float4 get_wwzx() { }

	// RVA: 0x28EA360 Offset: 0x28E8D60 VA: 0x1828EA360
	public float4 get_wwzy() { }

	// RVA: 0x28EA380 Offset: 0x28E8D80 VA: 0x1828EA380
	public float4 get_wwzz() { }

	// RVA: 0x28EA320 Offset: 0x28E8D20 VA: 0x1828EA320
	public float4 get_wwzw() { }

	// RVA: 0x28EA160 Offset: 0x28E8B60 VA: 0x1828EA160
	public float4 get_wwwx() { }

	// RVA: 0x28EA180 Offset: 0x28E8B80 VA: 0x1828EA180
	public float4 get_wwwy() { }

	// RVA: 0x28EA1A0 Offset: 0x28E8BA0 VA: 0x1828EA1A0
	public float4 get_wwwz() { }

	// RVA: 0x28EA140 Offset: 0x28E8B40 VA: 0x1828EA140
	public float4 get_wwww() { }

	// RVA: 0x28EAED0 Offset: 0x28E98D0 VA: 0x1828EAED0
	public float3 get_xxx() { }

	// RVA: 0x28EAF60 Offset: 0x28E9960 VA: 0x1828EAF60
	public float3 get_xxy() { }

	// RVA: 0x28EB000 Offset: 0x28E9A00 VA: 0x1828EB000
	public float3 get_xxz() { }

	// RVA: 0x28EAE30 Offset: 0x28E9830 VA: 0x1828EAE30
	public float3 get_xxw() { }

	// RVA: 0x28EB120 Offset: 0x28E9B20 VA: 0x1828EB120
	public float3 get_xyx() { }

	// RVA: 0x28EB1C0 Offset: 0x28E9BC0 VA: 0x1828EB1C0
	public float3 get_xyy() { }

	// RVA: 0x541660 Offset: 0x540060 VA: 0x180541660
	public float3 get_xyz() { }

	// RVA: 0x28ED540 Offset: 0x28EBF40 VA: 0x1828ED540
	public void set_xyz(float3 value) { }

	// RVA: 0x28EB080 Offset: 0x28E9A80 VA: 0x1828EB080
	public float3 get_xyw() { }

	// RVA: 0x28ED500 Offset: 0x28EBF00 VA: 0x1828ED500
	public void set_xyw(float3 value) { }

	// RVA: 0x28EB360 Offset: 0x28E9D60 VA: 0x1828EB360
	public float3 get_xzx() { }

	// RVA: 0x28EB400 Offset: 0x28E9E00 VA: 0x1828EB400
	public float3 get_xzy() { }

	// RVA: 0x28ED5B0 Offset: 0x28EBFB0 VA: 0x1828ED5B0
	public void set_xzy(float3 value) { }

	// RVA: 0x28EB4A0 Offset: 0x28E9EA0 VA: 0x1828EB4A0
	public float3 get_xzz() { }

	// RVA: 0x28EB2C0 Offset: 0x28E9CC0 VA: 0x1828EB2C0
	public float3 get_xzw() { }

	// RVA: 0x28ED570 Offset: 0x28EBF70 VA: 0x1828ED570
	public void set_xzw(float3 value) { }

	// RVA: 0x28EAC40 Offset: 0x28E9640 VA: 0x1828EAC40
	public float3 get_xwx() { }

	// RVA: 0x28EACE0 Offset: 0x28E96E0 VA: 0x1828EACE0
	public float3 get_xwy() { }

	// RVA: 0x28ED480 Offset: 0x28EBE80 VA: 0x1828ED480
	public void set_xwy(float3 value) { }

	// RVA: 0x28EAD80 Offset: 0x28E9780 VA: 0x1828EAD80
	public float3 get_xwz() { }

	// RVA: 0x28ED4C0 Offset: 0x28EBEC0 VA: 0x1828ED4C0
	public void set_xwz(float3 value) { }

	// RVA: 0x28EABA0 Offset: 0x28E95A0 VA: 0x1828EABA0
	public float3 get_xww() { }

	// RVA: 0x28EB8A0 Offset: 0x28EA2A0 VA: 0x1828EB8A0
	public float3 get_yxx() { }

	// RVA: 0x28EB940 Offset: 0x28EA340 VA: 0x1828EB940
	public float3 get_yxy() { }

	// RVA: 0x28EB9E0 Offset: 0x28EA3E0 VA: 0x1828EB9E0
	public float3 get_yxz() { }

	// RVA: 0x28ED6D0 Offset: 0x28EC0D0 VA: 0x1828ED6D0
	public void set_yxz(float3 value) { }

	// RVA: 0x28EB800 Offset: 0x28EA200 VA: 0x1828EB800
	public float3 get_yxw() { }

	// RVA: 0x28ED690 Offset: 0x28EC090 VA: 0x1828ED690
	public void set_yxw(float3 value) { }

	// RVA: 0x28EBB20 Offset: 0x28EA520 VA: 0x1828EBB20
	public float3 get_yyx() { }

	// RVA: 0x28EBBC0 Offset: 0x28EA5C0 VA: 0x1828EBBC0
	public float3 get_yyy() { }

	// RVA: 0x28EBC50 Offset: 0x28EA650 VA: 0x1828EBC50
	public float3 get_yyz() { }

	// RVA: 0x28EBAA0 Offset: 0x28EA4A0 VA: 0x1828EBAA0
	public float3 get_yyw() { }

	// RVA: 0x28EBDB0 Offset: 0x28EA7B0 VA: 0x1828EBDB0
	public float3 get_yzx() { }

	// RVA: 0x28ED760 Offset: 0x28EC160 VA: 0x1828ED760
	public void set_yzx(float3 value) { }

	// RVA: 0x28EBE50 Offset: 0x28EA850 VA: 0x1828EBE50
	public float3 get_yzy() { }

	// RVA: 0x28EBEF0 Offset: 0x28EA8F0 VA: 0x1828EBEF0
	public float3 get_yzz() { }

	// RVA: 0x28EBD10 Offset: 0x28EA710 VA: 0x1828EBD10
	public float3 get_yzw() { }

	// RVA: 0x28ED720 Offset: 0x28EC120 VA: 0x1828ED720
	public void set_yzw(float3 value) { }

	// RVA: 0x28EB600 Offset: 0x28EA000 VA: 0x1828EB600
	public float3 get_ywx() { }

	// RVA: 0x28ED600 Offset: 0x28EC000 VA: 0x1828ED600
	public void set_ywx(float3 value) { }

	// RVA: 0x28EB6A0 Offset: 0x28EA0A0 VA: 0x1828EB6A0
	public float3 get_ywy() { }

	// RVA: 0x28EB740 Offset: 0x28EA140 VA: 0x1828EB740
	public float3 get_ywz() { }

	// RVA: 0x28ED640 Offset: 0x28EC040 VA: 0x1828ED640
	public void set_ywz(float3 value) { }

	// RVA: 0x28EB560 Offset: 0x28E9F60 VA: 0x1828EB560
	public float3 get_yww() { }

	// RVA: 0x28EC2D0 Offset: 0x28EACD0 VA: 0x1828EC2D0
	public float3 get_zxx() { }

	// RVA: 0x28EC370 Offset: 0x28EAD70 VA: 0x1828EC370
	public float3 get_zxy() { }

	// RVA: 0x28ED870 Offset: 0x28EC270 VA: 0x1828ED870
	public void set_zxy(float3 value) { }

	// RVA: 0x28EC410 Offset: 0x28EAE10 VA: 0x1828EC410
	public float3 get_zxz() { }

	// RVA: 0x28EC230 Offset: 0x28EAC30 VA: 0x1828EC230
	public float3 get_zxw() { }

	// RVA: 0x28ED830 Offset: 0x28EC230 VA: 0x1828ED830
	public void set_zxw(float3 value) { }

	// RVA: 0x28EC570 Offset: 0x28EAF70 VA: 0x1828EC570
	public float3 get_zyx() { }

	// RVA: 0x28ED900 Offset: 0x28EC300 VA: 0x1828ED900
	public void set_zyx(float3 value) { }

	// RVA: 0x28EC610 Offset: 0x28EB010 VA: 0x1828EC610
	public float3 get_zyy() { }

	// RVA: 0x28EC6B0 Offset: 0x28EB0B0 VA: 0x1828EC6B0
	public float3 get_zyz() { }

	// RVA: 0x28EC4D0 Offset: 0x28EAED0 VA: 0x1828EC4D0
	public float3 get_zyw() { }

	// RVA: 0x28ED8C0 Offset: 0x28EC2C0 VA: 0x1828ED8C0
	public void set_zyw(float3 value) { }

	// RVA: 0x28EC810 Offset: 0x28EB210 VA: 0x1828EC810
	public float3 get_zzx() { }

	// RVA: 0x28EC8B0 Offset: 0x28EB2B0 VA: 0x1828EC8B0
	public float3 get_zzy() { }

	// RVA: 0x28EC950 Offset: 0x28EB350 VA: 0x1828EC950
	public float3 get_zzz() { }

	// RVA: 0x28EC770 Offset: 0x28EB170 VA: 0x1828EC770
	public float3 get_zzw() { }

	// RVA: 0x28EC030 Offset: 0x28EAA30 VA: 0x1828EC030
	public float3 get_zwx() { }

	// RVA: 0x28ED7A0 Offset: 0x28EC1A0 VA: 0x1828ED7A0
	public void set_zwx(float3 value) { }

	// RVA: 0x28EC0D0 Offset: 0x28EAAD0 VA: 0x1828EC0D0
	public float3 get_zwy() { }

	// RVA: 0x28ED7E0 Offset: 0x28EC1E0 VA: 0x1828ED7E0
	public void set_zwy(float3 value) { }

	// RVA: 0x28EC170 Offset: 0x28EAB70 VA: 0x1828EC170
	public float3 get_zwz() { }

	// RVA: 0x28EBF90 Offset: 0x28EA990 VA: 0x1828EBF90
	public float3 get_zww() { }

	// RVA: 0x28EA460 Offset: 0x28E8E60 VA: 0x1828EA460
	public float3 get_wxx() { }

	// RVA: 0x28EA500 Offset: 0x28E8F00 VA: 0x1828EA500
	public float3 get_wxy() { }

	// RVA: 0x28ED2D0 Offset: 0x28EBCD0 VA: 0x1828ED2D0
	public void set_wxy(float3 value) { }

	// RVA: 0x28EA5A0 Offset: 0x28E8FA0 VA: 0x1828EA5A0
	public float3 get_wxz() { }

	// RVA: 0x28ED310 Offset: 0x28EBD10 VA: 0x1828ED310
	public void set_wxz(float3 value) { }

	// RVA: 0x28EA3C0 Offset: 0x28E8DC0 VA: 0x1828EA3C0
	public float3 get_wxw() { }

	// RVA: 0x28EA700 Offset: 0x28E9100 VA: 0x1828EA700
	public float3 get_wyx() { }

	// RVA: 0x28ED360 Offset: 0x28EBD60 VA: 0x1828ED360
	public void set_wyx(float3 value) { }

	// RVA: 0x28EA7A0 Offset: 0x28E91A0 VA: 0x1828EA7A0
	public float3 get_wyy() { }

	// RVA: 0x28EA840 Offset: 0x28E9240 VA: 0x1828EA840
	public float3 get_wyz() { }

	// RVA: 0x28ED3A0 Offset: 0x28EBDA0 VA: 0x1828ED3A0
	public void set_wyz(float3 value) { }

	// RVA: 0x28EA660 Offset: 0x28E9060 VA: 0x1828EA660
	public float3 get_wyw() { }

	// RVA: 0x28EA9A0 Offset: 0x28E93A0 VA: 0x1828EA9A0
	public float3 get_wzx() { }

	// RVA: 0x28ED3F0 Offset: 0x28EBDF0 VA: 0x1828ED3F0
	public void set_wzx(float3 value) { }

	// RVA: 0x28EAA40 Offset: 0x28E9440 VA: 0x1828EAA40
	public float3 get_wzy() { }

	// RVA: 0x28ED430 Offset: 0x28EBE30 VA: 0x1828ED430
	public void set_wzy(float3 value) { }

	// RVA: 0x28EAAE0 Offset: 0x28E94E0 VA: 0x1828EAAE0
	public float3 get_wzz() { }

	// RVA: 0x28EA900 Offset: 0x28E9300 VA: 0x1828EA900
	public float3 get_wzw() { }

	// RVA: 0x28EA1C0 Offset: 0x28E8BC0 VA: 0x1828EA1C0
	public float3 get_wwx() { }

	// RVA: 0x28EA260 Offset: 0x28E8C60 VA: 0x1828EA260
	public float3 get_wwy() { }

	// RVA: 0x28EA300 Offset: 0x28E8D00 VA: 0x1828EA300
	public float3 get_wwz() { }

	// RVA: 0x28EA130 Offset: 0x28E8B30 VA: 0x1828EA130
	public float3 get_www() { }

	// RVA: 0x2928AE0 Offset: 0x29274E0 VA: 0x182928AE0
	public float2 get_xx() { }

	// RVA: 0x4A0C40 Offset: 0x49F640 VA: 0x1804A0C40
	public float2 get_xy() { }

	// RVA: 0x214CC40 Offset: 0x214B640 VA: 0x18214CC40
	public void set_xy(float2 value) { }

	// RVA: 0x7BCB30 Offset: 0x7BB530 VA: 0x1807BCB30
	public float2 get_xz() { }

	// RVA: 0x292FE60 Offset: 0x292E860 VA: 0x18292FE60
	public void set_xz(float2 value) { }

	// RVA: 0x293DEA0 Offset: 0x293C8A0 VA: 0x18293DEA0
	public float2 get_xw() { }

	// RVA: 0x293E7C0 Offset: 0x293D1C0 VA: 0x18293E7C0
	public void set_xw(float2 value) { }

	// RVA: 0x7BCB50 Offset: 0x7BB550 VA: 0x1807BCB50
	public float2 get_yx() { }

	// RVA: 0x2929280 Offset: 0x2927C80 VA: 0x182929280
	public void set_yx(float2 value) { }

	// RVA: 0x2928AF0 Offset: 0x29274F0 VA: 0x182928AF0
	public float2 get_yy() { }

	// RVA: 0x7BCB70 Offset: 0x7BB570 VA: 0x1807BCB70
	public float2 get_yz() { }

	// RVA: 0x292FE80 Offset: 0x292E880 VA: 0x18292FE80
	public void set_yz(float2 value) { }

	// RVA: 0x293DEC0 Offset: 0x293C8C0 VA: 0x18293DEC0
	public float2 get_yw() { }

	// RVA: 0x293E7E0 Offset: 0x293D1E0 VA: 0x18293E7E0
	public void set_yw(float2 value) { }

	// RVA: 0x7BCB90 Offset: 0x7BB590 VA: 0x1807BCB90
	public float2 get_zx() { }

	// RVA: 0x292FEA0 Offset: 0x292E8A0 VA: 0x18292FEA0
	public void set_zx(float2 value) { }

	// RVA: 0x7BCBB0 Offset: 0x7BB5B0 VA: 0x1807BCBB0
	public float2 get_zy() { }

	// RVA: 0x292FEC0 Offset: 0x292E8C0 VA: 0x18292FEC0
	public void set_zy(float2 value) { }

	// RVA: 0x292F630 Offset: 0x292E030 VA: 0x18292F630
	public float2 get_zz() { }

	// RVA: 0x18CCE00 Offset: 0x18CB800 VA: 0x1818CCE00
	public float2 get_zw() { }

	// RVA: 0x214CC60 Offset: 0x214B660 VA: 0x18214CC60
	public void set_zw(float2 value) { }

	// RVA: 0x293DE40 Offset: 0x293C840 VA: 0x18293DE40
	public float2 get_wx() { }

	// RVA: 0x293E760 Offset: 0x293D160 VA: 0x18293E760
	public void set_wx(float2 value) { }

	// RVA: 0x293DE60 Offset: 0x293C860 VA: 0x18293DE60
	public float2 get_wy() { }

	// RVA: 0x293E780 Offset: 0x293D180 VA: 0x18293E780
	public void set_wy(float2 value) { }

	// RVA: 0x293DE80 Offset: 0x293C880 VA: 0x18293DE80
	public float2 get_wz() { }

	// RVA: 0x293E7A0 Offset: 0x293D1A0 VA: 0x18293E7A0
	public void set_wz(float2 value) { }

	// RVA: 0x293DE20 Offset: 0x293C820 VA: 0x18293DE20
	public float2 get_ww() { }

	// RVA: 0xF6CE40 Offset: 0xF6B840 VA: 0x180F6CE40
	public float get_Item(int index) { }

	// RVA: 0xF73260 Offset: 0xF71C60 VA: 0x180F73260
	public void set_Item(int index, float value) { }

	// RVA: 0x214CBC0 Offset: 0x214B5C0 VA: 0x18214CBC0 Slot: 4
	public bool Equals(float4 rhs) { }

	// RVA: 0x293D6C0 Offset: 0x293C0C0 VA: 0x18293D6C0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x289FF40 Offset: 0x289E940 VA: 0x18289FF40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x293D780 Offset: 0x293C180 VA: 0x18293D780 Slot: 3
	public override string ToString() { }

	// RVA: 0x293D9A0 Offset: 0x293C3A0 VA: 0x18293D9A0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xC0CF00 Offset: 0xC0B900 VA: 0x180C0CF00
	public static float4 op_Implicit(Vector4 v) { }

	// RVA: 0xC0CF00 Offset: 0xC0B900 VA: 0x180C0CF00
	public static Vector4 op_Implicit(float4 v) { }
}
