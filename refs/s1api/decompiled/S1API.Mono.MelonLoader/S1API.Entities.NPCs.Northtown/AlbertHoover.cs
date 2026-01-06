using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class AlbertHoover : NPC
{
	public new static string NPCId => "albert_hoover";

	internal AlbertHoover()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "albert_hoover"))
	{
	}
}
