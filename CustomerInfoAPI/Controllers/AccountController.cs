using AutoMapper;
using Entities.DTO;
using Entities.Interfaces;
using Entities.Models;
using LoggerService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInfoAPI.Controllers
{
    [Route("api/Account/{id}")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AccountController(IUnitOfWork unit, ILoggerManager logger, IMapper mapper)
        {
            _unitOfWork = unit;
            _logger = logger;
            _mapper = mapper;
        }

        
        [HttpGet]
        public ActionResult<Account> GetAccount(Guid Id)
        {
            try
            {
                var accountDto = new AccountDTO();
                var account = _unitOfWork.Accounts.FindAccount(Id);

                accountDto = _mapper.Map<AccountDTO>(account);

                return Ok(accountDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAccount)} action { ex}");
                return StatusCode(500, "Internal server error, no account found");
            }
        }
    }
}
