using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyCore
{
    public interface ITemperatureController
    {
        /// <summary>
        /// Is the temperature controller avaiable        
        /// </summary>
        /// <returns>Returns true if all components are connected correctly</returns>
        bool isAvaiable();

        /// <summary>
        /// Provide outside temperature in degree celsius
        /// </summary>
        /// <returns>outside temperature</returns>
        double GetOutsideTemperature();

        /// <summary>
        /// Provide inside temperature in degree celsius
        /// </summary>
        /// <returns>inside temperature</returns>
        double GetInsideTemperature();

        /// <summary>
        /// Get if one heater is on
        /// </summary>
        /// <returns>true if exactly one heater is on</returns>
        bool GetIsOneHeaterOn();

        /// <summary>
        /// Get if both heaters are on
        /// </summary>
        /// <returns>true if exactly two heaters are on</returns>
        bool GetAreBothHeatersOn();

        /// <summary>
        /// Set exactly one heater on
        /// </summary>
        void SetOneHeaterOn(double intensity);

        /// <summary>
        /// Set both heater on
        /// </summary>
        void SetBothHeatersOn(double intensity);

        /// <summary>
        /// Disable both heaters
        /// </summary>
        /// <param name="intensity"></param>
        void SetNoHeaterOn(double intensity);
    }
}
