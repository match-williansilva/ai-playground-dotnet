using AIPlayground.OpenRouter.Application.DTOs.Chat;

namespace AIPlayground.OpenRouter.Application.Interfaces
{
    public interface IChatProvider
    {
        Task<ChatResponseDTO> SendChatAsync(ChatRequestDTO request, CancellationToken cancellationToken = default);
    }
}
