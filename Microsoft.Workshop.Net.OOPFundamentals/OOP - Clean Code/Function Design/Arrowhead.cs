namespace Microsoft.Workshop.Net.OOPFundamentals.OOP___Clean_Code.Function_Design
{
    public class Arrowhead
    {
           public bool validate(int parameter1, int parameter2, bool boolParameter) {
            if (parameter1 > 0 && parameter2 < 4) {
                if (parameter2 < -2) {
                    return false;
                } else {
                    if(parameter1 == 1 && boolParameter) {
                        return true;
                    } else if (!boolParameter) {
                        if (parameter2 == 3) {
                            return true;
                        } else {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return true;
        }

        public bool validateNonArrow(int parameter1, int parameter2, bool boolParameter) {
            if (parameter1 < 0)
                return true;
            
            if (parameter2 > 4)
                return true;

            if (parameter2 >= -2)
                return true;

            if (parameter2 == 3 && !boolParameter)
                return true;

            return false;
        }
    }
}