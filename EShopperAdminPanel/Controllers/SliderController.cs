using DAL.Entity;
using DAL.Operations;
using EShopperAdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EShopperAdminPanel.Controllers
{
    public class SliderController : Controller
    {
        public IActionResult Index()
        {
            GenericRepository<Slider> repository = new GenericRepository<Slider>();

            var sliders = repository.GetList();

            List<SliderModel> sliderModel = sliders.Select(i => new SliderModel()
            {
                Id = i.Id,
                Name = i.Name
            }
            ).ToList();


            return View(sliderModel);
        }

        public JsonResult CreateSlider(string _sliderName)
        {
            try
            {
                var slider = new Slider();
                slider.Name = _sliderName;

                GenericRepository<Slider> repository = new GenericRepository<Slider>();
                var result = repository.Create(slider);

                var sliderModel = new SliderModel()
                {
                    Id = result.Id,
                    Name = result.Name
                };

                return Json(sliderModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult UpdateSlider(int _id, string _sliderName)
        {
            try
            {
                var slider = new Slider();
                slider.Id = _id;
                slider.Name = _sliderName;

                GenericRepository<Slider> repository = new GenericRepository<Slider>();
                var result = repository.Update(slider);

                var sliderModel = new SliderModel()
                {
                    Id = result.Id,
                    Name = result.Name
                };


                return Json(sliderModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult DeleteSlider(int _id)
        {
            try
            {
                GenericRepository<Slider> repository = new GenericRepository<Slider>();
                var result = repository.Delete(_id);

                return Json(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
