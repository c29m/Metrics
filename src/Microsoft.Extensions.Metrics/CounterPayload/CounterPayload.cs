﻿using System.Collections.Generic;

namespace Microsoft.Extensions.Metrics
{
    public class CounterPayload : ICounterPayload
    {
        public CounterPayload(IDictionary<string, object> payloadFields)
        {
            Name = payloadFields["Name"].ToString();
            Value = payloadFields["Mean"].ToString();
            DisplayName = payloadFields["DisplayName"].ToString();
        }

        public string Name { get; }
        public string Value { get; }
        public string DisplayName { get; }
    }
}