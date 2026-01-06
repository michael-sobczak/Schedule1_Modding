using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class BradCrosby : NPC
{
	public new static string NPCId => "brad_crosby";

	internal BradCrosby()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "brad_crosby"))
	{
	}
}
