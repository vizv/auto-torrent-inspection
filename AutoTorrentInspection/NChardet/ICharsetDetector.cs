﻿namespace NChardet
{
    public interface ICharsetDetector
    {
        void Init(ICharsetDetectionObserver observer);
        bool DoIt(byte[] aBuf, int aLen, bool oDontFeedMe);
        void Done();
    }
}