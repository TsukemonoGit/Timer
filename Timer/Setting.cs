using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimer
{
    public class Setting
    {
        private string _soundFileName;
        private int _maxTime;
        private string _memoText;

        public string SoundFileName
        {
            get { return _soundFileName; }
            set { _soundFileName = value; }
        }

        public int MaxTime
        {
            get { return _maxTime; }
            set { _maxTime = value; }
        }
        public string MemoText
        {
            get { return _memoText; }
            set { _memoText = value; }
        }
        public Setting()
        {
            _soundFileName = "";
            _maxTime = 0;
            _memoText = "";
        }
    }
}
