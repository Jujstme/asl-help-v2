using AslHelp.Memory.Native.Enums;
using AslHelp.Memory.Native.Structs;

namespace AslHelp.Memory;

public readonly record struct MemoryPage
{
    public MemoryPage(nuint @base, uint regionSize, MemProtect protect, MemState state, MemType type)
    {
        Base = @base;
        RegionSize = regionSize;
        Protect = protect;
        State = state;
        Type = type;
    }

    internal unsafe MemoryPage(MEMORY_BASIC_INFORMATION mbi)
    {
        Base = (nuint)mbi.BaseAddress;
        RegionSize = (uint)mbi.RegionSize;
        Protect = mbi.Protect;
        State = mbi.State;
        Type = mbi.Type;
    }

    public nuint Base { get; }
    public uint RegionSize { get; }

    public MemProtect Protect { get; }
    public MemState State { get; }
    public MemType Type { get; }

    public override string ToString()
    {
        return
            $"{nameof(MemoryPage)} {{ {nameof(Base)} = 0x{(ulong)Base:X}, {nameof(RegionSize)} = 0x{RegionSize:X} }}";
    }
}
