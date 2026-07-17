public class BuilderPatternTest {

    public static void main(String[] args) {

        Computer officePC = new Computer.Builder()
                .setCPU("Intel Core i5")
                .setRAM("16GB")
                .setStorage("512GB SSD")
                .build();

        officePC.display();
    }
}