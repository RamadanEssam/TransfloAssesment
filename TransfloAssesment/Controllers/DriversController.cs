using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Transflo_Task.Models;
using TransfloAssesment.Dtos;
using TransfloAssesment.Models;
using TransfloAssesment.Services;

namespace TransfloAssesment.Controllers
{

    [ApiController]
    [Route("api/Drivers")]
    public class DriversController : ControllerBase
    {

        protected APIResponse _response;
        private readonly IDriversService _driversService;
    

        public DriversController(IDriversService driversService)
        {
            _driversService = driversService;
            _response = new();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var drivers = await _driversService.GetAll();
            _response.Result = drivers;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
            
        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<APIResponse>> GetDriver(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var driver = await _driversService.GetById(id);
              
                if (driver == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = driver;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] DriverDto dto)
        {
            if (ModelState.IsValid)
            {

                var driver = new Driver
                {
                    firstName = dto.firstName,
                    lastName = dto.lastName,
                    phoneNumber = dto.phoneNumber,
                    Email = dto.Email,
                    creationDate = DateTime.Now.Date,
                    isDeleted = false,


                };

                await _driversService.Add(driver);



                _response.Result = driver;
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);



            }
            else
            {
                return BadRequest(dto);
            }

        }




        [HttpPut("{id:int}", Name = "UpdateDriver")]

        //[HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] DriverDto dto)
        {
            var driver = await _driversService.GetById(id);

            if (driver == null)
                return NotFound($"No Driver was found with ID: {id}");

            driver.firstName = dto.firstName;
            driver.lastName = dto.lastName;
            driver.phoneNumber= dto.phoneNumber;
            driver.Email= dto.Email;
            driver.modificationDate= DateTime.Now.Date;

            _driversService.Update(driver);


            _response.StatusCode = HttpStatusCode.NoContent;
            _response.IsSuccess = true;
            return Ok(_response);

         
        }


        [HttpDelete("{id:int}")]

        public async Task<IActionResult> DeleteAsync(int id)
        {
            var driver = await _driversService.GetById(id);

            if (driver == null)
                return NotFound($"No driver was found with ID: {id}");
            
            _driversService.Delete(driver);

       
            _response.StatusCode = HttpStatusCode.NoContent;
            _response.IsSuccess = true;
            return Ok(_response);
        }

    }
}
