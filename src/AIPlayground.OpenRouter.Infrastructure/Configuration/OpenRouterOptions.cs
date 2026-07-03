using System;
using System.Collections.Generic;
using System.Text;

namespace AIPlayground.OpenRouter.Infrastructure.Configuration
{
    public sealed class OpenRouterOptions
    {
        public const string SectionName = "OpenRouter";

        public string ApiKey { get; init; } = string.Empty;
        public string BaseUrl { get; init; } = "https://openrouter.ai/api/v1";
        public string Model { get; init; } = string.Empty;
    }
}
