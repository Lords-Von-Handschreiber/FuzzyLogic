using DotFuzzy;
using FuzzyCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogicImpl
{
    public class FuzzyLogicEntry
    {
        private FuzzyEngine engine = new FuzzyEngine();
        private ITemperatureController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="FuzzyLogicEntry" /> class.
        /// </summary>
        /// <param name="controller">The controller.</param>
        public FuzzyLogicEntry(ITemperatureController controller)
        {
            this.controller = controller;
            LinguisticVariable tempInside = new LinguisticVariable("TemperatureInside");
            tempInside.MembershipFunctionCollection.Add(new MembershipFunction("Cold", -10, -10, 15, 19));
            tempInside.MembershipFunctionCollection.Add(new MembershipFunction("Normal", 15, 22, 22, 26));
            tempInside.MembershipFunctionCollection.Add(new MembershipFunction("Warm", 22, 26, 125, 125));

            LinguisticVariable tempOutside = new LinguisticVariable("TemperatureOutside");
            tempOutside.MembershipFunctionCollection.Add(new MembershipFunction("Cold", -20, -20, 10, 16));
            tempOutside.MembershipFunctionCollection.Add(new MembershipFunction("Normal", 13, 21, 21, 27));
            tempOutside.MembershipFunctionCollection.Add(new MembershipFunction("Warm", 20, 26, 125, 125));

            LinguisticVariable heating = new LinguisticVariable("PerformHeat");
            heating.MembershipFunctionCollection.Add(new MembershipFunction("none", 0, 0, 16, 33));
            heating.MembershipFunctionCollection.Add(new MembershipFunction("one", 25, 50, 50, 66));
            heating.MembershipFunctionCollection.Add(new MembershipFunction("both", 45, 75, 100, 100));

            engine.LinguisticVariableCollection.Add(tempInside);
            engine.LinguisticVariableCollection.Add(tempOutside);
            engine.LinguisticVariableCollection.Add(heating);
            engine.Consequent = "PerformHeat";

            engine.FuzzyRuleCollection.Add(new FuzzyRule("IF (TemperatureInside IS Cold) AND (TemperatureOutside IS Cold) THEN PerformHeat IS both"));
            engine.FuzzyRuleCollection.Add(new FuzzyRule("IF (TemperatureInside IS Cold) AND (TemperatureOutside IS Normal) THEN PerformHeat IS one"));
            engine.FuzzyRuleCollection.Add(new FuzzyRule("IF (TemperatureInside IS Cold) AND (TemperatureOutside IS Warm) THEN PerformHeat IS none"));
            engine.FuzzyRuleCollection.Add(new FuzzyRule("IF (TemperatureInside IS Normal) AND (TemperatureOutside IS Cold) THEN PerformHeat IS one"));
            engine.FuzzyRuleCollection.Add(new FuzzyRule("IF (TemperatureInside IS Normal) AND (TemperatureOutside IS Normal) THEN PerformHeat IS none"));
            engine.FuzzyRuleCollection.Add(new FuzzyRule("IF (TemperatureInside IS Normal) AND (TemperatureOutside IS Warm) THEN PerformHeat IS none"));
            engine.FuzzyRuleCollection.Add(new FuzzyRule("IF (TemperatureInside IS Warm) AND (TemperatureOutside IS Cold) THEN PerformHeat IS none"));
            engine.FuzzyRuleCollection.Add(new FuzzyRule("IF (TemperatureInside IS Warm) AND (TemperatureOutside IS Normal) THEN PerformHeat IS none"));
            engine.FuzzyRuleCollection.Add(new FuzzyRule("IF (TemperatureInside IS Warm) AND (TemperatureOutside IS Warm) THEN PerformHeat IS none"));                       
        }

        /// <summary>
        /// Performs the fuzzy calculation.
        /// </summary>
        public double PerformFuzzyCalculation()
        {
            if (controller.IsAvaiable())            
            {
                LinguisticVariable tempinside = engine.LinguisticVariableCollection[0];
                tempinside.InputValue = controller.GetInsideTemperature();
                LinguisticVariable tempoutside = engine.LinguisticVariableCollection[1];
                tempoutside.InputValue = controller.GetOutsideTemperature();
                LinguisticVariable heating = engine.LinguisticVariableCollection[2];
                
                try
                {
                    double result =  engine.Defuzzify();
                    SetController(result);
                    return result;
                }
                catch (Exception ex)
                {

                }
            }
            return -1;
        }

        /// <summary>
        /// Sets the controller.
        /// </summary>
        /// <param name="result">The result.</param>
        public void SetController(double result)
        {
            if (result >= 0.66)
            {
                controller.SetBothHeatersOn(result);
            }
            else if (result >= 0.25)
            {
                controller.SetOneHeaterOn(result);
            }
            else
            {
                controller.SetNoHeaterOn(result);
            }
        }
    }
}
