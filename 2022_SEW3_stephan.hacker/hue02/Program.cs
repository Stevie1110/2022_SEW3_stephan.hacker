﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace hue02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            chatbot chatbot = new chatbot();
            chatbot.StartChat();
        }
    }
}
