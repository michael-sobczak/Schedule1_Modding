using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class JessiWaters : NPC
{
	public new static string NPCId => "jessi_waters";

	internal JessiWaters()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "jessi_waters"))
	{
	}
}
