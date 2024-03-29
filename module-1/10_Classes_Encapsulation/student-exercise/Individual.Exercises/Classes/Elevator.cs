﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        //constructor
        public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
            CurrentLevel = 1;
            DoorIsOpen = false;
        }

        //Class properties
        public int CurrentLevel { get; private set; }
        public int NumberOfLevels { get; }
        public bool DoorIsOpen { get; private set; }


        //Methods
        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
        public void CloseDoor()
        {
            DoorIsOpen = false;
        }
        public void GoUp(int desiredFloor)
        {
            if (DoorIsOpen == false && CurrentLevel < NumberOfLevels && desiredFloor > CurrentLevel)
            {
                CurrentLevel++;
            }
            else
            {
                CurrentLevel = CurrentLevel;
            }
        }
        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen == false && CurrentLevel > 1 && desiredFloor <= CurrentLevel)
            {
                CurrentLevel--;
            }
            else
            {
                CurrentLevel = CurrentLevel;
            }
        }

    }

}
