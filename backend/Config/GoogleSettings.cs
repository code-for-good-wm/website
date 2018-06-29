namespace CodeForGood.Config
{
    public interface IGoogleSettings
    {
        string TagManagerContainerID { get; }
    }

    public class GoogleSettings : IGoogleSettings
    {
        public string TagManagerContainerID { get; set; }
    }

}
