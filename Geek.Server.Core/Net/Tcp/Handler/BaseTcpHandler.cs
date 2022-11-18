﻿
namespace Geek.Server
{
    public abstract class BaseTcpHandler
    {
        public NetChannel Channel { get; set; }

        public Message Msg { get; set; }

        public virtual Task Init()
        {
            return Task.CompletedTask;
        }

        public abstract Task ActionAsync();

        public virtual Task InnerAction()
        {
            return ActionAsync();
        }

    }
}