public struct half4 : IEquatable<half4>, IFormattable // TypeDefIndex: 10920
{
	// Fields
	public half x; // 0x0
	public half y; // 0x2
	public half z; // 0x4
	public half w; // 0x6
	public static readonly half4 zero; // 0x0

	// Properties
	[EditorBrowsable(1)]
	public half4 xxxx { get; }
	[EditorBrowsable(1)]
	public half4 xxxy { get; }
	[EditorBrowsable(1)]
	public half4 xxxz { get; }
	[EditorBrowsable(1)]
	public half4 xxxw { get; }
	[EditorBrowsable(1)]
	public half4 xxyx { get; }
	[EditorBrowsable(1)]
	public half4 xxyy { get; }
	[EditorBrowsable(1)]
	public half4 xxyz { get; }
	[EditorBrowsable(1)]
	public half4 xxyw { get; }
	[EditorBrowsable(1)]
	public half4 xxzx { get; }
	[EditorBrowsable(1)]
	public half4 xxzy { get; }
	[EditorBrowsable(1)]
	public half4 xxzz { get; }
	[EditorBrowsable(1)]
	public half4 xxzw { get; }
	[EditorBrowsable(1)]
	public half4 xxwx { get; }
	[EditorBrowsable(1)]
	public half4 xxwy { get; }
	[EditorBrowsable(1)]
	public half4 xxwz { get; }
	[EditorBrowsable(1)]
	public half4 xxww { get; }
	[EditorBrowsable(1)]
	public half4 xyxx { get; }
	[EditorBrowsable(1)]
	public half4 xyxy { get; }
	[EditorBrowsable(1)]
	public half4 xyxz { get; }
	[EditorBrowsable(1)]
	public half4 xyxw { get; }
	[EditorBrowsable(1)]
	public half4 xyyx { get; }
	[EditorBrowsable(1)]
	public half4 xyyy { get; }
	[EditorBrowsable(1)]
	public half4 xyyz { get; }
	[EditorBrowsable(1)]
	public half4 xyyw { get; }
	[EditorBrowsable(1)]
	public half4 xyzx { get; }
	[EditorBrowsable(1)]
	public half4 xyzy { get; }
	[EditorBrowsable(1)]
	public half4 xyzz { get; }
	[EditorBrowsable(1)]
	public half4 xyzw { get; set; }
	[EditorBrowsable(1)]
	public half4 xywx { get; }
	[EditorBrowsable(1)]
	public half4 xywy { get; }
	[EditorBrowsable(1)]
	public half4 xywz { get; set; }
	[EditorBrowsable(1)]
	public half4 xyww { get; }
	[EditorBrowsable(1)]
	public half4 xzxx { get; }
	[EditorBrowsable(1)]
	public half4 xzxy { get; }
	[EditorBrowsable(1)]
	public half4 xzxz { get; }
	[EditorBrowsable(1)]
	public half4 xzxw { get; }
	[EditorBrowsable(1)]
	public half4 xzyx { get; }
	[EditorBrowsable(1)]
	public half4 xzyy { get; }
	[EditorBrowsable(1)]
	public half4 xzyz { get; }
	[EditorBrowsable(1)]
	public half4 xzyw { get; set; }
	[EditorBrowsable(1)]
	public half4 xzzx { get; }
	[EditorBrowsable(1)]
	public half4 xzzy { get; }
	[EditorBrowsable(1)]
	public half4 xzzz { get; }
	[EditorBrowsable(1)]
	public half4 xzzw { get; }
	[EditorBrowsable(1)]
	public half4 xzwx { get; }
	[EditorBrowsable(1)]
	public half4 xzwy { get; set; }
	[EditorBrowsable(1)]
	public half4 xzwz { get; }
	[EditorBrowsable(1)]
	public half4 xzww { get; }
	[EditorBrowsable(1)]
	public half4 xwxx { get; }
	[EditorBrowsable(1)]
	public half4 xwxy { get; }
	[EditorBrowsable(1)]
	public half4 xwxz { get; }
	[EditorBrowsable(1)]
	public half4 xwxw { get; }
	[EditorBrowsable(1)]
	public half4 xwyx { get; }
	[EditorBrowsable(1)]
	public half4 xwyy { get; }
	[EditorBrowsable(1)]
	public half4 xwyz { get; set; }
	[EditorBrowsable(1)]
	public half4 xwyw { get; }
	[EditorBrowsable(1)]
	public half4 xwzx { get; }
	[EditorBrowsable(1)]
	public half4 xwzy { get; set; }
	[EditorBrowsable(1)]
	public half4 xwzz { get; }
	[EditorBrowsable(1)]
	public half4 xwzw { get; }
	[EditorBrowsable(1)]
	public half4 xwwx { get; }
	[EditorBrowsable(1)]
	public half4 xwwy { get; }
	[EditorBrowsable(1)]
	public half4 xwwz { get; }
	[EditorBrowsable(1)]
	public half4 xwww { get; }
	[EditorBrowsable(1)]
	public half4 yxxx { get; }
	[EditorBrowsable(1)]
	public half4 yxxy { get; }
	[EditorBrowsable(1)]
	public half4 yxxz { get; }
	[EditorBrowsable(1)]
	public half4 yxxw { get; }
	[EditorBrowsable(1)]
	public half4 yxyx { get; }
	[EditorBrowsable(1)]
	public half4 yxyy { get; }
	[EditorBrowsable(1)]
	public half4 yxyz { get; }
	[EditorBrowsable(1)]
	public half4 yxyw { get; }
	[EditorBrowsable(1)]
	public half4 yxzx { get; }
	[EditorBrowsable(1)]
	public half4 yxzy { get; }
	[EditorBrowsable(1)]
	public half4 yxzz { get; }
	[EditorBrowsable(1)]
	public half4 yxzw { get; set; }
	[EditorBrowsable(1)]
	public half4 yxwx { get; }
	[EditorBrowsable(1)]
	public half4 yxwy { get; }
	[EditorBrowsable(1)]
	public half4 yxwz { get; set; }
	[EditorBrowsable(1)]
	public half4 yxww { get; }
	[EditorBrowsable(1)]
	public half4 yyxx { get; }
	[EditorBrowsable(1)]
	public half4 yyxy { get; }
	[EditorBrowsable(1)]
	public half4 yyxz { get; }
	[EditorBrowsable(1)]
	public half4 yyxw { get; }
	[EditorBrowsable(1)]
	public half4 yyyx { get; }
	[EditorBrowsable(1)]
	public half4 yyyy { get; }
	[EditorBrowsable(1)]
	public half4 yyyz { get; }
	[EditorBrowsable(1)]
	public half4 yyyw { get; }
	[EditorBrowsable(1)]
	public half4 yyzx { get; }
	[EditorBrowsable(1)]
	public half4 yyzy { get; }
	[EditorBrowsable(1)]
	public half4 yyzz { get; }
	[EditorBrowsable(1)]
	public half4 yyzw { get; }
	[EditorBrowsable(1)]
	public half4 yywx { get; }
	[EditorBrowsable(1)]
	public half4 yywy { get; }
	[EditorBrowsable(1)]
	public half4 yywz { get; }
	[EditorBrowsable(1)]
	public half4 yyww { get; }
	[EditorBrowsable(1)]
	public half4 yzxx { get; }
	[EditorBrowsable(1)]
	public half4 yzxy { get; }
	[EditorBrowsable(1)]
	public half4 yzxz { get; }
	[EditorBrowsable(1)]
	public half4 yzxw { get; set; }
	[EditorBrowsable(1)]
	public half4 yzyx { get; }
	[EditorBrowsable(1)]
	public half4 yzyy { get; }
	[EditorBrowsable(1)]
	public half4 yzyz { get; }
	[EditorBrowsable(1)]
	public half4 yzyw { get; }
	[EditorBrowsable(1)]
	public half4 yzzx { get; }
	[EditorBrowsable(1)]
	public half4 yzzy { get; }
	[EditorBrowsable(1)]
	public half4 yzzz { get; }
	[EditorBrowsable(1)]
	public half4 yzzw { get; }
	[EditorBrowsable(1)]
	public half4 yzwx { get; set; }
	[EditorBrowsable(1)]
	public half4 yzwy { get; }
	[EditorBrowsable(1)]
	public half4 yzwz { get; }
	[EditorBrowsable(1)]
	public half4 yzww { get; }
	[EditorBrowsable(1)]
	public half4 ywxx { get; }
	[EditorBrowsable(1)]
	public half4 ywxy { get; }
	[EditorBrowsable(1)]
	public half4 ywxz { get; set; }
	[EditorBrowsable(1)]
	public half4 ywxw { get; }
	[EditorBrowsable(1)]
	public half4 ywyx { get; }
	[EditorBrowsable(1)]
	public half4 ywyy { get; }
	[EditorBrowsable(1)]
	public half4 ywyz { get; }
	[EditorBrowsable(1)]
	public half4 ywyw { get; }
	[EditorBrowsable(1)]
	public half4 ywzx { get; set; }
	[EditorBrowsable(1)]
	public half4 ywzy { get; }
	[EditorBrowsable(1)]
	public half4 ywzz { get; }
	[EditorBrowsable(1)]
	public half4 ywzw { get; }
	[EditorBrowsable(1)]
	public half4 ywwx { get; }
	[EditorBrowsable(1)]
	public half4 ywwy { get; }
	[EditorBrowsable(1)]
	public half4 ywwz { get; }
	[EditorBrowsable(1)]
	public half4 ywww { get; }
	[EditorBrowsable(1)]
	public half4 zxxx { get; }
	[EditorBrowsable(1)]
	public half4 zxxy { get; }
	[EditorBrowsable(1)]
	public half4 zxxz { get; }
	[EditorBrowsable(1)]
	public half4 zxxw { get; }
	[EditorBrowsable(1)]
	public half4 zxyx { get; }
	[EditorBrowsable(1)]
	public half4 zxyy { get; }
	[EditorBrowsable(1)]
	public half4 zxyz { get; }
	[EditorBrowsable(1)]
	public half4 zxyw { get; set; }
	[EditorBrowsable(1)]
	public half4 zxzx { get; }
	[EditorBrowsable(1)]
	public half4 zxzy { get; }
	[EditorBrowsable(1)]
	public half4 zxzz { get; }
	[EditorBrowsable(1)]
	public half4 zxzw { get; }
	[EditorBrowsable(1)]
	public half4 zxwx { get; }
	[EditorBrowsable(1)]
	public half4 zxwy { get; set; }
	[EditorBrowsable(1)]
	public half4 zxwz { get; }
	[EditorBrowsable(1)]
	public half4 zxww { get; }
	[EditorBrowsable(1)]
	public half4 zyxx { get; }
	[EditorBrowsable(1)]
	public half4 zyxy { get; }
	[EditorBrowsable(1)]
	public half4 zyxz { get; }
	[EditorBrowsable(1)]
	public half4 zyxw { get; set; }
	[EditorBrowsable(1)]
	public half4 zyyx { get; }
	[EditorBrowsable(1)]
	public half4 zyyy { get; }
	[EditorBrowsable(1)]
	public half4 zyyz { get; }
	[EditorBrowsable(1)]
	public half4 zyyw { get; }
	[EditorBrowsable(1)]
	public half4 zyzx { get; }
	[EditorBrowsable(1)]
	public half4 zyzy { get; }
	[EditorBrowsable(1)]
	public half4 zyzz { get; }
	[EditorBrowsable(1)]
	public half4 zyzw { get; }
	[EditorBrowsable(1)]
	public half4 zywx { get; set; }
	[EditorBrowsable(1)]
	public half4 zywy { get; }
	[EditorBrowsable(1)]
	public half4 zywz { get; }
	[EditorBrowsable(1)]
	public half4 zyww { get; }
	[EditorBrowsable(1)]
	public half4 zzxx { get; }
	[EditorBrowsable(1)]
	public half4 zzxy { get; }
	[EditorBrowsable(1)]
	public half4 zzxz { get; }
	[EditorBrowsable(1)]
	public half4 zzxw { get; }
	[EditorBrowsable(1)]
	public half4 zzyx { get; }
	[EditorBrowsable(1)]
	public half4 zzyy { get; }
	[EditorBrowsable(1)]
	public half4 zzyz { get; }
	[EditorBrowsable(1)]
	public half4 zzyw { get; }
	[EditorBrowsable(1)]
	public half4 zzzx { get; }
	[EditorBrowsable(1)]
	public half4 zzzy { get; }
	[EditorBrowsable(1)]
	public half4 zzzz { get; }
	[EditorBrowsable(1)]
	public half4 zzzw { get; }
	[EditorBrowsable(1)]
	public half4 zzwx { get; }
	[EditorBrowsable(1)]
	public half4 zzwy { get; }
	[EditorBrowsable(1)]
	public half4 zzwz { get; }
	[EditorBrowsable(1)]
	public half4 zzww { get; }
	[EditorBrowsable(1)]
	public half4 zwxx { get; }
	[EditorBrowsable(1)]
	public half4 zwxy { get; set; }
	[EditorBrowsable(1)]
	public half4 zwxz { get; }
	[EditorBrowsable(1)]
	public half4 zwxw { get; }
	[EditorBrowsable(1)]
	public half4 zwyx { get; set; }
	[EditorBrowsable(1)]
	public half4 zwyy { get; }
	[EditorBrowsable(1)]
	public half4 zwyz { get; }
	[EditorBrowsable(1)]
	public half4 zwyw { get; }
	[EditorBrowsable(1)]
	public half4 zwzx { get; }
	[EditorBrowsable(1)]
	public half4 zwzy { get; }
	[EditorBrowsable(1)]
	public half4 zwzz { get; }
	[EditorBrowsable(1)]
	public half4 zwzw { get; }
	[EditorBrowsable(1)]
	public half4 zwwx { get; }
	[EditorBrowsable(1)]
	public half4 zwwy { get; }
	[EditorBrowsable(1)]
	public half4 zwwz { get; }
	[EditorBrowsable(1)]
	public half4 zwww { get; }
	[EditorBrowsable(1)]
	public half4 wxxx { get; }
	[EditorBrowsable(1)]
	public half4 wxxy { get; }
	[EditorBrowsable(1)]
	public half4 wxxz { get; }
	[EditorBrowsable(1)]
	public half4 wxxw { get; }
	[EditorBrowsable(1)]
	public half4 wxyx { get; }
	[EditorBrowsable(1)]
	public half4 wxyy { get; }
	[EditorBrowsable(1)]
	public half4 wxyz { get; set; }
	[EditorBrowsable(1)]
	public half4 wxyw { get; }
	[EditorBrowsable(1)]
	public half4 wxzx { get; }
	[EditorBrowsable(1)]
	public half4 wxzy { get; set; }
	[EditorBrowsable(1)]
	public half4 wxzz { get; }
	[EditorBrowsable(1)]
	public half4 wxzw { get; }
	[EditorBrowsable(1)]
	public half4 wxwx { get; }
	[EditorBrowsable(1)]
	public half4 wxwy { get; }
	[EditorBrowsable(1)]
	public half4 wxwz { get; }
	[EditorBrowsable(1)]
	public half4 wxww { get; }
	[EditorBrowsable(1)]
	public half4 wyxx { get; }
	[EditorBrowsable(1)]
	public half4 wyxy { get; }
	[EditorBrowsable(1)]
	public half4 wyxz { get; set; }
	[EditorBrowsable(1)]
	public half4 wyxw { get; }
	[EditorBrowsable(1)]
	public half4 wyyx { get; }
	[EditorBrowsable(1)]
	public half4 wyyy { get; }
	[EditorBrowsable(1)]
	public half4 wyyz { get; }
	[EditorBrowsable(1)]
	public half4 wyyw { get; }
	[EditorBrowsable(1)]
	public half4 wyzx { get; set; }
	[EditorBrowsable(1)]
	public half4 wyzy { get; }
	[EditorBrowsable(1)]
	public half4 wyzz { get; }
	[EditorBrowsable(1)]
	public half4 wyzw { get; }
	[EditorBrowsable(1)]
	public half4 wywx { get; }
	[EditorBrowsable(1)]
	public half4 wywy { get; }
	[EditorBrowsable(1)]
	public half4 wywz { get; }
	[EditorBrowsable(1)]
	public half4 wyww { get; }
	[EditorBrowsable(1)]
	public half4 wzxx { get; }
	[EditorBrowsable(1)]
	public half4 wzxy { get; set; }
	[EditorBrowsable(1)]
	public half4 wzxz { get; }
	[EditorBrowsable(1)]
	public half4 wzxw { get; }
	[EditorBrowsable(1)]
	public half4 wzyx { get; set; }
	[EditorBrowsable(1)]
	public half4 wzyy { get; }
	[EditorBrowsable(1)]
	public half4 wzyz { get; }
	[EditorBrowsable(1)]
	public half4 wzyw { get; }
	[EditorBrowsable(1)]
	public half4 wzzx { get; }
	[EditorBrowsable(1)]
	public half4 wzzy { get; }
	[EditorBrowsable(1)]
	public half4 wzzz { get; }
	[EditorBrowsable(1)]
	public half4 wzzw { get; }
	[EditorBrowsable(1)]
	public half4 wzwx { get; }
	[EditorBrowsable(1)]
	public half4 wzwy { get; }
	[EditorBrowsable(1)]
	public half4 wzwz { get; }
	[EditorBrowsable(1)]
	public half4 wzww { get; }
	[EditorBrowsable(1)]
	public half4 wwxx { get; }
	[EditorBrowsable(1)]
	public half4 wwxy { get; }
	[EditorBrowsable(1)]
	public half4 wwxz { get; }
	[EditorBrowsable(1)]
	public half4 wwxw { get; }
	[EditorBrowsable(1)]
	public half4 wwyx { get; }
	[EditorBrowsable(1)]
	public half4 wwyy { get; }
	[EditorBrowsable(1)]
	public half4 wwyz { get; }
	[EditorBrowsable(1)]
	public half4 wwyw { get; }
	[EditorBrowsable(1)]
	public half4 wwzx { get; }
	[EditorBrowsable(1)]
	public half4 wwzy { get; }
	[EditorBrowsable(1)]
	public half4 wwzz { get; }
	[EditorBrowsable(1)]
	public half4 wwzw { get; }
	[EditorBrowsable(1)]
	public half4 wwwx { get; }
	[EditorBrowsable(1)]
	public half4 wwwy { get; }
	[EditorBrowsable(1)]
	public half4 wwwz { get; }
	[EditorBrowsable(1)]
	public half4 wwww { get; }
	[EditorBrowsable(1)]
	public half3 xxx { get; }
	[EditorBrowsable(1)]
	public half3 xxy { get; }
	[EditorBrowsable(1)]
	public half3 xxz { get; }
	[EditorBrowsable(1)]
	public half3 xxw { get; }
	[EditorBrowsable(1)]
	public half3 xyx { get; }
	[EditorBrowsable(1)]
	public half3 xyy { get; }
	[EditorBrowsable(1)]
	public half3 xyz { get; set; }
	[EditorBrowsable(1)]
	public half3 xyw { get; set; }
	[EditorBrowsable(1)]
	public half3 xzx { get; }
	[EditorBrowsable(1)]
	public half3 xzy { get; set; }
	[EditorBrowsable(1)]
	public half3 xzz { get; }
	[EditorBrowsable(1)]
	public half3 xzw { get; set; }
	[EditorBrowsable(1)]
	public half3 xwx { get; }
	[EditorBrowsable(1)]
	public half3 xwy { get; set; }
	[EditorBrowsable(1)]
	public half3 xwz { get; set; }
	[EditorBrowsable(1)]
	public half3 xww { get; }
	[EditorBrowsable(1)]
	public half3 yxx { get; }
	[EditorBrowsable(1)]
	public half3 yxy { get; }
	[EditorBrowsable(1)]
	public half3 yxz { get; set; }
	[EditorBrowsable(1)]
	public half3 yxw { get; set; }
	[EditorBrowsable(1)]
	public half3 yyx { get; }
	[EditorBrowsable(1)]
	public half3 yyy { get; }
	[EditorBrowsable(1)]
	public half3 yyz { get; }
	[EditorBrowsable(1)]
	public half3 yyw { get; }
	[EditorBrowsable(1)]
	public half3 yzx { get; set; }
	[EditorBrowsable(1)]
	public half3 yzy { get; }
	[EditorBrowsable(1)]
	public half3 yzz { get; }
	[EditorBrowsable(1)]
	public half3 yzw { get; set; }
	[EditorBrowsable(1)]
	public half3 ywx { get; set; }
	[EditorBrowsable(1)]
	public half3 ywy { get; }
	[EditorBrowsable(1)]
	public half3 ywz { get; set; }
	[EditorBrowsable(1)]
	public half3 yww { get; }
	[EditorBrowsable(1)]
	public half3 zxx { get; }
	[EditorBrowsable(1)]
	public half3 zxy { get; set; }
	[EditorBrowsable(1)]
	public half3 zxz { get; }
	[EditorBrowsable(1)]
	public half3 zxw { get; set; }
	[EditorBrowsable(1)]
	public half3 zyx { get; set; }
	[EditorBrowsable(1)]
	public half3 zyy { get; }
	[EditorBrowsable(1)]
	public half3 zyz { get; }
	[EditorBrowsable(1)]
	public half3 zyw { get; set; }
	[EditorBrowsable(1)]
	public half3 zzx { get; }
	[EditorBrowsable(1)]
	public half3 zzy { get; }
	[EditorBrowsable(1)]
	public half3 zzz { get; }
	[EditorBrowsable(1)]
	public half3 zzw { get; }
	[EditorBrowsable(1)]
	public half3 zwx { get; set; }
	[EditorBrowsable(1)]
	public half3 zwy { get; set; }
	[EditorBrowsable(1)]
	public half3 zwz { get; }
	[EditorBrowsable(1)]
	public half3 zww { get; }
	[EditorBrowsable(1)]
	public half3 wxx { get; }
	[EditorBrowsable(1)]
	public half3 wxy { get; set; }
	[EditorBrowsable(1)]
	public half3 wxz { get; set; }
	[EditorBrowsable(1)]
	public half3 wxw { get; }
	[EditorBrowsable(1)]
	public half3 wyx { get; set; }
	[EditorBrowsable(1)]
	public half3 wyy { get; }
	[EditorBrowsable(1)]
	public half3 wyz { get; set; }
	[EditorBrowsable(1)]
	public half3 wyw { get; }
	[EditorBrowsable(1)]
	public half3 wzx { get; set; }
	[EditorBrowsable(1)]
	public half3 wzy { get; set; }
	[EditorBrowsable(1)]
	public half3 wzz { get; }
	[EditorBrowsable(1)]
	public half3 wzw { get; }
	[EditorBrowsable(1)]
	public half3 wwx { get; }
	[EditorBrowsable(1)]
	public half3 wwy { get; }
	[EditorBrowsable(1)]
	public half3 wwz { get; }
	[EditorBrowsable(1)]
	public half3 www { get; }
	[EditorBrowsable(1)]
	public half2 xx { get; }
	[EditorBrowsable(1)]
	public half2 xy { get; set; }
	[EditorBrowsable(1)]
	public half2 xz { get; set; }
	[EditorBrowsable(1)]
	public half2 xw { get; set; }
	[EditorBrowsable(1)]
	public half2 yx { get; set; }
	[EditorBrowsable(1)]
	public half2 yy { get; }
	[EditorBrowsable(1)]
	public half2 yz { get; set; }
	[EditorBrowsable(1)]
	public half2 yw { get; set; }
	[EditorBrowsable(1)]
	public half2 zx { get; set; }
	[EditorBrowsable(1)]
	public half2 zy { get; set; }
	[EditorBrowsable(1)]
	public half2 zz { get; }
	[EditorBrowsable(1)]
	public half2 zw { get; set; }
	[EditorBrowsable(1)]
	public half2 wx { get; set; }
	[EditorBrowsable(1)]
	public half2 wy { get; set; }
	[EditorBrowsable(1)]
	public half2 wz { get; set; }
	[EditorBrowsable(1)]
	public half2 ww { get; }
	public half Item { get; set; }

