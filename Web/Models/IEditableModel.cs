namespace MvcValidation.Web.Models
{
    public interface IEditableModel
    {
        object GetViewModel(string id);
    }
}