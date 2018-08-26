using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HartenjagenScoreApp.Classes
{
    class Ronde
    {
        private int _rondeNummer = 0;
        private int _rondeScore = 0;

        public int RondeNummer { get => _rondeNummer; set => _rondeNummer = value; }
        public int RondeScore { get => _rondeScore; set => _rondeScore = value; }
    }
}