	// Methods

	// RVA: 0x2712A80 Offset: 0x2711480 VA: 0x182712A80
	public void .ctor(half x, half y, half z, half w) { }

	// RVA: 0x294FF50 Offset: 0x294E950 VA: 0x18294FF50
	public void .ctor(half x, half y, half2 zw) { }

	// RVA: 0x29500B0 Offset: 0x294EAB0 VA: 0x1829500B0
	public void .ctor(half x, half2 yz, half w) { }

	// RVA: 0x2950100 Offset: 0x294EB00 VA: 0x182950100
	public void .ctor(half x, half3 yzw) { }

	// RVA: 0x294FE80 Offset: 0x294E880 VA: 0x18294FE80
	public void .ctor(half2 xy, half z, half w) { }

	// RVA: 0x294FF00 Offset: 0x294E900 VA: 0x18294FF00
	public void .ctor(half2 xy, half2 zw) { }

	// RVA: 0x29500E0 Offset: 0x294EAE0 VA: 0x1829500E0
	public void .ctor(half3 xyz, half w) { }

	// RVA: 0x294FF20 Offset: 0x294E920 VA: 0x18294FF20
	public void .ctor(half4 xyzw) { }

	// RVA: 0x29500D0 Offset: 0x294EAD0 VA: 0x1829500D0
	public void .ctor(half v) { }

