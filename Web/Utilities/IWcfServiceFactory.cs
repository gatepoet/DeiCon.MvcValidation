namespace MvcValidation.Web.Utilities
{
    public interface IWcfServiceFactory
    {
        T Load<T>();
        void Clear();
    }
}