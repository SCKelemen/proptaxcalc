using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc.Calc
{
    public interface IPropertyTaxStrategy { }
    public abstract class PropertyTaxStrategy : IPropertyTaxStrategy
    {

    }

    public class AlabamaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class AlaskaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class ArizonaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class ArkansasPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class CaliforniaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class ColoradoPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class ConnecticutPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class DelawarePropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class FloridaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class GeorgiaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class HawaiiPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class IdahoPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class IllinoisPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class IndianaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class IowaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class KansasPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class KentuckyPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class LouisianaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class MainePropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class MarylandPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class MassachusettsPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class MichiganPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class MinnesotaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class MississippiPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class MissouriPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class MontanaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class NebraskaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class NevadaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class NewHampshirePropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class NewJerseyPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class NewMexicoPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class NewYorkPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class NorthCarolinaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class NorthDakotaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class OhioPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class OklahomaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class OregonPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class PennsylvaniaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class RhodeIslandPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class SouthCarolinaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class SouthDakotaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class TennesseePropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class TexasPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class UtahPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class VermontPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class VirginiaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class WashingtonPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class WestVirginiaPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class WisconsinPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }
    public class WyomingPropertyTaxStrategy : PropertyTaxStrategy, IPropertyTaxStrategy
    {

    }

    









    class PropertyTax
    {
    }

    class Percentage
    {
       

 const decimal Alabama=0.00m;
const decimal Alaska =0.00m;
const decimal Arizona =0.00m;
const decimal Arkansas =0.00m;
const decimal California =0.00m;
const decimal Colorado =0.00m;
const decimal Connecticut =0.00m;
const decimal Delaware =0.00m;
const decimal Florida =0.00m;
const decimal Georgia =0.00m;
const decimal Hawaii =0.00m;
const decimal Idaho =0.00m;
const decimal Illinois =0.00m;
const decimal Indiana =0.00m;
const decimal Iowa =0.00m;
const decimal Kansas =0.00m;
const decimal Kentucky =0.00m;
const decimal Louisiana =0.00m;
const decimal Maine =0.00m;
const decimal Maryland =0.00m;
const decimal Massachusetts =0.00m;
const decimal Michigan =0.00;
const decimal Minnesota =0.00;
const decimal Mississippi =0.00;
const decimal Missouri =0.00;
const decimal Montana =0.00;
const decimal Nebraska =0.00;
const decimal Nevada =0.00;
const decimal NewHampshire =0.00;
const decimal NewJersey =0.00;
const decimal NewMexico =0.00;
const decimal NewYork =0.00;
const decimal NorthCarolina =0.00;
const decimal NorthDakota =0.00;
const decimal Ohio =0.00;
const decimal Oklahoma =0.00;
const decimal Oregon =0.00;
const decimal Pennsylvania =0.00;
const decimal RhodeIsland =0.00;
const decimal SouthCarolina =0.00;
const decimal SouthDakota =0.00;
const decimal Tennessee =0.00;
const decimal Texas =0.00;
const decimal Utah =0.00;
const decimal Vermont =0.00;
const decimal Virginia =0.00;
const decimal Washington =0.00;
const decimal WestVirginia =0.00;
const decimal Wisconsin = 0.00;
const decimal Wyoming = 0.0;
    }
}
