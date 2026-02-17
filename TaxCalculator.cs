namespace knightmoves;
public class TaxCalculator
{
    private int Rate = 15;
    public string State = "TX";
    public bool Exempt = false;
    
    public int Calculate(){
        if(Exempt){
            return CalculateExempt(1.37);
        }else{
            return CalculateNonExempt(5.72);
        }
    }

    private int CalculateNonExempt(double v)
    {
        return 0;
    }

    private int CalculateExempt(double v)
    {
        return 0;
    }
}

