using System.ComponentModel;

namespace Login
{
    enum StageOfLife
    {
        Volwassen, // = 460,
        Groeiende, // = 1,
        Drachtig, //= 2,
        Lacterend //= 607
    }

    enum Puzzles
    {
        [Description("Geen puzzel")]
        Geen,
        Balpuzzel
    }
}