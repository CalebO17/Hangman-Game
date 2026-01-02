using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// Caleb - Player is for keeping track of player information

namespace HangmanAssignment
{
    internal class Player
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(age > 0 && age < 100)
                {
                    age = value;
                }
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value!="")
                {
                    name = value;
                }
            }
        }
        public string Gender {  get; set; }

        public Player(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            Gender = gender;
        }
        public Player()
        {
            Age = 99;
            Name = "John Doe";
            Gender = "Male";
        }
    }
}
