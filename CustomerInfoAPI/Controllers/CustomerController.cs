using AutoMapper;
using Entities.DTO;
using Entities.Interfaces;
using Entities.Models;
using Entities.Repository;
using LoggerService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInfoAPI.Controllers
{
    [Route("api/CustomersData")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CustomerController(IUnitOfWork unit, ILoggerManager logger, IMapper mapper)
        {
            _unitOfWork = unit;
            _logger = logger;
            _mapper = mapper;
        }

        
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            try
            {
                IEnumerable<CustomerDTO> allCustomersDto = new List<CustomerDTO>();
                var AllCustomers = _unitOfWork.Customers.GetAllCustomers(false);

                allCustomersDto = _mapper.Map<IEnumerable<CustomerDTO>>(AllCustomers);
                                
                return Ok(allCustomersDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCustomers)} action { ex}");
                return StatusCode(500, "Internal server error");
            }            
        }
                
    }
}
