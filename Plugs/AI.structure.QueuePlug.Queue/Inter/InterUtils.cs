﻿using System.Threading.Tasks;

namespace AI.structure.QueuePlug.Queue
{
    internal static class InterUtils
    {
        public static Task<bool> TrueTask => Task.FromResult(true);

        public static Task<bool> FalseTask => Task.FromResult(false);
    }
}