	// RVA: 0x2950050 Offset: 0x294EA50 VA: 0x182950050
	public void .ctor(float v) { }

	// RVA: 0x294FEA0 Offset: 0x294E8A0 VA: 0x18294FEA0
	public void .ctor(float4 v) { }

	// RVA: 0x294FFE0 Offset: 0x294E9E0 VA: 0x18294FFE0
	public void .ctor(double v) { }

	// RVA: 0x294FF70 Offset: 0x294E970 VA: 0x18294FF70
	public void .ctor(double4 v) { }

	// RVA: 0x289EB50 Offset: 0x289D550 VA: 0x18289EB50
	public static half4 op_Implicit(half v) { }

	// RVA: 0x289EC40 Offset: 0x289D640 VA: 0x18289EC40
	public static half4 op_Explicit(float v) { }

	// RVA: 0x289EDD0 Offset: 0x289D7D0 VA: 0x18289EDD0
	public static half4 op_Explicit(float4 v) { }

	// RVA: 0x289ED00 Offset: 0x289D700 VA: 0x18289ED00
	public static half4 op_Explicit(double v) { }

	// RVA: 0x289EBA0 Offset: 0x289D5A0 VA: 0x18289EBA0
	public static half4 op_Explicit(double4 v) { }

	// RVA: 0x29527A0 Offset: 0x29511A0 VA: 0x1829527A0
	public static bool4 op_Equality(half4 lhs, half4 rhs) { }

	// RVA: 0x29527F0 Offset: 0x29511F0 VA: 0x1829527F0
	public static bool4 op_Equality(half4 lhs, half rhs) { }

	// RVA: 0x2952760 Offset: 0x2951160 VA: 0x182952760
	public static bool4 op_Equality(half lhs, half4 rhs) { }

	// RVA: 0x2952870 Offset: 0x2951270 VA: 0x182952870
	public static bool4 op_Inequality(half4 lhs, half4 rhs) { }

	// RVA: 0x2952830 Offset: 0x2951230 VA: 0x182952830
	public static bool4 op_Inequality(half4 lhs, half rhs) { }

	// RVA: 0x29528C0 Offset: 0x29512C0 VA: 0x1829528C0
	public static bool4 op_Inequality(half lhs, half4 rhs) { }

	// RVA: 0x294DEE0 Offset: 0x294C8E0 VA: 0x18294DEE0
	public half4 get_xxxx() { }

	// RVA: 0x294DF00 Offset: 0x294C900 VA: 0x18294DF00
	public half4 get_xxxy() { }

	// RVA: 0x294E810 Offset: 0x294D210 VA: 0x18294E810
	public half4 get_xxxz() { }

	// RVA: 0x2951410 Offset: 0x294FE10 VA: 0x182951410
	public half4 get_xxxw() { }

	// RVA: 0x294DF50 Offset: 0x294C950 VA: 0x18294DF50
	public half4 get_xxyx() { }

	// RVA: 0x294DF80 Offset: 0x294C980 VA: 0x18294DF80
	public half4 get_xxyy() { }

	// RVA: 0x294E840 Offset: 0x294D240 VA: 0x18294E840
	public half4 get_xxyz() { }

	// RVA: 0x2951440 Offset: 0x294FE40 VA: 0x182951440
	public half4 get_xxyw() { }

	// RVA: 0x294E890 Offset: 0x294D290 VA: 0x18294E890
	public half4 get_xxzx() { }

	// RVA: 0x294E8C0 Offset: 0x294D2C0 VA: 0x18294E8C0
	public half4 get_xxzy() { }

	// RVA: 0x294E8F0 Offset: 0x294D2F0 VA: 0x18294E8F0
	public half4 get_xxzz() { }

	// RVA: 0x2951470 Offset: 0x294FE70 VA: 0x182951470
	public half4 get_xxzw() { }

	// RVA: 0x2951380 Offset: 0x294FD80 VA: 0x182951380
	public half4 get_xxwx() { }

	// RVA: 0x29513B0 Offset: 0x294FDB0 VA: 0x1829513B0
	public half4 get_xxwy() { }

	// RVA: 0x29513E0 Offset: 0x294FDE0 VA: 0x1829513E0
	public half4 get_xxwz() { }

