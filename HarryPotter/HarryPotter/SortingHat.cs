using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    class SortingHat
    {
        House gryffindor;
        House ravenclaw;
        House hufflepuff;
        House slytherin;
        List<Wizard> wizardsList = new List<Wizard>();


        public SortingHat(List<Wizard> wizardsList, House gryffindor, House ravenclaw, House hufflepuff, House slytherin)
        {
            this.wizardsList = wizardsList;
            this.gryffindor = gryffindor;
            this.ravenclaw = ravenclaw;
            this.hufflepuff = hufflepuff;
            this.slytherin = slytherin;
        }


        public void AssigningWizards()
        {
            foreach (Wizard wizard in wizardsList)
            {
                if (wizard.Courage >= wizard.Intelligence && wizard.Courage >= wizard.Perseverance && wizard.Courage >= wizard.Cunning)
                {
                    gryffindor.Insert(wizard, wizard.Courage);
                }
                else if (wizard.Intelligence >= wizard.Courage && wizard.Intelligence >= wizard.Perseverance && wizard.Intelligence >= wizard.Cunning)
                {
                    ravenclaw.Insert(wizard, wizard.Intelligence);
                }
                else if (wizard.Perseverance >= wizard.Courage && wizard.Perseverance >= wizard.Intelligence && wizard.Perseverance >= wizard.Cunning)
                {
                    hufflepuff.Insert(wizard, wizard.Perseverance);
                }
                else if (wizard.Cunning >= wizard.Courage && wizard.Cunning >= wizard.Intelligence && wizard.Cunning >= wizard.Perseverance)
                {
                    slytherin.Insert(wizard, wizard.Cunning);
                }
                else
                {
                    throw new Exception();
                }
            }
        }







    }
}
