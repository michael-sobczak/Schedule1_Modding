using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class PeterFile : NPC
{
	public new static string NPCId => "peter_file";

	internal PeterFile()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "peter_file"))
	{
	}
}
