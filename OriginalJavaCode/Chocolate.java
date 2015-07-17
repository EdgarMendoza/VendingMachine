package Main;
/**
 * Created by Edgar on 7/1/2015.
 */
//TODO: Add toString() method
public class Chocolate extends Snack {

    private ChocolateName name;
    private int amountPresent;

    //Constructors
    public Chocolate(){
        this(ChocolateName.SNICKERS, 0, BrandType.FRITOLAYS, 0.0);
    }
    public Chocolate(ChocolateName name, int amount, BrandType brand, double price){
        super(brand, price);
        setName(name);
        setAmount(amount);
    }

    //Set Methods
    public void setName(ChocolateName name){
        this.name = name;
    }
    public void setAmount(int amount){
        amountPresent = amount;
    }

    //Get Methods
    public ChocolateName getSnackName(){
        return name;
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

enum ChocolateName{
    SNICKERS,MUSKETEERS, DOVE, TWIX;
}
