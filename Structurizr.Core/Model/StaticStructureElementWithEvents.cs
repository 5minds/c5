using System.Collections.Generic;

namespace Structurizr
{
    public abstract class StaticStructureElementWithEvents : StaticStructureElement
    {
        private HashSet<Event> _publishedEvents { get; set; } = new HashSet<Event>();
        private HashSet<Event> _subscribedEvents = new HashSet<Event>();
        
        public ISet<Event> PublishedEvents 
        {
            get => new HashSet<Event>(_publishedEvents);
            internal set => _publishedEvents = new HashSet<Event>(value);
        }
        
        public ISet<Event> SubscribedEvents 
        {
            get => new HashSet<Event>(_subscribedEvents);
            internal set => _subscribedEvents = new HashSet<Event>(value);
        }

        public void Publishes(Event @event)
        {
            _publishedEvents.Add(@event);
        }

        public void Subscribes(Event @event)
        {
            _subscribedEvents.Add(@event);
        }
    }
}