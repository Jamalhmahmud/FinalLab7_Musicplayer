﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab7c
{
    interface MusicPlayerInterface
    {
    void Switch(bool on);
    void play(bool on);
    void setVolume(int loudness);
     void playNext();
     void playPrevious();

}
}
