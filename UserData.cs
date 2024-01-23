using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace BingusLines;

public class UserData
{
    public List<string> BingoGoals = new();
    public List<string> BingoActions = new();
    public Dictionary<string, List<string>> BingoDeps;

    public string GoalsFilePath = "Data/Goals.json";
    public string ActionsFilePath = "Data/Actions.json";
    public string DepsFilePath = "Data/Dependencies.json";

    // Man I love linq
    // public void MigrateFromCSource()
    // {
    //     BingoGoals = Enum.GetValues(typeof(BingoGoal)).Cast<BingoGoal>().Select(x => x.ToString()).ToList();
    //     BingoActions = Enum.GetValues(typeof(BingoAction)).Cast<BingoAction>().Select(x => x.ToString()).ToList();
    //     BingoDeps = SynergyApp.Data.ToDictionary(x => x.Goal.ToString(), x => x.Actions.Select(a => a.ToString()).ToList());
    //     
    //     WriteFilesToDisk();
    // }

    public void WriteFilesToDisk()
    {
        if (!Directory.Exists("Data"))
        {
            Directory.CreateDirectory("Data");
        }
        
        var serdeSettings = new JsonSerializerOptions() { WriteIndented = true };
        File.WriteAllText(GoalsFilePath, JsonSerializer.Serialize(BingoGoals, serdeSettings));
        File.WriteAllText(ActionsFilePath, JsonSerializer.Serialize(BingoActions, serdeSettings));
        File.WriteAllText(DepsFilePath, JsonSerializer.Serialize(BingoDeps, serdeSettings));
    }

    public void ReadFilesFromDisk()
    {
        var goalsTxt = File.ReadAllText(GoalsFilePath);
        BingoGoals = JsonSerializer.Deserialize<List<string>>(goalsTxt);
        
        var actionsTxt = File.ReadAllText(ActionsFilePath);
        BingoActions = JsonSerializer.Deserialize<List<string>>(actionsTxt);

        var depsTxt = File.ReadAllText(DepsFilePath);
        BingoDeps = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(depsTxt);
    }

    private bool ValidateDepsFile()
    {
        throw new NotImplementedException();
    }
}