using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4_jorgevillarreal

{
    class MediaPlayer
    {

        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
}
