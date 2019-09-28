using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {

        //constructor
        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        //Class properties
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }
        

        //Methods
        public void TurnOff()
        {
            IsOn = false;
        }
        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn && newChannel > 2 && newChannel < 19)
            {
                CurrentChannel = newChannel;
            }
            else
            {
                CurrentChannel = 3;
            }
        }
        public void ChannelUp()
        {
            if (IsOn && CurrentChannel < 18)
            {
                CurrentChannel++;
            }
            else
            {
                CurrentChannel = 3;
            }
        }
        public void ChannelDown()
        {
            if (IsOn && CurrentChannel > 3 && CurrentChannel < 19)
            {
                CurrentChannel--;
            }
            else if (IsOn)
            {
                CurrentChannel = 18;
            }
        }
        public void RaiseVolume()
        {
            if (IsOn && CurrentVolume < 10)
            {
                CurrentVolume++;
            }
            else if (IsOn)
            {
                CurrentVolume = 10;
            }
            else
            {
                CurrentVolume = CurrentVolume;
            }
        }
        public void LowerVolume()
        {
            if (IsOn && CurrentVolume > 0)
            {
                CurrentVolume--;
            }
            else if (IsOn)
            {
                CurrentVolume = 0;
            }
            else
            {
                CurrentVolume = CurrentVolume;
            }
        }

    }
}
