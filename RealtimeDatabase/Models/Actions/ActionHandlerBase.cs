﻿using RealtimeDatabase.Models.Commands;
using RealtimeDatabase.Models.Responses;
using System.Threading.Tasks;
using RealtimeDatabase.Connection;

namespace RealtimeDatabase.Models.Actions
{
    public class ActionHandlerBase
    {
        public ConnectionBase connection;
        public ExecuteCommand executeCommand;

        public void Notify(object data)
        {
            if (connection != null)
            {
                _ = connection.Send(new ExecuteResponse()
                {
                    ReferenceId = executeCommand.ReferenceId,
                    Result = data,
                    Type = ExecuteResponse.ExecuteResponseType.Notify
                });
            }
        }
    }
}
