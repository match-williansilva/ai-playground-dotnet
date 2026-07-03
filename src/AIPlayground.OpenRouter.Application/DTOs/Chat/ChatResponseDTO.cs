using System;
using System.Collections.Generic;
using System.Text;

namespace AIPlayground.OpenRouter.Application.DTOs.Chat
{
    public sealed record ChatResponseDTO
    (
        string Content,
        string Model
    );
}
