﻿using System;

namespace ImageFanReloaded.CommonTypes.CommonEventArgs
{
    public class FolderChangedEventArgs
        : EventArgs
    {
        public FolderChangedEventArgs(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Path cannot be empty.", nameof(path));
            }

            Path = path;
        }

        public string Path { get; private set; }
    }
}
