using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.WebApi.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarInformationController : ControllerBase
    {
        private ICarInformationService _carInformationService;
        public CarInformationController(ICarInformationService carInformationService)
        {
            _carInformationService = carInformationService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            try
            {
                var result = _carInformationService.GetAll();
                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
                
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retreiving data from database!");
            }
        }

        [HttpGet("getbymake")]
        public IActionResult GetByMake(int makeId)
        {
            try
            {
                var result = _carInformationService.GetByMake(makeId);
                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retreiving data from database!");
            }
        }

        [HttpGet("get")]
        public IActionResult Get(int carId)
        {
            try
            {
                var result = _carInformationService.GetById(carId);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retreiving data from database!");
            }
        }

        [HttpPost("add")]
        public IActionResult Add(CarInformation carInformation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(carInformation != null)
                    {
                        _carInformationService.Add(carInformation);
                        return Ok();
                    }
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retreiving data from database!");
            }
        }

        [HttpPut("update/{carId:int}")]
        public IActionResult Update(CarInformation carInformation, int carId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var carToUpdate = _carInformationService.GetById(carId);
                    if (carToUpdate == null)
                    {
                        return NotFound($"Car with ID = {carId} not found!");
                    }

                    _carInformationService.Update(carInformation);
                    return Ok();
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retreiving data from database!");
            }
        }

        [HttpDelete("delete/{carId:int}")]
        public IActionResult Delete(int carId)
        {
            try
            {
                var carToDelete = _carInformationService.GetById(carId);
                if (carToDelete == null)
                {
                    return NotFound($"Car with ID = {carId} not found!");
                }
                _carInformationService.Delete(carToDelete);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retreiving data from database!");
            }
        }

    }
}
