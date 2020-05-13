using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Structurizr
{
    /// <summary>
    /// An event.
    /// </summary>
    [DataContract]
    public sealed class Event : Element, IEquatable<Event>
    {
        public override string CanonicalName => CanonicalNameSeparator + FormatForCanonicalName(Name);

        public override Element Parent { get; set; }

        /// <summary>
        /// The events namespace.
        /// </summary>
        /// <value></value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string Namespace { get; set; }
                
        internal Event()
        {
        }

        public override List<string> GetRequiredTags()
        {
            return new List<string>
            {
                Structurizr.Tags.Element,
                Structurizr.Tags.Event
            };
        }

        public bool Equals(Event @event)
        {
            return this.Equals(@event as Element);
        }
    }
}