	// RVA: 0x2951350 Offset: 0x294FD50 VA: 0x182951350
	public half4 get_xxww() { }

	// RVA: 0x294DFF0 Offset: 0x294C9F0 VA: 0x18294DFF0
	public half4 get_xyxx() { }

	// RVA: 0x294E020 Offset: 0x294CA20 VA: 0x18294E020
	public half4 get_xyxy() { }

	// RVA: 0x294E920 Offset: 0x294D320 VA: 0x18294E920
	public half4 get_xyxz() { }

	// RVA: 0x2951580 Offset: 0x294FF80 VA: 0x182951580
	public half4 get_xyxw() { }

	// RVA: 0x294E070 Offset: 0x294CA70 VA: 0x18294E070
	public half4 get_xyyx() { }

	// RVA: 0x294E0A0 Offset: 0x294CAA0 VA: 0x18294E0A0
	public half4 get_xyyy() { }

	// RVA: 0x294E950 Offset: 0x294D350 VA: 0x18294E950
	public half4 get_xyyz() { }

	// RVA: 0x29515B0 Offset: 0x294FFB0 VA: 0x1829515B0
	public half4 get_xyyw() { }

	// RVA: 0x294E9A0 Offset: 0x294D3A0 VA: 0x18294E9A0
	public half4 get_xyzx() { }

	// RVA: 0x294E9D0 Offset: 0x294D3D0 VA: 0x18294E9D0
	public half4 get_xyzy() { }

	// RVA: 0x294EA00 Offset: 0x294D400 VA: 0x18294EA00
	public half4 get_xyzz() { }

	// RVA: 0x29515E0 Offset: 0x294FFE0 VA: 0x1829515E0
	public half4 get_xyzw() { }

	// RVA: 0x294FF20 Offset: 0x294E920 VA: 0x18294FF20
	public void set_xyzw(half4 value) { }

	// RVA: 0x29514F0 Offset: 0x294FEF0 VA: 0x1829514F0
	public half4 get_xywx() { }

	// RVA: 0x2951520 Offset: 0x294FF20 VA: 0x182951520
	public half4 get_xywy() { }

	// RVA: 0x2951550 Offset: 0x294FF50 VA: 0x182951550
	public half4 get_xywz() { }

	// RVA: 0x2952BE0 Offset: 0x29515E0 VA: 0x182952BE0
	public void set_xywz(half4 value) { }

	// RVA: 0x29514C0 Offset: 0x294FEC0 VA: 0x1829514C0
	public half4 get_xyww() { }

	// RVA: 0x294EA70 Offset: 0x294D470 VA: 0x18294EA70
	public half4 get_xzxx() { }

	// RVA: 0x294EAA0 Offset: 0x294D4A0 VA: 0x18294EAA0
	public half4 get_xzxy() { }

	// RVA: 0x294EAD0 Offset: 0x294D4D0 VA: 0x18294EAD0
	public half4 get_xzxz() { }

	// RVA: 0x29516F0 Offset: 0x29500F0 VA: 0x1829516F0
	public half4 get_xzxw() { }

	// RVA: 0x294EB20 Offset: 0x294D520 VA: 0x18294EB20
	public half4 get_xzyx() { }

	// RVA: 0x294EB50 Offset: 0x294D550 VA: 0x18294EB50
	public half4 get_xzyy() { }

	// RVA: 0x294EB80 Offset: 0x294D580 VA: 0x18294EB80
	public half4 get_xzyz() { }

	// RVA: 0x2951720 Offset: 0x2950120 VA: 0x182951720
	public half4 get_xzyw() { }

	// RVA: 0x2952C60 Offset: 0x2951660 VA: 0x182952C60
	public void set_xzyw(half4 value) { }

	// RVA: 0x294EBD0 Offset: 0x294D5D0 VA: 0x18294EBD0
	public half4 get_xzzx() { }

	// RVA: 0x294EC00 Offset: 0x294D600 VA: 0x18294EC00
	public half4 get_xzzy() { }

	// RVA: 0x294EC30 Offset: 0x294D630 VA: 0x18294EC30
	public half4 get_xzzz() { }

	// RVA: 0x2951750 Offset: 0x2950150 VA: 0x182951750
	public half4 get_xzzw() { }

	// RVA: 0x2951660 Offset: 0x2950060 VA: 0x182951660
	public half4 get_xzwx() { }

	// RVA: 0x2951690 Offset: 0x2950090 VA: 0x182951690
	public half4 get_xzwy() { }

	// RVA: 0x2952C30 Offset: 0x2951630 VA: 0x182952C30
	public void set_xzwy(half4 value) { }

	// RVA: 0x29516C0 Offset: 0x29500C0 VA: 0x1829516C0
	public half4 get_xzwz() { }

	// RVA: 0x2951630 Offset: 0x2950030 VA: 0x182951630
	public half4 get_xzww() { }

	// RVA: 0x29510E0 Offset: 0x294FAE0 VA: 0x1829510E0
	public half4 get_xwxx() { }

	// RVA: 0x2951110 Offset: 0x294FB10 VA: 0x182951110
	public half4 get_xwxy() { }

	// RVA: 0x2951140 Offset: 0x294FB40 VA: 0x182951140
	public half4 get_xwxz() { }

	// RVA: 0x29510B0 Offset: 0x294FAB0 VA: 0x1829510B0
	public half4 get_xwxw() { }

	// RVA: 0x29511C0 Offset: 0x294FBC0 VA: 0x1829511C0
	public half4 get_xwyx() { }

	// RVA: 0x29511F0 Offset: 0x294FBF0 VA: 0x1829511F0
	public half4 get_xwyy() { }

	// RVA: 0x2951220 Offset: 0x294FC20 VA: 0x182951220
	public half4 get_xwyz() { }

	// RVA: 0x2952B40 Offset: 0x2951540 VA: 0x182952B40
	public void set_xwyz(half4 value) { }

	// RVA: 0x2951190 Offset: 0x294FB90 VA: 0x182951190
	public half4 get_xwyw() { }

	// RVA: 0x29512A0 Offset: 0x294FCA0 VA: 0x1829512A0
	public half4 get_xwzx() { }

	// RVA: 0x29512D0 Offset: 0x294FCD0 VA: 0x1829512D0
	public half4 get_xwzy() { }

	// RVA: 0x2952B90 Offset: 0x2951590 VA: 0x182952B90
	public void set_xwzy(half4 value) { }

	// RVA: 0x2951300 Offset: 0x294FD00 VA: 0x182951300
	public half4 get_xwzz() { }

	// RVA: 0x2951270 Offset: 0x294FC70 VA: 0x182951270
	public half4 get_xwzw() { }

	// RVA: 0x2951000 Offset: 0x294FA00 VA: 0x182951000
	public half4 get_xwwx() { }

	// RVA: 0x2951030 Offset: 0x294FA30 VA: 0x182951030
	public half4 get_xwwy() { }

	// RVA: 0x2951060 Offset: 0x294FA60 VA: 0x182951060
	public half4 get_xwwz() { }

	// RVA: 0x2950FD0 Offset: 0x294F9D0 VA: 0x182950FD0
	public half4 get_xwww() { }

	// RVA: 0x294E110 Offset: 0x294CB10 VA: 0x18294E110
	public half4 get_yxxx() { }

	// RVA: 0x294E140 Offset: 0x294CB40 VA: 0x18294E140
	public half4 get_yxxy() { }

	// RVA: 0x294EC60 Offset: 0x294D660 VA: 0x18294EC60
	public half4 get_yxxz() { }

	// RVA: 0x2951C00 Offset: 0x2950600 VA: 0x182951C00
	public half4 get_yxxw() { }

	// RVA: 0x294E190 Offset: 0x294CB90 VA: 0x18294E190
	public half4 get_yxyx() { }

	// RVA: 0x294E1C0 Offset: 0x294CBC0 VA: 0x18294E1C0
	public half4 get_yxyy() { }

	// RVA: 0x294EC90 Offset: 0x294D690 VA: 0x18294EC90
	public half4 get_yxyz() { }

	// RVA: 0x2951C30 Offset: 0x2950630 VA: 0x182951C30
	public half4 get_yxyw() { }

	// RVA: 0x294ECE0 Offset: 0x294D6E0 VA: 0x18294ECE0
	public half4 get_yxzx() { }

	// RVA: 0x294ED10 Offset: 0x294D710 VA: 0x18294ED10
	public half4 get_yxzy() { }

	// RVA: 0x294ED40 Offset: 0x294D740 VA: 0x18294ED40
	public half4 get_yxzz() { }

	// RVA: 0x2951C60 Offset: 0x2950660 VA: 0x182951C60
	public half4 get_yxzw() { }

	// RVA: 0x2952D90 Offset: 0x2951790 VA: 0x182952D90
	public void set_yxzw(half4 value) { }

	// RVA: 0x2951B70 Offset: 0x2950570 VA: 0x182951B70
	public half4 get_yxwx() { }

	// RVA: 0x2951BA0 Offset: 0x29505A0 VA: 0x182951BA0
	public half4 get_yxwy() { }

	// RVA: 0x2951BD0 Offset: 0x29505D0 VA: 0x182951BD0
	public half4 get_yxwz() { }

	// RVA: 0x2952D60 Offset: 0x2951760 VA: 0x182952D60
	public void set_yxwz(half4 value) { }

	// RVA: 0x2951B40 Offset: 0x2950540 VA: 0x182951B40
	public half4 get_yxww() { }

	// RVA: 0x294E230 Offset: 0x294CC30 VA: 0x18294E230
	public half4 get_yyxx() { }

	// RVA: 0x294E260 Offset: 0x294CC60 VA: 0x18294E260
	public half4 get_yyxy() { }

	// RVA: 0x294ED70 Offset: 0x294D770 VA: 0x18294ED70
	public half4 get_yyxz() { }

	// RVA: 0x2951D70 Offset: 0x2950770 VA: 0x182951D70
	public half4 get_yyxw() { }

