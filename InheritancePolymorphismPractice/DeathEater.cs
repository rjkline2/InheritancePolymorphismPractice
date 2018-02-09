namespace InheritanceAndPolymorphismPractice
{
    public class DeathEater : Wizard
    {
        //fields 
        private bool hasDarkMark;
        
        //Properties
        public bool HasDarkMark
        {
            get { return this.hasDarkMark; }
            set { this.hasDarkMark = value; }
        }

        //Constructor
        public DeathEater():base(false)
        {

        }
    }
}