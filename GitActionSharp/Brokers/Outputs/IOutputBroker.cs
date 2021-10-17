// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

namespace GitActionSharp.Brokers.Outputs
{
    public interface IOutputBroker
    {
        void GenerateFileOutput(string destinationPath, string content);
    }
}
