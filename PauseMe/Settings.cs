using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PauseMe
{
    public class Settings
    {
        public TimeSpan PauseTime { get; private set; }
        public TimeSpan PauseEvery { get; private set; }

        public Settings(TimeSpan pauseEvery, TimeSpan pauseTime)
        {
            PauseTime = pauseTime;
            PauseEvery = pauseEvery;
        }
    }
}
