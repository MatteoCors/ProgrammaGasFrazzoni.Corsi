using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int particelleSettoreA = 100;
            int particelleSettoreB = 0;

          
            if (File.Exists("C:\\Temp\\Particelle.csv"))
                File.Delete("C:\\Temp\\Particelle.csv");

            ScriviParticelleSuFile(0, particelleSettoreA, particelleSettoreB);

            Random random = new Random();

            for (int istante = 0; istante < 30; istante++)
            {
                int nuoveParticelleSettoreA = 0;
                int nuoveParticelleSettoreB = 0;

                
                for (int particella = 0; particella < particelleSettoreA; particella++)
                {
                    if (random.Next(6) == 0)
                    {
                        
                        nuoveParticelleSettoreB++;
                    }
                    else
                    {
                        nuoveParticelleSettoreA++;
                    }
                }

                
                for (int particella = 0; particella < particelleSettoreB; particella++)
                {
                    if (random.Next(6) == 0)
                    {
                        nuoveParticelleSettoreA++;
                    }
                    else
                    {
                       
                        nuoveParticelleSettoreB++;
                    }
                }

                
                particelleSettoreA = nuoveParticelleSettoreA;
                particelleSettoreB = nuoveParticelleSettoreB;

                ScriviParticelleSuFile(istante + 1, particelleSettoreA, particelleSettoreB);
            }
        }

        private static void ScriviParticelleSuFile(int istante, int particelleSettoreA, int particelleSettoreB)
        {
            
        }
    }
}

         


