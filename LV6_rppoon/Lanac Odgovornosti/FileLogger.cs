using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_rppoon.Lanac_Odgovornosti
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(this.filePath))
            {
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                builder.Append(type);
                builder.Append(": ");
                builder.Append(DateTime.Now);
                builder.Append('=', message.Length);
                builder.Append(message);
                builder.Append('=', message.Length);
                builder.Append("\n");

                streamWriter.WriteLine(builder);
            }
        }
    }
}
