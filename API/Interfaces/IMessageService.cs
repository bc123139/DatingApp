﻿using API.DAL.Message.Models;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface IMessageService
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageModel>> GetMessagesForUser();
        Task<IEnumerable<MessageModel>> GetMessagesThread(string currentUserId, string recipientId);
        Task<bool> SaveAllAsync();
    }
}
