// ---------------------------------------------------------------
// Copyright (c) Shri Humrudha Jagathisun All rights reserved.
// ---------------------------------------------------------------

using System.IO;

namespace GitActionSharp.Brokers.Outputs
{
    public class OutputBroker : IOutputBroker
    {
        public void GenerateFileOutput(string destinationPath, string contents) =>
            File.WriteAllText(destinationPath, contents);
    }
}
