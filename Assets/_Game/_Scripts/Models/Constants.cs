using System.Collections.Generic;

public class Constants {
    public const string JoinKey = "j";
    public const string DifficultyKey = "d";
    public const string GameTypeKey = "t";

    public static readonly List<string> GameTypes = new() { "Simple Driwing", "Only Car", "Racing" };
    public static readonly List<string> Difficulties = new() { "Easy", "Medium", "Hard" };
}