	// RVA: 0x294E2B0 Offset: 0x294CCB0 VA: 0x18294E2B0
	public half4 get_yyyx() { }

	// RVA: 0x294E2E0 Offset: 0x294CCE0 VA: 0x18294E2E0
	public half4 get_yyyy() { }

	// RVA: 0x294EDA0 Offset: 0x294D7A0 VA: 0x18294EDA0
	public half4 get_yyyz() { }

	// RVA: 0x2951DA0 Offset: 0x29507A0 VA: 0x182951DA0
	public half4 get_yyyw() { }

	// RVA: 0x294EDF0 Offset: 0x294D7F0 VA: 0x18294EDF0
	public half4 get_yyzx() { }

	// RVA: 0x294EE20 Offset: 0x294D820 VA: 0x18294EE20
	public half4 get_yyzy() { }

	// RVA: 0x294EE50 Offset: 0x294D850 VA: 0x18294EE50
	public half4 get_yyzz() { }

	// RVA: 0x2951DD0 Offset: 0x29507D0 VA: 0x182951DD0
	public half4 get_yyzw() { }

	// RVA: 0x2951CE0 Offset: 0x29506E0 VA: 0x182951CE0
	public half4 get_yywx() { }

	// RVA: 0x2951D10 Offset: 0x2950710 VA: 0x182951D10
	public half4 get_yywy() { }

	// RVA: 0x2951D40 Offset: 0x2950740 VA: 0x182951D40
	public half4 get_yywz() { }

	// RVA: 0x2951CB0 Offset: 0x29506B0 VA: 0x182951CB0
	public half4 get_yyww() { }

	// RVA: 0x294EEC0 Offset: 0x294D8C0 VA: 0x18294EEC0
	public half4 get_yzxx() { }

	// RVA: 0x294EEF0 Offset: 0x294D8F0 VA: 0x18294EEF0
	public half4 get_yzxy() { }

	// RVA: 0x294EF20 Offset: 0x294D920 VA: 0x18294EF20
	public half4 get_yzxz() { }

	// RVA: 0x2951EE0 Offset: 0x29508E0 VA: 0x182951EE0
	public half4 get_yzxw() { }

	// RVA: 0x2952E10 Offset: 0x2951810 VA: 0x182952E10
	public void set_yzxw(half4 value) { }

	// RVA: 0x294EF70 Offset: 0x294D970 VA: 0x18294EF70
	public half4 get_yzyx() { }

	// RVA: 0x294EFA0 Offset: 0x294D9A0 VA: 0x18294EFA0
	public half4 get_yzyy() { }

	// RVA: 0x294EFD0 Offset: 0x294D9D0 VA: 0x18294EFD0
	public half4 get_yzyz() { }

	// RVA: 0x2951F10 Offset: 0x2950910 VA: 0x182951F10
	public half4 get_yzyw() { }

	// RVA: 0x294F020 Offset: 0x294DA20 VA: 0x18294F020
	public half4 get_yzzx() { }

	// RVA: 0x294F050 Offset: 0x294DA50 VA: 0x18294F050
	public half4 get_yzzy() { }

	// RVA: 0x294F080 Offset: 0x294DA80 VA: 0x18294F080
	public half4 get_yzzz() { }

	// RVA: 0x2951F40 Offset: 0x2950940 VA: 0x182951F40
	public half4 get_yzzw() { }

	// RVA: 0x2951E50 Offset: 0x2950850 VA: 0x182951E50
	public half4 get_yzwx() { }

	// RVA: 0x2952DE0 Offset: 0x29517E0 VA: 0x182952DE0
	public void set_yzwx(half4 value) { }

	// RVA: 0x2951E80 Offset: 0x2950880 VA: 0x182951E80
	public half4 get_yzwy() { }

	// RVA: 0x2951EB0 Offset: 0x29508B0 VA: 0x182951EB0
	public half4 get_yzwz() { }

	// RVA: 0x2951E20 Offset: 0x2950820 VA: 0x182951E20
	public half4 get_yzww() { }

	// RVA: 0x29518D0 Offset: 0x29502D0 VA: 0x1829518D0
	public half4 get_ywxx() { }

	// RVA: 0x2951900 Offset: 0x2950300 VA: 0x182951900
	public half4 get_ywxy() { }

	// RVA: 0x2951930 Offset: 0x2950330 VA: 0x182951930
	public half4 get_ywxz() { }

	// RVA: 0x2952CC0 Offset: 0x29516C0 VA: 0x182952CC0
	public void set_ywxz(half4 value) { }

	// RVA: 0x29518A0 Offset: 0x29502A0 VA: 0x1829518A0
	public half4 get_ywxw() { }

	// RVA: 0x29519B0 Offset: 0x29503B0 VA: 0x1829519B0
	public half4 get_ywyx() { }

	// RVA: 0x29519E0 Offset: 0x29503E0 VA: 0x1829519E0
	public half4 get_ywyy() { }

	// RVA: 0x2951A10 Offset: 0x2950410 VA: 0x182951A10
	public half4 get_ywyz() { }

	// RVA: 0x2951980 Offset: 0x2950380 VA: 0x182951980
	public half4 get_ywyw() { }

	// RVA: 0x2951A90 Offset: 0x2950490 VA: 0x182951A90
	public half4 get_ywzx() { }

	// RVA: 0x2952D10 Offset: 0x2951710 VA: 0x182952D10
	public void set_ywzx(half4 value) { }

	// RVA: 0x2951AC0 Offset: 0x29504C0 VA: 0x182951AC0
	public half4 get_ywzy() { }

	// RVA: 0x2951AF0 Offset: 0x29504F0 VA: 0x182951AF0
	public half4 get_ywzz() { }

	// RVA: 0x2951A60 Offset: 0x2950460 VA: 0x182951A60
	public half4 get_ywzw() { }

	// RVA: 0x29517F0 Offset: 0x29501F0 VA: 0x1829517F0
	public half4 get_ywwx() { }

	// RVA: 0x2951820 Offset: 0x2950220 VA: 0x182951820
	public half4 get_ywwy() { }

	// RVA: 0x2951850 Offset: 0x2950250 VA: 0x182951850
	public half4 get_ywwz() { }

	// RVA: 0x29517C0 Offset: 0x29501C0 VA: 0x1829517C0
	public half4 get_ywww() { }

	// RVA: 0x294F0F0 Offset: 0x294DAF0 VA: 0x18294F0F0
	public half4 get_zxxx() { }

	// RVA: 0x294F120 Offset: 0x294DB20 VA: 0x18294F120
	public half4 get_zxxy() { }

	// RVA: 0x294F150 Offset: 0x294DB50 VA: 0x18294F150
	public half4 get_zxxz() { }

	// RVA: 0x29523F0 Offset: 0x2950DF0 VA: 0x1829523F0
	public half4 get_zxxw() { }

	// RVA: 0x294F1A0 Offset: 0x294DBA0 VA: 0x18294F1A0
	public half4 get_zxyx() { }

	// RVA: 0x294F1D0 Offset: 0x294DBD0 VA: 0x18294F1D0
	public half4 get_zxyy() { }

	// RVA: 0x294F200 Offset: 0x294DC00 VA: 0x18294F200
	public half4 get_zxyz() { }

	// RVA: 0x2952420 Offset: 0x2950E20 VA: 0x182952420
	public half4 get_zxyw() { }

	// RVA: 0x2952F40 Offset: 0x2951940 VA: 0x182952F40
	public void set_zxyw(half4 value) { }

	// RVA: 0x294F250 Offset: 0x294DC50 VA: 0x18294F250
	public half4 get_zxzx() { }

	// RVA: 0x294F280 Offset: 0x294DC80 VA: 0x18294F280
	public half4 get_zxzy() { }

	// RVA: 0x294F2B0 Offset: 0x294DCB0 VA: 0x18294F2B0
	public half4 get_zxzz() { }

	// RVA: 0x2952450 Offset: 0x2950E50 VA: 0x182952450
	public half4 get_zxzw() { }

	// RVA: 0x2952360 Offset: 0x2950D60 VA: 0x182952360
	public half4 get_zxwx() { }

	// RVA: 0x2952390 Offset: 0x2950D90 VA: 0x182952390
	public half4 get_zxwy() { }

	// RVA: 0x2952F10 Offset: 0x2951910 VA: 0x182952F10
	public void set_zxwy(half4 value) { }

	// RVA: 0x29523C0 Offset: 0x2950DC0 VA: 0x1829523C0
	public half4 get_zxwz() { }

	// RVA: 0x2952330 Offset: 0x2950D30 VA: 0x182952330
	public half4 get_zxww() { }

	// RVA: 0x294F320 Offset: 0x294DD20 VA: 0x18294F320
	public half4 get_zyxx() { }

	// RVA: 0x294F350 Offset: 0x294DD50 VA: 0x18294F350
	public half4 get_zyxy() { }

	// RVA: 0x294F380 Offset: 0x294DD80 VA: 0x18294F380
	public half4 get_zyxz() { }

	// RVA: 0x2952560 Offset: 0x2950F60 VA: 0x182952560
	public half4 get_zyxw() { }

	// RVA: 0x2952FC0 Offset: 0x29519C0 VA: 0x182952FC0
	public void set_zyxw(half4 value) { }

	// RVA: 0x294F3D0 Offset: 0x294DDD0 VA: 0x18294F3D0
	public half4 get_zyyx() { }

	// RVA: 0x294F400 Offset: 0x294DE00 VA: 0x18294F400
	public half4 get_zyyy() { }

	// RVA: 0x294F430 Offset: 0x294DE30 VA: 0x18294F430
	public half4 get_zyyz() { }

	// RVA: 0x2952590 Offset: 0x2950F90 VA: 0x182952590
	public half4 get_zyyw() { }

	// RVA: 0x294F480 Offset: 0x294DE80 VA: 0x18294F480
	public half4 get_zyzx() { }

	// RVA: 0x294F4B0 Offset: 0x294DEB0 VA: 0x18294F4B0
	public half4 get_zyzy() { }

