package Main;
/**
 * Created by Edgar on 7/1/2015.
 * Abstract class to be extended by the different types of snacks
 */
public abstract class Snack {

    //Private variables common to all snack types
    private BrandType snackBrand;
    private double snackPrice;

    //Constructors
    public Snack() {
        this(BrandType.FRITOLAYS, 0.0);
    }

    public Snack(BrandType brand, double price){
        setSnackBrand(brand);
        setSnackPrice(price);
    }

    //Set Methods
    public void setSnackBrand(BrandType name){
        snackBrand = name;
    }
    public void setSnackPrice(double price) {
        snackPrice = price;
    }

    //Get Methods
    public BrandType getSnackBrand(){
        return snackBrand;
    }
    public double getSnackPrice(){
        return snackPrice;
    }

    //Will be implemented in the extending classes for printing the snacks brand and name
    //Used when giving snack to user
    public abstract String printSnackName();

    //Reduces snack amount when a snack is given
    public abstract void reduceAmountPresent();
    public abstract int getAmount();
    @Override
    public String toString(){
        return String.format("%-12s $%-5.2f", getSnackBrand(), getSnackPrice());
    }
}

enum BrandType{
    FRITOLAYS, MARS;
}
