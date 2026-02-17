namespace knightmoves;
public class TaxCalculator
{
    public int Rate = 15;
    public string State = "TX";
    public bool Exempt = false;
    
    public int Calculate(){
        if(Exempt){
            return CalculateExempt(1.37);
        }else{
            return CalculateNonExempt(5.72);
        }
    }

    public int CalculateNonExempt(double v)
    {
        return 0;
    }

    public int CalculateExempt(double v)
    {
        return 0;
    }
}
