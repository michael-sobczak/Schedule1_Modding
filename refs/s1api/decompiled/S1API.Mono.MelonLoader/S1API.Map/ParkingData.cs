using S1API.Vehicles;
using ScheduleOne.Vehicles;

namespace S1API.Map;

public class ParkingData(string _lotId, int _index, ParkingAlignment _align)
{
	public string LotId => _lotId;

	public int Index => _index;

	public ParkingAlignment Alignment => _align;

	internal ParkingData(ParkData data)
		: this(data.lotGUID.ToString(), data.spotIndex, (ParkingAlignment)data.alignment)
	{
	}//IL_0019: Unknown result type (might be due to invalid IL or missing references)
	//IL_0023: Expected I4, but got Unknown

}
