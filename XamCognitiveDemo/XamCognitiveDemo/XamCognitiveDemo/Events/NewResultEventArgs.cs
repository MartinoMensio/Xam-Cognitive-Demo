﻿using System;
using XamCognitiveDemo.Models;

namespace XamCognitiveDemo.Events
{
    public class NewResultEventArgs : EventArgs
    {
        public NewResultEventArgs()
        {
        }
        public AnalysisResult AnalysisResult { get; set; }
        public bool TimedOut { get; set; } = false;
        public Exception Exception { get; set; } = null;
    }
}