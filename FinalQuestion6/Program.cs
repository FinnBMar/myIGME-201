using System;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

public class PlayerSettings
{
    public string PlayerName { get; set; }
    public int Level { get; set; }
    public int Hp { get; set; }
    public string[] Inventory { get; set; }
    public string LicenseKey { get; set; }

    private static PlayerSettings instance;

    private PlayerSettings() { }

    public static PlayerSettings Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new PlayerSettings();
            }
            return instance;
        }
    }

    public void LoadSettings(string filePath)
    {
        try
        {
            string json = File.ReadAllText(filePath);
            instance = JsonConvert.DeserializeObject<PlayerSettings>(json);
            Console.WriteLine("Settings loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading settings: {ex.Message}");
        }
    }

    public void SaveSettings(string filePath)
    {
        try
        {
            string json = JsonConvert.SerializeObject(instance, Formatting.Indented);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Settings saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving settings: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        string filePath = "playerSettings.json";

        // Example of using the singleton to load and save settings
        PlayerSettings playerSettings = PlayerSettings.Instance;
        playerSettings.LoadSettings(filePath);

        // Modify settings
        playerSettings.PlayerName = "new_player";
        playerSettings.Level = 5;
        playerSettings.Hp = 100;

        // Add an item to inventory
        Array.Resize(ref playerSettings.Inventory, playerSettings.Inventory.Length + 1);
        playerSettings.Inventory[playerSettings.Inventory.Length - 1] = "new_item";

        playerSettings.SaveSettings(filePath);
    }
}
