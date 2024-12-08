using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace LuminaAi_v1._0._0.Pages.Chat
{
    public class IndexModel : PageModel
    {
        // List to store chat messages.
        public List<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

        // Property to bind user input.
        [BindProperty]
        public string UserMessage { get; set; }

        // Called when the page is loaded (GET request).
        public void OnGet()
        {
            // Add a welcome message from AI.
            ChatMessages.Add(new ChatMessage { Sender = "AI", Text = "Hello! How can I assist you today?" });
        }

        // Called when a message is posted (POST request).
        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(UserMessage))
            {
                // Add the user's message to the chat history.
                ChatMessages.Add(new ChatMessage { Sender = "You", Text = UserMessage });

                // Simulate an AI response (can be replaced with actual AI logic).
                ChatMessages.Add(new ChatMessage { Sender = "AI", Text = $"You said: {UserMessage}" });

                // Return the page with updated chat messages.
                return Page();
            }

            // If no message is provided, return the page.
            return Page();
        }
    }

    // Model to represent a chat message.
    public class ChatMessage
    {
        public string Sender { get; set; }  // The sender of the message (AI or User).
        public string Text { get; set; }    // The content of the message.
    }
}
