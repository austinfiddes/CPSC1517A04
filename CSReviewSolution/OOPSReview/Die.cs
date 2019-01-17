﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    public class Die
    {
        //create class level variable which will be an instance 
        //  of the System namespace math class Random
        //create a static instance which will be used for ALL Die
        //  instances created by the programmer/developer 
        //this instance of random will be generated once on the first 
        //  Die instance that is created 
        private static Random _rnd = new Random()
        //Data Members
        //  usually private 
        private int _Sides;
        private string _Color;

        //Properties
        //are responsible to assigning and retrieving data
        //  to/from their accociated data member
        //retrieving data from a data member uses the get{}
        //assigning data to a data member uses the set{}
        //properties need to be exposed to outside users
        //properties will have a return datatype BUT no parameter list 

        //Fully Implemented Property 
        //  has a defined Data Member that the developer 
        //  can directly access.
        public int Sides
        {
            get
            {
                //returns data of a specified datatype (i.e. in this case the datatype would be int (public *int* Side))
                return _Sides;
            }
            set
            {
                //assigns a supplied value to the data member 
                //the supplied value is located in the key word: value 
                //optionally include data value validation to ensure
                //  an appropriate value has been supplied 
                if (value >= 6 && value <= 20)
                {
                    //this is an acceptable value to keep
                    _Sides = value;
                    Roll();
                }
                else
                {
                    //this is an unacceptable value 
                    //issue a user friendly error message 
                    throw new Exception("Die cannot be " + value.ToString() + " sided. Die must be between 6 and 20 sided.");
                }
            }
        }
        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                //value.Trim() == "" (i.e. string.IsNullOrWhiteSpace(value))
                //value == null (i.e. string.IsNullOrEmpty(value))
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("You must supply a color string for the die.");
                }
                else
                {
                    _Color = value;
                }
            }
        }
        
        //Auto Implemented Property
        //NO Data Member definition 
        //the data member is internally created for you 
        //the data member datatype is taken from your return datatype 
        //  specified on the Property header.
        //auto implemented properties are usually used when there 
        //  is no need for internal validation.
        //access to a value managed by an auto implemented property
        //  MUST be done via the property.
        //if you wish your auto implemented properties to have validation
        //  then a good practice is to use a private set and have 
        //  the validation done somewhere/somehow elsewhere in the class
        public int FaceValue { get; private set; }

        //Constructor
        //-optional-
        //purpose of a constructor is to ensure that when an instance 
        //  of this class in created, it will be created within a stable 
        //  state; ALWAYS
        //you DO NOT call the constructor directly. It is called for you
        //  when you create an instance of the class.
        //if you do not code a constructor then the system will assign
        //  a default value to each data member/auto implemented property
        //  internal member matching the data type of that item
        //if you do code a constructor then you are responsible for ALL
        //  constructors for the class

        //syntax   public [classname]([list of paramaters - optional]) { coding block }

        //Default Constructor
        //is similar to the system default constructor 
        public Die()
        {
            //if you leave this coding block empty it would be the same 
            //  as using a system default constructor 

            //optionally 
            //you can set your own default values
            _Sides = 6;         //via data member 
            Color = "white";    //via property
            Roll();
        }

        //Greedy Constructor
        //this constructor will allow the user of the class to pass in
        //  a set of values which will be used at the time of instance creation
        //  to set the values of the internal data members auto properties 
        public Die(int sides, string color)
        {
            Sides = sides;
            Color = color;
            Roll();  //is an internal method of this Die class
        }

        //Behaviours (i.e. methods)
        //are methods that can be used by the outside user to 
        //  a) affect values within the instance
        //  b) use instance data to generate and return information 
        public void Roll()
        {
            //Random can take a set of values and produce a integer 
            //  value between the two values, where the minimum value 
            //  is inclusive and the maximum value is exclusive 
            FaceValue = _rnd.Next(1, Sides + 1);
        }
    }
}
