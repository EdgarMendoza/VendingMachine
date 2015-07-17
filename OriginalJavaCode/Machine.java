package Main;
import java.util.ArrayList;
import java.util.Scanner;
/**
 * Created by Edgar on 7/1/2015.
 */
public class Machine {

    private ArrayList<Snack> snacksPresent = new ArrayList<Snack>();
    private double moneyEntered;

    //Constructor
    public Machine(){
        moneyEntered = 0;
    }

    //Methods for displaying the two menus: Main and Transaction Menu
    //Will ask the user to make a choice and return that choice
    public int displayMainMenu(){
        System.out.printf("\n\n----------------------\n");
        System.out.printf("\t%s\n", "Main Menu");
        System.out.printf("----------------------\n");
        System.out.printf("1: Display Snacks\n");
        System.out.printf("2: Insert Money\n");
        System.out.printf("0: Exit\n");
        System.out.printf("----------------------\n");
        System.out.printf("Enter Number Choice: ");

        Scanner input = new Scanner(System.in);
        return input.nextInt();
    }
    //Will get called by the insertMoney method
    public int displayTransactionMenu(){
        System.out.printf("-------------------------------------------\n");
        System.out.printf("\t\tTransaction Menu\n");
        System.out.printf("-------------------------------------------\n");
        displaySnackList();
        System.out.printf("%-3s %s\n", "0:", "{{Cancel Transaction}}");
        System.out.printf("-------------------------------------------\n");
        System.out.printf("Enter Number Choice: ");


        Scanner input = new Scanner(System.in);
        return input.nextInt();
    }

    //Displays a list of the items in the snack arraylist
    public void displaySnackList(){
        int index = 1;
        System.out.printf("-------------------------------------------\n");
        System.out.printf("\t\tSnacks List\n");
        System.out.printf("-------------------------------------------\n");
        System.out.printf("%-3s %-5s %-12s %-12s %-5s\n", "#", "Amount", "Name", "Brand", "Price");
        for(Snack list : snacksPresent){
            System.out.printf("%d%-2s %s\n", index, ":", list.toString());
            index++;
        }
    }

    //Used by the operator to add a snack to the vending machine
    public void addSnack(Snack newSnack){
        snacksPresent.add(newSnack);
    }

    //Method is initiated from selecting insert money option in the main menu and will ask for amount to enter
    //Will get snack choice after displaying the transaction, give chosen snack and call method to return left over money
    public void addMoney(){
        Scanner input = new Scanner(System.in);
        System.out.printf("How much money would you like to enter: $");
        moneyEntered = input.nextDouble();

        int snackChoice = displayTransactionMenu();

        System.out.println();

        if(snacksPresent.get(snackChoice - 1).getAmount() == 0){
            System.out.println("Sorry we are out of that snack");
            returnMoney(-1);
        }
        else if(snackChoice != 0) {
            if(moneyEntered < snacksPresent.get(snackChoice - 1).getSnackPrice()){
                System.out.printf("Sorry not enough money was inserted\n");
                returnMoney(-1);
            }
            else {
                giveSnack(snackChoice - 1);
                returnMoney(snackChoice - 1);
            }
        }
        else
            returnMoney(-1);
    }

    //Will take the index of the snack that was chosen and display a message of giving the snack
    //Will call returnMoney after the snack is given
    public void giveSnack(int index){
        if(snacksPresent.get(index) instanceof  Chocolate)
            System.out.printf("Here is your %s\n", snacksPresent.get(index).printSnackName());
        else if(snacksPresent.get(index) instanceof  Chips)
            System.out.printf("Here are your %s\n", snacksPresent.get(index).printSnackName());

        snacksPresent.get(index).reduceAmountPresent();
    }

    //If methods receives a -1 from the addMoney method it will return all money
    //Otherwise it will calculate the change and if it is not 0 will return the change
    public void returnMoney(int index){
        if(index == -1)
            System.out.printf("Here is your money $%.2f\n", moneyEntered);
        else {
            double change = moneyEntered - snacksPresent.get(index).getSnackPrice();

            if(change != 0)
                System.out.printf("Here is your change $%.2f\n", change);
        }

        System.out.printf("Thank You, Please Shop Again\n");
    }
}