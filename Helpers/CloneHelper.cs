namespace BizClient.Helpers;

public static class CloneHelper
{
    public static T Clone<T>(T obj)
    {
        var serilaized = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(serilaized);
    }
}
