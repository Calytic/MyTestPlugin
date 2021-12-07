namespace uMod.Plugins
{
    [Info("My Test Plugin", "uMod", "1.0.14")]
    [Description("Test Plugin")]
    public class MyTestPlugin : Plugin
    {
        void Load()
        {
            Logger.Info("My Test Plugin loaded!");
        }
    }
}
