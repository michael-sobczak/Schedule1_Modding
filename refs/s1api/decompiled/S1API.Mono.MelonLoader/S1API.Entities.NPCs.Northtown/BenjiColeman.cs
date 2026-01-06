using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class BenjiColeman : NPC
{
	public new static string NPCId => "benji_coleman";

	internal BenjiColeman()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "benji_coleman"))
	{
	}
}
