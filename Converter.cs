using System;
namespace Program{
    public class Converter {
        static double usd{ get; set;}
        static double eur {get; set;}
        static double rub {get; set;}
        public Converter(double us, double eu, double rb)
        {
            usd = us;
            eur = eu;
            rb  = rub;
        }
        static double ConvertSomToUsd(double som) 
        {
            double us = Math.Round(som/usd,4);
            return us;
        }
        static double ConvertSomToEur(double som)
        {
            double eu = Math.Round(som/eur,4);
            return eu;
        }
        static double ConvertSomToRub(double som)
        {            
            double rb = Math.Round(som/usd,4);
            return rub;
        }
        static double ConvertUsdToSom(double us)
        {
            double som = Math.Round(us*usd,4);
            return som; 
        }
        static double ConvertEurToSom(double eu)
        {
            double som = Math.Round(eu*eur,4);
            return som;
        }
        static double ConvertRubToSom(double rb)
        {
            double som = Math.Round(rb*rub,4);
            return som;
        }
    }
} 