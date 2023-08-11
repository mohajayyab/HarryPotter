using System;
using System.Collections.Generic;
using System.Linq;

namespace HarryPotter
{ 
    class Program
    {

        static void Main()
        {
            while (true)
            {
                try
                {


                    House gryffindor = new House();
                    House ravenclaw = new House();
                    House hufflepuff = new House();
                    House slytherin = new House();

                    Wizard wizard = new Wizard();
                    List<Wizard> newList = wizard.GenerateRandomWizard(10);

                    SortingHat newSortingHat = new SortingHat(newList, gryffindor, ravenclaw, hufflepuff, slytherin);
                    newSortingHat.AssigningWizards();


                    Console.WriteLine("Input: ");
                    string input = Console.ReadLine();

                    string propertyName = input.Split(' ')[0];
                    if (IsPropertyMatch(propertyName) == false)
                    {
                        throw new InputException();
                    }

                    if (CanConvertToInt(input.Split(' ')[1]) == false)
                    {
                        throw new ConvertException();
                    }
                    int minValue = int.Parse(input.Split(' ')[1]);


                    List<Wizard> filteredWizardsforgryffindor = gryffindor.GetWizardsWithProperty(propertyName, minValue);
                    List<Wizard> filteredWizardsforravenclaw = ravenclaw.GetWizardsWithProperty(propertyName, minValue);
                    List<Wizard> filteredWizardsforhufflepuff = hufflepuff.GetWizardsWithProperty(propertyName, minValue);
                    List<Wizard> filteredWizardsforslytherin = slytherin.GetWizardsWithProperty(propertyName, minValue);

                    if (filteredWizardsforgryffindor.Count == 0 && filteredWizardsforravenclaw.Count == 0 && filteredWizardsforhufflepuff.Count == 0 && filteredWizardsforslytherin.Count == 0)
                    {
                        throw new NoElementException();
                        //Console.WriteLine("No wizards found with the given property and minimum value.");
                    }
                    else
                    {
                        Console.WriteLine("Wizards with property '{0}' and minimum value of {1}:", propertyName, minValue);
                        foreach (var wizards in filteredWizardsforgryffindor)
                        {

                            if (filteredWizardsforgryffindor.Contains(wizard))
                            {
                                Console.WriteLine("Gryffindor: {0}", wizard.Name);
                            }
                            else if (filteredWizardsforravenclaw.Contains(wizard))
                            {
                                Console.WriteLine("Ravenclaw: {0}", wizard.Name);
                            }
                            else if (filteredWizardsforhufflepuff.Contains(wizard))
                            {
                                Console.WriteLine("Hufflepuff: {0}", wizard.Name);
                            }
                            else if (filteredWizardsforslytherin.Contains(wizard))
                            {
                                Console.WriteLine("Slytherin: {0}", wizard.Name);
                            }


                        }
                        foreach (var wizard1 in filteredWizardsforravenclaw)
                        {
                            if (filteredWizardsforgryffindor.Contains(wizard1))
                            {
                                Console.WriteLine("Gryffindor: {0}", wizard1.Name);
                            }
                            else if (filteredWizardsforravenclaw.Contains(wizard1))
                            {
                                Console.WriteLine("Ravenclaw: {0}", wizard1.Name);
                            }
                            else if (filteredWizardsforhufflepuff.Contains(wizard1))
                            {
                                Console.WriteLine("Hufflepuff: {0}", wizard1.Name);
                            }
                            else if (filteredWizardsforslytherin.Contains(wizard1))
                            {
                                Console.WriteLine("Slytherin: {0}", wizard1.Name);
                            }
                        }
                        foreach (var wizard2 in filteredWizardsforhufflepuff)
                        {
                            if (filteredWizardsforgryffindor.Contains(wizard2))
                            {
                                Console.WriteLine("Gryffindor: {0}", wizard2.Name);
                            }
                            else if (filteredWizardsforravenclaw.Contains(wizard2))
                            {
                                Console.WriteLine("Ravenclaw: {0}", wizard2.Name);
                            }
                            else if (filteredWizardsforhufflepuff.Contains(wizard2))
                            {
                                Console.WriteLine("Hufflepuff: {0}", wizard2.Name);
                            }
                            else if (filteredWizardsforslytherin.Contains(wizard2))
                            {
                                Console.WriteLine("Slytherin: {0}", wizard2.Name);
                            }
                        }

                        foreach (var wizard3 in filteredWizardsforslytherin)
                        {
                            if (filteredWizardsforgryffindor.Contains(wizard3))
                            {
                                Console.WriteLine("Gryffindor: {0}", wizard3.Name);
                            }
                            else if (filteredWizardsforravenclaw.Contains(wizard3))
                            {
                                Console.WriteLine("Ravenclaw: {0}", wizard3.Name);
                            }
                            else if (filteredWizardsforhufflepuff.Contains(wizard3))
                            {
                                Console.WriteLine("Hufflepuff: {0}", wizard3.Name);
                            }
                            else if (filteredWizardsforslytherin.Contains(wizard3))
                            {
                                Console.WriteLine("Slytherin: {0}", wizard3.Name);
                            }
                        }
                    }
                }
                catch (InputException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: The given quality name wasn't in correct form.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (ConvertException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: The given number wasn't in correct form.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (InsertionException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: An error happened while assigning wizards to the houses.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (NoElementException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: No wizards found with the given property and minimum value.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }





                static bool IsPropertyMatch(string input)
                {
                    string[] validProperties = { "Courage", "Intelligence", "Perseverance", "Cunning" };
                    return validProperties.Contains(input);
                }

                static bool CanConvertToInt(string input)
                {
                    int number;
                    return int.TryParse(input, out number);
                }





            }
        }
    }




}
