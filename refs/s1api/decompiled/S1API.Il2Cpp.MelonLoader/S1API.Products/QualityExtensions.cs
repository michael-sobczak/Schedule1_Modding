using Il2CppScheduleOne.ItemFramework;

namespace S1API.Products;

internal static class QualityExtensions
{
	internal static Quality ToAPI(this EQuality quality)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		if (1 == 0)
		{
		}
		Quality result = (int)quality switch
		{
			0 => Quality.Trash, 
			1 => Quality.Poor, 
			2 => Quality.Standard, 
			3 => Quality.Premium, 
			4 => Quality.Heavenly, 
			_ => Quality.Trash, 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	internal static EQuality ToInternal(this Quality quality)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (1 == 0)
		{
		}
		EQuality result = (EQuality)(quality switch
		{
			Quality.Trash => 0, 
			Quality.Poor => 1, 
			Quality.Standard => 2, 
			Quality.Premium => 3, 
			Quality.Heavenly => 4, 
			_ => 0, 
		});
		if (1 == 0)
		{
		}
		return result;
	}
}
