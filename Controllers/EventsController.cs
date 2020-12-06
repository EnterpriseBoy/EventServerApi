using System.Collections.Generic;
using EventServerApi.Data;
using EventServerApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventServerApi.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private IEventServerRepo _repository { get; }
        public EventsController(IEventServerRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Event>> GetAllEvent()
        {
            var events = _repository.GetAllEvents();

            return Ok(events);
        }
        
        [HttpGet("{id}")]
        public ActionResult<Event> GetEventById(int id)
        {
            var eventItem = _repository.GetEventById(id);

            return Ok(eventItem);
        }
    }
}