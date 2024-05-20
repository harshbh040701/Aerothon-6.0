﻿using Aerothon.Models.Response;

namespace Aerothon.Models.Request
{
    public class FlightRequest
    {
        public string Id { get; set; }
        public WayPointRequest LastPosition { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }

    }
}