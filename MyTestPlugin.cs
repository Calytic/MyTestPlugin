namespace uMod.Plugins
{
    [Info("My Test Plugin", "uMod", "1.0.0")]
    [Description("Test Plugin")]
    public class MyPlugin : Plugin
    {
        void Load()
        {
            Logger.Info("My Test Plugin loaded!");
        }
    }
}