	// RVA: 0x294F4E0 Offset: 0x294DEE0 VA: 0x18294F4E0
	public half4 get_zyzz() { }

	// RVA: 0x29525C0 Offset: 0x2950FC0 VA: 0x1829525C0
	public half4 get_zyzw() { }

	// RVA: 0x29524D0 Offset: 0x2950ED0 VA: 0x1829524D0
	public half4 get_zywx() { }

	// RVA: 0x2952F90 Offset: 0x2951990 VA: 0x182952F90
	public void set_zywx(half4 value) { }

	// RVA: 0x2952500 Offset: 0x2950F00 VA: 0x182952500
	public half4 get_zywy() { }

	// RVA: 0x2952530 Offset: 0x2950F30 VA: 0x182952530
	public half4 get_zywz() { }

	// RVA: 0x29524A0 Offset: 0x2950EA0 VA: 0x1829524A0
	public half4 get_zyww() { }

	// RVA: 0x294F550 Offset: 0x294DF50 VA: 0x18294F550
	public half4 get_zzxx() { }

	// RVA: 0x294F580 Offset: 0x294DF80 VA: 0x18294F580
	public half4 get_zzxy() { }

	// RVA: 0x294F5B0 Offset: 0x294DFB0 VA: 0x18294F5B0
	public half4 get_zzxz() { }

	// RVA: 0x29526D0 Offset: 0x29510D0 VA: 0x1829526D0
	public half4 get_zzxw() { }

	// RVA: 0x294F600 Offset: 0x294E000 VA: 0x18294F600
	public half4 get_zzyx() { }

	// RVA: 0x294F630 Offset: 0x294E030 VA: 0x18294F630
	public half4 get_zzyy() { }

	// RVA: 0x294F660 Offset: 0x294E060 VA: 0x18294F660
	public half4 get_zzyz() { }

	// RVA: 0x2952700 Offset: 0x2951100 VA: 0x182952700
	public half4 get_zzyw() { }

	// RVA: 0x294F6B0 Offset: 0x294E0B0 VA: 0x18294F6B0
	public half4 get_zzzx() { }

	// RVA: 0x294F6E0 Offset: 0x294E0E0 VA: 0x18294F6E0
	public half4 get_zzzy() { }

	// RVA: 0x294F710 Offset: 0x294E110 VA: 0x18294F710
	public half4 get_zzzz() { }

	// RVA: 0x2952730 Offset: 0x2951130 VA: 0x182952730
	public half4 get_zzzw() { }

	// RVA: 0x2952640 Offset: 0x2951040 VA: 0x182952640
	public half4 get_zzwx() { }

	// RVA: 0x2952670 Offset: 0x2951070 VA: 0x182952670
	public half4 get_zzwy() { }

	// RVA: 0x29526A0 Offset: 0x29510A0 VA: 0x1829526A0
	public half4 get_zzwz() { }

	// RVA: 0x2952610 Offset: 0x2951010 VA: 0x182952610
	public half4 get_zzww() { }

	// RVA: 0x29520C0 Offset: 0x2950AC0 VA: 0x1829520C0
	public half4 get_zwxx() { }

	// RVA: 0x29520F0 Offset: 0x2950AF0 VA: 0x1829520F0
	public half4 get_zwxy() { }

	// RVA: 0x2952E70 Offset: 0x2951870 VA: 0x182952E70
	public void set_zwxy(half4 value) { }

	// RVA: 0x2952120 Offset: 0x2950B20 VA: 0x182952120
	public half4 get_zwxz() { }

	// RVA: 0x2952090 Offset: 0x2950A90 VA: 0x182952090
	public half4 get_zwxw() { }

	// RVA: 0x29521A0 Offset: 0x2950BA0 VA: 0x1829521A0
	public half4 get_zwyx() { }

	// RVA: 0x2952EC0 Offset: 0x29518C0 VA: 0x182952EC0
	public void set_zwyx(half4 value) { }

	// RVA: 0x29521D0 Offset: 0x2950BD0 VA: 0x1829521D0
	public half4 get_zwyy() { }

	// RVA: 0x2952200 Offset: 0x2950C00 VA: 0x182952200
	public half4 get_zwyz() { }

	// RVA: 0x2952170 Offset: 0x2950B70 VA: 0x182952170
	public half4 get_zwyw() { }

	// RVA: 0x2952280 Offset: 0x2950C80 VA: 0x182952280
	public half4 get_zwzx() { }

	// RVA: 0x29522B0 Offset: 0x2950CB0 VA: 0x1829522B0
	public half4 get_zwzy() { }

	// RVA: 0x29522E0 Offset: 0x2950CE0 VA: 0x1829522E0
	public half4 get_zwzz() { }

	// RVA: 0x2952250 Offset: 0x2950C50 VA: 0x182952250
	public half4 get_zwzw() { }

	// RVA: 0x2951FE0 Offset: 0x29509E0 VA: 0x182951FE0
	public half4 get_zwwx() { }

	// RVA: 0x2952010 Offset: 0x2950A10 VA: 0x182952010
	public half4 get_zwwy() { }

	// RVA: 0x2952040 Offset: 0x2950A40 VA: 0x182952040
	public half4 get_zwwz() { }

	// RVA: 0x2951FB0 Offset: 0x29509B0 VA: 0x182951FB0
	public half4 get_zwww() { }

	// RVA: 0x2950600 Offset: 0x294F000 VA: 0x182950600
	public half4 get_wxxx() { }

	// RVA: 0x2950630 Offset: 0x294F030 VA: 0x182950630
	public half4 get_wxxy() { }

	// RVA: 0x2950660 Offset: 0x294F060 VA: 0x182950660
	public half4 get_wxxz() { }

	// RVA: 0x29505D0 Offset: 0x294EFD0 VA: 0x1829505D0
	public half4 get_wxxw() { }

	// RVA: 0x29506E0 Offset: 0x294F0E0 VA: 0x1829506E0
	public half4 get_wxyx() { }

	// RVA: 0x2950710 Offset: 0x294F110 VA: 0x182950710
	public half4 get_wxyy() { }

	// RVA: 0x2950740 Offset: 0x294F140 VA: 0x182950740
	public half4 get_wxyz() { }

	// RVA: 0x2952930 Offset: 0x2951330 VA: 0x182952930
	public void set_wxyz(half4 value) { }

	// RVA: 0x29506B0 Offset: 0x294F0B0 VA: 0x1829506B0
	public half4 get_wxyw() { }

	// RVA: 0x29507C0 Offset: 0x294F1C0 VA: 0x1829507C0
	public half4 get_wxzx() { }

	// RVA: 0x29507F0 Offset: 0x294F1F0 VA: 0x1829507F0
	public half4 get_wxzy() { }

	// RVA: 0x2952980 Offset: 0x2951380 VA: 0x182952980
	public void set_wxzy(half4 value) { }

	// RVA: 0x2950820 Offset: 0x294F220 VA: 0x182950820
	public half4 get_wxzz() { }

	// RVA: 0x2950790 Offset: 0x294F190 VA: 0x182950790
	public half4 get_wxzw() { }

	// RVA: 0x2950520 Offset: 0x294EF20 VA: 0x182950520
	public half4 get_wxwx() { }

	// RVA: 0x2950550 Offset: 0x294EF50 VA: 0x182950550
	public half4 get_wxwy() { }

	// RVA: 0x2950580 Offset: 0x294EF80 VA: 0x182950580
	public half4 get_wxwz() { }

	// RVA: 0x29504F0 Offset: 0x294EEF0 VA: 0x1829504F0
	public half4 get_wxww() { }

	// RVA: 0x29509A0 Offset: 0x294F3A0 VA: 0x1829509A0
	public half4 get_wyxx() { }

	// RVA: 0x29509D0 Offset: 0x294F3D0 VA: 0x1829509D0
	public half4 get_wyxy() { }

	// RVA: 0x2950A00 Offset: 0x294F400 VA: 0x182950A00
	public half4 get_wyxz() { }

	// RVA: 0x29529E0 Offset: 0x29513E0 VA: 0x1829529E0
	public void set_wyxz(half4 value) { }

	// RVA: 0x2950970 Offset: 0x294F370 VA: 0x182950970
	public half4 get_wyxw() { }

	// RVA: 0x2950A80 Offset: 0x294F480 VA: 0x182950A80
	public half4 get_wyyx() { }

	// RVA: 0x2950AB0 Offset: 0x294F4B0 VA: 0x182950AB0
	public half4 get_wyyy() { }

	// RVA: 0x2950AE0 Offset: 0x294F4E0 VA: 0x182950AE0
	public half4 get_wyyz() { }

	// RVA: 0x2950A50 Offset: 0x294F450 VA: 0x182950A50
	public half4 get_wyyw() { }

	// RVA: 0x2950B60 Offset: 0x294F560 VA: 0x182950B60
	public half4 get_wyzx() { }

	// RVA: 0x2952A30 Offset: 0x2951430 VA: 0x182952A30
	public void set_wyzx(half4 value) { }

	// RVA: 0x2950B90 Offset: 0x294F590 VA: 0x182950B90
	public half4 get_wyzy() { }

	// RVA: 0x2950BC0 Offset: 0x294F5C0 VA: 0x182950BC0
	public half4 get_wyzz() { }

	// RVA: 0x2950B30 Offset: 0x294F530 VA: 0x182950B30
	public half4 get_wyzw() { }

	// RVA: 0x29508C0 Offset: 0x294F2C0 VA: 0x1829508C0
	public half4 get_wywx() { }

	// RVA: 0x29508F0 Offset: 0x294F2F0 VA: 0x1829508F0
	public half4 get_wywy() { }

	// RVA: 0x2950920 Offset: 0x294F320 VA: 0x182950920
	public half4 get_wywz() { }

	// RVA: 0x2950890 Offset: 0x294F290 VA: 0x182950890
	public half4 get_wyww() { }

	// RVA: 0x2950D40 Offset: 0x294F740 VA: 0x182950D40
	public half4 get_wzxx() { }

