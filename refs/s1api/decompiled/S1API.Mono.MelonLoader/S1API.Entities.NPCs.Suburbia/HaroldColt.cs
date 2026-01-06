using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class HaroldColt : NPC
{
	public new static string NPCId => "harold_colt";

	internal HaroldColt()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "harold_colt"))
	{
	}
}
