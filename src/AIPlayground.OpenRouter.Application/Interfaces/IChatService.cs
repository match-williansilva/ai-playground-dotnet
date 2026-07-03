using AIPlayground.OpenRouter.Application.DTOs.Chat;

namespace AIPlayground.OpenRouter.Application.Interfaces
{
    public interface IChatService
    {
        Task<ChatResponseDTO> SendChatAsync(ChatRequestDTO request, CancellationToken cancellationToken = default);
    }
}
