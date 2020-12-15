using System;

///<summary>namespace Enemies</summary>
namespace Enemies
{
    ///<summary> new class zombie</summary>
    public class Zombie
    {
        ///<summary> zombie's health</summary>
        public int health;
        ///<summary> sets health to 0 </summary>
        public Zombie()
        {
            this.health = 0;
        }
        ///<summary> sets new value to health </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                this.health = value;
            }
        }
        ///<summary> name = no name </summary>
        private string name = "(No name)";
        ///<summary> get and set name to value </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        ///<summary> returns zombie's gelath </summary>
        public int GetHealth()
        {
            return (this.health);
        }
    }
}