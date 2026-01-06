using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class TobiasWentworth : NPC
{
	public new static string NPCId => "tobias_wentworth";

	internal TobiasWentworth()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "tobias_wentworth"))
	{
	}
}
