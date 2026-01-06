using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class PhilipWentworth : NPC
{
	public new static string NPCId => "philip_wentworth";

	internal PhilipWentworth()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "philip_wentworth"))
	{
	}
}
