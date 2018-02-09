namespace InheritanceAndPolymorphismPractice
{
    public class Wizard
    {
        //fields
        private bool isGood;

        //Properties
        public bool IsGood
        {
            get { return this.isGood; }
            set { this.isGood = value; }
        }

        //Constructors
        public Wizard()
        {
            //default constructor
        }

        public Wizard(bool isGood)
        {
            this.isGood = isGood;
        }
    }
}