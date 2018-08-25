using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HartenjagenScoreApp
{
    class Hartenjagen
    {
        private int _draaiScore = 40;
        private int _rondeScore = 15;
        private string _spelStatus = "Brengen";

        public int DraaiScore { get => _draaiScore; set => _draaiScore = value; }
        public int RondeScore { get => _rondeScore; set => _rondeScore = value; }
        public string SpelStatus { get => _spelStatus; set => _spelStatus = value; }
    }
}
