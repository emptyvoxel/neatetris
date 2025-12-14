namespace Tetris;

public static class Tetrominoes
{
    public static readonly ushort[] O = { 0b0110_0110_0000_0000 };
    public static readonly ushort[] I = { 0b0000_1111_0000_0000, 0b0010_0010_0010_0010, 0b0000_0000_1111_0000, 0b0100_0100_0100_0100 };
    public static readonly ushort[] J = { 0b100_111_000_0000000, 0b011_010_010_0000000, 0b000_111_001_0000000, 0b010_010_110_0000000 };
    public static readonly ushort[] L = { 0b001_111_000_0000000, 0b010_010_011_0000000, 0b000_111_100_0000000, 0b110_010_010_0000000 };
    public static readonly ushort[] S = { 0b011_110_000_0000000, 0b010_011_001_0000000, 0b000_011_110_0000000, 0b100_110_010_0000000 };
    public static readonly ushort[] Z = { 0b110_011_000_0000000, 0b001_011_010_0000000, 0b000_110_011_0000000, 0b010_110_100_0000000 };
    public static readonly ushort[] T = { 0b010_111_000_0000000, 0b010_011_010_0000000, 0b000_111_010_0000000, 0b010_110_010_0000000 };
}

// Rotations follow the Super Rotation System: https://tetris.wiki/Super_Rotation_System
