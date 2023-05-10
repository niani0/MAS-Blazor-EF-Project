import utils.ObjectPlus4;

public class Company extends ObjectPlus4 {
    String nip;
    public static final String isOwnedBy = "is owned by";

    public Company(String nip) {
        this.nip = nip;
    }
}
