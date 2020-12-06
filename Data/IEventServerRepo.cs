using System.Collections.Generic;
using EventServerApi.Models;

namespace EventServerApi.Data
{
    public interface IEventServerRepo
    {
        IEnumerable<Event> GetAllEvents();
        Event GetEventById(int id);
    }
}