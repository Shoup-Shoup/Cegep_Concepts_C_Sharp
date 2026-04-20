using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classe
{
    /* Abstract modifier:
     *      Sert a identifier un élément qui est volontairment incomplet    
     *      Si une classe non abstraite est dérivée d’une classe abstraite, elle est obligée d’implémenter des méthodes abstraites
     *      Using the abstract modifier on a class stops people from being able to create an instance of this class. Its stops
     *          us from doing that because the code thinks the class is incomplete
     *      Existe uniquement s'il existe une méthode abstraite déclarée, mais non défini. Les classes ayant des méthodes abstraite
     *          ne sont pas nécéssairement des classes abstraites, c'est seulement si la classe a des méthodes abstraites non défini
     *      Les classes abstraites laissent une partie ou la totalité des membres non implémentés pour que l'implémentation soit
     *      créer par la classe dérivé
     *      On ne peut pas créer d'instance d'une classe abstraite puisqu'elle contient des méthodes incomplète
     *      Le but est de créer une classe qui fourni la définition commune a toutes les classe dérivé
     *      Toutes les classses dérivées des classes abstraite doivent implémenter toutes les méthode abstraites
     *      La classe abstraite a quelque méthode défini qui représente le code commun défini de toutes les classes dérivée et à
     *      quelque méthodes abstraites non-defini qui doivent être défini spécifiquement par la classe dérivée
     *      Une classe abstraite peut avoir des attributs
     *      
     */

    internal abstract class C4_Vehicule_Abstract
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
}
