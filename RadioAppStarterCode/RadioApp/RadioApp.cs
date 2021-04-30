using System;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;

        public int Channel
        {
            get { return _channel; }
            set
            {
                if (_on == false)
                {
                    _channel = 1;
                }
                else
                {
                    if (value >= 5 || value <= 0)
                    {
                        _channel = 2;
                    }
                    else
                    {
                        _channel = value;
                    }
                }
            }
        }

        public string Play()
        {
            if (_on == false)
            {
                return "Radio is off";
            }
            else
            {
                return $"Playing channel {Channel}";
            }
        }
        public void TurnOff()
        {
            _on = false;
        }
        public void TurnOn()
        {
            _on = true;
        }
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}