

namespace Celeste.Mod.FemtoHelper;

public class FemtoHelperSession : EverestModuleSession
{
    public bool HasRotateDash { get; set; } = false;
    public float RotateDashAngle { get; set; } = 0;
    public float RotateDashScalar { get; set; } = 1;
    public bool HasStartedRotateDashing { get; set; } = false;
    public Color[] RotateDashColors { get; set; } = [Calc.HexToColor("7958ad"), Calc.HexToColor("cbace6"), Calc.HexToColor("634691")];
    /*
    public Dictionary<string, object> CustomWipeData;

    public T GetWipeData<T>(string key, T defaultValue)
    {
        if (CustomWipeData.TryGetValue(key, out object value) && value is T)
        {
            return (T)value;
        }
        return defaultValue;
    }
    */

}