using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class AlbertHoover : NPC
{
	public new static string NPCId => "albert_hoover";

	internal AlbertHoover()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "albert_hoover"))
	{
	}
}
