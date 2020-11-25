namespace Microsoft.Workshop.Net.CSharpFeatures.OperatorExtentions
{
    public class Conversion
    {
        
    }

    public class IntFraction {
        public int Num {get; set;}  
        public int Den {get; set;}    

        public static explicit operator IntFraction(DoubleFraction d) {
            return new IntFraction() {
                Den = (int)d.Den,
                Num = (int)d.Num
            };
        }   
    }

    public class DoubleFraction {
        public double Num {get; set;}  

        public double Den {get; set;} 

        public static implicit operator DoubleFraction(IntFraction d) {
            return new DoubleFraction() {
                Den = d.Den,
                Num = d.Num
            };
        }    
    }
}