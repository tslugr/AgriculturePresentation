using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var values = _addressService.GetListAll();
            return View(values);
        }


        public IActionResult DeleteAddress(int id)
        {
            var values = _addressService.GetById(id);
            _addressService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var values = _addressService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAddress(Address p)
        {
            AddressValidator validationRules = new AddressValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                _addressService.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