	// RVA: 0x2950D70 Offset: 0x294F770 VA: 0x182950D70
	public half4 get_wzxy() { }

	// RVA: 0x2952A90 Offset: 0x2951490 VA: 0x182952A90
	public void set_wzxy(half4 value) { }

	// RVA: 0x2950DA0 Offset: 0x294F7A0 VA: 0x182950DA0
	public half4 get_wzxz() { }

	// RVA: 0x2950D10 Offset: 0x294F710 VA: 0x182950D10
	public half4 get_wzxw() { }

	// RVA: 0x2950E20 Offset: 0x294F820 VA: 0x182950E20
	public half4 get_wzyx() { }

	// RVA: 0x2952AE0 Offset: 0x29514E0 VA: 0x182952AE0
	public void set_wzyx(half4 value) { }

	// RVA: 0x2950E50 Offset: 0x294F850 VA: 0x182950E50
	public half4 get_wzyy() { }

	// RVA: 0x2950E80 Offset: 0x294F880 VA: 0x182950E80
	public half4 get_wzyz() { }

	// RVA: 0x2950DF0 Offset: 0x294F7F0 VA: 0x182950DF0
	public half4 get_wzyw() { }

	// RVA: 0x2950F00 Offset: 0x294F900 VA: 0x182950F00
	public half4 get_wzzx() { }

	// RVA: 0x2950F30 Offset: 0x294F930 VA: 0x182950F30
	public half4 get_wzzy() { }

	// RVA: 0x2950F60 Offset: 0x294F960 VA: 0x182950F60
	public half4 get_wzzz() { }

	// RVA: 0x2950ED0 Offset: 0x294F8D0 VA: 0x182950ED0
	public half4 get_wzzw() { }

	// RVA: 0x2950C60 Offset: 0x294F660 VA: 0x182950C60
	public half4 get_wzwx() { }

	// RVA: 0x2950C90 Offset: 0x294F690 VA: 0x182950C90
	public half4 get_wzwy() { }

	// RVA: 0x2950CC0 Offset: 0x294F6C0 VA: 0x182950CC0
	public half4 get_wzwz() { }

	// RVA: 0x2950C30 Offset: 0x294F630 VA: 0x182950C30
	public half4 get_wzww() { }

	// RVA: 0x2950260 Offset: 0x294EC60 VA: 0x182950260
	public half4 get_wwxx() { }

	// RVA: 0x2950290 Offset: 0x294EC90 VA: 0x182950290
	public half4 get_wwxy() { }

	// RVA: 0x29502C0 Offset: 0x294ECC0 VA: 0x1829502C0
	public half4 get_wwxz() { }

	// RVA: 0x2950230 Offset: 0x294EC30 VA: 0x182950230
	public half4 get_wwxw() { }

	// RVA: 0x2950340 Offset: 0x294ED40 VA: 0x182950340
	public half4 get_wwyx() { }

	// RVA: 0x2950370 Offset: 0x294ED70 VA: 0x182950370
	public half4 get_wwyy() { }

	// RVA: 0x29503A0 Offset: 0x294EDA0 VA: 0x1829503A0
	public half4 get_wwyz() { }

	// RVA: 0x2950310 Offset: 0x294ED10 VA: 0x182950310
	public half4 get_wwyw() { }

	// RVA: 0x2950420 Offset: 0x294EE20 VA: 0x182950420
	public half4 get_wwzx() { }

	// RVA: 0x2950450 Offset: 0x294EE50 VA: 0x182950450
	public half4 get_wwzy() { }

	// RVA: 0x2950480 Offset: 0x294EE80 VA: 0x182950480
	public half4 get_wwzz() { }

	// RVA: 0x29503F0 Offset: 0x294EDF0 VA: 0x1829503F0
	public half4 get_wwzw() { }

	// RVA: 0x2950180 Offset: 0x294EB80 VA: 0x182950180
	public half4 get_wwwx() { }

	// RVA: 0x29501B0 Offset: 0x294EBB0 VA: 0x1829501B0
	public half4 get_wwwy() { }

	// RVA: 0x29501E0 Offset: 0x294EBE0 VA: 0x1829501E0
	public half4 get_wwwz() { }

	// RVA: 0x2950160 Offset: 0x294EB60 VA: 0x182950160
	public half4 get_wwww() { }

	// RVA: 0x294DEC0 Offset: 0x294C8C0 VA: 0x18294DEC0
	public half3 get_xxx() { }

	// RVA: 0x294DF30 Offset: 0x294C930 VA: 0x18294DF30
	public half3 get_xxy() { }

	// RVA: 0x294E870 Offset: 0x294D270 VA: 0x18294E870
	public half3 get_xxz() { }

	// RVA: 0x2951330 Offset: 0x294FD30 VA: 0x182951330
	public half3 get_xxw() { }

	// RVA: 0x294DFD0 Offset: 0x294C9D0 VA: 0x18294DFD0
	public half3 get_xyx() { }

	// RVA: 0x294E050 Offset: 0x294CA50 VA: 0x18294E050
	public half3 get_xyy() { }

	// RVA: 0x294E980 Offset: 0x294D380 VA: 0x18294E980
	public half3 get_xyz() { }

	// RVA: 0x294E790 Offset: 0x294D190 VA: 0x18294E790
	public void set_xyz(half3 value) { }

	// RVA: 0x29514A0 Offset: 0x294FEA0 VA: 0x1829514A0
	public half3 get_xyw() { }

	// RVA: 0x2952BC0 Offset: 0x29515C0 VA: 0x182952BC0
	public void set_xyw(half3 value) { }

	// RVA: 0x294EA50 Offset: 0x294D450 VA: 0x18294EA50
	public half3 get_xzx() { }

	// RVA: 0x294EB00 Offset: 0x294D500 VA: 0x18294EB00
	public half3 get_xzy() { }

	// RVA: 0x294F860 Offset: 0x294E260 VA: 0x18294F860
	public void set_xzy(half3 value) { }

	// RVA: 0x294EBB0 Offset: 0x294D5B0 VA: 0x18294EBB0
	public half3 get_xzz() { }

	// RVA: 0x2951610 Offset: 0x2950010 VA: 0x182951610
	public half3 get_xzw() { }

	// RVA: 0x2952C10 Offset: 0x2951610 VA: 0x182952C10
	public void set_xzw(half3 value) { }

	// RVA: 0x2951090 Offset: 0x294FA90 VA: 0x182951090
	public half3 get_xwx() { }

	// RVA: 0x2951170 Offset: 0x294FB70 VA: 0x182951170
	public half3 get_xwy() { }

	// RVA: 0x2952B20 Offset: 0x2951520 VA: 0x182952B20
	public void set_xwy(half3 value) { }

	// RVA: 0x2951250 Offset: 0x294FC50 VA: 0x182951250
	public half3 get_xwz() { }

	// RVA: 0x2952B70 Offset: 0x2951570 VA: 0x182952B70
	public void set_xwz(half3 value) { }

	// RVA: 0x2950FB0 Offset: 0x294F9B0 VA: 0x182950FB0
	public half3 get_xww() { }

	// RVA: 0x294E0F0 Offset: 0x294CAF0 VA: 0x18294E0F0
	public half3 get_yxx() { }

	// RVA: 0x294E170 Offset: 0x294CB70 VA: 0x18294E170
	public half3 get_yxy() { }

	// RVA: 0x294ECC0 Offset: 0x294D6C0 VA: 0x18294ECC0
	public half3 get_yxz() { }

	// RVA: 0x294F880 Offset: 0x294E280 VA: 0x18294F880
	public void set_yxz(half3 value) { }

	// RVA: 0x2951B20 Offset: 0x2950520 VA: 0x182951B20
	public half3 get_yxw() { }

	// RVA: 0x2952D40 Offset: 0x2951740 VA: 0x182952D40
	public void set_yxw(half3 value) { }

	// RVA: 0x294E210 Offset: 0x294CC10 VA: 0x18294E210
	public half3 get_yyx() { }

	// RVA: 0x294E290 Offset: 0x294CC90 VA: 0x18294E290
	public half3 get_yyy() { }

	// RVA: 0x294EDD0 Offset: 0x294D7D0 VA: 0x18294EDD0
	public half3 get_yyz() { }

	// RVA: 0x2951C90 Offset: 0x2950690 VA: 0x182951C90
	public half3 get_yyw() { }

	// RVA: 0x294EEA0 Offset: 0x294D8A0 VA: 0x18294EEA0
	public half3 get_yzx() { }

	// RVA: 0x294F8B0 Offset: 0x294E2B0 VA: 0x18294F8B0
	public void set_yzx(half3 value) { }

	// RVA: 0x294EF50 Offset: 0x294D950 VA: 0x18294EF50
	public half3 get_yzy() { }

	// RVA: 0x294F000 Offset: 0x294DA00 VA: 0x18294F000
	public half3 get_yzz() { }

	// RVA: 0x2951E00 Offset: 0x2950800 VA: 0x182951E00
	public half3 get_yzw() { }

	// RVA: 0x2952DC0 Offset: 0x29517C0 VA: 0x182952DC0
	public void set_yzw(half3 value) { }

	// RVA: 0x2951880 Offset: 0x2950280 VA: 0x182951880
	public half3 get_ywx() { }

	// RVA: 0x2952CA0 Offset: 0x29516A0 VA: 0x182952CA0
	public void set_ywx(half3 value) { }

	// RVA: 0x2951960 Offset: 0x2950360 VA: 0x182951960
	public half3 get_ywy() { }

	// RVA: 0x2951A40 Offset: 0x2950440 VA: 0x182951A40
	public half3 get_ywz() { }

	// RVA: 0x2952CF0 Offset: 0x29516F0 VA: 0x182952CF0
	public void set_ywz(half3 value) { }

	// RVA: 0x29517A0 Offset: 0x29501A0 VA: 0x1829517A0
	public half3 get_yww() { }

