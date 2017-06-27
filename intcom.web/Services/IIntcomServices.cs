namespace intcom.web.Services
{
    public interface IIntcomServices
    {
        void download(string key, string destination);
        object getAll();
        void upload(string[] files);
    }
}