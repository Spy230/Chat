﻿using System.ServiceModel;

namespace Chat
{
    internal class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public OperationContext operationContext { get; set; }
    }
}
