﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik {
    class VideoOglas : Oglas {

        public override string ToString() {
            return String.Format("{0}\n{1}\n{2}\n\n", Naslov, Tekst, Video);
        }

        public string Video { get; set; }

        private string video;
    }
}
