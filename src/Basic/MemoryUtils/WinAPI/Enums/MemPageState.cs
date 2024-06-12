namespace AslHelp.MemUtils;

[Flags]
public enum MemPageState : uint
{
    MEM_COMMIT = 0x00001000,
    MEM_RESERVE = 0x00002000,
    MEM_DECOMMIT = 0x00004000,
    MEM_RELEASE = 0x00008000,
    MEM_RESET = 0x00080000,
    MEM_TOP_DOWN = 0x00100000,
    MEM_WRITE_WATCH = 0x00200000,
    MEM_PHYSICAL = 0x00400000,
    MEM_RESET_UNDO = 0x01000000,
    MEM_LARGE_PAGES = 0x20000000
}