	// RVA: 0x294F0D0 Offset: 0x294DAD0 VA: 0x18294F0D0
	public half3 get_zxx() { }

	// RVA: 0x294F180 Offset: 0x294DB80 VA: 0x18294F180
	public half3 get_zxy() { }

	// RVA: 0x294F8E0 Offset: 0x294E2E0 VA: 0x18294F8E0
	public void set_zxy(half3 value) { }

	// RVA: 0x294F230 Offset: 0x294DC30 VA: 0x18294F230
	public half3 get_zxz() { }

	// RVA: 0x2952310 Offset: 0x2950D10 VA: 0x182952310
	public half3 get_zxw() { }

	// RVA: 0x2952EF0 Offset: 0x29518F0 VA: 0x182952EF0
	public void set_zxw(half3 value) { }

	// RVA: 0x294F300 Offset: 0x294DD00 VA: 0x18294F300
	public half3 get_zyx() { }

	// RVA: 0x294F910 Offset: 0x294E310 VA: 0x18294F910
	public void set_zyx(half3 value) { }

	// RVA: 0x294F3B0 Offset: 0x294DDB0 VA: 0x18294F3B0
	public half3 get_zyy() { }

	// RVA: 0x294F460 Offset: 0x294DE60 VA: 0x18294F460
	public half3 get_zyz() { }

	// RVA: 0x2952480 Offset: 0x2950E80 VA: 0x182952480
	public half3 get_zyw() { }

	// RVA: 0x2952F70 Offset: 0x2951970 VA: 0x182952F70
	public void set_zyw(half3 value) { }

	// RVA: 0x294F530 Offset: 0x294DF30 VA: 0x18294F530
	public half3 get_zzx() { }

	// RVA: 0x294F5E0 Offset: 0x294DFE0 VA: 0x18294F5E0
	public half3 get_zzy() { }

	// RVA: 0x294F690 Offset: 0x294E090 VA: 0x18294F690
	public half3 get_zzz() { }

	// RVA: 0x29525F0 Offset: 0x2950FF0 VA: 0x1829525F0
	public half3 get_zzw() { }

	// RVA: 0x2952070 Offset: 0x2950A70 VA: 0x182952070
	public half3 get_zwx() { }

	// RVA: 0x2952E50 Offset: 0x2951850 VA: 0x182952E50
	public void set_zwx(half3 value) { }

	// RVA: 0x2952150 Offset: 0x2950B50 VA: 0x182952150
	public half3 get_zwy() { }

	// RVA: 0x2952EA0 Offset: 0x29518A0 VA: 0x182952EA0
	public void set_zwy(half3 value) { }

	// RVA: 0x2952230 Offset: 0x2950C30 VA: 0x182952230
	public half3 get_zwz() { }

	// RVA: 0x2951F90 Offset: 0x2950990 VA: 0x182951F90
	public half3 get_zww() { }

	// RVA: 0x29505B0 Offset: 0x294EFB0 VA: 0x1829505B0
	public half3 get_wxx() { }

	// RVA: 0x2950690 Offset: 0x294F090 VA: 0x182950690
	public half3 get_wxy() { }

	// RVA: 0x2952910 Offset: 0x2951310 VA: 0x182952910
	public void set_wxy(half3 value) { }

	// RVA: 0x2950770 Offset: 0x294F170 VA: 0x182950770
	public half3 get_wxz() { }

	// RVA: 0x2952960 Offset: 0x2951360 VA: 0x182952960
	public void set_wxz(half3 value) { }

	// RVA: 0x29504D0 Offset: 0x294EED0 VA: 0x1829504D0
	public half3 get_wxw() { }

	// RVA: 0x2950950 Offset: 0x294F350 VA: 0x182950950
	public half3 get_wyx() { }

	// RVA: 0x29529C0 Offset: 0x29513C0 VA: 0x1829529C0
	public void set_wyx(half3 value) { }

	// RVA: 0x2950A30 Offset: 0x294F430 VA: 0x182950A30
	public half3 get_wyy() { }

	// RVA: 0x2950B10 Offset: 0x294F510 VA: 0x182950B10
	public half3 get_wyz() { }

	// RVA: 0x2952A10 Offset: 0x2951410 VA: 0x182952A10
	public void set_wyz(half3 value) { }

	// RVA: 0x2950870 Offset: 0x294F270 VA: 0x182950870
	public half3 get_wyw() { }

	// RVA: 0x2950CF0 Offset: 0x294F6F0 VA: 0x182950CF0
	public half3 get_wzx() { }

	// RVA: 0x2952A70 Offset: 0x2951470 VA: 0x182952A70
	public void set_wzx(half3 value) { }

	// RVA: 0x2950DD0 Offset: 0x294F7D0 VA: 0x182950DD0
	public half3 get_wzy() { }

	// RVA: 0x2952AC0 Offset: 0x29514C0 VA: 0x182952AC0
	public void set_wzy(half3 value) { }

	// RVA: 0x2950EB0 Offset: 0x294F8B0 VA: 0x182950EB0
	public half3 get_wzz() { }

	// RVA: 0x2950C10 Offset: 0x294F610 VA: 0x182950C10
	public half3 get_wzw() { }

	// RVA: 0x2950210 Offset: 0x294EC10 VA: 0x182950210
	public half3 get_wwx() { }

	// RVA: 0x29502F0 Offset: 0x294ECF0 VA: 0x1829502F0
	public half3 get_wwy() { }

	// RVA: 0x29503D0 Offset: 0x294EDD0 VA: 0x1829503D0
	public half3 get_wwz() { }

	// RVA: 0x2950140 Offset: 0x294EB40 VA: 0x182950140
	public half3 get_www() { }

	// RVA: 0x294DEA0 Offset: 0x294C8A0 VA: 0x18294DEA0
	public half2 get_xx() { }

	// RVA: 0x294DFB0 Offset: 0x294C9B0 VA: 0x18294DFB0
	public half2 get_xy() { }

	// RVA: 0x294DE40 Offset: 0x294C840 VA: 0x18294DE40
	public void set_xy(half2 value) { }

	// RVA: 0x294EA30 Offset: 0x294D430 VA: 0x18294EA30
	public half2 get_xz() { }

	// RVA: 0x294F850 Offset: 0x294E250 VA: 0x18294F850
	public void set_xz(half2 value) { }

	// RVA: 0x2950F90 Offset: 0x294F990 VA: 0x182950F90
	public half2 get_xw() { }

	// RVA: 0x2952B10 Offset: 0x2951510 VA: 0x182952B10
	public void set_xw(half2 value) { }

	// RVA: 0x294E0D0 Offset: 0x294CAD0 VA: 0x18294E0D0
	public half2 get_yx() { }

	// RVA: 0x294E3C0 Offset: 0x294CDC0 VA: 0x18294E3C0
	public void set_yx(half2 value) { }

	// RVA: 0x294E1F0 Offset: 0x294CBF0 VA: 0x18294E1F0
	public half2 get_yy() { }

	// RVA: 0x294EE80 Offset: 0x294D880 VA: 0x18294EE80
	public half2 get_yz() { }

	// RVA: 0x294F8A0 Offset: 0x294E2A0 VA: 0x18294F8A0
	public void set_yz(half2 value) { }

	// RVA: 0x2951780 Offset: 0x2950180 VA: 0x182951780
	public half2 get_yw() { }

	// RVA: 0x2952C90 Offset: 0x2951690 VA: 0x182952C90
	public void set_yw(half2 value) { }

	// RVA: 0x294F0B0 Offset: 0x294DAB0 VA: 0x18294F0B0
	public half2 get_zx() { }

	// RVA: 0x294F8D0 Offset: 0x294E2D0 VA: 0x18294F8D0
	public void set_zx(half2 value) { }

	// RVA: 0x294F2E0 Offset: 0x294DCE0 VA: 0x18294F2E0
	public half2 get_zy() { }

	// RVA: 0x294F900 Offset: 0x294E300 VA: 0x18294F900
	public void set_zy(half2 value) { }

	// RVA: 0x294F510 Offset: 0x294DF10 VA: 0x18294F510
	public half2 get_zz() { }

	// RVA: 0x2951F70 Offset: 0x2950970 VA: 0x182951F70
	public half2 get_zw() { }

	// RVA: 0x2952E40 Offset: 0x2951840 VA: 0x182952E40
	public void set_zw(half2 value) { }

	// RVA: 0x29504B0 Offset: 0x294EEB0 VA: 0x1829504B0
	public half2 get_wx() { }

	// RVA: 0x2952900 Offset: 0x2951300 VA: 0x182952900
	public void set_wx(half2 value) { }

	// RVA: 0x2950850 Offset: 0x294F250 VA: 0x182950850
	public half2 get_wy() { }

	// RVA: 0x29529B0 Offset: 0x29513B0 VA: 0x1829529B0
	public void set_wy(half2 value) { }

	// RVA: 0x2950BF0 Offset: 0x294F5F0 VA: 0x182950BF0
	public half2 get_wz() { }

	// RVA: 0x2952A60 Offset: 0x2951460 VA: 0x182952A60
	public void set_wz(half2 value) { }

	// RVA: 0x2950120 Offset: 0x294EB20 VA: 0x182950120
	public half2 get_ww() { }

	// RVA: 0xF6CD10 Offset: 0xF6B710 VA: 0x180F6CD10
	public half get_Item(int index) { }

	// RVA: 0xF730D0 Offset: 0xF71AD0 VA: 0x180F730D0
	public void set_Item(int index, half value) { }

	// RVA: 0x294F930 Offset: 0x294E330 VA: 0x18294F930 Slot: 4
	public bool Equals(half4 rhs) { }

	// RVA: 0x294F960 Offset: 0x294E360 VA: 0x18294F960 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x294FA10 Offset: 0x294E410 VA: 0x18294FA10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x294FA60 Offset: 0x294E460 VA: 0x18294FA60 Slot: 3
	public override string ToString() { }

	// RVA: 0x294FC70 Offset: 0x294E670 VA: 0x18294FC70 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
