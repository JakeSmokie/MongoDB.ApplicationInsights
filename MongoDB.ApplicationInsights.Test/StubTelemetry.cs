using System;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;
using NSubstitute;

namespace MongoDB.ApplicationInsights.Test {
    public class StubTelemetry {
        public StubTelemetry() {
            TelemetryChannel = Substitute.For<ITelemetryChannel>();

            var config = new TelemetryConfiguration {
                TelemetryChannel = TelemetryChannel,
                InstrumentationKey = Guid.NewGuid().ToString()
            };

            TelemetryClient = new TelemetryClient(config);
        }

        public ITelemetryChannel TelemetryChannel { get; set; }
        public TelemetryClient TelemetryClient { get; set; }
    }
}