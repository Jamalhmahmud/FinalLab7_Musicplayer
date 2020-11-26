using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab7c
{
    interface RadioPlayerInterface
    {

        void Switch (bool on);
     void retune(double frequency);
        void SetVolume(int loudness);
        void changeChannel();
    }
}
