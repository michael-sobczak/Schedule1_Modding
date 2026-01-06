using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class MacCooper : NPC
{
	public new static string NPCId => "mac_cooper";

	internal MacCooper()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "mac_cooper"))
	{
	}
}
