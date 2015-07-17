package Main;
/**
 * Created by Edgar on 7/1/2015.
 */

//TODO: Add toString() method
public class Chips extends Snack {

    private ChipName snackName;
    private int amountPresent;

    //Constructors
    public Chips() {
        this(ChipName.DORITOS, 0, BrandType.FRITOLAYS, 0.0);
    }
    public Chips(ChipName name, int amount, BrandType brand, double price){
        super(brand, price);
        setSnackName(name);
        setSnackAmount(amount);
    }

    //Set Methods
    public void setSnackName(ChipName name){
        snackName = name;
    }
    public void setSnackAmount(int amount){
        amountPresent = amount;
    }

    //Get Methods
    public ChipName getSnackName(){
        return snackName;
    }
    @Override
    public int getAmount(){
        return amountPresent;
    }

    @Override
    public String printSnackName(){
        return String.format("%s %s", super.getSnackBrand(), getSnackName());
    }

    @Override
    public void reduceAmountPresent(){
        amountPresent--;
    }

    @Override
    public String toString(){
        return String.format("%-6d %-12s %-20s", getAmount(), getSnackName(), super.toString());
    }
}

enum ChipName{
    DORITOS, TOSTITOS, RUFFLES, LAYS;
}