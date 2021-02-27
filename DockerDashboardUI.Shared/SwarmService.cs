using System;

namespace DockerDashboardUI.Shared
{
    public class SwarmService
    {
        public string Name { get; set; }

        public string  PublishedPorts { get; set; }
        #nullable enable
        public Uri? SwaggerUrl { get; set; }
        #nullable disable

    }
}
