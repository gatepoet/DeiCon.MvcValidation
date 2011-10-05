using System.Web.Mvc;
using MvcValidation.Web.Models;
using MvcValidation.Web.Utilities;
using Microsoft.Practices.ServiceLocation;

namespace MvcValidation.Web.Controllers
{
    public class ItemController : Controller, IExtendedAttributeController
    {
        public new ViewResult View()
        {
// ReSharper disable Asp.NotResolved
            return base.View();
// ReSharper restore Asp.NotResolved
        }
        private readonly IServiceLocator _locator = ServiceLocator.Current;
        
        public ActionResult Index()
        {
            var model = _locator.GetInstance<ItemModel>();
            return View(model.GetViewModel());
        }

        [HttpGet]
        [LoadViewModel]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateViewModel]
        public ActionResult Create(CreateItemViewModel viewModel, CreateItemModel model)
        {
            model.AddItem(viewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [LoadViewModel]
        public ViewResult Edit(string name)
        {
            return View();
        }

        [HttpPost]
        [ValidateViewModel]
        public ActionResult Edit(EditItemViewModel viewModel, EditItemModel model)
        {
            model.EditItem(viewModel);

            return RedirectToAction("Index");
        }
    }
}