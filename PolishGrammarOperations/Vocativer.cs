using System;
using System.Linq;

namespace PolishGrammarOperations
{
    public static class Vocativer
    {
        public static string Translate(string name)
        {
            if (name.Length >= 4)
            {
                switch (name.Substring(name.Length - 4))
                {
                    case "ciek":
                        return name.Substring(0, name.Length - 4) + "ćku";
                    case "siek":
                        return name.Substring(0, name.Length - 4) + "śku";
                    case "iela":
                    case "bela":
                    case "zula":
                        return name.Substring(0, name.Length - 1) + "o";
                }
            }
            if (name.Length >= 3)
            {
                switch (name.Substring(name.Length - 3))
                {
                    case "per":
                    case "der":
                        return name.Substring(0, name.Length - 2) + "rze";
                    case "cja":
                    case "ria":
                    case "lia":
                    case "dia":
                    case "wia":
                    case "fia":
                        return name.Substring(0, name.Length - 1) + "o";
                    case "ael":
                    case "iel":
                    case "oel":
                    case "uel":
                        return name + "u";
                }
            }
            if (name.Length >= 2)
            {
                switch (name.Substring(name.Length - 2))
                {
                    case "ni":
                        return name;
                    case "eł":
                        return name.Substring(0, name.Length - 2) + "le";
                    case "tr":
                        return name + "ze";
                    case "ał":
                        return name.Substring(0, name.Length - 1) + "le";
                    case "sł":
                        return name.Substring(0, name.Length - 2) + "śle";
                    case "it":
                    case "rt":
                        return name.Substring(0, name.Length - 1) + "cie";
                    case "ek":
                        return name.Substring(0, name.Length - 2) + "ku";
                    case "el":
                        return name.Substring(0, name.Length - 2) + "lu";
                    case "st":
                        return name.Substring(0, name.Length - 2) + "ście";
                    case "ja":
                    case "ia":
                    case "la":
                    case "ba":
                        return name.Substring(0, name.Length - 1) + "o";
                }
            }
            if (name.Length >= 1)
            {
                switch (name.Substring(name.Length - 1))
                {
                    case "n":
                    case "f":
                    case "m":
                    case "w":
                    case "p":
                    case "s":
                    case "b":
                        return name + "ie";
                    case "g":
                    case "h":
                    case "j":
                    case "k":
                    case "l":
                    case "z":
                        return name + "u";
                    case "r":
                        return name + "ze";
                    case "d":
                        return name + "zie";
                    case "a":
                        return name.Substring(0, name.Length - 1) + "o";
                    case "y":
                        return name;
                    case "t":
                        return name.Substring(0, name.Length - 1) + "cie";
                }
            }

            return name;
        }
    }
}