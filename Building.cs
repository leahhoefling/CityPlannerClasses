using System;

namespace planner
{
    public class Building
    {
        // Private Fields
        // _designer of type string. It will hold your name.
        private string _designer = "Leah";
        public string Designer
        {
            get
            {
                return _designer;
            }
        }
        // _dateConstructed of type DateTime. This will hold the exact time the building was created.
        private DateTime _dateConstructed { get; set; }
        public DateTime DateConstructed
        {
            get
            {
                return _dateConstructed;
            }

        }

        // _address of type string.
        private string _address { get; set; }
        public string Address
        {
            get
            {
                return _address;
            }

        }

        // _owner of type string. This will store the same of the person who owns the building.
        private string _owner { get; set; }
        public string Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }

        // Public Properties
        // Stories typed as an integer.
        public int Stories { get; set; }

        // Width typed as a double.
        public double Width { get; set; }

        // Depth typed as a double.
        public double Depth { get; set; }

        // Volume should be read-only and should return Width * Depth * (3 * # of Stories). Each story is 3 meters high.
        public double Volume
        {
            get { return Width * Depth * (3 * Stories); }
        }

        //THIS IS THE CONSTRUCTOR
        public Building(string address)
        {
            _address = address;
        }

        // Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
        //this is the method
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        // Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. The method should take that string and assign it to the private _owner field.
        public void Purchase(string person)
        {
            _owner = person;
        }

    }

}
