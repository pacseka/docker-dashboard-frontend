using System;
using System.Collections.Generic;

namespace DockerDashboardUI.Shared
{
    public class SwarmServiceDto
    {
        public string Name { get; set; }

        public List<ServicePort> Ports { get; set; }

#nullable enable
        public Uri? SwaggerUrl { get; set; }
#nullable disable

    }
}
