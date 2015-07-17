package Main;

public class Main {

    public static void main(String[] args) {
        System.out.println("* * * * * * * * * * * * * * *");
        System.out.println("*\tVending Machine\t    *");
        System.out.println("*\t\t\t    *");
        System.out.println("*\tWritten By\t    *");
        System.out.println("*\tEdgar Mendoza\t    *");
        System.out.println("* * * * * * * * * * * * * * *");

        int choice = -1;
        //Makes a new machine and adds the snacks
        Machine venMachine = new Machine();
        venMachine.addSnack(new Chocolate(ChocolateName.SNICKERS, 10, BrandType.MARS, 1.25));
        venMachine.addSnack(new Chocolate(ChocolateName.TWIX, 10, BrandType.MARS, 1.25));
        venMachine.addSnack(new Chocolate(ChocolateName.DOVE, 5, BrandType.MARS, 1.75));
        venMachine.addSnack(new Chocolate(ChocolateName.MUSKETEERS, 7, BrandType.MARS, 1.50));
        venMachine.addSnack(new Chips(ChipName.DORITOS, 10, BrandType.FRITOLAYS, 2.15));
        venMachine.addSnack(new Chips(ChipName.TOSTITOS, 10, BrandType.FRITOLAYS, 2.00));
        venMachine.addSnack(new Chips(ChipName.RUFFLES, 2, BrandType.FRITOLAYS, 1.50));
        venMachine.addSnack(new Chips(ChipName.LAYS, 6, BrandType.FRITOLAYS, 1.75));

        while(choice != 0){
            choice = venMachine.displayMainMenu();

            System.out.println();

            if(choice == 1)
                venMachine.displaySnackList();
            else if(choice == 2)
                venMachine.addMoney();
        }
    }
}
